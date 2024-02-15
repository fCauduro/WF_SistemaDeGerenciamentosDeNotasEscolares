using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_SistemaDeGerenciamentosDeNotasEscolares.ClassesBanco
{
    public class Usuarios
    {
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string Cpf { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public int matricula { get; set; }
        public string endereco { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public enum vinculo { }
    }
}
