namespace desenvolvimentoDesktop
{
    partial class Calculadora
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
            label1 = new Label();
            btnSomar = new Button();
            txtValorA = new TextBox();
            label2 = new Label();
            txtValorB = new TextBox();
            lblResposta = new Label();
            b = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "valor A";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(254, 74);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(79, 23);
            btnSomar.TabIndex = 1;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // txtValorA
            // 
            txtValorA.Location = new Point(48, 27);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new Size(144, 23);
            txtValorA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "ValorB";
            // 
            // txtValorB
            // 
            txtValorB.Location = new Point(48, 85);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(144, 23);
            txtValorB.TabIndex = 4;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(407, 117);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(0, 15);
            lblResposta.TabIndex = 5;
            // 
            // b
            // 
            b.Location = new Point(254, 132);
            b.Name = "b";
            b.Size = new Size(75, 23);
            b.TabIndex = 6;
            b.Text = "Dividir";
            b.UseVisualStyleBackColor = true;
            b.Click += b_Click_1;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(254, 103);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Subtrair";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 196);
            Controls.Add(btnDividir);
            Controls.Add(b);
            Controls.Add(lblResposta);
            Controls.Add(txtValorB);
            Controls.Add(label2);
            Controls.Add(txtValorA);
            Controls.Add(btnSomar);
            Controls.Add(label1);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSomar;
        private TextBox txtValorA;
        private Label label2;
        private TextBox txtValorB;
        private Label lblResposta;
        private Button b;
        private Button btnDividir;
    }
}
