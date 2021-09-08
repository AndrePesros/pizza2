using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza2
{
    public partial class Form1 : Form
    {
        Pizzaria x = new Pizzaria();
        double valor = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            

            x.Idcliente = int.Parse(textIDCLIENTE.Text);
            x.Idpedido = int.Parse(textIDPEDIDO.Text);
            x.Nome = textNOME.Text;
            x.Pedido = textPedido.Text;
            x.Telefone = textTelefone.Text;
            x.Valor = double.Parse(textValor.Text);
            valor = double.Parse(textValor.Text);
            dataGridView1.Rows.Add(new object[] { x.Idcliente, x.Nome, x.Telefone, x.Idpedido, x.Pedido, x.Valor });

            double Total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total += Convert.ToDouble(dataGridView1.Rows[i].Cells["ColumnValor"].Value);
            }

            textCobrança.Text = Total.ToString();
        }
       
        

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        
    private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            x.Idcliente = int.Parse(textIDCLIENTE.Text);
            x.Idpedido = int.Parse(textIDPEDIDO.Text);
            x.Nome = textNOME.Text;
            x.Pedido = textPedido.Text;
            x.Telefone = textTelefone.Text;
            x.Valor = double.Parse(textValor.Text);

            dataGridView1.Rows.Add(new object[] { x.Idcliente, x.Nome, x.Telefone, x.Idpedido, x.Pedido, x.Valor });

            
        }
    }
}
