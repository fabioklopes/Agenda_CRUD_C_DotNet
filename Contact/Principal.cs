using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Logotipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por: FKL Digital Conenct\n\n" +
                "Versão: 1.0.0", "Sobre...");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contatoDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contatoDBDataSet.people'. Você pode movê-la ou removê-la conforme necessário.
            this.peopleTableAdapter.Fill(this.contatoDBDataSet.people);

        }
    }
}
