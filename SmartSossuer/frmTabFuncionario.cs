﻿using System;
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
    public partial class frmTabFuncionario : Form
    {
        public frmTabFuncionario()
        {
            InitializeComponent();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSairTabFun_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
