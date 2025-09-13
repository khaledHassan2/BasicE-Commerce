using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation.UserForms
{
    public partial class CategoryProductForm : Form
    {
        private readonly IUserProductService _ProductService;
        private List<UserProductDTO>? _Products;

        public CategoryProductForm(int CategoryId)
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var productRepository = new ProductRepository(dbContext);
            _ProductService = new UserProductService(unitOfWork, productRepository);

            // جلب المنتجات
            _Products = _ProductService.GetProductsByCategory(CategoryId).ToList();

            // عرض كل منتج في Card داخل FlowLayoutPanel
            foreach (var product in _Products)
            {
                var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                var panel = CreateCard(saveDirectory, product.Name, product.Description, product.Price);

                flowLayoutPanel1.Controls.Add(panel); // ✅ الكروت تضاف هنا
            }
        }

        private Panel CreateCard(string imagePath, string name, string description, decimal price)
        {
            // الكارد نفسه
            Panel card = new Panel();
            card.Size = new Size(200, 300);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10); // مسافة بين الكروت

            // الصورة
            PictureBox picture = new PictureBox();
            picture.Size = new Size(200, 150);
            picture.Image = Image.FromFile(imagePath);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Dock = DockStyle.Top;

            // الاسم
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Dock = DockStyle.Top;
            lblName.Height = 30;

            // الوصف
            Label lblDesc = new Label();
            lblDesc.Text = description;
            lblDesc.Font = new Font("Arial", 9, FontStyle.Regular);
            lblDesc.TextAlign = ContentAlignment.TopCenter;
            lblDesc.Dock = DockStyle.Top;
            lblDesc.Height = 50;

            // السعر
            Label lblPrice = new Label();
            lblPrice.Text = price.ToString("C"); // يظهر كعملة $
            lblPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Dock = DockStyle.Bottom;
            lblPrice.Height = 30;

            // زرار شراء
            Button btnBuy = new Button();
            btnBuy.Text = "Buy Now";
            btnBuy.Dock = DockStyle.Bottom;
            btnBuy.Height = 35;
            btnBuy.BackColor = Color.LightBlue;
            btnBuy.Click += (s, e) =>
            {
                MessageBox.Show($"add {name} to Cart");
            };

            // ترتيب العناصر داخل الكارد
            card.Controls.Add(btnBuy);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblName);
            card.Controls.Add(picture);

            return card;
        }
    }
}
