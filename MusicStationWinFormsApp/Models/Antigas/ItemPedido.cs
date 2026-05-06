namespace MusicStationWinFormsApp.models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Profissional Profissional { get; set; }
        public Decimal ValorServico { get; set; }
        public string Observacao { get; set; }
    }
}