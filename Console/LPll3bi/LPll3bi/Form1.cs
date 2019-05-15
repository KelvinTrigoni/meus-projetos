using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPll3bi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rA93912DataSet1.LPII3bi' table. You can move, or remove it, as needed.
            this.lPII3biTableAdapter.Fill(this.rA93912DataSet1.LPII3bi);


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(nome.Text != null)
            {
                DialogResult resultado = MessageBox.Show("tem certeza que deseja excluir?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(resultado == DialogResult.No)
                {
                    return;
                }

                negocios cont = new negocios();
                cont.codigo = int.Parse(this.cod.Text);
                cont.excluir(cont.codigo);
                contato.preenchergrid(dataGridView1);

                limpar();
                habilitarcontrole();
                nome.Focus();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = true;

                MessageBox.Show("Contato excluido com sucesso!", "Sucesso", MessageBoxButtons.OK);

            }
            else
            {
                nome.Focus();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("Nao esxiste contato para ser excluido", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarcontrole();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if(nome.Text != null)
            {
                nome.Focus();
                button2.Enabled = true;
            }

            limpar();

        }

        public void habilitarcontrole()
        {
            nome.Enabled = true;
            endereco.Enabled = true;
            telefone.Enabled = true;
        }

        public void limpar()
        {
            cod.Text = "";
            nome.Text = "";
            endereco.Text = "";
            telefone.Text = "";
        }



        negocios contato = new negocios();

        private void button2_Click(object sender, EventArgs e)
        {

            if (nome.Text != "")
            {
                
                contato.nome = this.nome.Text;
                contato.endereco = this.endereco.Text;
                contato.telefone = this.telefone.Text;
                contato.inserir();

                contato.preenchergrid(dataGridView1);

                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

                MessageBox.Show("Contato cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else
            {
                nome.Focus();
                button1.Enabled = false;
                MessageBox.Show("Adicione um nome de contato", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(nome.Text != null)
                {
                    contato.codigo = int.Parse(cod.Text);
                    contato.nome = nome.Text;
                    contato.endereco = endereco.Text;
                    contato.telefone = telefone.Text;
                    contato.alterar();
                    contato.preenchergrid(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox.Text == "Codigo")
            {
                contato.codigo = int.Parse(textBox2.Text);
                contato.Concodigo(dataGridView1);
            }
            if(comboBox.Text == "Nome")
            {
                contato.nome = textBox2.Text;
                contato.Connome(dataGridView1); 

            }
            if(comboBox.Text == "Telefone")
            {
                contato.telefone = textBox2.Text;
                contato.Confone(dataGridView1);
            }
            if(comboBox.Text == "")
            {
                contato.preenchergrid(dataGridView1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            habilitarcontrole();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = false;

            cod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            endereco.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telefone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
