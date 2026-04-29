using System;
using System.Windows.Forms;
using System.Globalization;

namespace BasicCalculator
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
            // Attach key press handlers to allow only numeric input
            this.txtV1.KeyPress += txtNumber_KeyPress;
            this.txtV2.KeyPress += txtNumber_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdMás_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a + b;
                lblResultadoFinal.Text = r.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void cmdMenos_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a - b;
                lblResultadoFinal.Text = r.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void cmdMultiplicar_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double r = a * b;
                lblResultadoFinal.Text = r.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void cmdDividir_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                if (b == 0)
                {
                    // Division by zero
                    lblResultadoFinal.Text = "Error: División por 0";
                    MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double r = a / b;
                    lblResultadoFinal.Text = r.ToString(CultureInfo.CurrentCulture);
                }
            }
        }

        private void txtV1_TextChanged(object sender, EventArgs e)
        {
            // Optional: clear result when inputs change
            lblResultadoFinal.Text = "XX";
        }

        private void txtV2_TextChanged(object sender, EventArgs e)
        {
            // Optional: clear result when inputs change
            lblResultadoFinal.Text = "XX";
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys
            if (char.IsControl(e.KeyChar))
                return;

            TextBox tb = sender as TextBox;
            string decimalSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow one decimal separator (either '.' or ',')
            if ((e.KeyChar == '.' || e.KeyChar == ',') && !tb.Text.Contains(decimalSep) && !tb.Text.Contains(".") && !tb.Text.Contains(","))
            {
                // If current culture uses ',' but user typed '.', we allow it and keep as entered; parsing will handle it.
                return;
            }

            // Allow minus sign only at the start and only once
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains("-"))
                return;

            // Otherwise, block input
            e.Handled = true;
        }

        private bool TryGetInputs(out double v1, out double v2)
        {
            v1 = 0;
            v2 = 0;

            string s1 = txtV1.Text.Trim();
            string s2 = txtV2.Text.Trim();

            if (string.IsNullOrEmpty(s1))
            {
                MessageBox.Show("Ingrese el Valor 1.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtV1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(s2))
            {
                MessageBox.Show("Ingrese el Valor 2.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtV2.Focus();
                return false;
            }

            // Try parsing with current culture then invariant
            if (!double.TryParse(s1, NumberStyles.Float, CultureInfo.CurrentCulture, out v1) &&
                !double.TryParse(s1, NumberStyles.Float, CultureInfo.InvariantCulture, out v1))
            {
                MessageBox.Show("Valor 1 debe ser un número.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtV1.Focus();
                return false;
            }

            if (!double.TryParse(s2, NumberStyles.Float, CultureInfo.CurrentCulture, out v2) &&
                !double.TryParse(s2, NumberStyles.Float, CultureInfo.InvariantCulture, out v2))
            {
                MessageBox.Show("Valor 2 debe ser un número.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtV2.Focus();
                return false;
            }

            return true;
        }
    }
}
