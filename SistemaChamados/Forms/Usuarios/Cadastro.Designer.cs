
namespace SistemaChamados.Forms.Usuarios
{
    partial class Cadastro
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
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.CampoEmail = new System.Windows.Forms.TextBox();
            this.SetorBox = new System.Windows.Forms.ComboBox();
            this.BotaoAddUsr = new System.Windows.Forms.Button();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SetorLabel = new System.Windows.Forms.Label();
            this.BotaoCancelaAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampoNome
            // 
            this.CampoNome.Location = new System.Drawing.Point(20, 29);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(340, 20);
            this.CampoNome.TabIndex = 0;
            // 
            // CampoEmail
            // 
            this.CampoEmail.Location = new System.Drawing.Point(20, 79);
            this.CampoEmail.Name = "CampoEmail";
            this.CampoEmail.Size = new System.Drawing.Size(340, 20);
            this.CampoEmail.TabIndex = 1;
            // 
            // SetorBox
            // 
            this.SetorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetorBox.Items.AddRange(new object[] {
            "Diretoria",
            "Recursos Humanos",
            "Financeiro",
            "Investimentos",
            "Tecnologia da Informação",
            "Outros"});
            this.SetorBox.Location = new System.Drawing.Point(20, 129);
            this.SetorBox.Name = "SetorBox";
            this.SetorBox.Size = new System.Drawing.Size(340, 21);
            this.SetorBox.TabIndex = 2;
            // 
            // BotaoAddUsr
            // 
            this.BotaoAddUsr.Location = new System.Drawing.Point(20, 180);
            this.BotaoAddUsr.Name = "BotaoAddUsr";
            this.BotaoAddUsr.Size = new System.Drawing.Size(340, 40);
            this.BotaoAddUsr.TabIndex = 3;
            this.BotaoAddUsr.Text = "Adicionar o Usuário";
            this.BotaoAddUsr.UseVisualStyleBackColor = true;
            this.BotaoAddUsr.Click += new System.EventHandler(this.BotaoAddUsr_Click);
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(17, 13);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(38, 13);
            this.NomeLabel.TabIndex = 4;
            this.NomeLabel.Text = "Nome:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 63);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "E-mail:";
            // 
            // SetorLabel
            // 
            this.SetorLabel.AutoSize = true;
            this.SetorLabel.Location = new System.Drawing.Point(20, 113);
            this.SetorLabel.Name = "SetorLabel";
            this.SetorLabel.Size = new System.Drawing.Size(35, 13);
            this.SetorLabel.TabIndex = 6;
            this.SetorLabel.Text = "Setor:";
            // 
            // BotaoCancelaAdd
            // 
            this.BotaoCancelaAdd.Location = new System.Drawing.Point(20, 230);
            this.BotaoCancelaAdd.Name = "BotaoCancelaAdd";
            this.BotaoCancelaAdd.Size = new System.Drawing.Size(340, 40);
            this.BotaoCancelaAdd.TabIndex = 7;
            this.BotaoCancelaAdd.Text = "Cancelar";
            this.BotaoCancelaAdd.UseVisualStyleBackColor = true;
            this.BotaoCancelaAdd.Click += new System.EventHandler(this.BotaoCancelaAdd_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.BotaoCancelaAdd);
            this.Controls.Add(this.SetorLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.BotaoAddUsr);
            this.Controls.Add(this.SetorBox);
            this.Controls.Add(this.CampoEmail);
            this.Controls.Add(this.CampoNome);
            this.Name = "Cadastro";
            this.Text = "Cadastrar Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.TextBox CampoEmail;
        private System.Windows.Forms.ComboBox SetorBox;
        private System.Windows.Forms.Button BotaoAddUsr;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label SetorLabel;
        private System.Windows.Forms.Button BotaoCancelaAdd;
    }
}