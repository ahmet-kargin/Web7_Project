using AlSatProjesi_01.BusinessLayer;
using AlSatProjesi_01.DataAccessLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlSatProjesi_01
{
    public partial class FormAna : Form
    {
        OrderBusiness orderBusiness = new OrderBusiness();
        ProductBusiness productBusiness = new ProductBusiness();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            cmbProducts.DataSource = productBusiness.ProductList();
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ID";
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderDate = dtpOrderDate.Value;
            order.ProductID = Convert.ToInt32(cmbProducts.SelectedValue.ToString());
            order.SoldQuantity = Convert.ToInt32(nudQuantity.Value);
            orderBusiness.OrderInsert(order);
        }
    }
}
