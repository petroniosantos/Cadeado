namespace cadeado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSequenciaChaves = new System.Windows.Forms.TextBox();
            this.txtOpcoesChaves = new System.Windows.Forms.TextBox();
            this.lstCadeado = new System.Windows.Forms.ListBox();
            this.nudChavesSeletoras = new System.Windows.Forms.NumericUpDown();
            this.lblSeraAbertEm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudChavesSeletoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combinação Letras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opções de Letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chaves Seletoras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sequência para Abrir Cadeado";
            // 
            // txtSequenciaChaves
            // 
            this.txtSequenciaChaves.Location = new System.Drawing.Point(202, 45);
            this.txtSequenciaChaves.Name = "txtSequenciaChaves";
            this.txtSequenciaChaves.Size = new System.Drawing.Size(253, 23);
            this.txtSequenciaChaves.TabIndex = 4;
            // 
            // txtOpcoesChaves
            // 
            this.txtOpcoesChaves.Location = new System.Drawing.Point(202, 79);
            this.txtOpcoesChaves.Name = "txtOpcoesChaves";
            this.txtOpcoesChaves.Size = new System.Drawing.Size(253, 23);
            this.txtOpcoesChaves.TabIndex = 4;
            // 
            // lstCadeado
            // 
            this.lstCadeado.FormattingEnabled = true;
            this.lstCadeado.ItemHeight = 15;
            this.lstCadeado.Location = new System.Drawing.Point(468, 44);
            this.lstCadeado.Name = "lstCadeado";
            this.lstCadeado.Size = new System.Drawing.Size(419, 289);
            this.lstCadeado.TabIndex = 5;
            // 
            // nudChavesSeletoras
            // 
            this.nudChavesSeletoras.Location = new System.Drawing.Point(202, 118);
            this.nudChavesSeletoras.Name = "nudChavesSeletoras";
            this.nudChavesSeletoras.Size = new System.Drawing.Size(50, 23);
            this.nudChavesSeletoras.TabIndex = 6;
            // 
            // lblSeraAbertEm
            // 
            this.lblSeraAbertEm.AutoSize = true;
            this.lblSeraAbertEm.Location = new System.Drawing.Point(202, 161);
            this.lblSeraAbertEm.Name = "lblSeraAbertEm";
            this.lblSeraAbertEm.Size = new System.Drawing.Size(0, 15);
            this.lblSeraAbertEm.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lista com todas sequências Possíveis";
            // 
            // btnCalcule
            // 
            this.btnCalcule.Location = new System.Drawing.Point(177, 244);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(75, 23);
            this.btnCalcule.TabIndex = 9;
            this.btnCalcule.Text = "Calcule";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.botao_calcular);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 347);
            this.Controls.Add(this.btnCalcule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSeraAbertEm);
            this.Controls.Add(this.nudChavesSeletoras);
            this.Controls.Add(this.lstCadeado);
            this.Controls.Add(this.txtOpcoesChaves);
            this.Controls.Add(this.txtSequenciaChaves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CADEADO";
            ((System.ComponentModel.ISupportInitialize)(this.nudChavesSeletoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSequenciaChaves;
        private System.Windows.Forms.TextBox txtOpcoesChaves;
        private System.Windows.Forms.ListBox lstCadeado;
        private System.Windows.Forms.NumericUpDown nudChavesSeletoras;
        private System.Windows.Forms.Label lblSeraAbertEm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcule;
    }
}

