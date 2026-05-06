namespace MusicStationWinFormsApp.models
{
    public class ItemLocacao
    {
        public int Id { get; set; }
        public Instrumento Instrumento { get; set; }
        public decimal PrecoLocacao { get; set; }
        public int Dias { get; set; }
        public decimal Subtotal => PrecoLocacao * Dias;
    }
}