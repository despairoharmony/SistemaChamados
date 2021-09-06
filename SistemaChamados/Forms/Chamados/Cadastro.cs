using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamados.Forms.Chamados
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseOcorrenciasDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.baseOcorrenciasDataSet.usuarios);
            
        }
        // Botão para voltar a base de ocorrências
        private void BotaoCancelChm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Botão para adicionar a ocorrência
        private void BotaoAddChm_Click(object sender, EventArgs e)
        {
            // Verificar se há usuarios cadastrados
            if (UsersBox.Text == "")
            {
                MessageBox.Show(Global.MsgNoUsr);
                this.Close();
                return;
            }
            // Recolher informações preenchidas
            int usrID = int.Parse(UsersBox.SelectedValue.ToString());
            string titulo = TitleBox.Text;
            string sistema = SistemaBox.Text;
            string situacao = SituacaoBox.Text;
            string descricao = DescriptionBox.Text;
            // Verificar se os campos foram preenchidos
            if (titulo == "" || sistema == "" || situacao == "" || descricao == "")
            {
                MessageBox.Show(Global.MsgFill);
            }
            else
            {
                // Inserir os dados novos no servidor e fechar a janela
                SQLManagment.Insert.Chamado(titulo, sistema, situacao, usrID, descricao);
                MessageBox.Show(Global.MsgOcAdd);
                this.Close();
            }
        }
    }
}
