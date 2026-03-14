using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

  using System;
using System.Windows.Forms;

namespace StudentRegistrationApplication // Matching namespace
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            object value = InitializeComponent();
        }

        private object InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            // Populate Date of Birth ComboBoxes
            cmbDay.Items.Add("-Day-");
            cmbMonth.Items.Add("-Month-");
            cmbYear.Items.Add("-Year-");

            for (int i = 1; i <= 31; i++) cmbDay.Items.Add(i);
            for (int i = 1; i <= 12; i++) cmbMonth.Items.Add(i);
            for (int i = 1900; i <= DateTime.Now.Year; i++) cmbYear.Items.Add(i);

            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Validation Logic
            if (string.IsNullOrWhiteSpace(LastNametxt.Text) || string.IsNullOrWhiteSpace(FirstNametxt.Text))
            {
                MessageBox.Show("Please fill out the required name fields.", "Validation Error");
                return;
            }

            string gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Not Selected");
            string studentInfo = $"Name: {FirstNametxt.Text} {LastNametxt.Text} {MiddleNametxt.Text}\nGender: {gender}";

            MessageBox.Show(studentInfo, "Registration Successful");
        }
    }
