namespace Apresentacao
{
    partial class FrmSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSessao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAbrirSessao = new System.Windows.Forms.Button();
            this.lblInstrucaoMesario = new System.Windows.Forms.Label();
            this.lblAvisoMesario = new System.Windows.Forms.Label();
            this.lblAviso2Mesario = new System.Windows.Forms.Label();
            this.lblAviso3Mesario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAbrirSessao
            // 
            this.btnAbrirSessao.Location = new System.Drawing.Point(418, 167);
            this.btnAbrirSessao.Name = "btnAbrirSessao";
            this.btnAbrirSessao.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirSessao.TabIndex = 1;
            this.btnAbrirSessao.Text = "Abrir sessão";
            this.btnAbrirSessao.UseVisualStyleBackColor = true;
            // 
            // lblInstrucaoMesario
            // 
            this.lblInstrucaoMesario.AutoSize = true;
            this.lblInstrucaoMesario.Location = new System.Drawing.Point(21, 18);
            this.lblInstrucaoMesario.Name = "lblInstrucaoMesario";
            this.lblInstrucaoMesario.Size = new System.Drawing.Size(167, 13);
            this.lblInstrucaoMesario.TabIndex = 2;
            this.lblInstrucaoMesario.Text = "Caro Mesário, escolha uma turma:";
            // 
            // lblAvisoMesario
            // 
            this.lblAvisoMesario.AutoSize = true;
            this.lblAvisoMesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoMesario.Location = new System.Drawing.Point(354, 83);
            this.lblAvisoMesario.Name = "lblAvisoMesario";
            this.lblAvisoMesario.Size = new System.Drawing.Size(197, 16);
            this.lblAvisoMesario.TabIndex = 3;
            this.lblAvisoMesario.Text = "Certifique-se que os alunos";
            // 
            // lblAviso2Mesario
            // 
            this.lblAviso2Mesario.AutoSize = true;
            this.lblAviso2Mesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso2Mesario.Location = new System.Drawing.Point(327, 100);
            this.lblAviso2Mesario.Name = "lblAviso2Mesario";
            this.lblAviso2Mesario.Size = new System.Drawing.Size(250, 16);
            this.lblAviso2Mesario.TabIndex = 3;
            this.lblAviso2Mesario.Text = "estão em fila e que esta em posse ";
            // 
            // lblAviso3Mesario
            // 
            this.lblAviso3Mesario.AutoSize = true;
            this.lblAviso3Mesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso3Mesario.Location = new System.Drawing.Point(375, 118);
            this.lblAviso3Mesario.Name = "lblAviso3Mesario";
            this.lblAviso3Mesario.Size = new System.Drawing.Size(154, 16);
            this.lblAviso3Mesario.TabIndex = 3;
            this.lblAviso3Mesario.Text = "da lista de presença.";
            // 
            // FrmSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 289);
            this.Controls.Add(this.lblAviso3Mesario);
            this.Controls.Add(this.lblAviso2Mesario);
            this.Controls.Add(this.lblAvisoMesario);
            this.Controls.Add(this.lblInstrucaoMesario);
            this.Controls.Add(this.btnAbrirSessao);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSessao";
            this.Text = "Abertura de Sessão";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAbrirSessao;
        private System.Windows.Forms.Label lblInstrucaoMesario;
        private System.Windows.Forms.Label lblAvisoMesario;
        private System.Windows.Forms.Label lblAviso2Mesario;
        private System.Windows.Forms.Label lblAviso3Mesario;
    }
}