namespace Variaveis
{
    partial class frmSoma
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
            btnReais = new Button();
            btnInteiros = new Button();
            lblA = new Label();
            lblB = new Label();
            lblResultado = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnReais
            // 
            btnReais.Location = new Point(240, 64);
            btnReais.Name = "btnReais";
            btnReais.Size = new Size(94, 29);
            btnReais.TabIndex = 0;
            btnReais.Text = "Reais";
            btnReais.UseVisualStyleBackColor = true;
            btnReais.Click += btnReais_Click;
            // 
            // btnInteiros
            // 
            btnInteiros.Location = new Point(240, 14);
            btnInteiros.Name = "btnInteiros";
            btnInteiros.Size = new Size(94, 29);
            btnInteiros.TabIndex = 1;
            btnInteiros.Text = "Inteiros";
            btnInteiros.UseVisualStyleBackColor = true;
            btnInteiros.Click += btnInteiros_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(76, 10);
            lblA.Name = "lblA";
            lblA.Size = new Size(19, 20);
            lblA.TabIndex = 2;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(77, 56);
            lblB.Name = "lblB";
            lblB.Size = new Size(18, 20);
            lblB.TabIndex = 3;
            lblB.Text = "B";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 103);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // txtA
            // 
            txtA.Location = new Point(101, 3);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(101, 49);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(101, 96);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 7;
            // 
            // frmSoma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 154);
            Controls.Add(txtResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblResultado);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnInteiros);
            Controls.Add(btnReais);
            Name = "frmSoma";
            Text = "Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReais;
        private Button btnInteiros;
        private Label lblA;
        private Label lblB;
        private Label lblResultado;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResultado;

        public EventHandler lblResultado_Click { get; private set; }
        public EventHandler txtB_TextChanged { get; private set; }
    }
}
