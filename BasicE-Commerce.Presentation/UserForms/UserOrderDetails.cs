using BasicE_Commerce.Application.IServices.IUserServices;
using BasicE_Commerce.Application.Services.UserServices;
using BasicE_Commerce.Context.Data;
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

namespace BasicE_Commerce.Presentation.UserForms
{
    public partial class UserOrderDetails : Form
    {
        public int _orderId;
        public UserOrderDetails(int orderId)
        {
            InitializeComponent();
            var dbContext = new BasicEcommerceDbContext();
            var unitOfWork = new UnitOfWork(dbContext);
            var repo=new OrderItemRepository(dbContext);
            _userOrderItemService = new UserOrderItemService(unitOfWork,repo);
            _orderId= orderId;
        }
        IUserOrderItemService _userOrderItemService;

        private void UserOrderDetails_Load(object sender, EventArgs e)
        {
           var orders= _userOrderItemService.GetOrderItemByOrderId(_orderId);
            dataGridView1.DataSource = orders;
        }
    }
}
