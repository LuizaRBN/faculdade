namespace Operadores
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
            lblX = new Label();
            btnPre = new Button();
            btnPos = new Button();
            txtX = new TextBox();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(15, 22);
            lblX.Name = "lblX";
            lblX.Size = new Size(18, 20);
            lblX.TabIndex = 0;
            lblX.Text = "X";
            // 
            // btnPre
            // 
            btnPre.Location = new Point(15, 89);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(201, 29);
            btnPre.TabIndex = 1;
            btnPre.Text = "Incremento pré-fixado";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btnPre_Click;
            // 
            // btnPos
            // 
            btnPos.Location = new Point(260, 89);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(199, 29);
            btnPos.TabIndex = 2;
            btnPos.Text = "Incremento pós-fixado";
            btnPos.UseVisualStyleBackColor = true;
            btnPos.Click += btnPos_Click;
            // 
            // txtX
            // 
            txtX.Location = new Point(70, 22);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 196);
            Controls.Add(txtX);
            Controls.Add(btnPos);
            Controls.Add(btnPre);
            Controls.Add(lblX);
            Name = "Form1";
            Text = "Operador de Incremento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Button btnPre;
        private Button btnPos;
        private TextBox txtX;
    }
}
