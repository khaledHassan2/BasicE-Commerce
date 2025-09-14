using BasicE_Commerce.DTOs.mapping;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MapsterConfig.BasicECommerceMapsterConfiguration();

           
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
            //this.Hide();
        }
    }
}
