namespace HardwarePOO.entities
{
    public class MotherBoard
    {
        public MotherBoard()
        {
            Fabricante = new Fabricante();
        }
        public string Geracao { get; set; }
        public int Slots { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}