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
    public partial class frmMenuSS : Form
    {
        public frmMenuSS()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabClie = new frmTabCliente();
            tabClie.Show();
        }

        private void tsmRegistro_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abFunc = new frmFuncionario();
            abFunc.Show();
        }

        private void adicionarNovaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCategoria = new frmCategoria();
            addCategoria.Show();
        }

        private void manutençãoDosEquipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addEquipa = new frmEquipamentos();
            addEquipa.Show();
        }

        private void novidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNovidades = new frmNovidade();
            addNovidades.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addUnidades = new frmUnidade();
            addUnidades.Show();
        }

    
        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabFuncio = new frmTabFuncionario();
            tabFuncio.Show();
        }

        private void novidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabNovidades = new frmTabNovidade();
            tabNovidades.Show();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tabUnidades = new frmTabUnidade();
            tabUnidades.Show();
        }
    }
}
