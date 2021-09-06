
namespace SistemaChamados.Forms.Chamados
{
    partial class Editar
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
            this.UsersBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseOcorrenciasDataSet = new SistemaChamados.BaseOcorrenciasDataSet();
            this.usuariosTableAdapter = new SistemaChamados.BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.SistemaBox = new System.Windows.Forms.ComboBox();
            this.SituacaoBox = new System.Windows.Forms.ComboBox();
            this.BotaoAddChm = new System.Windows.Forms.Button();
            this.BotaoCancelChm = new System.Windows.Forms.Button();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.SistemaLabel = new System.Windows.Forms.Label();
            this.SituacaoLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DescricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersBox
            // 
            this.UsersBox.DataSource = this.usuariosBindingSource;
            this.UsersBox.DisplayMember = "nome";
            this.UsersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(12, 130);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(500, 21);
            this.UsersBox.TabIndex = 0;
            this.UsersBox.ValueMember = "UsuarioID";
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
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 180);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(500, 180);
            this.DescriptionBox.TabIndex = 1;
            this.DescriptionBox.Text = "";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(12, 30);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(500, 20);
            this.TitleBox.TabIndex = 2;
            // 
            // SistemaBox
            // 
            this.SistemaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SistemaBox.FormattingEnabled = true;
            this.SistemaBox.Items.AddRange(new object[] {
            "Atacado",
            "Varejo",
            "Internet Banking",
            "Previdência",
            "Investimento",
            "Doações",
            "Outros"});
            this.SistemaBox.Location = new System.Drawing.Point(12, 80);
            this.SistemaBox.Name = "SistemaBox";
            this.SistemaBox.Size = new System.Drawing.Size(245, 21);
            this.SistemaBox.TabIndex = 3;
            // 
            // SituacaoBox
            // 
            this.SituacaoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SituacaoBox.FormattingEnabled = true;
            this.SituacaoBox.Items.AddRange(new object[] {
            "Ativo",
            "Em Manutenção",
            "Resolvido"});
            this.SituacaoBox.Location = new System.Drawing.Point(267, 80);
            this.SituacaoBox.Name = "SituacaoBox";
            this.SituacaoBox.Size = new System.Drawing.Size(245, 21);
            this.SituacaoBox.TabIndex = 4;
            // 
            // BotaoAddChm
            // 
            this.BotaoAddChm.Location = new System.Drawing.Point(12, 380);
            this.BotaoAddChm.Name = "BotaoAddChm";
            this.BotaoAddChm.Size = new System.Drawing.Size(245, 40);
            this.BotaoAddChm.TabIndex = 5;
            this.BotaoAddChm.Text = "Atualizar a Ocorrência";
            this.BotaoAddChm.UseVisualStyleBackColor = true;
            this.BotaoAddChm.Click += new System.EventHandler(this.BotaoAddChm_Click);
            // 
            // BotaoCancelChm
            // 
            this.BotaoCancelChm.Location = new System.Drawing.Point(267, 380);
            this.BotaoCancelChm.Name = "BotaoCancelChm";
            this.BotaoCancelChm.Size = new System.Drawing.Size(245, 40);
            this.BotaoCancelChm.TabIndex = 6;
            this.BotaoCancelChm.Text = "Cancelar";
            this.BotaoCancelChm.UseVisualStyleBackColor = true;
            this.BotaoCancelChm.Click += new System.EventHandler(this.BotaoCancelChm_Click);
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Location = new System.Drawing.Point(9, 9);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(38, 13);
            this.TituloLabel.TabIndex = 7;
            this.TituloLabel.Text = "Título:";
            // 
            // SistemaLabel
            // 
            this.SistemaLabel.AutoSize = true;
            this.SistemaLabel.Location = new System.Drawing.Point(9, 64);
            this.SistemaLabel.Name = "SistemaLabel";
            this.SistemaLabel.Size = new System.Drawing.Size(47, 13);
            this.SistemaLabel.TabIndex = 8;
            this.SistemaLabel.Text = "Sistema:";
            // 
            // SituacaoLabel
            // 
            this.SituacaoLabel.AutoSize = true;
            this.SituacaoLabel.Location = new System.Drawing.Point(264, 64);
            this.SituacaoLabel.Name = "SituacaoLabel";
            this.SituacaoLabel.Size = new System.Drawing.Size(52, 13);
            this.SituacaoLabel.TabIndex = 9;
            this.SituacaoLabel.Text = "Situação:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(9, 114);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(111, 13);
            this.UserLabel.TabIndex = 10;
            this.UserLabel.Text = "Usuário Responsável:";
            // 
            // DescricaoLabel
            // 
            this.DescricaoLabel.AutoSize = true;
            this.DescricaoLabel.Location = new System.Drawing.Point(9, 164);
            this.DescricaoLabel.Name = "DescricaoLabel";
            this.DescricaoLabel.Size = new System.Drawing.Size(58, 13);
            this.DescricaoLabel.TabIndex = 11;
            this.DescricaoLabel.Text = "Descrição:";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.DescricaoLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.SituacaoLabel);
            this.Controls.Add(this.SistemaLabel);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.BotaoCancelChm);
            this.Controls.Add(this.BotaoAddChm);
            this.Controls.Add(this.SituacaoBox);
            this.Controls.Add(this.SistemaBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.UsersBox);
            this.Name = "Editar";
            this.Text = "Editar Ocorrência";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOcorrenciasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsersBox;
        private BaseOcorrenciasDataSet baseOcorrenciasDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BaseOcorrenciasDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.ComboBox SistemaBox;
        private System.Windows.Forms.ComboBox SituacaoBox;
        private System.Windows.Forms.Button BotaoAddChm;
        private System.Windows.Forms.Button BotaoCancelChm;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label SistemaLabel;
        private System.Windows.Forms.Label SituacaoLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label DescricaoLabel;
    }
}