namespace QUESTAO1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmesanterior = new System.Windows.Forms.TextBox();
            this.txtConsumoAtual = new System.Windows.Forms.TextBox();
            this.btnCalcularConsumo = new System.Windows.Forms.Button();
            this.txtEXIBIR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do consumo do mês anterior:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor do consumo atual:";
            // 
            // txtmesanterior
            // 
            this.txtmesanterior.Location = new System.Drawing.Point(274, 100);
            this.txtmesanterior.Name = "txtmesanterior";
            this.txtmesanterior.Size = new System.Drawing.Size(100, 20);
            this.txtmesanterior.TabIndex = 2;
            // 
            // txtConsumoAtual
            // 
            this.txtConsumoAtual.Location = new System.Drawing.Point(274, 34);
            this.txtConsumoAtual.Name = "txtConsumoAtual";
            this.txtConsumoAtual.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoAtual.TabIndex = 3;
            // 
            // btnCalcularConsumo
            // 
            this.btnCalcularConsumo.Location = new System.Drawing.Point(285, 172);
            this.btnCalcularConsumo.Name = "btnCalcularConsumo";
            this.btnCalcularConsumo.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularConsumo.TabIndex = 4;
            this.btnCalcularConsumo.Text = "Calcular";
            this.btnCalcularConsumo.UseVisualStyleBackColor = true;
            this.btnCalcularConsumo.Click += new System.EventHandler(this.btnCalcularConsumo_Click);
            // 
            // txtEXIBIR
            // 
            this.txtEXIBIR.Location = new System.Drawing.Point(274, 239);
            this.txtEXIBIR.Name = "txtEXIBIR";
            this.txtEXIBIR.Size = new System.Drawing.Size(100, 20);
            this.txtEXIBIR.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEXIBIR);
            this.Controls.Add(this.btnCalcularConsumo);
            this.Controls.Add(this.txtConsumoAtual);
            this.Controls.Add(this.txtmesanterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmesanterior;
        private System.Windows.Forms.TextBox txtConsumoAtual;
        private System.Windows.Forms.Button btnCalcularConsumo;
        private System.Windows.Forms.TextBox txtEXIBIR;
    }
}

