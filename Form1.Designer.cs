
namespace pizza2
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
            this.labelIDCLIENTE = new System.Windows.Forms.Label();
            this.labelNOME = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textIDCLIENTE = new System.Windows.Forms.TextBox();
            this.textNOME = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textPedido = new System.Windows.Forms.TextBox();
            this.textIDPEDIDO = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelPedido = new System.Windows.Forms.Label();
            this.labelIDPEDIDO = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnidcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textCobrança = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDCLIENTE
            // 
            this.labelIDCLIENTE.AutoSize = true;
            this.labelIDCLIENTE.Location = new System.Drawing.Point(12, 9);
            this.labelIDCLIENTE.Name = "labelIDCLIENTE";
            this.labelIDCLIENTE.Size = new System.Drawing.Size(58, 15);
            this.labelIDCLIENTE.TabIndex = 0;
            this.labelIDCLIENTE.Text = "ID Cliente";
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Location = new System.Drawing.Point(12, 53);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(40, 15);
            this.labelNOME.TabIndex = 1;
            this.labelNOME.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(12, 97);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // textIDCLIENTE
            // 
            this.textIDCLIENTE.Location = new System.Drawing.Point(12, 27);
            this.textIDCLIENTE.Name = "textIDCLIENTE";
            this.textIDCLIENTE.Size = new System.Drawing.Size(100, 23);
            this.textIDCLIENTE.TabIndex = 3;
            // 
            // textNOME
            // 
            this.textNOME.Location = new System.Drawing.Point(12, 71);
            this.textNOME.Name = "textNOME";
            this.textNOME.Size = new System.Drawing.Size(100, 23);
            this.textNOME.TabIndex = 4;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(12, 115);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 23);
            this.textTelefone.TabIndex = 5;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(142, 115);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 23);
            this.textValor.TabIndex = 11;
            // 
            // textPedido
            // 
            this.textPedido.Location = new System.Drawing.Point(142, 71);
            this.textPedido.Name = "textPedido";
            this.textPedido.Size = new System.Drawing.Size(100, 23);
            this.textPedido.TabIndex = 10;
            // 
            // textIDPEDIDO
            // 
            this.textIDPEDIDO.Location = new System.Drawing.Point(142, 27);
            this.textIDPEDIDO.Name = "textIDPEDIDO";
            this.textIDPEDIDO.Size = new System.Drawing.Size(100, 23);
            this.textIDPEDIDO.TabIndex = 9;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(142, 97);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(33, 15);
            this.labelValor.TabIndex = 8;
            this.labelValor.Text = "Valor";
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Location = new System.Drawing.Point(142, 53);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(44, 15);
            this.labelPedido.TabIndex = 7;
            this.labelPedido.Text = "Pedido";
            // 
            // labelIDPEDIDO
            // 
            this.labelIDPEDIDO.AutoSize = true;
            this.labelIDPEDIDO.Location = new System.Drawing.Point(142, 9);
            this.labelIDPEDIDO.Name = "labelIDPEDIDO";
            this.labelIDPEDIDO.Size = new System.Drawing.Size(58, 15);
            this.labelIDPEDIDO.TabIndex = 6;
            this.labelIDPEDIDO.Text = "ID Pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnidcliente,
            this.ColumnNome,
            this.ColumnTelefone,
            this.ColumnIDpedido,
            this.ColumnPedido,
            this.ColumnValor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 252);
            this.dataGridView1.TabIndex = 12;
            // 
            // columnidcliente
            // 
            this.columnidcliente.HeaderText = "ID CLIENTE";
            this.columnidcliente.Name = "columnidcliente";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnIDpedido
            // 
            this.ColumnIDpedido.HeaderText = "ID PEDIDO";
            this.ColumnIDpedido.Name = "ColumnIDpedido";
            // 
            // ColumnPedido
            // 
            this.ColumnPedido.HeaderText = "PEDIDO";
            this.ColumnPedido.Name = "ColumnPedido";
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "VALOR";
            this.ColumnValor.Name = "ColumnValor";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "******************  Menu  *********************",
            "*                                                                             *",
            "*Pizza de calabreza.............................. R$ 14.90*",
            "*Pizza de Mussarela............................. R$ 15.70*",
            "*Pizza de Frango com Catupiry.......... R$ 20.00*",
            "*Pizza de calabreza.............................. R$ 12.90*",
            "*Pizza de calabreza.............................. R$ 26.90*",
            "*                                                                             *",
            "************************************************"});
            this.listBox1.Location = new System.Drawing.Point(248, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 139);
            this.listBox1.TabIndex = 13;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(544, 27);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(544, 71);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(544, 114);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 17;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textCobrança
            // 
            this.textCobrança.Location = new System.Drawing.Point(555, 447);
            this.textCobrança.Name = "textCobrança";
            this.textCobrança.Size = new System.Drawing.Size(100, 23);
            this.textCobrança.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valor Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 482);
            this.Controls.Add(this.textCobrança);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textPedido);
            this.Controls.Add(this.textIDPEDIDO);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.labelIDPEDIDO);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textNOME);
            this.Controls.Add(this.textIDCLIENTE);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.labelIDCLIENTE);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDCLIENTE;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textIDCLIENTE;
        private System.Windows.Forms.TextBox textNOME;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textPedido;
        private System.Windows.Forms.TextBox textIDPEDIDO;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.Label labelIDPEDIDO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnidcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.TextBox textCobrança;
        private System.Windows.Forms.Label label1;
    }
}

