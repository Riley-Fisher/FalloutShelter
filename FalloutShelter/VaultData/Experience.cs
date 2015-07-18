namespace FalloutShelter.VaultData {
    public class Experience {
        public double experienceValue { get; set; }
        public int currentLevel { get; set; }
        public int storage { get; set; }
        public int accum { get; set; }
        public bool needLvUp { get; set; }
    }
}