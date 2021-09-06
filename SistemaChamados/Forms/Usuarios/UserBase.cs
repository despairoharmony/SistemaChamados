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
    public partial class UserBase : Form
    {
        // Definir variaveis de seleção
        private int SelectedUsrID = -1;
        private string SelectedName;
        private string SelectedEmail;
        private string SelectedSetor;
        // Definir booleana de pesquisa ativa
        private bool IsSearch = false;
            public UserBase()
        {
            InitializeComponent();
        }
        // Função para atualizar o DataGridView
        private void RefreshDataView()
        {
            if (IsSearch == false) // Quando a pesquisa não foi utilizada - atualizar pelo banco de dados
            {
                this.usuariosTableAdapter.Fill(this.baseOcorrenciasDataSet.usuarios);
                UserDataView.Update();
                UserDataView.Refresh();
            }
            else // Quando a pesquisa foi utilizada alguma vez - atualizar pela pesquisa
            {
                SQLManagment.Search.Usuario(UserDataView, CampoBuscaUs.Text);
                UserDataView.Update();
                UserDataView.Refresh();
            }
        }
        private void UserBase_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseOcorrenciasDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.baseOcorrenciasDataSet.usuarios);
        }
        // Cadastrar novo usuario
        private void BotaoAddUser_Click(object sender, EventArgs e)
        {
            // Abrir form de cadastro
            Form UsrAdd = new Forms.Usuarios.Cadastro();
            UsrAdd.ShowDialog();
            // Limpar campo de busca
            CampoBuscaUs.Text = "";
            // Recarregar o banco de dados dos usuarios
            RefreshDataView();
        }
        // Apagar usuario existente
        private void BotaoDeleteUser_Click(object sender, EventArgs e)
        {
            // Verificar se há uma seleção ativa
            if (SelectedUsrID == -1)
            {
                MessageBox.Show(Global.MsgUsrDel);
            } else 
            {
                // Confirmar exclusão
                DialogResult choice = MessageBox.Show(Global.MsgDelUsr1 + SelectedName + Global.MsgDelUsr2, Global.MsgConfirm, MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    // Excluir dado
                    SQLManagment.Delete.Usuario(SelectedUsrID);
                    MessageBox.Show(Global.MsgFinish);
                    // Recarregar o banco de dados dos usuarios
                    RefreshDataView();
                    // Remover a seleção
                    SelectedUsrID = -1;
                }
            }
        }
        // Coletar informações de celulas selecionadas
        private void UserDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a seleção não esta no indice
            if (e.RowIndex >= 0)
            {
                SelectedUsrID = int.Parse(UserDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
                SelectedName = UserDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SelectedEmail = UserDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
                SelectedSetor = UserDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        // Editar ocorrencia existente
        private void BotaoEditUser_Click(object sender, EventArgs e)
        {
            // Verificar se há uma seleção ativa
            if (SelectedUsrID == -1)
            {
                MessageBox.Show(Global.MsgUsrEdit);
            }
            else
            {
                // Abrir form de edição
                Form UsrEdit = new Forms.Usuarios.Editar(SelectedUsrID, SelectedName, SelectedEmail, SelectedSetor);
                UsrEdit.ShowDialog();
                // Recarregar o banco de dados dos usuarios
                RefreshDataView();
            }
        }
        // Voltar para a base de ocorrencias
        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Ativar a pesquisa
        private void BotaoBuscaUs_Click(object sender, EventArgs e)
        {
            // Ativar a pesquisa na atualização do DataGridView
            IsSearch = true;
            // Recarregar o banco de dados dos usuarios
            RefreshDataView();
        }
        // Clique duplo no objeto para abrir a edição
        private void UserDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a seleção não esta no indice
            if (e.RowIndex >= 0)
            {
                // Abrir form de edição
                Form UsrEdit = new Forms.Usuarios.Editar(SelectedUsrID, SelectedName, SelectedEmail, SelectedSetor);
                UsrEdit.ShowDialog();
                // Recarregar o banco de dados dos usuarios
                RefreshDataView();
            }
        }
    }
}
