using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Models;
using BasicE_Commerce.Presentation.AdminForms.AdminCategoryForms;

namespace BasicE_Commerce.Presentation.AdminForms
{
    public partial class AdminCategoriesForm : Form
    {
        private IAdminCategoryService _CategoryService;
        private List<AdminCategoryDTO>? _CategoryList;
        public AdminCategoriesForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var categoryRepsoity = new CategoryRepository(dbContext);
            _CategoryService = new AdminCategoryService(unitOfWork, categoryRepsoity);
        }

        private void LoadCategoriesBtn_Click(object sender, EventArgs e)
        {
            _CategoryList = _CategoryService.GetAll().ToList();
            CategoryListGrid.DataSource = _CategoryList;
        }

        private void AddNewCategoryBtn_Click(object sender, EventArgs e)
        {
            AddNewCategoryForm addNewCategoryForm = new AddNewCategoryForm();
            addNewCategoryForm.ShowDialog();
        }
    }
}
