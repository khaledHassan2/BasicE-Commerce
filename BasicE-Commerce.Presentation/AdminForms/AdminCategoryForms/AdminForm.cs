using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Application.Services.IdentityServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Presentation.AdminForms.AdminCategoryForms;
using BasicE_Commerce.Presentation.AdminForms.AdminOrderForms;
using BasicE_Commerce.Presentation.AdminForms.AdminProductForms;
using Helpers;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation.AdminForms
{
    public partial class AdminForm : Form
    {
        private IAdminCategoryService _CategoryService;
        private List<AdminCategoryDTO>? _CategoryList;
        private IAdminProductService _ProductService;
        private List<AdminProductDTO>? _ProductList;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        public AdminForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var categoryRepsoity = new CategoryRepository(dbContext);
            _CategoryService = new AdminCategoryService(unitOfWork, categoryRepsoity);

            var productRepsoity = new ProductRepository(dbContext);
            _ProductService = new AdminProductService(unitOfWork, productRepsoity);
            _bindingSource = new BindingSource();

            _unitOfWork = unitOfWork;
            _userRepository=new UserRepository(dbContext);
        }
        BindingSource _bindingSource;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            CategoryListGrid.AllowUserToAddRows = false;

            this.Text = UserCookies.CurrentUserName + " - Admin Panel";
            //delet
            CategoryListGrid.UserDeletingRow += (sender, e) =>
            {
                if (e.Row.DataBoundItem is AdminCategoryDTO DeCategory)
                {

                    _CategoryService.Delete(DeCategory.Id);
                    // _CategoryList.RemoveAt(e.Row.Index);
                    //  _bindingSource.ResetBindings(false);
                }
                else
                {
                    e.Cancel = true; // Cancel the deletion
                }

            };

            CategoryListGrid.CellEndEdit += (sender, e) =>
            {
                if (CategoryListGrid.Rows[e.RowIndex].DataBoundItem is AdminCategoryDTO UpCategory)
                {
                    _CategoryService.Update(UpCategory);
                }
            };
        }
        private void LoadCategoriesBtn_Click(object sender, EventArgs e)
        {
            _CategoryList = _CategoryService.GetAll().ToList();
            _bindingSource.DataSource = _CategoryList;
            CategoryListGrid.DataSource = _bindingSource;
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
            CategoryListGrid.UserDeletingRow += (sender, e) =>
            {
                if (e.Row.DataBoundItem is AdminProductDTO DeProduct)
                {
                    _ProductService.Delete(DeProduct.Id);

                }
                else
                {
                    e.Cancel = true;
                }
            };

            CategoryListGrid.CellEndEdit += (sender, e) =>
            {
                if (CategoryListGrid.Rows[e.RowIndex].DataBoundItem is AdminProductDTO UpProduct)
                {
                    _ProductService.Update(UpProduct);
                }
            };
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

        private void button1_Click(object sender, EventArgs e)
        {
            AcountService  acountService = new AcountService(_unitOfWork, _userRepository);
            acountService.Logout();
            this.Close();

        }



    }
}
