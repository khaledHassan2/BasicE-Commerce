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
            flowCart.Controls.Clear();
            foreach (var item in LocalCart.carteItems)
            {
                var product = _ProductService.GetItemById(item.ProductId);

                // panel يمثل الكارت
                Panel card = new Panel();
                card.Width = 300;
                card.Height = 150;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(10);

                // صورة المنتج
                PictureBox pic = new PictureBox();
                pic.Width = 80;
                pic.Height = 80;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Location = new Point(10, 10);
                if (!string.IsNullOrEmpty(product.Image) && File.Exists(product.Image))
                {
                    pic.Image = Image.FromFile(product.Image);
                }
                else
                {
                    pic.BackColor = Color.LightGray; // لو مفيش صورة
                }

                // اسم المنتج
                Label lblName = new Label();
                lblName.Text = product.Name;
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.Location = new Point(100, 10);
                lblName.AutoSize = true;

                // الوصف
                Label lblDesc = new Label();
                lblDesc.Text = product.Description;
                lblDesc.Location = new Point(100, 40);
                lblDesc.AutoSize = true;

                // السعر
                Label lblPrice = new Label();
                lblPrice.Text = $"Price: {product.Price}";
                lblPrice.Location = new Point(100, 65);
                lblPrice.AutoSize = true;

                // الكمية
                Label lblQty = new Label();
                lblQty.Text = $"Qty: {item.Quantity}";
                lblQty.Location = new Point(100, 90);
                lblQty.AutoSize = true;

                // الإجمالي
                Label lblTotal = new Label();
                lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                lblTotal.Location = new Point(100, 115);
                lblTotal.AutoSize = true;

                // زرار زيادة الكمية
                Button btnIncrease = new Button();
                btnIncrease.Text = "+";
                btnIncrease.Width = 30;
                btnIncrease.Height = 25;
                btnIncrease.Location = new Point(220, 85);
                btnIncrease.Click += (s, e) =>
                {
                    item.Quantity++;
                    lblQty.Text = $"Qty: {item.Quantity}";
                    lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                };

                // زرار تقليل الكمية
                Button btnDecrease = new Button();
                btnDecrease.Text = "-";
                btnDecrease.Width = 30;
                btnDecrease.Height = 25;
                btnDecrease.Location = new Point(260, 85);
                btnDecrease.Click += (s, e) =>
                {
                    if (item.Quantity > 1)
                    {
                        item.Quantity--;
                        lblQty.Text = $"Qty: {item.Quantity}";
                        lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                    }
                };

                // أضف العناصر للـPanel
                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblDesc);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblQty);
                card.Controls.Add(lblTotal);
                card.Controls.Add(btnIncrease);
                card.Controls.Add(btnDecrease);

                // أضف الكارت للـFlowLayoutPanel
                flowCart.Controls.Add(card);
            }
        }
    }
}
