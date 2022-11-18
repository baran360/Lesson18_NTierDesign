using Lesson18_NTierDesign.BusinessLayer;
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
    public partial class frm_ProductDetails : Form
    {
        int listviewID;
        cls_Product product = new cls_Product();

        public frm_ProductDetails()
        {
            InitializeComponent();
        }
        public frm_ProductDetails(int listviewID):this()
        {
            this.listviewID = listviewID;
        }

        private void frm_ProductDetails_Load(object sender, EventArgs e)
        {
            product.ProductID = listviewID;
            txt_ProductID.Text = listviewID.ToString();
            SqlDataReader reader = product.Details();

            reader.Read();
            txt_ProductName.Text = reader[1].ToString();
            txt_UnitPrice.Text = reader[2].ToString();
            txt_UnitsInStock.Text = reader[3].ToString();
            txt_CategoryName.Text = reader[4].ToString();
            txt_CompanyName.Text = reader[5].ToString();
        }
    }
}
