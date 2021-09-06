
namespace SistemaChamados.Forms.Chamados
{
    partial class Base
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BotaoCadastrarOc = new System.Windows.Forms.Button();
            this.BotaoEditarOc = new System.Windows.Forms.Button();
            this.BotaoDeletarOc = new System.Windows.Forms.Button();
            this.BotaoUsuario = new System.Windows.Forms.Button();
            this.ChamadosDataView = new System.Windows.Forms.DataGridView();
            this.chamadoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseOcorrenciasDataSet1 = new SistemaChamados.BaseOcorrenciasDataSet1();
            this.chamadosTableAdapter = new SistemaChamados.BaseOcorrenciasDataSet1TableAdapters.chamadosTableAdapter();
            this.BotaoBuscaOc = new System.Windows.Forms.Button();
            this.CampoBuscaOc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChamadosDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoCadastrarOc
            // 
            this.BotaoCadastrarOc.Location = new System.Drawing.Point(640, 50);
            this.BotaoCadastrarOc.Name = "BotaoCadastrarOc";
            this.BotaoCadastrarOc.Size = new System.Drawing.Size(150, 50);
            this.BotaoCadastrarOc.TabIndex = 0;
            this.BotaoCadastrarOc.Text = "Cadastrar Nova Ocorrência";
            this.BotaoCadastrarOc.UseVisualStyleBackColor = true;
            this.BotaoCadastrarOc.Click += new System.EventHandler(this.BotaoCadastrarOc_Click);
            // 
            // BotaoEditarOc
            // 
            this.BotaoEditarOc.Location = new System.Drawing.Point(640, 110);
            this.BotaoEditarOc.Name = "BotaoEditarOc";
            this.BotaoEditarOc.Size = new System.Drawing.Size(150, 50);
            this.BotaoEditarOc.TabIndex = 1;
            this.BotaoEditarOc.Text = "Editar Ocorrência";
            this.BotaoEditarOc.UseVisualStyleBackColor = true;
            this.BotaoEditarOc.Click += new System.EventHandler(this.BotaoEditarOc_Click);
            // 
            // BotaoDeletarOc
            // 
            this.BotaoDeletarOc.Location = new System.Drawing.Point(640, 170);
            this.BotaoDeletarOc.Name = "BotaoDeletarOc";
            this.BotaoDeletarOc.Size = new System.Drawing.Size(150, 50);
            this.BotaoDeletarOc.TabIndex = 2;
            this.BotaoDeletarOc.Text = "Apagar a Ocorrência";
            this.BotaoDeletarOc.UseVisualStyleBackColor = true;
            this.BotaoDeletarOc.Click += new System.EventHandler(this.BotaoDeletarOc_Click);
            // 
            // BotaoUsuario
            // 
            this.BotaoUsuario.Location = new System.Drawing.Point(640, 390);
            this.BotaoUsuario.Name = "BotaoUsuario";
            this.BotaoUsuario.Size = new System.Drawing.Size(150, 47);
            this.BotaoUsuario.TabIndex = 3;
            this.BotaoUsuario.Text = "Cadastro de Usuários";
            this.BotaoUsuario.UseVisualStyleBackColor = true;
            this.BotaoUsuario.Click += new System.EventHandler(this.BotaoUsuario_Click);
            // 
            // ChamadosDataView
            // 
            this.ChamadosDataView.AllowUserToAddRows = false;
            this.ChamadosDataView.AllowUserToDeleteRows = false;
            this.ChamadosDataView.AllowUserToResizeColumns = false;
            this.ChamadosDataView.AllowUserToResizeRows = false;
            this.ChamadosDataView.AutoGenerateColumns = false;
            this.ChamadosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChamadosDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chamadoIDDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.sistemaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.atualizacaoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.ChamadosDataView.DataSource = this.chamadosBindingSource;
            this.ChamadosDataView.Location = new System.Drawing.Point(12, 50);
            this.ChamadosDataView.MultiSelect = false;
            this.ChamadosDataView.Name = "ChamadosDataView";
            this.ChamadosDataView.Size = new System.Drawing.Size(622, 387);
            this.ChamadosDataView.TabIndex = 4;
            this.ChamadosDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChamadosDataView_CellClick);
            this.ChamadosDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChamadosDataView_CellContentClick);
            // 
            // chamadoIDDataGridViewTextBoxColumn
            // 
            this.chamadoIDDataGridViewTextBoxColumn.DataPropertyName = "ChamadoID";
            this.chamadoIDDataGridViewTextBoxColumn.HeaderText = "ChamadoID";
            this.chamadoIDDataGridViewTextBoxColumn.Name = "chamadoIDDataGridViewTextBoxColumn";
            this.chamadoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // sistemaDataGridViewTextBoxColumn
            // 
            this.sistemaDataGridViewTextBoxColumn.DataPropertyName = "sistema";
            this.sistemaDataGridViewTextBoxColumn.HeaderText = "Sistema";
            this.sistemaDataGridViewTextBoxColumn.Name = "sistemaDataGridViewTextBoxColumn";
            this.sistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sistemaDataGridViewTextBoxColumn.Width = 110;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Data Cadastrada";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaDataGridViewTextBoxColumn.Width = 110;
            // 
            // atualizacaoDataGridViewTextBoxColumn
            // 
            this.atualizacaoDataGridViewTextBoxColumn.DataPropertyName = "atualizacao";
            this.atualizacaoDataGridViewTextBoxColumn.HeaderText = "Ultima Atualização";
            this.atualizacaoDataGridViewTextBoxColumn.Name = "atualizacaoDataGridViewTextBoxColumn";
            this.atualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.atualizacaoDataGridViewTextBoxColumn.Width = 110;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // chamadosBindingSource
            // 
            this.chamadosBindingSource.DataMember = "chamados";
            this.chamadosBindingSource.DataSource = this.baseOcorrenciasDataSet1;
            // 
            // baseOcorrenciasDataSet1
            // 
            this.baseOcorrenciasDataSet1.DataSetName = "BaseOcorrenciasDataSet1";
            this.baseOcorrenciasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamadosTableAdapter
            // 
            this.chamadosTableAdapter.ClearBeforeFill = true;
            // 
            // BotaoBuscaOc
            // 
            this.BotaoBuscaOc.Location = new System.Drawing.Point(640, 10);
            this.BotaoBuscaOc.Name = "BotaoBuscaOc";
            this.BotaoBuscaOc.Size = new System.Drawing.Size(150, 25);
            this.BotaoBuscaOc.TabIndex = 5;
            this.BotaoBuscaOc.Text = "Pesquisar";
            this.BotaoBuscaOc.UseVisualStyleBackColor = true;
            this.BotaoBuscaOc.Click += new System.EventHandler(this.BotaoBuscaOc_Click);
            // 
            // CampoBuscaOc
            // 
            this.CampoBuscaOc.Location = new System.Drawing.Point(13, 12);
            this.CampoBuscaOc.Name = "CampoBuscaOc";
            this.CampoBuscaOc.Size = new System.Drawing.Size(621, 20);
            this.CampoBuscaOc.TabIndex = 6;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CampoBuscaOc);
            this.Controls.Add(this.BotaoBuscaOc);
            this.Controls.Add(this.ChamadosDataView);
            this.Controls.Add(this.BotaoUsuario);
            this.Controls.Add(this.BotaoDeletarOc);
            this.Controls.Add(this.BotaoEditarOc);
            this.Controls.Add(this.BotaoCadastrarOc);
            this.Name = "Base";
            this.Text = "Sistema de Chamados";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChamadosDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoCadastrarOc;
        private System.Windows.Forms.Button BotaoEditarOc;
        private System.Windows.Forms.Button BotaoDeletarOc;
        private System.Windows.Forms.Button BotaoUsuario;
        private System.Windows.Forms.DataGridView ChamadosDataView;
        private BaseOcorrenciasDataSet1 baseOcorrenciasDataSet1;
        private System.Windows.Forms.BindingSource chamadosBindingSource;
        private BaseOcorrenciasDataSet1TableAdapters.chamadosTableAdapter chamadosTableAdapter;
        private System.Windows.Forms.Button BotaoBuscaOc;
        private System.Windows.Forms.TextBox CampoBuscaOc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}