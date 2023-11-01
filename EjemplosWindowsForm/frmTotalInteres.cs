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
    public partial class frmTotalInteres : Form
    {
        public delegate void pasarInteres(string intereses);
        public event pasarInteres InteresCompuesto;
        public frmTotalInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            InteresCompuesto(CalcularIntereses());
            Close();
        }
        private string CalcularIntereses()
        {
            // Declaración de variables
            double capital, razon, plazos;
            double interes, monto;

            capital = double.Parse(this.txtCapital.Text);
            razon = double.Parse(txtRazon.Text);
            plazos = double.Parse(txtPlazos.Text);

            monto = Math.Pow ((1 + razon), plazos) * capital;
            interes = monto - capital;

            return Convert.ToString(interes);
        }
    }
}
