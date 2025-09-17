using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.IdentityServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.DTOs.OrderItemDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Presentation.UserForms;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation
{
    public partial class UserMainForm : Form
    {
        private readonly IUserCategoryService _categoryService;
        private readonly IUserProductService _productService;
        private List<UserProductDTO>? _Products = new List<UserProductDTO>();
        private readonly IUserOrderService _orderService;
        private readonly IUserOrderItemService _orderItemService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        public UserMainForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var categoryRepository = new CategoryRepository(dbContext);
            var productRepository = new ProductRepository(dbContext);
            var orderRepository = new OrderRepository(dbContext);
            var orderItemRepository = new OrderItemRepository(dbContext);

            _categoryService = new UserCategoryService(unitOfWork, categoryRepository);
            _productService = new UserProductService(unitOfWork, productRepository);
            _orderService = new UserOrderService(unitOfWork, orderRepository);
            _orderItemService = new UserOrderItemService(unitOfWork, orderItemRepository);
            _unitOfWork = new UnitOfWork(dbContext);
            _userRepository= new UserRepository(dbContext);
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome {UserCookies.CurrentUserName}";
            checkoutbtn.Visible = false;
            LoadCategories();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = false;
            headerLabel.Text = "Categories";
            LoadCategories();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = false;
            headerLabel.Text = "Products";
            LoadProducts();
        }

        private void LoadCategories()
        {
            checkoutbtn.Visible = false;
            mainPanel.Controls.Clear();
            var categories = _categoryService.GetAll().ToList();

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;

            foreach (var category in categories)
            {
                Panel card = new Panel();
                card.Size = new Size(200, 60);
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.BackColor = Color.White;

                Label lbl = new Label();
                lbl.Text = category.Name;
                lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                card.Cursor = Cursors.Hand;
                card.Click += (s, e) =>
                {
                    headerLabel.Text = $"{category.Name} Products";
                    LoadProductsByCategory(category.Id);
                };

                lbl.Click += (s, e) =>
                {
                    headerLabel.Text = $"{category.Name} Products";
                    LoadProductsByCategory(category.Id);
                };

                card.Controls.Add(lbl);
                flow.Controls.Add(card);
            }

            mainPanel.Controls.Add(flow);
        }

        private void LoadProductsByCategory(int categoryId)
        {
            checkoutbtn.Visible = false;
            mainPanel.Controls.Clear();


            Panel container = new Panel();
            container.Dock = DockStyle.Fill;
            container.AutoScroll = true;


            Button btnBack = new Button();
            btnBack.Text = "← Back to Categories";
            btnBack.Height = 40;
            btnBack.Dock = DockStyle.Top;
            btnBack.BackColor = Color.LightGray;
            btnBack.Click += (s, e) =>
            {
                headerLabel.Text = "Categories";
                LoadCategories();
            };


            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;

            var products = _productService.GetAll()
                .Where(p => p.CategoryId == categoryId)
                .ToList();

            foreach (var product in products)
            {
                var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                var card = CreateProductCard(product.Id, saveDirectory, product.Name, product.Description, product.Price);
                flow.Controls.Add(card);
            }


            container.Controls.Add(flow);
            container.Controls.Add(btnBack);


            mainPanel.Controls.Add(container);
        }

        private void LoadProducts()
        {
            checkoutbtn.Visible = false;
            mainPanel.Controls.Clear();
            var products = _productService.GetAll().ToList();

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;

            foreach (var product in products)
            {
                var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                var card = CreateProductCard(product.Id, saveDirectory, product.Name, product.Description, product.Price);

                flow.Controls.Add(card);
            }

            mainPanel.Controls.Add(flow);
        }

        private Panel CreateProductCard(int id, string imagePath, string name, string description, decimal price)
        {
            Panel _container = new Panel();
            _container.Dock = DockStyle.Fill;
            _container.AutoScroll = true;

            Button btnBack = new Button();
            btnBack.Text = "← Back to Categories";
            btnBack.Height = 40;
            btnBack.Dock = DockStyle.Top;
            btnBack.BackColor = Color.LightGray;
            btnBack.Click += (s, e) =>
            {
                //headerLabel.Text = "Categories";
                //LoadCategories();
            };
            Panel card = new Panel();
            card.Size = new Size(200, 300);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);


            PictureBox picture = new PictureBox();
            picture.Size = new Size(200, 150);
            if (File.Exists(imagePath))
                picture.Image = Image.FromFile(imagePath);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Dock = DockStyle.Top;


            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Dock = DockStyle.Top;
            lblName.Height = 30;


            Label lblDesc = new Label();
            lblDesc.Text = description;
            lblDesc.Font = new Font("Arial", 9, FontStyle.Regular);
            lblDesc.TextAlign = ContentAlignment.TopCenter;
            lblDesc.Dock = DockStyle.Top;
            lblDesc.Height = 50;


            Label lblPrice = new Label();
            lblPrice.Text = price.ToString("C");
            lblPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Dock = DockStyle.Bottom;
            lblPrice.Height = 30;


            Button btnBuy = new Button();
            btnBuy.Text = "Buy Now";
            btnBuy.Dock = DockStyle.Bottom;
            btnBuy.Height = 35;
            btnBuy.BackColor = Color.LightBlue;
            btnBuy.Click += (s, e) =>
            {
                var item = new HCarteItem()
                {
                    ProductId = id
                };
                LocalCart.carteItems.Add(item);
                MessageBox.Show($"Added {name} to Cart");
            };


            card.Controls.Add(btnBuy);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblName);
            card.Controls.Add(picture);
            _container.Controls.Add(btnBack);


            return card;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = true;
            headerLabel.Text = "My Cart";
            mainPanel.Controls.Clear();

            FlowLayoutPanel flowCart = new FlowLayoutPanel();
            flowCart.Dock = DockStyle.Fill;
            flowCart.AutoScroll = true;

            foreach (var item in LocalCart.carteItems)
            {
                var product = _productService.GetItemById(item.ProductId);

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

                var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                if (File.Exists(saveDirectory))
                    pic.Image = Image.FromFile(saveDirectory);
                else
                    pic.BackColor = Color.LightGray;

                // اسم المنتج
                Label lblName = new Label();
                lblName.Text = product.Name;
                lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblName.Location = new Point(100, 10);
                lblName.AutoSize = true;

                // السعر
                Label lblPrice = new Label();
                lblPrice.Text = $"Price: {product.Price}";
                lblPrice.Location = new Point(100, 40);
                lblPrice.AutoSize = true;

                // الكمية
                Label lblQty = new Label();
                lblQty.Text = $"Qty: {item.Quantity}";
                lblQty.Location = new Point(100, 65);
                lblQty.AutoSize = true;

                // الإجمالي
                Label lblTotal = new Label();
                lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                lblTotal.Location = new Point(100, 90);
                lblTotal.AutoSize = true;

                // زر زيادة
                Button btnIncrease = new Button();
                btnIncrease.Text = "+";
                btnIncrease.Width = 30;
                btnIncrease.Height = 25;
                btnIncrease.Location = new Point(220, 85);
                btnIncrease.Click += (s2, e2) =>
                {
                    item.Quantity++;
                    lblQty.Text = $"Qty: {item.Quantity}";
                    lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                };

                // زر نقصان
                Button btnDecrease = new Button();
                btnDecrease.Text = "-";
                btnDecrease.Width = 30;
                btnDecrease.Height = 25;
                btnDecrease.Location = new Point(260, 85);
                btnDecrease.Click += (s2, e2) =>
                {
                    if (item.Quantity > 1)
                    {
                        item.Quantity--;
                        lblQty.Text = $"Qty: {item.Quantity}";
                        lblTotal.Text = $"Total: {product.Price * item.Quantity}";
                    }
                };

                // أضف العناصر للكارت
                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblQty);
                card.Controls.Add(lblTotal);
                card.Controls.Add(btnIncrease);
                card.Controls.Add(btnDecrease);

                // أضف الكارت للـ FlowLayoutPanel
                flowCart.Controls.Add(card);
            }

            mainPanel.Controls.Add(flowCart);
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            OrderCreatedDTO orderDTO = new OrderCreatedDTO()
            {
                UserId = UserCookies.CurrentUserId
            };
            int OrderID = _orderService.CreateOrder(orderDTO);

            foreach (var item in LocalCart.carteItems)
            {
                OrderItemCreatedDTO itemDTO = new OrderItemCreatedDTO()
                {
                    Quantity = item.Quantity,
                    OrderId = OrderID,
                    ProductId = item.ProductId

                };

                _orderItemService.CreateOrderItem(itemDTO);
            }
            MessageBox.Show("Order Placed Successfully!");
            LocalCart.carteItems.Clear();
            mainPanel.Controls.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = false;
            headerLabel.Text = "My Orders";
            mainPanel.Controls.Clear();

            var orders = _orderService.getOrdersByUserId(UserCookies.CurrentUserId);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;

            foreach (var order in orders)
            {
                Panel card = new Panel();
                card.Size = new Size(180, 200);
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.BackColor = Color.White;

                // Order ID
                Label lblOrder = new Label();
                lblOrder.Text = $"Order";
                lblOrder.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblOrder.Dock = DockStyle.Top;
                lblOrder.Height = 30;
                lblOrder.TextAlign = ContentAlignment.MiddleCenter;

                // Date
                Label lblDate = new Label();
                lblDate.Text = $"Date: {order.OrderDate.ToShortDateString()}";
                lblDate.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblDate.Dock = DockStyle.Top;
                lblDate.Height = 30;
                lblDate.TextAlign = ContentAlignment.MiddleLeft;

                // Status
                Label lblStatus = new Label();
                lblStatus.Text = $"Status: {order.Status}";
                lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblStatus.Dock = DockStyle.Top;
                lblStatus.Height = 30;
                lblStatus.TextAlign = ContentAlignment.MiddleLeft;

                //Details
                Button btnDetails = new Button();
                btnDetails.Text = "Details";
                btnDetails.Dock = DockStyle.Bottom;
                btnDetails.Height = 35;
                btnDetails.BackColor = Color.LightGreen;


                btnDetails.Click += (s, ev) =>
                {
                    ShowOrderDetails(order.Id);
                };

                //delete order
                Button btnDelete = new Button();
                btnDelete.Text = "Delete";
                btnDelete.Dock = DockStyle.Bottom;
                btnDelete.Height = 35;
                btnDelete.BackColor = Color.Red;
                btnDelete.ForeColor = Color.White;
                btnDelete.Enabled = (order.Status == "Pending");
                btnDelete.Visible = (order.Status == "Pending");

                btnDelete.Click += (s, ev) =>
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this order?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        _orderService.DeleteOrder(order.Id);   // استدعاء السيرفيس
                        MessageBox.Show("Order Deleted Successfully!");
                        btnOrder_Click(null, null); 
                    }
                };


                card.Controls.Add(btnDetails);
                card.Controls.Add(btnDelete);
                card.Controls.Add(lblStatus);
                card.Controls.Add(lblDate);
                card.Controls.Add(lblOrder);
                flow.Controls.Add(card);
            }


            mainPanel.Controls.Add(flow);
        }
        private void ShowOrderDetails(int orderId)
        {

            UserOrderDetailsForm userOrderDetails = new UserOrderDetailsForm(orderId);
            userOrderDetails.Show();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            AcountService acountService = new AcountService(_unitOfWork, _userRepository);
            
            acountService.Logout();
            this.Close();   
        }
    }
}
