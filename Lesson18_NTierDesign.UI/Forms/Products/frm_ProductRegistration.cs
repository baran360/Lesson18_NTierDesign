using Lesson18_NTierDesign.BusinessLayer;
using Lesson18_NTierDesign.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson18_NTierDesign.UI.Forms.Products
{
    public partial class frm_ProductRegistration : Form
    {
        cls_Product product = new cls_Product();

        public frm_ProductRegistration()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            product.ProductName = txt_ProductName.Text;
            product.UnitPrice = decimal.Parse(txt_UnitPrice.Text);
            product.UnitsInStock = Int16.Parse(txt_UnitsInStock.Text);
            product.CategoryID = cmb_CategoryName.SelectedIndex + 1;
            product.SupplierID = cmb_CompanyName.SelectedIndex + 1;

            bool result = product.Save();
            if (result)
            {
                MessageBox.Show(cls_Message.ShowMessage("Products", Operation.Save, result));
            }
        }

        private void frm_ProductRegistration_Load(object sender, EventArgs e)
        {
            FillCategories();
            FillSuppliers();
        }
        void FillCategories()
        {
            SqlDataReader reader = product.Categories();

            foreach (var item in reader)
            {
                cmb_CategoryName.Items.Add(reader["CategoryName"]);
            }
        }
        void FillSuppliers()
        {
            SqlDataReader reader = product.Suppliers();

            foreach (var item in reader)
            {
                cmb_CompanyName.Items.Add(reader["CompanyName"]);
            }
        }
    }
}
