using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FalloutShelter.VaultData;
using Newtonsoft.Json;

namespace FalloutShelter {
    public partial class Form1 : Form {
        private RootObject _vault;

        public Form1() {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            var openFileDialog1 = new OpenFileDialog {
                FilterIndex = 1,
                RestoreDirectory = true,
                Filter = @"Save files (*.sav)|*.sav|All files (*.*)|*.*"
            };


            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try {
                using (var ms = new MemoryStream()) {
                    openFileDialog1.OpenFile().CopyTo(ms);

                    byte[] encodedBytes = Convert.FromBase64String(Encoding.ASCII.GetString(ms.ToArray()));
                    var aesCrypto = new AesCryptoServiceProvider {
                        Mode = CipherMode.CBC
                    };

                    byte[] rgbIV = Encoding.ASCII.GetBytes("tu89geji340t89u2");
                    byte[] rgbKey = new Rfc2898DeriveBytes("UGxheWVy", rgbIV).GetBytes(32);

                    CryptoStream cryptoStream;
                    using (ICryptoTransform CryptoTransform = aesCrypto.CreateDecryptor(rgbKey, rgbIV)) {
                        Stream s = new MemoryStream(encodedBytes);
                        cryptoStream = new CryptoStream(s, CryptoTransform, CryptoStreamMode.Read);
                    }
                    var plainBytes = new byte[encodedBytes.Length];
                    int decryptedByteCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);

                    _vault =
                        JsonConvert.DeserializeObject<RootObject>(Encoding.UTF8.GetString(plainBytes, 0,
                            decryptedByteCount));
                    initPropgrid();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Could not read file from disk. Original error: {ex.Message}");
            }
        }

        public static bool IsBase64String(string s) {
            if (string.IsNullOrWhiteSpace(s)) return false;
            s = s.Trim();
            return (s.Length%4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        private void Form1_Load(object sender, EventArgs e) {}

        public void initPropgrid() {
            propertyGrid1.SelectedObject = _vault;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

        /// <summary>
        /// Need to implement saving!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            
            Console.WriteLine(JsonConvert.SerializeObject(_vault, Formatting.Indented, new JsonSerializerSettings {
                NullValueHandling = NullValueHandling.Ignore
            }));

        }
    }
}