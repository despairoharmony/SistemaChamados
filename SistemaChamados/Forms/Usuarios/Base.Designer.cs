
namespace SistemaChamados.Forms.Usuarios
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
            this.BotaoCadastrarUsr = new System.Windows.Forms.Button();
            this.BotaoEditarUsr = new System.Windows.Forms.Button();
            this.BotaoDeleteUsr = new System.Windows.Forms.Button();
            this.baseOcorrenciasDataSet = new SistemaChamados.BaseOcorrenciasDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new SistemaChamados.BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter();
            this.baseOcorrenciasDataSet1 = new SistemaChamados.BaseOcorrenciasUserDataSet();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new SistemaChamados.BaseOcorrenciasDataSet1TableAdapters.usuariosTableAdapter();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoCadastrarUsr
            // 
            this.BotaoCadastrarUsr.Location = new System.Drawing.Point(440, 20);
            this.BotaoCadastrarUsr.Name = "BotaoCadastrarUsr";
            this.BotaoCadastrarUsr.Size = new System.Drawing.Size(130, 50);
            this.BotaoCadastrarUsr.TabIndex = 0;
            this.BotaoCadastrarUsr.Text = "Novo Usuário";
            this.BotaoCadastrarUsr.UseVisualStyleBackColor = true;
            this.BotaoCadastrarUsr.Click += new System.EventHandler(this.BotaoCadastrarUsr_Click);
            // 
            // BotaoEditarUsr
            // 
            this.BotaoEditarUsr.Location = new System.Drawing.Point(440, 90);
            this.BotaoEditarUsr.Name = "BotaoEditarUsr";
            this.BotaoEditarUsr.Size = new System.Drawing.Size(130, 50);
            this.BotaoEditarUsr.TabIndex = 1;
            this.BotaoEditarUsr.Text = "Editar Usuário";
            this.BotaoEditarUsr.UseVisualStyleBackColor = true;
            // 
            // BotaoDeleteUsr
            // 
            this.BotaoDeleteUsr.Location = new System.Drawing.Point(440, 160);
            this.BotaoDeleteUsr.Name = "BotaoDeleteUsr";
            this.BotaoDeleteUsr.Size = new System.Drawing.Size(130, 50);
            this.BotaoDeleteUsr.TabIndex = 2;
            this.BotaoDeleteUsr.Text = "Apagar Usuário";
            this.BotaoDeleteUsr.UseVisualStyleBackColor = true;
            // 
            // baseOcorrenciasDataSet
            // 
            this.baseOcorrenciasDataSet.DataSetName = "BaseOcorrenciasDataSet";
            this.baseOcorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.cadastroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.baseOcorrenciasDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // baseOcorrenciasDataSet1
            // 
            this.baseOcorrenciasDataSet1.DataSetName = "BaseOcorrenciasDataSet1";
            this.baseOcorrenciasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.baseOcorrenciasDataSet1;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            // 
            // cadastroDataGridViewTextBoxColumn
            // 
            this.cadastroDataGridViewTextBoxColumn.DataPropertyName = "cadastro";
            this.cadastroDataGridViewTextBoxColumn.HeaderText = "cadastro";
            this.cadastroDataGridViewTextBoxColumn.Name = "cadastroDataGridViewTextBoxColumn";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BotaoDeleteUsr);
            this.Controls.Add(this.BotaoEditarUsr);
            this.Controls.Add(this.BotaoCadastrarUsr);
            this.Name = "Base";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoCadastrarUsr;
        private System.Windows.Forms.Button BotaoEditarUsr;
        private System.Windows.Forms.Button BotaoDeleteUsr;
        private BaseOcorrenciasDataSet baseOcorrenciasDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private BaseOcorrenciasUserDataSet baseOcorrenciasDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private BaseOcorrenciasDataSet1TableAdapters.usuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastroDataGridViewTextBoxColumn;
    }
}