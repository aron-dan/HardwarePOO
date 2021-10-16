namespace HardwarePOO.entities
{
    public class VideoCard
    {
        public VideoCard()
        {
            Fabricante = new Fabricante();
        }
        public float TereFlops { get; set; }
        public string Gibas { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}