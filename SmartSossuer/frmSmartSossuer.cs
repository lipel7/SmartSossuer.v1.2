using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSossuer
{
    public partial class frmSmartSossuer : Form
    {
        public frmSmartSossuer()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abCliente = new frmCliente();
            abCliente.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abFunc = new frmFuncionario();
            abFunc.Show();
        }

        private void adicionarNovaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abnCategoria = new frmCategoria();
            abnCategoria.Show();
        }

        private void manutençãoDosEquipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abmEquipa = new frmEquipamentos();
            abmEquipa.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abinfoCadastro = new frmInfoCadastrais();
            abinfoCadastro.Show();
        }
    }
}
