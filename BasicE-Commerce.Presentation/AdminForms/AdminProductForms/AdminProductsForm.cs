using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
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
    public partial class AdminProductsForm : Form
    {
        private IAdminProductService _ProductService;
        private List<AdminProductDTO>? _ProductList;
        public AdminProductsForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var productRepsoity = new ProductRepository(dbContext);
            _ProductService = new AdminProductService(unitOfWork, productRepsoity);


        }

        private void LoadProductsBtn_Click(object sender, EventArgs e)
        {
            _ProductList = _ProductService.GetAll().ToList();
            ProductListGrid.DataSource = _ProductList;
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.ShowDialog();
        }
    }
}
