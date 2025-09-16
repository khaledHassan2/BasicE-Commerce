using BasicE_Commerce.Application.IServices.IAdminServices;
using BasicE_Commerce.DTOs.OrderDTOs;
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
    public partial class AdminOrderDetailsForm : Form
    {
        private readonly AdminOrderDTO _order;
        private readonly IAdminOrderItemService _orderItemService;

        public AdminOrderDetailsForm(AdminOrderDTO order, IAdminOrderItemService orderItemService)
        {
            InitializeComponent();
            _order = order;
            _orderItemService = orderItemService;

            var orderItems = _orderItemService.GetOrderItemByOrderId(_order.Id);
            dataGridView1.DataSource = orderItems;

        }

        private void AdminOrderDetailsForm_Load(object sender, EventArgs e)
        {

            // هات الـ Items من السيرفس
            //var items = _orderItemService.GetItemById(_order.Id);
            //dataGridView1.DataSource = items;
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
