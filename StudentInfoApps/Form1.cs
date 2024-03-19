using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApps
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            rbMale.Checked=true;
            BackColor = Color.AliceBlue;
            btnCount.AutoSize = true;

            comboCountry.Items.Add("Morocco");

            btnAdd.Enabled = false;
            comboCountry.SelectedIndex = 3;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbMale.Checked)
                gender = rbMale.Text;
            else
                gender = "Female";

            lstStudents.Items.Add($"Name {txtName.Text}, Gender: {gender}" +
                $"GPA: {nudGPA.Value}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Number of items\n {lstStudents.Items.Count}");
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 10)
                txtName.Enabled = false;
        }

        private void cbBusServices_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBusServices.Checked) 
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

            btnAdd.Enabled = cbBusServices.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_MouseHover(object sender, EventArgs e)
        {
            picLogo.Width = 250;
        }
    }
}
