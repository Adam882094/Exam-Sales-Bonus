using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_AdamBrennan_82094_
{
    public partial class frmMailOrder : Form
    {
        public frmMailOrder()
        {
            InitializeComponent();
        }

        private void rdoFrench_CheckedChanged(object sender, EventArgs e)
        {

            lblName.Text = "Nom de l'employé";
            lblId.Text = "ID de l'employé";
            lblTotalHours.Text = "Total des heures travaillées";
            lblTotalMonthly.Text = "Ventes mensuelles totales";
            lblTotalBonus.Text = "Bonus de vente";
        }

        private void rdoEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = "Employee Name";
            lblId.Text = "Employee ID";
            lblTotalHours.Text = "Total Hours Worked";
            lblTotalMonthly.Text = "Total Monthly Sales";
            lblTotalBonus.Text = "Sales Bonus";
        }

        private void rdoSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = "Nombre de empleado";
            lblId.Text = "ID de empleado";
            lblTotalHours.Text = "Horas totales trabajadas";
            lblTotalMonthly.Text = "Ventas mensuales";
            lblTotalBonus.Text = "Bono de ventas";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form is being sent to the Printer!");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string val = vali.totalHourscheck(txtHoursWorked.Text);
            if (val == "0")
            {
                MessageBox.Show("Total Hours Worked must be between 0 and 160");
            }
            else
            {


                string negative = vali.neg(txtTotalMonthly.Text);
                if (negative == "1")
                {
                    MessageBox.Show("Monthly Sales can't be lower than 0 and must have a value");
                }
                else
                {


                    string name = vali.name(txtName.Text);
                    if (name == "1")
                    {
                        MessageBox.Show("Enter a name");
                    }
                    else
                    {
                        string userid = vali.user(txtId.Text);
                        if (userid == "1")
                        {
                            MessageBox.Show("Enter Employee ID");
                        }
                        else
                        {



                            double totalHours = double.Parse(txtHoursWorked.Text);
                            totalHours = totalHours / 160;
                            double totalMonthly = double.Parse(txtTotalMonthly.Text);
                            totalMonthly = totalMonthly * 0.02;
                            double salesBonus = totalHours * totalMonthly;
                            txtSalesBonus.Text = salesBonus.ToString();
                        }
                    }
                }
            }
        }
    }
}
