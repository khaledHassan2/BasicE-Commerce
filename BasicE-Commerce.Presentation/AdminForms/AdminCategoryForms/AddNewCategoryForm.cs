using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
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

namespace BasicE_Commerce.Presentation.AdminForms.AdminCategoryForms
{
    public partial class AddNewCategoryForm : Form
    {
        private IAdminCategoryService _CategoryService;

        public AddNewCategoryForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var categoryRepsoity = new CategoryRepository(dbContext);
            _CategoryService = new AdminCategoryService(unitOfWork, categoryRepsoity);
        }

        private void SaveNewCategoryBtn_Click(object sender, EventArgs e)
        {
            var newCategory = new CategoryCreatedDTO
            {
                Name = CategoryNameinput.Text,
                Description = CategoryDescriptionInput.Text
            };

            if (newCategory.Name.Length>3) {
            _CategoryService.Create(newCategory);
            this.Close();
            }
            else
            {
                MessageBox.Show("Name Must By More Than 3 Char");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
