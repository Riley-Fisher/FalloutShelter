using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FalloutShelter.Converters;
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
                    _vault = JsonConvert.DeserializeObject<RootObject>(SaveConverter.Decrypt(ms.ToArray()));
                    propertyGrid1.SelectedObject = _vault;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            string rawJSON = JsonConvert.SerializeObject(_vault, Formatting.None, new JsonSerializerSettings {
                NullValueHandling = NullValueHandling.Ignore
            });
            string file = SaveConverter.Encrypt(rawJSON);
            var save = new SaveFileDialog(
                );
        }
    }
}