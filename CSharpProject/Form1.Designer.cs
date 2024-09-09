namespace CSharpProject
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
            btnClique = new Button();
            SuspendLayout();
            // 
            // btnClique
            // 
            btnClique.BackColor = Color.Purple;
            btnClique.Cursor = Cursors.Hand;
            btnClique.FlatStyle = FlatStyle.Popup;
            btnClique.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClique.ForeColor = Color.Gold;
            btnClique.ImageAlign = ContentAlignment.MiddleLeft;
            btnClique.Location = new Point(350, 202);
            btnClique.Name = "btnClique";
            btnClique.Size = new Size(159, 57);
            btnClique.TabIndex = 0;
            btnClique.Text = "Click Here";
            btnClique.UseVisualStyleBackColor = false;
            btnClique.Click += btnClique_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClique);
            ForeColor = Color.Transparent;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClique;
    }
}
