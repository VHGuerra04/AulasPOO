namespace ContaBancaria
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
            btnVerificar = new Button();
            txbCodigoCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbCPF = new TextBox();
            label3 = new Label();
            txbNome = new TextBox();
            label4 = new Label();
            txbEndereco = new TextBox();
            label5 = new Label();
            txbIdade = new TextBox();
            label6 = new Label();
            txbNumeroConta = new TextBox();
            label7 = new Label();
            txbAgencia = new TextBox();
            btnCriarConta = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = SystemColors.ActiveCaption;
            btnVerificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = SystemColors.Desktop;
            btnVerificar.Location = new Point(61, 350);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(142, 50);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar Idade";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txbCodigoCliente
            // 
            txbCodigoCliente.Location = new Point(61, 93);
            txbCodigoCliente.Name = "txbCodigoCliente";
            txbCodigoCliente.Size = new Size(103, 23);
            txbCodigoCliente.TabIndex = 1;
            txbCodigoCliente.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 75);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 2;
            label1.Text = "Codigo do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 124);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // txbCPF
            // 
            txbCPF.Location = new Point(61, 142);
            txbCPF.Name = "txbCPF";
            txbCPF.Size = new Size(142, 23);
            txbCPF.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 182);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(61, 200);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(103, 23);
            txbNome.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 237);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Endereço";
            label4.Click += label4_Click;
            // 
            // txbEndereco
            // 
            txbEndereco.Location = new Point(61, 255);
            txbEndereco.Name = "txbEndereco";
            txbEndereco.Size = new Size(103, 23);
            txbEndereco.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 290);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Idade";
            // 
            // txbIdade
            // 
            txbIdade.Location = new Point(61, 308);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(103, 23);
            txbIdade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 75);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 12;
            label6.Text = "Número da conta";
            label6.Click += label6_Click;
            // 
            // txbNumeroConta
            // 
            txbNumeroConta.Location = new Point(309, 93);
            txbNumeroConta.Name = "txbNumeroConta";
            txbNumeroConta.Size = new Size(103, 23);
            txbNumeroConta.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 124);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 14;
            label7.Text = "Agência";
            // 
            // txbAgencia
            // 
            txbAgencia.Location = new Point(309, 142);
            txbAgencia.Name = "txbAgencia";
            txbAgencia.Size = new Size(103, 23);
            txbAgencia.TabIndex = 13;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = SystemColors.ActiveCaption;
            btnCriarConta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarConta.ForeColor = SystemColors.Desktop;
            btnCriarConta.Location = new Point(309, 185);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(142, 50);
            btnCriarConta.TabIndex = 15;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(309, 272);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 16;
            button1.Text = "Poupança";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCriarConta);
            Controls.Add(label7);
            Controls.Add(txbAgencia);
            Controls.Add(label6);
            Controls.Add(txbNumeroConta);
            Controls.Add(label5);
            Controls.Add(txbIdade);
            Controls.Add(label4);
            Controls.Add(txbEndereco);
            Controls.Add(label3);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(txbCPF);
            Controls.Add(label1);
            Controls.Add(txbCodigoCliente);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox txbCodigoCliente;
        private Label label1;
        private Label label2;
        private TextBox txbCPF;
        private Label label3;
        private TextBox txbNome;
        private Label label4;
        private TextBox txbEndereco;
        private Label label5;
        private TextBox txbIdade;
        private Label label6;
        private TextBox txbNumeroConta;
        private Label label7;
        private TextBox txbAgencia;
        private Button btnCriarConta;
        private Button button1;
    }
}
