namespace CondicionalSimples
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
            lblMedia = new Label();
            btnVerificar = new Button();
            txtMedia = new TextBox();
            SuspendLayout();
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(21, 33);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(51, 20);
            lblMedia.TabIndex = 0;
            lblMedia.Text = "Média";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(56, 92);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(144, 29);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(94, 30);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(125, 27);
            txtMedia.TabIndex = 2;
            // 
            // FormMedia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 187);
            Controls.Add(txtMedia);
            Controls.Add(btnVerificar);
            Controls.Add(lblMedia);
            Name = "FormMedia";
            Text = "Média";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedia;
        private Button btnVerificar;
        private TextBox txtMedia;
    }
}
