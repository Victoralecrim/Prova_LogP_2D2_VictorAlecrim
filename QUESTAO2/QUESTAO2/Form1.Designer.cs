namespace QUESTAO2
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
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.BtnCalcArea = new System.Windows.Forms.Button();
            this.txtAltura2 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea1 = new System.Windows.Forms.TextBox();
            this.txtArea2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a base 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a altura 1:";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(181, 50);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(181, 121);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // BtnCalcArea
            // 
            this.BtnCalcArea.Location = new System.Drawing.Point(324, 202);
            this.BtnCalcArea.Name = "BtnCalcArea";
            this.BtnCalcArea.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcArea.TabIndex = 4;
            this.BtnCalcArea.Text = "Calcular";
            this.BtnCalcArea.UseVisualStyleBackColor = true;
            this.BtnCalcArea.Click += new System.EventHandler(this.BtnCalcArea_Click);
            // 
            // txtAltura2
            // 
            this.txtAltura2.Location = new System.Drawing.Point(504, 118);
            this.txtAltura2.Name = "txtAltura2";
            this.txtAltura2.Size = new System.Drawing.Size(100, 20);
            this.txtAltura2.TabIndex = 5;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(504, 43);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 20);
            this.txtBase2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite a base 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite a altura 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtArea1
            // 
            this.txtArea1.Location = new System.Drawing.Point(181, 252);
            this.txtArea1.Name = "txtArea1";
            this.txtArea1.Size = new System.Drawing.Size(100, 20);
            this.txtArea1.TabIndex = 9;
            // 
            // txtArea2
            // 
            this.txtArea2.Location = new System.Drawing.Point(421, 252);
            this.txtArea2.Name = "txtArea2";
            this.txtArea2.Size = new System.Drawing.Size(100, 20);
            this.txtArea2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArea2);
            this.Controls.Add(this.txtArea1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtAltura2);
            this.Controls.Add(this.BtnCalcArea);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtbase);
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
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button BtnCalcArea;
        private System.Windows.Forms.TextBox txtAltura2;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea1;
        private System.Windows.Forms.TextBox txtArea2;
    }
}

