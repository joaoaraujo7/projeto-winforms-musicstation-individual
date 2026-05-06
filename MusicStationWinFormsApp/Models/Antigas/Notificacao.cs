using MusicStationWinFormsApp.models.enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStationWinFormsApp.models
{
    public class Notificacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
        public TipoNotificacao TipoNotificacao { get; set; }
        public DateTime DataEnvio { get; set; }
        public short Lida {  get; set; }
        Usuario Usuario { get; set; }

        public string UsuarioNome => Usuario.NomeCompleto;
    }
}
