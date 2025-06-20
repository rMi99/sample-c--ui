using System.Diagnostics.Eventing.Reader;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (username != "123" || password != "123")
            {
                MessageBox.Show("Password is incorrect", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //MessageBox.Show("Sucess", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();

                this.Hide(); // Hide the current form
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //viva ask diffrent of both??
                Application.Exit(); //close all the form
                this.Close(); // Close the current form
                this.Hide(); // Hide the current form, but it will still be in memory

            }
            else
            {
                MessageBox.Show("You clicked No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide(); // Hide the current form
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
