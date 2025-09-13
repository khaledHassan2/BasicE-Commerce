using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation
{
    public partial class UserMainForm : Form
    {
        private readonly IUserCategoryService _categoryService;
        private readonly List<UserCategoryDTO> _categories;
        private int _CategoryIdSelected = 1;

        private readonly IUserProductService _ProductService;
        private readonly List<UserProductDTO> _Products;

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

            var ProductService = new ProductRepository(dbContext);
            _ProductService = new UserProductService(unitOfWork, ProductService);


        }

        private void CategoriesOptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CategoryIdSelected = (int)CategoriesOptionsList.SelectedValue;
        }

        private void SearchCategoryBtn_Click(object sender, EventArgs e)
        {
            _Products = _categoryService.GetAll().ToList();
        }
    }
}
