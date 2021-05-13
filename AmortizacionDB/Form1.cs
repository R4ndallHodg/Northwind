using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmortizacionDB.Models;

namespace AmortizacionDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAmortizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            using (var db = new NorthwindEntities())
            {
                 db.TablaAmortizacion(10000000, 12, 2);
                dgvAmortizacion.DataSource = db.Prestamo.ToList();
            }
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                string[] empty = { };
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE Prestamo");
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
