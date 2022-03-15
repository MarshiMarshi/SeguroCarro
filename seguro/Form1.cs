using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seguro
{
    public partial class frmInsuranceCalc : Form
    {
        public frmInsuranceCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtAge.Text, out double parseAge))
                {
                    if (double.TryParse(txtVehicleValue.Text, out double parseVehicleValue))
                    {
                        if (rdoMale.Checked)
                        {
                            txtInsuranceValue.Text = Convert.ToDouble(txtAge.Text) < 24 ? (Convert.ToDouble(txtVehicleValue.Text) * 0.1).ToString() : (Convert.ToDouble(txtVehicleValue.Text) * 0.05).ToString();
                        }
                        else if (rdoFeminine.Checked)
                        {
                            txtInsuranceValue.Text = (Convert.ToDouble(txtVehicleValue.Text) * 0.2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Não há nenhum sexo escolhido!", "Sexo Indefinido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {                        
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                string message = null;

                if (!double.TryParse(txtAge.Text, out double parseAge))
                {
                    message = txtAge.Text == "" ? "O campo \"Idade\" está vazio" : $"\"{txtAge.Text}\" não é um número";
                }

                if (!double.TryParse(txtVehicleValue.Text, out double parseVehicleValue) && message == null)
                {
                     message = txtVehicleValue.Text == "" ? "O campo \"Valor do Automóvel\" está vazio" : $"\"{txtVehicleValue.Text}\" não é um número";
                }
                else if (!double.TryParse(txtVehicleValue.Text, out double parseVehicleValue2))
                {
                     message += txtVehicleValue.Text == "" ? " e o campo \"Valor do Automóvel\" está vazio" : $" e \"{txtVehicleValue.Text}\" não é um número";
                }

                MessageBox.Show($"{message}!", "Falta de número no campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtVehicleValue.Clear();
            txtInsuranceValue.Clear();
            rdoFeminine.Focus();
            txtName.Focus();
        }
    }
}
