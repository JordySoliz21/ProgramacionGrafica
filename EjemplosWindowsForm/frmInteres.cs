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
    public partial class frmInteres : Form
    {
        public frmInteres()
        {
            InitializeComponent();
        }

        private void txtTotalInteres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmTotalInteres frmInteres = new frmTotalInteres();
                frmInteres.InteresCompuesto += new frmTotalInteres.pasarInteres(Ejecutar);
                frmInteres.ShowDialog();
            }
        }

        private void Ejecutar(string intereses)
        {
            txtTotalInteres.Text = intereses;
        }
    }
}
