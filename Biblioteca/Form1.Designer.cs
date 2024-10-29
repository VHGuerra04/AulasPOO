namespace Biblioteca
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
            btnBuscaNome = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnBuscaNome
            // 
            btnBuscaNome.Location = new Point(162, 201);
            btnBuscaNome.Name = "btnBuscaNome";
            btnBuscaNome.Size = new Size(106, 42);
            btnBuscaNome.TabIndex = 0;
            btnBuscaNome.Text = "Buscar Nome Pessoa";
            btnBuscaNome.UseVisualStyleBackColor = true;
            btnBuscaNome.Click += btnBuscaNome_Click;
            // 
            // button1
            // 
            button1.Location = new Point(162, 249);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 1;
            button1.Text = "Buscar Nome Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnBuscaNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscaNome;
        private Button button1;
    }
}
