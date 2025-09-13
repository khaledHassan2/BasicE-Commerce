using BasicE_Commerce.Application.IServices.IIdentityServices;
using BasicE_Commerce.Application.Services.IdentityServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.UserDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using Helpers;

namespace BasicE_Commerce.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly IAcountService _acountService;

        public LoginForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            _acountService = new AcountService(new UnitOfWork(dbContext), new UserRepository(dbContext));

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var userInput = new LoginUserDTO
            {
                Email = LoginEmailInput.Text,
                Password = LoginPasswordInput.Text
            };
            var flag = _acountService.Login(userInput);
            if (flag == true)
            {
                if (UserCookies.CurrentRole == "admin")
                {
                    AdminMainForm adminMainForm = new AdminMainForm();
                    adminMainForm.Show();
                    this.Close();
                }
                else if (UserCookies.CurrentRole == "user")
                {
                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show();
                    this.Close();
                }
            }

        }
    }
}
