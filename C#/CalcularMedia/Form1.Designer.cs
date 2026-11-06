namespace CalcularMedia
{
    partial class FormMedia
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
            lblNota1 = new Label();
            llblNota3 = new Label();
            lblMed = new Label();
            lblMedia = new Label();
            lblSit = new Label();
            lblSituacao = new Label();
            btnCalcular = new Button();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lblNota2 = new Label();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(26, 38);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(54, 20);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            // 
            // llblNota3
            // 
            llblNota3.AutoSize = true;
            llblNota3.Location = new Point(26, 122);
            llblNota3.Name = "llblNota3";
            llblNota3.Size = new Size(54, 20);
            llblNota3.TabIndex = 2;
            llblNota3.Text = "Nota 3";
            // 
            // lblMed
            // 
            lblMed.AutoSize = true;
            lblMed.Location = new Point(26, 199);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(51, 20);
            lblMed.TabIndex = 3;
            lblMed.Text = "Média";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(127, 199);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(50, 20);
            lblMedia.TabIndex = 4;
            lblMedia.Text = "label5";
            // 
            // lblSit
            // 
            lblSit.AutoSize = true;
            lblSit.Location = new Point(26, 244);
            lblSit.Name = "lblSit";
            lblSit.Size = new Size(66, 20);
            lblSit.TabIndex = 5;
            lblSit.Text = "Situação";
            lblSit.Click += Label6_Click;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(127, 244);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(50, 20);
            lblSituacao.TabIndex = 6;
            lblSituacao.Text = "label7";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(87, 303);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += BtnCalcular_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(110, 38);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 27);
            txtNota1.TabIndex = 8;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(110, 77);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 27);
            txtNota2.TabIndex = 9;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(110, 122);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(125, 27);
            txtNota3.TabIndex = 10;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(26, 77);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(54, 20);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota 2";
            // 
            // FormMedia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 405);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(btnCalcular);
            Controls.Add(lblSituacao);
            Controls.Add(lblSit);
            Controls.Add(lblMedia);
            Controls.Add(lblMed);
            Controls.Add(llblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "FormMedia";
            Text = "Calcular Média";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label llblNota3;
        private Label lblMed;
        private Label lblMedia;
        private Label lblSit;
        private Label lblSituacao;
        private Button btnCalcular;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label lblNota2;
    }
}
