namespace HardwarePOO.entities
{
    public class Processador
    {
        public Processador()
        {
            Fabricante = new Fabricante();
            GenerationPC = new GenerationPC();
            Modelo = new Modelo();

        }
        public double Ghz { get; set; }
        public GenerationPC GenerationPC { get; set; }
        public Fabricante Fabricante { get; set; }
        public Modelo Modelo { get; set; }
    }
}