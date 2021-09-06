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
    public partial class Editar : Form
    {
        private static int userID;
        public Editar(int uid, string nome, string email, string setor)
        {
            // Receber dados para a edição
            InitializeComponent();
            userID = uid;
            CampoNome.Text = nome;
            CampoEmail.Text = email;
            SetorBox.Text = setor;
        }
        // Botão para confirmar a edição do usuário
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
                SQLManagment.Update.Usuario(userID, nome, email, setor);
                MessageBox.Show(Global.MsgFinish);
                this.Close();
            }
        }
        // Voltar para a lista de usuarios
        private void BotaoCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
