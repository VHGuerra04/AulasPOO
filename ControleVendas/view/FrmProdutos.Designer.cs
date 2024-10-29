namespace ControleVendas.view
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            PageDados = new TabPage();
            PageConsulta = new TabPage();
            label2 = new Label();
            txbCodigo = new TextBox();
            txbDescricao = new TextBox();
            label3 = new Label();
            txbPreco = new TextBox();
            label4 = new Label();
            txbQuantidade = new TextBox();
            label5 = new Label();
            cbFornecedores = new ComboBox();
            label6 = new Label();
            btnexcluir = new Button();
            btnalterar = new Button();
            btnsalvar = new Button();
            label7 = new Label();
            txbPesquisar = new TextBox();
            btnPesquisar = new Button();
            dgvProdutos = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            PageDados.SuspendLayout();
            PageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(340, 33);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PageDados);
            tabControl1.Controls.Add(PageConsulta);
            tabControl1.Location = new Point(12, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(789, 279);
            tabControl1.TabIndex = 2;
            // 
            // PageDados
            // 
            PageDados.Controls.Add(label6);
            PageDados.Controls.Add(cbFornecedores);
            PageDados.Controls.Add(txbQuantidade);
            PageDados.Controls.Add(label5);
            PageDados.Controls.Add(txbPreco);
            PageDados.Controls.Add(label4);
            PageDados.Controls.Add(txbDescricao);
            PageDados.Controls.Add(label3);
            PageDados.Controls.Add(txbCodigo);
            PageDados.Controls.Add(label2);
            PageDados.Location = new Point(4, 24);
            PageDados.Name = "PageDados";
            PageDados.Padding = new Padding(3);
            PageDados.Size = new Size(781, 251);
            PageDados.TabIndex = 0;
            PageDados.Text = "Dados";
            PageDados.UseVisualStyleBackColor = true;
            PageDados.Click += PageDados_Click;
            // 
            // PageConsulta
            // 
            PageConsulta.Controls.Add(dgvProdutos);
            PageConsulta.Controls.Add(btnPesquisar);
            PageConsulta.Controls.Add(txbPesquisar);
            PageConsulta.Controls.Add(label7);
            PageConsulta.Location = new Point(4, 24);
            PageConsulta.Name = "PageConsulta";
            PageConsulta.Padding = new Padding(3);
            PageConsulta.Size = new Size(781, 251);
            PageConsulta.TabIndex = 1;
            PageConsulta.Text = "Consulta";
            PageConsulta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(86, 8);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(100, 23);
            txbCodigo.TabIndex = 1;
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(86, 37);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(286, 23);
            txbDescricao.TabIndex = 3;
            txbDescricao.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 45);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // txbPreco
            // 
            txbPreco.Location = new Point(86, 66);
            txbPreco.Name = "txbPreco";
            txbPreco.Size = new Size(100, 23);
            txbPreco.TabIndex = 5;
            //txbPreco.TextChanged += this.textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 74);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Preço";
            label4.Click += label4_Click;
            // 
            // txbQuantidade
            // 
            txbQuantidade.Location = new Point(272, 66);
            txbQuantidade.Name = "txbQuantidade";
            txbQuantidade.Size = new Size(100, 23);
            txbQuantidade.TabIndex = 7;
            //txbQuantidade.TextChanged += this.textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 69);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 6;
            label5.Text = "Quantidade";
            label5.Click += label5_Click;
            // 
            // cbFornecedores
            // 
            cbFornecedores.FormattingEnabled = true;
            cbFornecedores.Location = new Point(86, 95);
            cbFornecedores.Name = "cbFornecedores";
            cbFornecedores.Size = new Size(180, 23);
            cbFornecedores.TabIndex = 8;
            cbFornecedores.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 98);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 9;
            label6.Text = "Fornecedor";
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.FromArgb(128, 64, 64);
            btnexcluir.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexcluir.ForeColor = Color.PeachPuff;
            btnexcluir.Location = new Point(683, 400);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(108, 40);
            btnexcluir.TabIndex = 7;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btnalterar
            // 
            btnalterar.BackColor = Color.FromArgb(128, 64, 64);
            btnalterar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnalterar.ForeColor = Color.PeachPuff;
            btnalterar.Location = new Point(148, 400);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(108, 40);
            btnalterar.TabIndex = 6;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.SaddleBrown;
            btnsalvar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvar.ForeColor = Color.PeachPuff;
            btnsalvar.Location = new Point(19, 400);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(108, 40);
            btnsalvar.TabIndex = 5;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 16);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Pesquisar";
            // 
            // txbPesquisar
            // 
            txbPesquisar.Location = new Point(76, 13);
            txbPesquisar.Name = "txbPesquisar";
            txbPesquisar.Size = new Size(260, 23);
            txbPesquisar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.SaddleBrown;
            btnPesquisar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.PeachPuff;
            btnPesquisar.Location = new Point(342, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(136, 41);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(13, 47);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(762, 198);
            dgvProdutos.TabIndex = 5;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 459);
            Controls.Add(btnexcluir);
            Controls.Add(btnalterar);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(btnsalvar);
            Name = "FrmProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produtos";
            Load += FrmProdutos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            PageDados.ResumeLayout(false);
            PageDados.PerformLayout();
            PageConsulta.ResumeLayout(false);
            PageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage PageDados;
        private TabPage PageConsulta;
        private TextBox txbCodigo;
        private Label label2;
        private TextBox txbDescricao;
        private Label label3;
        private TextBox txbPreco;
        private Label label4;
        private TextBox txbQuantidade;
        private Label label5;
        private ComboBox cbFornecedores;
        private Label label6;
        private Button btnexcluir;
        private Button btnalterar;
        private Button btnsalvar;
        private Label label7;
        private TextBox txbPesquisar;
        private DataGridView dgvProdutos;
        private Button btnPesquisar;
    }
}