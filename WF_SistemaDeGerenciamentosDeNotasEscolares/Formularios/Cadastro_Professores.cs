using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_SistemaDeGerenciamentosDeNotasEscolares
{
    public partial class Cadastro_Professores : Form
    {
        public Cadastro_Professores()
        {
            InitializeComponent();
        }

        private void Cadastro_Professores_Load(object sender, EventArgs e)
        {
            DalNotas.CriarBancoSQLite();
            DalNotas.CriarTabelaSQLite();
        }
    }
}
