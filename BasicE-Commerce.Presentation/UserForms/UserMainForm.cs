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
using System.Drawing.Drawing2D;
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

        // Modern Colors
        private readonly Color PrimaryColor = Color.FromArgb(45, 126, 231);
        private readonly Color SecondaryColor = Color.FromArgb(108, 99, 255);
        private readonly Color AccentColor = Color.FromArgb(255, 107, 107);
        private readonly Color SuccessColor = Color.FromArgb(46, 204, 113);
        private readonly Color BackgroundColor = Color.FromArgb(248, 249, 250);
        private readonly Color CardColor = Color.White;
        private readonly Color TextPrimary = Color.FromArgb(33, 37, 41);
        private readonly Color TextSecondary = Color.FromArgb(108, 117, 125);

        public UserMainForm()
        {
            InitializeComponent();
            ApplyModernDesign();

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
            _userRepository = new UserRepository(dbContext);
        }

        private void ApplyModernDesign()
        {
            // Set form properties
            this.BackColor = BackgroundColor;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Create custom title bar if needed
            CreateModernTitleBar();
        }

        private void CreateModernTitleBar()
        {
            Panel titleBar = new Panel
            {
                Height = 50,
                Dock = DockStyle.Top,
                BackColor = PrimaryColor
            };

            Label titleLabel = new Label
            {
                Text = $"E-Commerce Store - Welcome {UserCookies.CurrentUserName}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(15, 12),
                AutoSize = true
            };

            // Close button
            Button closeBtn = new Button
            {
                Text = "✕",
                Size = new Size(40, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = AccentColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.Location = new Point(this.Width - 50, 10);
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.Click += (s, e) => {
                var result = MessageBox.Show("Do you want to close the application?", "Confirm Close",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                   System.Windows.Forms.Application.Exit();
            };

            // Minimize button
            Button minimizeBtn = new Button
            {
                Text = "−",
                Size = new Size(40, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(255, 193, 7),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.Location = new Point(this.Width - 95, 10);
            minimizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeBtn.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Maximize/Restore button
            Button maximizeBtn = new Button
            {
                Text = "□",
                Size = new Size(40, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = SuccessColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            maximizeBtn.FlatAppearance.BorderSize = 0;
            maximizeBtn.Location = new Point(this.Width - 140, 10);
            maximizeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeBtn.Click += (s, e) => {
                this.WindowState = this.WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal : FormWindowState.Maximized;
            };

            // Make title bar draggable
            titleBar.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    // تحريك النافذة
                    const int WM_NCLBUTTONDOWN = 0xA1;
                    const int HT_CAPTION = 0x2;
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };

            titleBar.Controls.AddRange(new Control[] { titleLabel, closeBtn, minimizeBtn, maximizeBtn });
            this.Controls.Add(titleBar);
        }

        // إضافة الدوال المطلوبة لتحريك النافذة
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome {UserCookies.CurrentUserName}";
            checkoutbtn.Visible = false;
            ApplyButtonStyles();
            LoadCategories();
        }

        private void ApplyButtonStyles()
        {
            // Style navigation buttons
            if (btnCategories != null)
                StyleButton(btnCategories, PrimaryColor);
            if (btnProducts != null)
                StyleButton(btnProducts, SecondaryColor);
            if (btnCart != null)
                StyleButton(btnCart, SuccessColor);
            if (btnOrder != null)
                StyleButton(btnOrder, Color.FromArgb(255, 193, 7));
            if (checkoutbtn != null)
                StyleButton(checkoutbtn, SuccessColor);
            if (logOutbtn != null)
                StyleButton(logOutbtn, AccentColor);
        }

        private void StyleButton(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 45;
            btn.UseVisualStyleBackColor = false;

            // Add hover effects
            btn.MouseEnter += (s, e) => {
                btn.BackColor = DarkenColor(color, 0.1f);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = color;
            };
        }

        private Button CreateModernButton(string text, int width, int height)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(width, height),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private void DrawRoundedButton(Graphics graphics, Button button, Color color)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 8;
            Rectangle rect = new Rectangle(0, 0, button.Width - 1, button.Height - 1);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            button.Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillPath(brush, path);
            }
        }

        private Color DarkenColor(Color color, float factor)
        {
            return Color.FromArgb(
                color.A,
                (int)(color.R * (1 - factor)),
                (int)(color.G * (1 - factor)),
                (int)(color.B * (1 - factor))
            );
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

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = BackgroundColor,
                Padding = new Padding(20)
            };

            foreach (var category in categories)
            {
                Panel card = CreateModernCategoryCard(category);
                flow.Controls.Add(card);
            }

            mainPanel.Controls.Add(flow);
        }

        private Panel CreateModernCategoryCard(UserCategoryDTO category)
        {
            Panel card = new Panel
            {
                Size = new Size(250, 120),
                Margin = new Padding(15),
                BackColor = CardColor,
                Cursor = Cursors.Hand
            };

            // Add shadow effect
            card.Paint += (s, e) => DrawCardShadow(e.Graphics, card);

            // Category icon (you can add different icons based on category)
            Label iconLabel = new Label
            {
                Text = "📁", // You can use FontAwesome or custom icons
                Font = new Font("Segoe UI Emoji", 24F),
                Size = new Size(50, 50),
                Location = new Point(20, 20),
                BackColor = Color.Transparent
            };

            Label nameLabel = new Label
            {
                Text = category.Name,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = TextPrimary,
                Location = new Point(80, 25),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            Label descLabel = new Label
            {
                Text = "Click to view products",
                Font = new Font("Segoe UI", 9F),
                ForeColor = TextSecondary,
                Location = new Point(80, 50),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // Hover effects
            card.MouseEnter += (s, e) => {
                card.BackColor = Color.FromArgb(248, 249, 250);
                card.Invalidate();
            };
            card.MouseLeave += (s, e) => {
                card.BackColor = CardColor;
                card.Invalidate();
            };

            // Click events
            card.Click += (s, e) => {
                headerLabel.Text = $"{category.Name} Products";
                LoadProductsByCategory(category.Id);
            };
            nameLabel.Click += (s, e) => {
                headerLabel.Text = $"{category.Name} Products";
                LoadProductsByCategory(category.Id);
            };

            card.Controls.AddRange(new Control[] { iconLabel, nameLabel, descLabel });
            return card;
        }

        private void DrawCardShadow(Graphics graphics, Control control)
        {
            Rectangle shadowRect = new Rectangle(2, 2, control.Width - 2, control.Height - 2);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
            {
                graphics.FillRectangle(shadowBrush, shadowRect);
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            checkoutbtn.Visible = false;
            mainPanel.Controls.Clear();

            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = BackgroundColor
            };

            Button btnBack = new Button
            {
                Text = "← Back to Categories",
                Size = new Size(200, 40),
                BackColor = TextSecondary,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                Dock = DockStyle.Top,
                Margin = new Padding(20, 10, 20, 10)
            };
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += (s, e) => {
                headerLabel.Text = "Categories";
                LoadCategories();
            };

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = BackgroundColor,
                Padding = new Padding(20)
            };

            var products = _productService.GetAll()
                .Where(p => p.CategoryId == categoryId)
                .ToList();

            foreach (var product in products)
            {
                var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                var card = CreateModernProductCard(product.Id, saveDirectory, product.Name,
                    product.Description, product.Price);
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

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = BackgroundColor,
                Padding = new Padding(20)
            };

            foreach (var product in products)
            {
                if (string.IsNullOrEmpty(product.Image))
                    continue;

                var saveDirectory = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "wwwroot", "Files", "Images", "ProductImages", product.Image);

                var card = CreateModernProductCard(product.Id, saveDirectory, product.Name,
                    product.Description, product.Price);
                flow.Controls.Add(card);
            }

            mainPanel.Controls.Add(flow);
        }

        private Panel CreateModernProductCard(int id, string imagePath, string name, string description, decimal price)
        {
            Panel card = new Panel
            {
                Size = new Size(280, 380),
                BackColor = CardColor,
                Margin = new Padding(15)
            };

            // Add shadow and rounded corners
            card.Paint += (s, e) => {
                DrawCardShadow(e.Graphics, card);
                DrawRoundedRectangle(e.Graphics, card);
            };

            // Product image with modern styling
            PictureBox picture = new PictureBox
            {
                Size = new Size(260, 180),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            if (File.Exists(imagePath))
            {
                picture.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Default image placeholder
                picture.Paint += (s, e) => {
                    e.Graphics.DrawString("No Image", new Font("Segoe UI", 10),
                        new SolidBrush(TextSecondary), new Point(80, 80));
                };
            }

            Label lblName = new Label
            {
                Text = name,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = TextPrimary,
                Location = new Point(15, 200),
                Size = new Size(250, 25),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblDesc = new Label
            {
                Text = description?.Length > 60 ? description.Substring(0, 60) + "..." : description,
                Font = new Font("Segoe UI", 9F),
                ForeColor = TextSecondary,
                Location = new Point(15, 225),
                Size = new Size(250, 40)
            };

            Label lblPrice = new Label
            {
                Text = price.ToString("C"),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = SuccessColor,
                Location = new Point(15, 270),
                Size = new Size(150, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button btnBuy = new Button
            {
                Text = "Add to Cart",
                Size = new Size(240, 40),
                Location = new Point(20, 320),
                BackColor = PrimaryColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.Click += (s, e) => {
                var item = new HCarteItem()
                {
                    ProductId = id
                };
                LocalCart.carteItems.Add(item);
                ShowNotification($"Added {name} to Cart", SuccessColor);
            };

            // Hover effects
            card.MouseEnter += (s, e) => {
                card.BackColor = Color.FromArgb(248, 249, 250);
                card.Invalidate();
            };
            card.MouseLeave += (s, e) => {
                card.BackColor = CardColor;
                card.Invalidate();
            };

            card.Controls.AddRange(new Control[] { picture, lblName, lblDesc, lblPrice, btnBuy });
            return card;
        }

        private void DrawRoundedRectangle(Graphics graphics, Control control)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 12;
            Rectangle rect = new Rectangle(0, 0, control.Width - 1, control.Height - 1);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }

        private void ShowNotification(string message, Color color)
        {
            Panel notification = new Panel
            {
                Size = new Size(300, 60),
                BackColor = color,
                Location = new Point(this.Width - 320, 50)
            };

            Label lblMessage = new Label
            {
                Text = message,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            notification.Controls.Add(lblMessage);
            this.Controls.Add(notification);
            notification.BringToFront();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 3000 };
            timer.Tick += (s, e) => {
                timer.Stop();
                this.Controls.Remove(notification);
                notification.Dispose();
            };
            timer.Start();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = true;
            headerLabel.Text = "My Cart";
            mainPanel.Controls.Clear();

            Panel containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = BackgroundColor,
                AutoScroll = true
            };

            FlowLayoutPanel flowCart = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = BackgroundColor,
                Padding = new Padding(20)
            };

            decimal totalAmount = 0;

            foreach (var item in LocalCart.carteItems)
            {
                var product = _productService.GetItemById(item.ProductId);
                totalAmount += product.Price * item.Quantity;

                Panel card = CreateModernCartItem(item, product);
                flowCart.Controls.Add(card);
            }

            if (LocalCart.carteItems.Any())
            {
                Panel totalPanel = new Panel
                {
                    Size = new Size(flowCart.Width - 40, 80),
                    BackColor = PrimaryColor,
                    Margin = new Padding(10)
                };

                Label totalLabel = new Label
                {
                    Text = $"Total Amount: {totalAmount:C}",
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                totalPanel.Controls.Add(totalLabel);
                flowCart.Controls.Add(totalPanel);
            }

            containerPanel.Controls.Add(flowCart);
            mainPanel.Controls.Add(containerPanel);
        }

        private Panel CreateModernCartItem(HCarteItem item, UserProductDTO product)
        {
            Panel card = new Panel
            {
                Size = new Size(600, 120),
                BackColor = CardColor,
                Margin = new Padding(10)
            };

            card.Paint += (s, e) => {
                DrawCardShadow(e.Graphics, card);
                DrawRoundedRectangle(e.Graphics, card);
            };

            // Product image
            PictureBox pic = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(15, 20),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "wwwroot", "Files", "Images", "ProductImages", product.Image);

            if (File.Exists(saveDirectory))
                pic.Image = Image.FromFile(saveDirectory);

            // Product details
            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = TextPrimary,
                Location = new Point(110, 20),
                AutoSize = true
            };

            Label lblPrice = new Label
            {
                Text = $"Price: {product.Price:C}",
                Font = new Font("Segoe UI", 10F),
                ForeColor = TextSecondary,
                Location = new Point(110, 45),
                AutoSize = true
            };

            Label lblQty = new Label
            {
                Text = $"Qty: {item.Quantity}",
                Font = new Font("Segoe UI", 10F),
                ForeColor = TextSecondary,
                Location = new Point(110, 70),
                AutoSize = true
            };

            Label lblTotal = new Label
            {
                Text = $"Total: {product.Price * item.Quantity:C}",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = SuccessColor,
                Location = new Point(110, 90),
                AutoSize = true
            };

            // Quantity controls
            Button btnIncrease = new Button
            {
                Text = "+",
                Size = new Size(35, 30),
                Location = new Point(480, 45),
                BackColor = SuccessColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnIncrease.FlatAppearance.BorderSize = 0;
            btnIncrease.Click += (s2, e2) => {
                item.Quantity++;
                lblQty.Text = $"Qty: {item.Quantity}";
                lblTotal.Text = $"Total: {product.Price * item.Quantity:C}";
            };

            Button btnDecrease = new Button
            {
                Text = "-",
                Size = new Size(35, 30),
                Location = new Point(520, 45),
                BackColor = AccentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnDecrease.FlatAppearance.BorderSize = 0;
            btnDecrease.Click += (s2, e2) => {
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                    lblQty.Text = $"Qty: {item.Quantity}";
                    lblTotal.Text = $"Total: {product.Price * item.Quantity:C}";
                }
            };

            // Remove item button
            Button btnRemove = new Button
            {
                Text = "Remove",
                Size = new Size(80, 30),
                Location = new Point(480, 80),
                BackColor = AccentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.Click += (s, e) => {
                LocalCart.carteItems.Remove(item);
                btnCart_Click(null, null); // Refresh cart
                ShowNotification($"Removed {product.Name} from cart", AccentColor);
            };

            card.Controls.AddRange(new Control[] {
                pic, lblName, lblPrice, lblQty, lblTotal, btnIncrease, btnDecrease, btnRemove
            });

            return card;
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            if (LocalCart.carteItems == null || !LocalCart.carteItems.Any())
            {
                ShowNotification("Your cart is empty!", AccentColor);
                return;
            }

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

            ShowNotification("Order placed successfully!", SuccessColor);
            LocalCart.carteItems.Clear();
            mainPanel.Controls.Clear();
            checkoutbtn.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            checkoutbtn.Visible = false;
            headerLabel.Text = "My Orders";
            mainPanel.Controls.Clear();

            var orders = _orderService.getOrdersByUserId(UserCookies.CurrentUserId);

            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = BackgroundColor,
                Padding = new Padding(20)
            };

            foreach (var order in orders)
            {
                Panel card = CreateModernOrderCard(order);
                flow.Controls.Add(card);
            }

            if (!orders.Any())
            {
                Label noOrdersLabel = new Label
                {
                    Text = "No orders found",
                    Font = new Font("Segoe UI", 14F),
                    ForeColor = TextSecondary,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                flow.Controls.Add(noOrdersLabel);
            }

            mainPanel.Controls.Add(flow);
        }

        private Panel CreateModernOrderCard(UserOrderDTO order)
        {
            Panel card = new Panel
            {
                Size = new Size(350, 180),
                BackColor = CardColor,
                Margin = new Padding(15)
            };

            card.Paint += (s, e) => {
                DrawCardShadow(e.Graphics, card);
                DrawRoundedRectangle(e.Graphics, card);
            };

            Label lblOrder = new Label
            {
                Text = $"Order #{order.Id}",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = TextPrimary,
                Location = new Point(20, 15),
                AutoSize = true
            };

            Label lblDate = new Label
            {
                Text = $"Date: {order.OrderDate.ToShortDateString()}",
                Font = new Font("Segoe UI", 10F),
                ForeColor = TextSecondary,
                Location = new Point(20, 45),
                AutoSize = true
            };

            Panel statusPanel = new Panel
            {
                Size = new Size(80, 25),
                Location = new Point(20, 70),
                BackColor = order.Status == "Pending" ? Color.FromArgb(255, 193, 7) : SuccessColor
            };

            Label lblStatus = new Label
            {
                Text = order.Status,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            statusPanel.Controls.Add(lblStatus);

            Button btnDetails = new Button
            {
                Text = "Details",
                Size = new Size(100, 35),
                Location = new Point(20, 120),
                BackColor = PrimaryColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.Click += (s, ev) => ShowOrderDetails(order.Id);

            Button btnDelete = new Button
            {
                Text = "Delete",
                Size = new Size(100, 35),
                Location = new Point(130, 120),
                BackColor = AccentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                Enabled = (order.Status == "Pending"),
                Visible = (order.Status == "Pending")
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += (s, ev) => {
                var result = MessageBox.Show("Are you sure you want to delete this order?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _orderService.DeleteOrder(order.Id);
                    ShowNotification("Order deleted successfully!", SuccessColor);
                    btnOrder_Click(null, null);
                }
            };

            card.Controls.AddRange(new Control[] {
                lblOrder, lblDate, statusPanel, btnDetails, btnDelete
            });

            return card;
        }

        private void ShowOrderDetails(int orderId)
        {
            UserOrderDetailsForm userOrderDetails = new UserOrderDetailsForm(orderId);
            userOrderDetails.Show();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {
            // Header label click event
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to log out?", "Log Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AcountService acountService = new AcountService(_unitOfWork, _userRepository);
                acountService.Logout();
                this.Close();
            }
        }

        // إضافة دالة لإنشاء أزرار مع نص واضح
        private Button CreateStyledButton(string text, Color backgroundColor, Point location, Size size)
        {
            Button btn = new Button
            {
                Text = text,
                BackColor = backgroundColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = location,
                Size = size,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = backgroundColor;

            // Add hover effects
            btn.MouseEnter += (s, e) => btn.BackColor = DarkenColor(backgroundColor, 0.15f);
            btn.MouseLeave += (s, e) => btn.BackColor = backgroundColor;

            return btn;
        }
    }
}