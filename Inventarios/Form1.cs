using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restauracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vtasticket frm = new frm_vtasticket();
            frm.ShowDialog();
         
        }

        private void elaboracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_compras frm = new frm_compras ();
            frm.ShowDialog();
        }

        private void elaboraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cotizaciones frm = new frm_cotizaciones();
            frm.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ventas frm = new frm_ventas();
            frm.ShowDialog();
        }
    }
}
