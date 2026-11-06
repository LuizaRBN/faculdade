namespace HelloWord
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
            btnMensagem = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(133, 122);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(94, 29);
            btnMensagem.TabIndex = 0;
            btnMensagem.Text = "Mensagem";
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(29, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(102, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 27);
            txtNome.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnMensagem);
            Name = "Form1";
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMensagem;
        private Label lblNome;
        private TextBox txtNome;
    }
}
