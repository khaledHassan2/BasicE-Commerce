using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using Helpers;

namespace BasicE_Commerce.Presentation.AdminForms.AdminProductForms
{
    public partial class AddNewProductForm : Form
    {
        private readonly IAdminCategoryService _categoryService;
        private readonly List<AdminCategoryDTO> _categories;
        private int _CategoryIdSelected = 1;

        private readonly IAdminProductService _productService;


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


            var productRepsoity = new ProductRepository(dbContext);
            _productService = new AdminProductService(unitOfWork, productRepsoity);


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
            _CategoryIdSelected = (int)CategoryOptionsList.SelectedValue;

        }

        private void SaveNewProductBtn_Click(object sender, EventArgs e)
        {
            var entityCreated = new ProductCreatedDTO
            {
                Name = ProductNameinput.Text,
                Description = ProductDescriptionInput.Text,
                Price = ProductPriceInput.Value,
                Stock = (int)ProductStockInput.Value,
                CategoryId = _CategoryIdSelected,
                Image = FileOperation.UploadImage(ProductImageBox.Image, "ProductImages")
            };
            if(entityCreated.Name.Length>3
                &&entityCreated.Image != null
                &&entityCreated.Price!=null
                &&entityCreated.CategoryId!=null
                &&entityCreated.Stock>=1)
            {
            _productService.Create(entityCreated);
            this.Close();
            }
            else
            {
                MessageBox.Show("data is in Valid");
            }

        }

        private void ProductImageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
