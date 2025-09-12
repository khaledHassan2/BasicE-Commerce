using BasicE_Commerce.Application.IServices.IIdentityServices;
using BasicE_Commerce.Application.Services.IdentityServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.UserDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;

namespace BasicE_Commerce.Presentation
{
    public partial class RegisterForm : Form
    {
        private readonly IAcountService _acountService;
        public RegisterForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            _acountService = new AcountService(new UnitOfWork(dbContext),new UserRepository(dbContext));
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            UserCreatedDTO userCreatedDTO = new UserCreatedDTO
            {
                Name = RegisterNameInput.Text,
                Email = RegisterEmailInput.Text,
                Password = RegisterPasswordInput.Text,
            };
            _acountService.Regitser(userCreatedDTO);
        }
    }
}
