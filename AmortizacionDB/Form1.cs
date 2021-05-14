using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmortizacionDB.Models;

namespace AmortizacionDB
{
    public partial class frmAmortizacion : Form
    {
        static Regex validate_emailaddress = email_validation();
        public frmAmortizacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Prestamo");
            }
            btnRefresh.Enabled = false;
        }


        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void btnAmortizacion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTasa.Text) || String.IsNullOrWhiteSpace(txtPlazo.Text) || String.IsNullOrWhiteSpace(txtCredito.Text) || String.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Porfavor rellene todos los campos del formulario");
                return;

            }
            else
            {
                if (!validate_emailaddress.IsMatch(txtCorreo.Text))
                {
                    MessageBox.Show("Direccion de correco no valida!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCorreo.Focus();
                    return;
                }
                else
                {
                    if (txtPlazo.Text == "0" || txtCredito.Text == "0" || txtTasa.Text == "0")
                    {
                        MessageBox.Show("No puede haber campos que valgan 0");
                        return;
                    }
                }
            }

            try
            {
                using (var db = new NorthwindEntities())
                {
                    db.TablaAmortizacion(decimal.Parse(txtCredito.Text), int.Parse(txtPlazo.Text), decimal.Parse(txtTasa.Text), decimal.Parse(txtIncremento.Text));
                    dgvAmortizacion.DataSource = db.Prestamo.ToList();
                    db.EnviarCorreo(txtCorreo.Text);
                    db.Database.ExecuteSqlCommand("TRUNCATE TABLE Prestamo");
                    db.SaveChangesAsync();
                }
            }
            catch (ArithmeticException ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtCorreo.Clear();
            txtCredito.Clear();
            txtIncremento.Clear();
            txtPlazo.Clear();
            txtTasa.Clear();
            btnRefresh.Enabled = true;
        }

        
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                dgvAmortizacion.DataSource = db.Prestamo.ToList();
                
            }
        }

        private void txtIncremento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
