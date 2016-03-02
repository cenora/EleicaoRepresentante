namespace Apresentacao
{
    partial class FrmMenu
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
            this.barraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            this.barraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersao});
            this.barraStatusPrincipal.Location = new System.Drawing.Point(0, 459);
            this.barraStatusPrincipal.Name = "barraStatusPrincipal";
            this.barraStatusPrincipal.Size = new System.Drawing.Size(859, 22);
            this.barraStatusPrincipal.TabIndex = 1;
            this.barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(59, 17);
            this.labelVersao.Text = "Versao 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(859, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPessoa});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "&Cadastro";
            // 
            // menuPessoa
            // 
            this.menuPessoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.menuPessoa.Name = "menuPessoa";
            this.menuPessoa.Size = new System.Drawing.Size(110, 22);
            this.menuPessoa.Text = "&Pessoa";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "C&adastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pesquisarToolStripMenuItem.Text = "P&esquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "&Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 481);
            this.Controls.Add(this.barraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenu";
            this.Text = "OcTur";
            this.barraStatusPrincipal.ResumeLayout(false);
            this.barraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuPessoa;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
    }
}