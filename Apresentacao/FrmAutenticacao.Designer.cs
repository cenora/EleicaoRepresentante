namespace Apresentacao
{
    partial class FrmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutenticacao));
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.rdoSessao = new System.Windows.Forms.RadioButton();
            this.rdoCadastrar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            resources.ApplyResources(this.txbUsuario, "txbUsuario");
            this.txbUsuario.Name = "txbUsuario";
            // 
            // txbSenha
            // 
            resources.ApplyResources(this.txbSenha, "txbSenha");
            this.txbSenha.Name = "txbSenha";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblSaudacao
            // 
            resources.ApplyResources(this.lblSaudacao, "lblSaudacao");
            this.lblSaudacao.Name = "lblSaudacao";
            // 
            // lblAviso
            // 
            resources.ApplyResources(this.lblAviso, "lblAviso");
            this.lblAviso.Name = "lblAviso";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // rdoSessao
            // 
            resources.ApplyResources(this.rdoSessao, "rdoSessao");
            this.rdoSessao.Name = "rdoSessao";
            this.rdoSessao.TabStop = true;
            this.rdoSessao.UseVisualStyleBackColor = true;
            // 
            // rdoCadastrar
            // 
            resources.ApplyResources(this.rdoCadastrar, "rdoCadastrar");
            this.rdoCadastrar.Name = "rdoCadastrar";
            this.rdoCadastrar.TabStop = true;
            this.rdoCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmAutenticacao
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rdoCadastrar);
            this.Controls.Add(this.rdoSessao);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Name = "FrmAutenticacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.RadioButton rdoSessao;
        private System.Windows.Forms.RadioButton rdoCadastrar;
    }
}

