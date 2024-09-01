using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2___FInal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema sistema = new frmSistema();
            sistema.MdiParent = this;
            sistema.Show();
        }
    }
}
