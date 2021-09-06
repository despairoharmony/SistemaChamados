using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SistemaChamados.Forms.Usuarios
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
        private void BotaoCadastrarUsr_Click(object sender, EventArgs e)
        {
            Form UsrAdd = new Forms.Usuarios.Cadastro();
            UsrAdd.ShowDialog();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseOcorrenciasDataSet1.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter1.Fill(this.baseOcorrenciasDataSet1.usuarios);
            // TODO: esta linha de código carrega dados na tabela 'baseOcorrenciasDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.baseOcorrenciasDataSet.usuarios);

        }
    }
}
