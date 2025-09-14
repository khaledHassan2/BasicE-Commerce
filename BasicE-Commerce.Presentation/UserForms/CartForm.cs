using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using Helpers;

namespace BasicE_Commerce.Presentation.UserForms
{
    public partial class CartForm : Form
    {
        private readonly IUserProductService _ProductService;
        private List<UserProductDTO>? _Products = new List<UserProductDTO>();
        public CartForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var productRepository = new ProductRepository(dbContext);
            _ProductService = new UserProductService(unitOfWork, productRepository);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in LocalCart.carteItems)
            {
                listBoxCart.Items.Add($"{item.ProductId} - {item.Quantity}");
            }
        }
    }
}
