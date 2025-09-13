using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Presentation.UserForms;

namespace BasicE_Commerce.Presentation
{
    public partial class UserMainForm : Form
    {
        private readonly IUserCategoryService _categoryService;
        private readonly List<UserCategoryDTO>? _categories;
        private int _CategoryIdSelected = 1;

        

        public UserMainForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var CategoryRepsoity = new CategoryRepository(dbContext);

            _categoryService = new UserCategoryService(unitOfWork, CategoryRepsoity);
            _categories = _categoryService.GetAll().ToList();
            CategoriesOptionsList.DataSource = _categories;

            CategoriesOptionsList.DisplayMember = "Name";
            CategoriesOptionsList.ValueMember = "Id";

            

        }

        private void CategoriesOptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesOptionsList.SelectedValue != null && CategoriesOptionsList.SelectedValue is int)
            {
                _CategoryIdSelected = (int)CategoriesOptionsList.SelectedValue;
            }

            //_CategoryIdSelected = (int)CategoriesOptionsList.SelectedValue;
        }

        private void SearchCategoryBtn_Click(object sender, EventArgs e)
        {
            CategoryProductForm categoryProductForm = new CategoryProductForm(_CategoryIdSelected); 
            categoryProductForm.ShowDialog();
            this.Close();
        }
    }
}
