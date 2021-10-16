namespace HardwarePOO.entities
{
    public class Gabinete
    {
        public Gabinete()
        {
            Fabricante = new Fabricante();
        }
         public Fabricante Fabricante { get; set; }
    }
}