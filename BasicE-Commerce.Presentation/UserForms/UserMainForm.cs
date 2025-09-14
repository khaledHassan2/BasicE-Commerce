using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.CategoryDTOs;
using BasicE_Commerce.DTOs.PtoductDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
//using BasicE_Commerce.Presentation.UserForms;
using Helpers;
using System;
using System.Collections.Generic;
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

        public UserMainForm()
        {
            InitializeComponent();

            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);

            var categoryRepository = new CategoryRepository(dbContext);
            var productRepository = new ProductRepository(dbContext);

            _categoryService = new UserCategoryService(unitOfWork, categoryRepository);
            _productService = new UserProductService(unitOfWork, productRepository);
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            LoadCategories(); // اول ما يحمل يعرض الكاتيجوري
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Categories";
            LoadCategories();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Products";
            LoadProducts();
        }

        private void LoadCategories()
        {
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

                // فتح صفحة المنتجات الخاصة بالكاتيجوري
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

        //private void LoadProductsByCategory(int categoryId)
        //{
        //    mainPanel.Controls.Clear();

        //    // زر الرجوع
        //    Button btnBack = new Button();
        //    btnBack.Text = "← Back to Categories";
        //    btnBack.Height = 40;
        //    btnBack.Dock = DockStyle.Top;
        //    btnBack.BackColor = Color.LightGray;
        //    btnBack.Click += (s, e) =>
        //    {
        //        headerLabel.Text = "Categories";
        //        LoadCategories();
        //    };
        //    mainPanel.Controls.Add(btnBack);

        //    var products = _productService.GetAll()
        //        .Where(p => p.CategoryId == categoryId)
        //        .ToList();

        //    FlowLayoutPanel flow = new FlowLayoutPanel();
        //    flow.Dock = DockStyle.Fill;
        //    flow.AutoScroll = true;

        //    foreach (var product in products)
        //    {
        //        var saveDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        //            "wwwroot", "Files", "Images", "ProductImages", product.Image);

        //        var card = CreateProductCard(product.Id, saveDirectory, product.Name, product.Description, product.Price);
        //        flow.Controls.Add(card);
        //    }

        //    mainPanel.Controls.Add(flow);
        //}
        private void LoadProductsByCategory(int categoryId)
        {
            mainPanel.Controls.Clear();

            // Panel رئيسي يحتوي على زر الرجوع + الكروت
            Panel container = new Panel();
            container.Dock = DockStyle.Fill;
            container.AutoScroll = true;

            // زر الرجوع
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

            // FlowLayoutPanel للكروت
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

            // ربط المكونات
            container.Controls.Add(flow);
            container.Controls.Add(btnBack);

            // عرض في المين بانيل
            mainPanel.Controls.Add(container);
        }



        private void LoadProducts()
        {
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
            Panel card = new Panel();
            card.Size = new Size(200, 300);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.Margin = new Padding(10);

            // الصورة
            PictureBox picture = new PictureBox();
            picture.Size = new Size(200, 150);
            if (File.Exists(imagePath))
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
            lblPrice.Text = price.ToString("C");
            lblPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Dock = DockStyle.Bottom;
            lblPrice.Height = 30;

            // زر شراء
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

            // إضافة العناصر للكارد
            card.Controls.Add(btnBuy);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblName);
            card.Controls.Add(picture);

            return card;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
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


        private Panel CreateCard(string title, string imagePath, Action onClick)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 250);
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;

            PictureBox pic = new PictureBox();
            pic.Size = new Size(200, 150);
            if (File.Exists(imagePath))
                pic.Image = Image.FromFile(imagePath);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = DockStyle.Top;

            Label lbl = new Label();
            lbl.Text = title;
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lbl.Dock = DockStyle.Top;
            lbl.Height = 40;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            Button btn = new Button();
            btn.Text = "View";
            btn.Dock = DockStyle.Bottom;
            btn.Height = 40;
            btn.BackColor = Color.LightBlue;
            btn.Click += (s, e) => onClick();

            card.Controls.Add(btn);
            card.Controls.Add(lbl);
            card.Controls.Add(pic);

            return card;
        }
    }
}
