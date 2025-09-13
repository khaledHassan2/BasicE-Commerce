using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
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

namespace BasicE_Commerce.Presentation.AdminForms.AdminProductForms
{
    public partial class AddNewProductForm : Form
    {
        private readonly IAdminCategoryService _categoryService;
        private readonly List<AdminCategoryDTO> _categories;
        public AddNewProductForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var CategoryRepsoity = new CategoryRepository(dbContext);

            _categoryService = new AdminCategoryService(unitOfWork, CategoryRepsoity);
            _categories = _categoryService.GetAll().ToList();

            CategoryOptionsList.DataSource = _categories;
            CategoryOptionsList.DisplayMember = "Name";
            CategoryOptionsList.ValueMember = "Id";
        }

        private void ProductUploadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "choise image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProductImageBox.Image = Image.FromFile(openFileDialog.FileName);
                ProductImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // يخلي الصورة تتظبط مع حجم البوكس
            }
        }

        private void CategoryOptionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  CategoryOptionsList.DataSource = categories;

        }

        private void SaveNewProductBtn_Click(object sender, EventArgs e)
        {
            var entityCreated = new ProductCreatedDTO
            {
                Name = ProductNameinput.Text,
                Description = ProductDescriptionInput.Text,
                Price = ProductPriceInput.Value,
                Stock = (int)ProductStockInput.Value,
                CategoryId = (int)CategoryOptionsList.SelectedItem,
                Image = FileOperation.UploadFile(ProductImageBox.Image, "ProductImages")
            };
        }
    }
}
