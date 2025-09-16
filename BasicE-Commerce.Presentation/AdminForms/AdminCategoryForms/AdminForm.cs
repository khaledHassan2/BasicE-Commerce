using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Models;
using BasicE_Commerce.Presentation.AdminForms.AdminCategoryForms;
using BasicE_Commerce.Presentation.AdminForms.AdminOrderForms;
using BasicE_Commerce.Presentation.AdminForms.AdminProductForms;
using Helpers;

namespace BasicE_Commerce.Presentation.AdminForms
{
    public partial class AdminForm : Form
    {
        private IAdminCategoryService _CategoryService;
        private List<AdminCategoryDTO>? _CategoryList;
        private IAdminProductService _ProductService;
        private List<AdminProductDTO>? _ProductList;
        public AdminForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var categoryRepsoity = new CategoryRepository(dbContext);
            _CategoryService = new AdminCategoryService(unitOfWork, categoryRepsoity);

            var productRepsoity = new ProductRepository(dbContext);
            _ProductService = new AdminProductService(unitOfWork, productRepsoity);
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

        private void LoadProductsBtn_Click(object sender, EventArgs e)
        {
            _ProductList = _ProductService.GetAll().ToList();
            CategoryListGrid.DataSource = _ProductList;
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.ShowDialog();
        }

        private void CategoryListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mangmentOrderbtn_Click(object sender, EventArgs e)
        {
            AdminOrderForm adminOrderForm = new AdminOrderForm();
            adminOrderForm.Show();
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Text=UserCookies.CurrentUserName + " - Admin Panel";
        }
    }
}
