using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosWindowsForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contenedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabControl frmTabControl = new frmTabControl();
            frmTabControl.ShowDialog();
        }

        private void cálculoInterésCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInteres frmInteres = new frmInteres();
            frmInteres.ShowDialog();
        }
    }
}
