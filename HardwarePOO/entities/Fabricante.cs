namespace HardwarePOO.entities
{
    public class Fabricante
    {
        public Fabricante()
        {
            Modelo = new Modelo();
        }
        public string Name { get; set; }
        public Modelo Modelo { get; set; }
    }
}