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
using Lesson18_NTierDesign.BusinessLayer;
using Lesson18_NTierDesign.TypeLayer;

namespace Lesson18_NTierDesign.UI.Forms.Products
{
    public partial class frm_ProductUpdate : Form
    {
        cls_Product product = new cls_Product();
        int listviewID;
        bool result;
        int itemCount;

        public frm_ProductUpdate()
        {
            InitializeComponent();
        }

        private void frm_ProductUpdate_Load(object sender, EventArgs e)
        {
            FillList(product.List());
            FillCategories();
            FillSuppliers();
        }
        void FillList(SqlDataReader reader)
        {
            itemCount = 0;
            lst_Products.Items.Clear();
            //SqlDataReader reader = product.List();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader[0].ToString();
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());

                lst_Products.Items.Add(item);
                itemCount++;
            }
            lbl_ItemCount.Text = itemCount.ToString() + " Items";
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

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                product.ProductName = txt_ProductName.Text;
                product.UnitPrice = decimal.Parse(txt_UnitPrice.Text);
                product.UnitsInStock = Int16.Parse(txt_UnitsInStock.Text);
                product.ProductID = listviewID;
                product.CategoryID = cmb_CategoryName.SelectedIndex + 1;
                product.SupplierID = cmb_CompanyName.SelectedIndex + 1;

                result = product.Update();

                FillList(product.List());
                MessageBox.Show(cls_Message.ShowMessage("Products", Operation.Update, result));
                ClearBoxes();
                listviewID = 0;
            }
        }

        private void lst_Products_Click(object sender, EventArgs e)
        {
            listviewID = Convert.ToInt32(lst_Products.FocusedItem.SubItems[0].Text);
            txt_ProductName.Text = lst_Products.FocusedItem.SubItems[1].Text;
            txt_UnitPrice.Text = lst_Products.FocusedItem.SubItems[2].Text;
            txt_UnitsInStock.Text = lst_Products.FocusedItem.SubItems[3].Text;
            cmb_CategoryName.Text = lst_Products.FocusedItem.SubItems[4].Text;
            cmb_CompanyName.Text = lst_Products.FocusedItem.SubItems[5].Text;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(listviewID > 0)
            {
                product.ProductID = listviewID;

                result = product.Delete();

                FillList(product.List());
                MessageBox.Show(cls_Message.ShowMessage("Products", Operation.Delete, result));
                ClearBoxes();
                listviewID = 0;
            }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                frm_ProductDetails form = new frm_ProductDetails(listviewID);
                form.ShowDialog();
            }
        }
        void ClearBoxes()
        {
            txt_ProductName.Text = txt_UnitPrice.Text = txt_UnitsInStock.Text = "";
            cmb_CategoryName.SelectedIndex = cmb_CompanyName.SelectedIndex = -1;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(txt_Search.Text.Length > 1)
            {
                FillList(product.List(txt_Search.Text));
            }
            else
            {
                FillList(product.List());
            }
        }
    }
}
