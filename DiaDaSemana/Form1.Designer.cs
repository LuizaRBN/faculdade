namespace DiaDaSemana
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
            lblDia = new Label();
            lblDiaSemana = new Label();
            txtDia = new TextBox();
            btnVerificar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(45, 42);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(32, 20);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaSemana.ForeColor = Color.Red;
            lblDiaSemana.Location = new Point(70, 120);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(70, 25);
            lblDiaSemana.TabIndex = 1;
            lblDiaSemana.Text = "label2";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(113, 35);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(12, 209);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(94, 29);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(144, 209);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 299);
            ControlBox = false;
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(txtDia);
            Controls.Add(lblDiaSemana);
            Controls.Add(lblDia);
            Name = "Form1";
            Text = "Seleciona Dia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblDiaSemana;
        private TextBox txtDia;
        private Button btnVerificar;
        private Button btnFechar;
    }
}
