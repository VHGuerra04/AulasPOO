namespace ControleVendas.view
{
    partial class FrmClientes
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
            btnsalvar = new Button();
            btnalterar = new Button();
            tabPage2 = new TabPage();
            dgvclientes = new DataGridView();
            btnpesquisar = new Button();
            txbpesquisar = new TextBox();
            label16 = new Label();
            tabPage1 = new TabPage();
            cbestado = new ComboBox();
            label15 = new Label();
            txbbairro = new TextBox();
            txbcomlemento = new TextBox();
            txbcidade = new TextBox();
            txbnumero = new TextBox();
            txbendereco = new TextBox();
            txbemail = new TextBox();
            txbrg = new TextBox();
            txbnome = new TextBox();
            txbcodigo = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txbcep = new MaskedTextBox();
            label9 = new Label();
            txbcelular = new MaskedTextBox();
            label8 = new Label();
            txbtelefone = new MaskedTextBox();
            label7 = new Label();
            txbcpf = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            btnexcluir = new Button();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvclientes).BeginInit();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(316, 33);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = Color.SaddleBrown;
            btnsalvar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalvar.ForeColor = Color.PeachPuff;
            btnsalvar.Location = new Point(12, 385);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(108, 40);
            btnsalvar.TabIndex = 2;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnalterar
            // 
            btnalterar.BackColor = Color.FromArgb(128, 64, 64);
            btnalterar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnalterar.ForeColor = Color.PeachPuff;
            btnalterar.Location = new Point(141, 385);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(108, 40);
            btnalterar.TabIndex = 3;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = false;
            btnalterar.Click += btnalterar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvclientes);
            tabPage2.Controls.Add(btnpesquisar);
            tabPage2.Controls.Add(txbpesquisar);
            tabPage2.Controls.Add(label16);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 245);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvclientes
            // 
            dgvclientes.AllowUserToAddRows = false;
            dgvclientes.AllowUserToDeleteRows = false;
            dgvclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvclientes.Location = new Point(13, 43);
            dgvclientes.Name = "dgvclientes";
            dgvclientes.ReadOnly = true;
            dgvclientes.Size = new Size(749, 196);
            dgvclientes.TabIndex = 4;
            dgvclientes.CellContentClick += dgvclientes_CellContentClick;
            dgvclientes.CellDoubleClick += dgvclientes_CellDoubleClick;
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.SaddleBrown;
            btnpesquisar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpesquisar.ForeColor = Color.PeachPuff;
            btnpesquisar.Location = new Point(335, 3);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(136, 41);
            btnpesquisar.TabIndex = 3;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // txbpesquisar
            // 
            txbpesquisar.Location = new Point(59, 14);
            txbpesquisar.Name = "txbpesquisar";
            txbpesquisar.Size = new Size(270, 23);
            txbpesquisar.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 17);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 0;
            label16.Text = "Nome";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbestado);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txbbairro);
            tabPage1.Controls.Add(txbcomlemento);
            tabPage1.Controls.Add(txbcidade);
            tabPage1.Controls.Add(txbnumero);
            tabPage1.Controls.Add(txbendereco);
            tabPage1.Controls.Add(txbemail);
            tabPage1.Controls.Add(txbrg);
            tabPage1.Controls.Add(txbnome);
            tabPage1.Controls.Add(txbcodigo);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txbcep);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txbcelular);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txbtelefone);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txbcpf);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 245);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados do Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // cbestado
            // 
            cbestado.FormattingEnabled = true;
            cbestado.Items.AddRange(new object[] { "RS", "SC", "PR", "SP", "RJ" });
            cbestado.Location = new Point(273, 192);
            cbestado.Name = "cbestado";
            cbestado.Size = new Size(121, 23);
            cbestado.TabIndex = 25;
            cbestado.SelectedIndexChanged += cbestado_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(246, 195);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 24;
            label15.Text = "UF";
            // 
            // txbbairro
            // 
            txbbairro.Location = new Point(61, 192);
            txbbairro.Name = "txbbairro";
            txbbairro.Size = new Size(172, 23);
            txbbairro.TabIndex = 23;
            // 
            // txbcomlemento
            // 
            txbcomlemento.Location = new Point(329, 163);
            txbcomlemento.Name = "txbcomlemento";
            txbcomlemento.Size = new Size(326, 23);
            txbcomlemento.TabIndex = 23;
            // 
            // txbcidade
            // 
            txbcidade.Location = new Point(61, 163);
            txbcidade.Name = "txbcidade";
            txbcidade.Size = new Size(172, 23);
            txbcidade.TabIndex = 21;
            // 
            // txbnumero
            // 
            txbnumero.Location = new Point(569, 134);
            txbnumero.Name = "txbnumero";
            txbnumero.Size = new Size(86, 23);
            txbnumero.TabIndex = 19;
            // 
            // txbendereco
            // 
            txbendereco.Location = new Point(232, 134);
            txbendereco.Name = "txbendereco";
            txbendereco.Size = new Size(271, 23);
            txbendereco.TabIndex = 17;
            // 
            // txbemail
            // 
            txbemail.Location = new Point(61, 76);
            txbemail.Name = "txbemail";
            txbemail.Size = new Size(271, 23);
            txbemail.TabIndex = 9;
            // 
            // txbrg
            // 
            txbrg.Location = new Point(375, 47);
            txbrg.Name = "txbrg";
            txbrg.Size = new Size(100, 23);
            txbrg.TabIndex = 7;
            txbrg.TextChanged += txbrg_TextChanged;
            // 
            // txbnome
            // 
            txbnome.Location = new Point(61, 47);
            txbnome.Name = "txbnome";
            txbnome.Size = new Size(271, 23);
            txbnome.TabIndex = 5;
            // 
            // txbcodigo
            // 
            txbcodigo.Location = new Point(61, 18);
            txbcodigo.Name = "txbcodigo";
            txbcodigo.Size = new Size(131, 23);
            txbcodigo.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 195);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 22;
            label14.Text = "Bairro";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(246, 166);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 22;
            label13.Text = "Comlemento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 166);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 20;
            label12.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(512, 137);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 18;
            label11.Text = "Número";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(177, 137);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 16;
            label10.Text = "Endereço";
            // 
            // txbcep
            // 
            txbcep.Location = new Point(61, 134);
            txbcep.Mask = "00000-999";
            txbcep.Name = "txbcep";
            txbcep.Size = new Size(100, 23);
            txbcep.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 137);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 14;
            label9.Text = "CEP";
            // 
            // txbcelular
            // 
            txbcelular.Location = new Point(232, 105);
            txbcelular.Mask = "(99) 00000-0000";
            txbcelular.Name = "txbcelular";
            txbcelular.Size = new Size(100, 23);
            txbcelular.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(177, 108);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 14;
            label8.Text = "Celular";
            // 
            // txbtelefone
            // 
            txbtelefone.Location = new Point(61, 105);
            txbtelefone.Mask = "(99) 0000-0000";
            txbtelefone.Name = "txbtelefone";
            txbtelefone.Size = new Size(100, 23);
            txbtelefone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 108);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Telefone";
            label7.Click += label7_Click;
            // 
            // txbcpf
            // 
            txbcpf.Location = new Point(375, 76);
            txbcpf.Mask = "###,###,###-##";
            txbcpf.Name = "txbcpf";
            txbcpf.Size = new Size(100, 23);
            txbcpf.TabIndex = 11;
            txbcpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 79);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 79);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 50);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "RG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 273);
            tabControl1.TabIndex = 1;
            // 
            // btnexcluir
            // 
            btnexcluir.BackColor = Color.FromArgb(128, 64, 64);
            btnexcluir.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexcluir.ForeColor = Color.PeachPuff;
            btnexcluir.Location = new Point(676, 385);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(108, 40);
            btnexcluir.TabIndex = 4;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = false;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 459);
            Controls.Add(btnexcluir);
            Controls.Add(btnalterar);
            Controls.Add(btnsalvar);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "FrmClientes";
            Text = "Cadastro de Clientes";
            Load += FrmClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvclientes).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnsalvar;
        private Button btnalterar;
        private TabPage tabPage2;
        private DataGridView dgvclientes;
        private Button btnpesquisar;
        private TextBox txbpesquisar;
        private Label label16;
        private TabPage tabPage1;
        private ComboBox cbestado;
        private Label label15;
        private TextBox txbbairro;
        private TextBox txbcomlemento;
        private TextBox txbcidade;
        private TextBox txbnumero;
        private TextBox txbendereco;
        private TextBox txbemail;
        private TextBox txbrg;
        private TextBox txbnome;
        private TextBox txbcodigo;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private MaskedTextBox txbcep;
        private Label label9;
        private MaskedTextBox txbcelular;
        private Label label8;
        private MaskedTextBox txbtelefone;
        private Label label7;
        private MaskedTextBox txbcpf;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
        private Button btnexcluir;
    }
}