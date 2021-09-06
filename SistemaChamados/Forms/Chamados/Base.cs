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
    public partial class Base : Form
    {
        // Definir variaveis de seleção
        private int SelectedChmID = -1;
        private string SelectedTitle;
        private string SelectedSistema;
        private string SelectedSituacao;
        private int SelectedUsrID;
        private string SelectedDescricao;
        // Definir booleana de pesquisa ativa
        private bool IsSearch = false;
        public Base()
        {
            InitializeComponent();
        }
        // Função para atualizar o DataGridView
        private void RefreshDataView()
        {
            if (IsSearch == false) // Quando a pesquisa não foi utilizada - atualizar pelo banco de dados
            {
                this.chamadosTableAdapter.Fill(this.baseOcorrenciasDataSet1.chamados);
                ChamadosDataView.Update();
                ChamadosDataView.Refresh();
            } else // Quando a pesquisa foi utilizada alguma vez - atualizar pela pesquisa
            {
                SQLManagment.Search.Chamado(ChamadosDataView, CampoBuscaOc.Text);
                ChamadosDataView.Update();
                ChamadosDataView.Refresh();
            }
        }
        // Cadastrar nova ocorrencia
        private void BotaoCadastrarOc_Click(object sender, EventArgs e)
        {
            // Abrir form de cadastro
            Form ChmAdd = new Forms.Chamados.Cadastro();
            ChmAdd.ShowDialog();
            // Limpar campo de busca
            CampoBuscaOc.Text = "";
            // Recarregar o banco de dados das ocorrencias
            RefreshDataView();
        }

        // Editar ocorrencia existente
        private void BotaoEditarOc_Click(object sender, EventArgs e)
        {
            // Verificar se há uma seleção ativa
            if (SelectedChmID == -1)
            {
                MessageBox.Show(Global.MsgOcEdit);
            }
            else
            {
                // Abrir form de edição
                Form ChmEdit = new Forms.Chamados.Editar(SelectedChmID, SelectedTitle, SelectedSistema, SelectedSituacao, SelectedUsrID, SelectedDescricao);
                ChmEdit.ShowDialog();
                // Recarregar o banco de dados das ocorrencias
                RefreshDataView();
            }
        }
        // Apagar ocorrencia existente
        private void BotaoDeletarOc_Click(object sender, EventArgs e)
        {
            // Verificar se há uma seleção ativa
            if (SelectedChmID == -1)
            {
                MessageBox.Show(Global.MsgOcDel);
            }
            else
            {
                // Confirmar exclusão
                DialogResult choice = MessageBox.Show(Global.MsgDelOc + SelectedTitle, Global.MsgConfirm, MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    // Excluir dado
                    SQLManagment.Delete.Chamado(SelectedChmID);
                    MessageBox.Show(Global.MsgFinish);
                    // Recarregar o banco de dados das ocorrencias
                    RefreshDataView();
                    // Remover a seleção
                    SelectedChmID = -1;
                }
            }
        }
        // Abrir lista de usuarios
        private void BotaoUsuario_Click(object sender, EventArgs e)
        {
            // Abrir Lista de usuários
            Form UsrBase = new Forms.Usuarios.UserBase();
            UsrBase.ShowDialog();
            // Recarregar o banco de dados das ocorrencias
            RefreshDataView();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'baseOcorrenciasDataSet1.chamados'. Você pode movê-la ou removê-la conforme necessário.
            this.chamadosTableAdapter.Fill(this.baseOcorrenciasDataSet1.chamados);
        }
        // Coletar informações de celulas selecionadas
        private void ChamadosDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a seleção não esta no indice
            if (e.RowIndex >= 0)
            {
                SelectedChmID = int.Parse(ChamadosDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
                SelectedTitle = ChamadosDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SelectedSistema = ChamadosDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
                SelectedSituacao = ChamadosDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
                SelectedUsrID = int.Parse(ChamadosDataView.Rows[e.RowIndex].Cells[4].Value.ToString());
                SelectedDescricao = ChamadosDataView.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
        // Ativar a pesquisa
        private void BotaoBuscaOc_Click(object sender, EventArgs e)
        {
            // Ativar a pesquisa na atualização do DataGridView
            IsSearch = true;
            // Recarregar o banco de dados das ocorrencias
            RefreshDataView();
        }
        // Clique duplo no objeto para abrir a edição
        private void ChamadosDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a seleção não esta no indice
            if (e.RowIndex >= 0)
            {
                // Abrir form de edição
                Form ChmEdit = new Forms.Chamados.Editar(SelectedChmID, SelectedTitle, SelectedSistema, SelectedSituacao, SelectedUsrID, SelectedDescricao);
                ChmEdit.ShowDialog();
                // Recarregar o banco de dados das ocorrencias
                RefreshDataView();
            }
        }
    }
}
