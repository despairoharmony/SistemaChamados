
namespace SistemaChamados.Forms.Usuarios
{
    partial class UserBase
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
            this.UserDataView = new System.Windows.Forms.DataGridView();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseOcorrenciasDataSet = new SistemaChamados.BaseOcorrenciasDataSet();
            this.usuariosTableAdapter = new SistemaChamados.BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter();
            this.BotaoAddUser = new System.Windows.Forms.Button();
            this.BotaoDeleteUser = new System.Windows.Forms.Button();
            this.BotaoEditUser = new System.Windows.Forms.Button();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.CampoBuscaUs = new System.Windows.Forms.TextBox();
            this.BotaoBuscaUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataView
            // 
            this.UserDataView.AllowUserToAddRows = false;
            this.UserDataView.AllowUserToDeleteRows = false;
            this.UserDataView.AllowUserToResizeColumns = false;
            this.UserDataView.AllowUserToResizeRows = false;
            this.UserDataView.AutoGenerateColumns = false;
            this.UserDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.cadastroDataGridViewTextBoxColumn});
            this.UserDataView.DataSource = this.usuariosBindingSource;
            this.UserDataView.Location = new System.Drawing.Point(12, 44);
            this.UserDataView.MultiSelect = false;
            this.UserDataView.Name = "UserDataView";
            this.UserDataView.Size = new System.Drawing.Size(580, 400);
            this.UserDataView.TabIndex = 0;
            this.UserDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataView_CellClick);
            this.UserDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataView_CellContentClick);
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Frozen = true;
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.Frozen = true;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 140;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.Frozen = true;
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 140;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            this.setorDataGridViewTextBoxColumn.Frozen = true;
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn.Width = 140;
            // 
            // cadastroDataGridViewTextBoxColumn
            // 
            this.cadastroDataGridViewTextBoxColumn.DataPropertyName = "cadastro";
            this.cadastroDataGridViewTextBoxColumn.Frozen = true;
            this.cadastroDataGridViewTextBoxColumn.HeaderText = "Data Cadastrada";
            this.cadastroDataGridViewTextBoxColumn.Name = "cadastroDataGridViewTextBoxColumn";
            this.cadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.cadastroDataGridViewTextBoxColumn.Width = 120;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.baseOcorrenciasDataSet;
            // 
            // baseOcorrenciasDataSet
            // 
            this.baseOcorrenciasDataSet.DataSetName = "BaseOcorrenciasDataSet";
            this.baseOcorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // BotaoAddUser
            // 
            this.BotaoAddUser.Location = new System.Drawing.Point(610, 44);
            this.BotaoAddUser.Name = "BotaoAddUser";
            this.BotaoAddUser.Size = new System.Drawing.Size(160, 50);
            this.BotaoAddUser.TabIndex = 1;
            this.BotaoAddUser.Text = "Novo Usuário";
            this.BotaoAddUser.UseVisualStyleBackColor = true;
            this.BotaoAddUser.Click += new System.EventHandler(this.BotaoAddUser_Click);
            // 
            // BotaoDeleteUser
            // 
            this.BotaoDeleteUser.Location = new System.Drawing.Point(610, 156);
            this.BotaoDeleteUser.Name = "BotaoDeleteUser";
            this.BotaoDeleteUser.Size = new System.Drawing.Size(160, 50);
            this.BotaoDeleteUser.TabIndex = 2;
            this.BotaoDeleteUser.Text = "Apagar Usuário";
            this.BotaoDeleteUser.UseVisualStyleBackColor = true;
            this.BotaoDeleteUser.Click += new System.EventHandler(this.BotaoDeleteUser_Click);
            // 
            // BotaoEditUser
            // 
            this.BotaoEditUser.Location = new System.Drawing.Point(610, 100);
            this.BotaoEditUser.Name = "BotaoEditUser";
            this.BotaoEditUser.Size = new System.Drawing.Size(160, 50);
            this.BotaoEditUser.TabIndex = 3;
            this.BotaoEditUser.Text = "Editar Usuário";
            this.BotaoEditUser.UseVisualStyleBackColor = true;
            this.BotaoEditUser.Click += new System.EventHandler(this.BotaoEditUser_Click);
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(610, 395);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(160, 50);
            this.BotaoVoltar.TabIndex = 4;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // CampoBuscaUs
            // 
            this.CampoBuscaUs.Location = new System.Drawing.Point(12, 12);
            this.CampoBuscaUs.Name = "CampoBuscaUs";
            this.CampoBuscaUs.Size = new System.Drawing.Size(580, 20);
            this.CampoBuscaUs.TabIndex = 5;
            // 
            // BotaoBuscaUs
            // 
            this.BotaoBuscaUs.Location = new System.Drawing.Point(610, 10);
            this.BotaoBuscaUs.Name = "BotaoBuscaUs";
            this.BotaoBuscaUs.Size = new System.Drawing.Size(160, 25);
            this.BotaoBuscaUs.TabIndex = 6;
            this.BotaoBuscaUs.Text = "Pesquisar";
            this.BotaoBuscaUs.UseVisualStyleBackColor = true;
            this.BotaoBuscaUs.Click += new System.EventHandler(this.BotaoBuscaUs_Click);
            // 
            // UserBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.BotaoBuscaUs);
            this.Controls.Add(this.CampoBuscaUs);
            this.Controls.Add(this.BotaoVoltar);
            this.Controls.Add(this.BotaoEditUser);
            this.Controls.Add(this.BotaoDeleteUser);
            this.Controls.Add(this.BotaoAddUser);
            this.Controls.Add(this.UserDataView);
            this.Name = "UserBase";
            this.Text = "Lista de Usuários";
            this.Load += new System.EventHandler(this.UserBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDataView;
        private BaseOcorrenciasDataSet baseOcorrenciasDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button BotaoAddUser;
        private System.Windows.Forms.Button BotaoDeleteUser;
        private System.Windows.Forms.Button BotaoEditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BotaoVoltar;
        private System.Windows.Forms.TextBox CampoBuscaUs;
        private System.Windows.Forms.Button BotaoBuscaUs;
    }
}