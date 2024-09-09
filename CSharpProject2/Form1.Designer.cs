namespace CSharpProject2
{
    partial class FRM2
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
            txtNome = new TextBox();
            lblTexto = new Label();
            btnExecute = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 154);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(386, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(84, 131);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(121, 20);
            lblTexto.TabIndex = 1;
            lblTexto.Text = "Digite seu nome:";
            lblTexto.Click += label1_Click;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(84, 200);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(94, 29);
            btnExecute.TabIndex = 2;
            btnExecute.Text = "Executar";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(196, 200);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // FRM2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnExecute);
            Controls.Add(lblTexto);
            Controls.Add(txtNome);
            Name = "FRM2";
            Text = "Segundo Programa";
            Load += FRM2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lblTexto;
        private Button btnExecute;
        private Button btnSair;
    }
}
