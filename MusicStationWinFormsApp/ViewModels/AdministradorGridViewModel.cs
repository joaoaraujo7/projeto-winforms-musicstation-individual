namespace MusicStationWinFormsApp.ViewModel
{
    public class AdministradorGridViewModel
    {
        public int IdAdmin { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string UsuarioNome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int NivelAcesso { get; set; }
        public string? Observacoes { get; set; }
    }
}