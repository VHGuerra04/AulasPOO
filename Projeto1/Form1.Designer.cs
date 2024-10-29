namespace Projeto1
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
            txbprimeironumero = new TextBox();
            txbsegundonumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnsomar = new Button();
            label3 = new Label();
            txbresultado = new TextBox();
            btnmultiplicar = new Button();
            btnsubtrasao = new Button();
            btndivisao = new Button();
            SuspendLayout();
            // 
            // txbprimeironumero
            // 
            txbprimeironumero.Location = new Point(97, 72);
            txbprimeironumero.Name = "txbprimeironumero";
            txbprimeironumero.Size = new Size(120, 23);
            txbprimeironumero.TabIndex = 0;
            txbprimeironumero.TextChanged += textBox1_TextChanged;
            // 
            // txbsegundonumero
            // 
            txbsegundonumero.Location = new Point(97, 137);
            txbsegundonumero.Name = "txbsegundonumero";
            txbsegundonumero.Size = new Size(120, 23);
            txbsegundonumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 54);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Dígite o número 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 119);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Dígite o número 2:";
            // 
            // btnsomar
            // 
            btnsomar.Location = new Point(50, 189);
            btnsomar.Name = "btnsomar";
            btnsomar.Size = new Size(98, 23);
            btnsomar.TabIndex = 4;
            btnsomar.Text = "Somar";
            btnsomar.UseVisualStyleBackColor = true;
            btnsomar.Click += btnsomar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(97, 257);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // txbresultado
            // 
            txbresultado.ForeColor = Color.Teal;
            txbresultado.Location = new Point(97, 275);
            txbresultado.Name = "txbresultado";
            txbresultado.Size = new Size(120, 23);
            txbresultado.TabIndex = 6;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Location = new Point(50, 231);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(98, 23);
            btnmultiplicar.TabIndex = 7;
            btnmultiplicar.Text = "Multiplicacao";
            btnmultiplicar.UseVisualStyleBackColor = true;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnsubtrasao
            // 
            btnsubtrasao.Location = new Point(154, 189);
            btnsubtrasao.Name = "btnsubtrasao";
            btnsubtrasao.Size = new Size(98, 23);
            btnsubtrasao.TabIndex = 8;
            btnsubtrasao.Text = "Subtrair";
            btnsubtrasao.UseVisualStyleBackColor = true;
            btnsubtrasao.Click += button2_Click;
            // 
            // btndivisao
            // 
            btndivisao.Location = new Point(154, 231);
            btndivisao.Name = "btndivisao";
            btndivisao.Size = new Size(98, 23);
            btndivisao.TabIndex = 9;
            btndivisao.Text = "Divisao";
            btndivisao.UseVisualStyleBackColor = true;
            btndivisao.Click += btndivisao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 448);
            Controls.Add(btndivisao);
            Controls.Add(btnsubtrasao);
            Controls.Add(btnmultiplicar);
            Controls.Add(txbresultado);
            Controls.Add(label3);
            Controls.Add(btnsomar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbsegundonumero);
            Controls.Add(txbprimeironumero);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbprimeironumero;
        private TextBox txbsegundonumero;
        private Label label1;
        private Label label2;
        private Button btnsomar;
        private Label label3;
        private TextBox txbresultado;
        private Button btnmultiplicar;
        private Button btnsubtrasao;
        private Button btndivisao;
    }
}
