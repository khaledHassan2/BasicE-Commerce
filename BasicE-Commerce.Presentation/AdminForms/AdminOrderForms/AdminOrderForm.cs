using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.Application.Services.AdminServices;
using BasicE_Commerce.Context.Data;
using BasicE_Commerce.DTOs.OrderDTOs;
using BasicE_Commerce.InfraStructure;
using BasicE_Commerce.InfraStructure.Repositories;
using BasicE_Commerce.Models;
using Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation.AdminForms.AdminOrderForms
{
    public partial class AdminOrderForm : Form
    {
        IAdminOrderItemService _adminOrderItemService;
        IUnitOfWork _unitOfWork;
        IAdminOrderService _adminOrderService;

        public AdminOrderForm()
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            _unitOfWork = new UnitOfWork(dbContext);
            var orderItemRepsoity = new OrderItemRepository(dbContext);
            _adminOrderItemService = new AdminOrderItemService(_unitOfWork, orderItemRepsoity);
            var orderRepsoity = new OrderRepository(dbContext);
            _adminOrderService = new AdminOrderService(_unitOfWork, orderRepsoity);
        }

        private void AdminOrderForm_Load(object sender, EventArgs e)
        {
            var orders = _adminOrderService.GetAll().ToList();

            // اختبار عدد الأوردرات
          //  MessageBox.Show("Orders Count: " + orders.Count);

            flowOrdersPanel.Controls.Clear();
            flowOrdersPanel.AutoScroll = true; // خلي الـ Panel يسمح بالسكرول

            foreach (var order in orders)
            {
                var card = CreateOrderCard(order);
                flowOrdersPanel.Controls.Add(card);
            }
        }

        private Panel CreateOrderCard(AdminOrderDTO order)
        {
            Panel card = new Panel();
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.WhiteSmoke;
            card.Width = 300;
            card.Height = 150;
            card.Margin = new Padding(10);

            // عنوان الأوردر
            Label lblOrder = new Label();
            lblOrder.Text = $"Order #{order.Id}";
            lblOrder.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblOrder.Location = new Point(10, 10);
            lblOrder.AutoSize = true;
            card.Controls.Add(lblOrder);

            // التاريخ
            Label lblDate = new Label();
            lblDate.Text = $"Date: {order.OrderDate.ToShortDateString()}";
            lblDate.Location = new Point(10, 40);
            lblDate.AutoSize = true;
            card.Controls.Add(lblDate);

            // ComboBox لتغيير الحالة
            ComboBox cmbStatus = new ComboBox();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Processing", "Shipped", "Completed", "Cancelled" });
            cmbStatus.SelectedItem = order.Status;
            cmbStatus.Location = new Point(10, 95);
            cmbStatus.Width = 150;
            cmbStatus.SelectedIndexChanged += (s, e) =>
            {
                order.Status = cmbStatus.SelectedItem.ToString();
                _adminOrderService.UpdateOrderStatus(order.Id, order.Status);

                MessageBox.Show($"Order {order.Id} status changed to {order.Status}");
                // حفظ التغيير في قاعدة البيانات
                _unitOfWork.Commit();
            };
            card.Controls.Add(cmbStatus);

            // زر Details
            Button btnDetails = new Button();
            btnDetails.Text = "Details";
            btnDetails.Location = new Point(180, 95);
            btnDetails.Click += (s, e) =>
            {
                // افتح فورم التفاصيل
                // var detailsForm = new AdminOrderDetailsForm(order);
                // detailsForm.ShowDialog();
            };
            card.Controls.Add(btnDetails);

            return card;
        }
    }
}
