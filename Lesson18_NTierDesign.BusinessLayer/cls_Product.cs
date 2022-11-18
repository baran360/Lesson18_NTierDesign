using Lesson18_NTierDesign.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_NTierDesign.BusinessLayer
{
    public class cls_Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        private decimal _UnitPrice { get; set; }
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set
            {
                if (value < 0) { _UnitPrice = Math.Abs(value); }
                else { _UnitPrice = value; }
            }
        }
        private int _UnitsInStock { get; set; }
        public int UnitsInStock
        {
            get { return _UnitsInStock; }
            set
            {
                if (value < 0) { _UnitsInStock = Math.Abs(value); }
                else { _UnitsInStock = value; }
            }
        }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }


        public bool Save()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "sp_Product_Insert";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@ProductName", ProductName);
            sqlcmd.Parameters.AddWithValue("@UnitPrice", _UnitPrice);
            sqlcmd.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return true;
        }
        public bool Update()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "sp_Product_Update";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@ProductName", ProductName);
            sqlcmd.Parameters.AddWithValue("@UnitPrice", _UnitPrice);
            sqlcmd.Parameters.AddWithValue("@UnitsInStock", _UnitsInStock);
            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);
            sqlcmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            sqlcmd.Parameters.AddWithValue("@SupplierID", SupplierID);

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return true;
        }
        public bool Delete()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "sp_Product_Delete";
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);

            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return true;
        }
        public SqlDataReader List()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select * from vw_ProductList order by ProductID desc";

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader List(string searchText)
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select * from vw_ProductList where ProductName like '%" + searchText + "%' order by ProductID desc";

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader Details()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandText = "select * from vw_ProductList where ProductID = @ProductID";
            sqlcmd.Parameters.AddWithValue("@ProductID", ProductID);
            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader Categories()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandText = "select CategoryID,CategoryName from Categories order by CategoryID";
            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader Suppliers()
        {
            SqlConnection sqlcon = cls_Connection.Connect;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();

            sqlcmd.CommandText = "select SupplierID,CompanyName from Suppliers order by SupplierID";
            sqlcmd.Connection = sqlcon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        }
    }
}
