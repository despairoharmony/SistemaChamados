using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamados.Forms.Usuarios
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        // Botão para adicionar usuario
        private void BotaoAddUsr_Click(object sender, EventArgs e)
        {
            // Recolher informações preenchidas
            string nome = CampoNome.Text;
            string email = CampoEmail.Text;
            string setor = SetorBox.Text;
            // Verificar se os campos foram preenchidos
            if (nome.Equals("") || email.Equals("") || setor.Equals(""))
            {
                MessageBox.Show(Global.MsgFill);
            } else
            {
                // Inserir os dados novos no servidor e fechar a janela
                SQLManagment.Insert.Usuario(nome, email, setor);
                MessageBox.Show(Global.MsgUsrAdd);
                this.Close();
            }
        }
        // Botão para voltar para a lista
        private void BotaoCancelaAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
