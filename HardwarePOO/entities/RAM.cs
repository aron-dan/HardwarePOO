namespace HardwarePOO.entities
{
    public class RAM
    {
        public RAM()
        {
            Fabricante = new Fabricante();
        }
        public int quantidade { get; set; }
        public float Espaço { get; set; }
        public int MegaHearts { get; set; }
        public string DRR { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}