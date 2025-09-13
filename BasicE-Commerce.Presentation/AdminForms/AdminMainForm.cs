using BasicE_Commerce.Presentation.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicE_Commerce.Presentation
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            AdminCategoriesForm adminCategoriesForm = new AdminCategoriesForm();
            adminCategoriesForm.ShowDialog();
        }
    }
}
