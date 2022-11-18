namespace Lesson18_NTierDesign.UI.Forms.Products
{
    partial class frm_ProductUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_UnitsInStock = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_UnitsInStock = new System.Windows.Forms.Label();
            this.lbl_UnitPrice = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lst_Products = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitsInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_CategoryName = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.cmb_CategoryName = new System.Windows.Forms.ComboBox();
            this.cmb_CompanyName = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_ItemCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UnitsInStock
            // 
            this.txt_UnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UnitsInStock.Location = new System.Drawing.Point(137, 137);
            this.txt_UnitsInStock.Name = "txt_UnitsInStock";
            this.txt_UnitsInStock.Size = new System.Drawing.Size(169, 20);
            this.txt_UnitsInStock.TabIndex = 23;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(137, 95);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(169, 20);
            this.txt_UnitPrice.TabIndex = 22;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ProductName.Location = new System.Drawing.Point(137, 53);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(169, 20);
            this.txt_ProductName.TabIndex = 21;
            // 
            // lbl_UnitsInStock
            // 
            this.lbl_UnitsInStock.AutoSize = true;
            this.lbl_UnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UnitsInStock.Location = new System.Drawing.Point(37, 140);
            this.lbl_UnitsInStock.Name = "lbl_UnitsInStock";
            this.lbl_UnitsInStock.Size = new System.Drawing.Size(74, 13);
            this.lbl_UnitsInStock.TabIndex = 20;
            this.lbl_UnitsInStock.Text = "Units In Stock";
            // 
            // lbl_UnitPrice
            // 
            this.lbl_UnitPrice.AutoSize = true;
            this.lbl_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UnitPrice.Location = new System.Drawing.Point(58, 98);
            this.lbl_UnitPrice.Name = "lbl_UnitPrice";
            this.lbl_UnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lbl_UnitPrice.TabIndex = 19;
            this.lbl_UnitPrice.Text = "Unit Price";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Location = new System.Drawing.Point(36, 56);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(75, 13);
            this.lbl_ProductName.TabIndex = 18;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.Khaki;
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Details.Location = new System.Drawing.Point(77, 394);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(205, 44);
            this.btn_Details.TabIndex = 17;
            this.btn_Details.Text = "Details";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(77, 333);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(205, 44);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(76, 271);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(206, 44);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // lst_Products
            // 
            this.lst_Products.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.ProductName,
            this.UnitPrice,
            this.UnitsInStock,
            this.CategoryName,
            this.CompanyName});
            this.lst_Products.FullRowSelect = true;
            this.lst_Products.GridLines = true;
            this.lst_Products.HideSelection = false;
            this.lst_Products.Location = new System.Drawing.Point(336, 53);
            this.lst_Products.Name = "lst_Products";
            this.lst_Products.Size = new System.Drawing.Size(629, 385);
            this.lst_Products.TabIndex = 14;
            this.lst_Products.UseCompatibleStateImageBehavior = false;
            this.lst_Products.View = System.Windows.Forms.View.Details;
            this.lst_Products.Click += new System.EventHandler(this.lst_Products_Click);
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 90;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.Width = 70;
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.Text = "Units In Stock";
            this.UnitsInStock.Width = 80;
            // 
            // CategoryName
            // 
            this.CategoryName.Text = "Category Name";
            this.CategoryName.Width = 140;
            // 
            // CompanyName
            // 
            this.CompanyName.Text = "Company Name";
            this.CompanyName.Width = 140;
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CategoryName.Location = new System.Drawing.Point(36, 185);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(80, 13);
            this.lbl_CategoryName.TabIndex = 24;
            this.lbl_CategoryName.Text = "Category Name";
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CompanyName.Location = new System.Drawing.Point(36, 228);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(82, 13);
            this.lbl_CompanyName.TabIndex = 26;
            this.lbl_CompanyName.Text = "Company Name";
            // 
            // cmb_CategoryName
            // 
            this.cmb_CategoryName.FormattingEnabled = true;
            this.cmb_CategoryName.Location = new System.Drawing.Point(137, 182);
            this.cmb_CategoryName.Name = "cmb_CategoryName";
            this.cmb_CategoryName.Size = new System.Drawing.Size(169, 21);
            this.cmb_CategoryName.TabIndex = 27;
            // 
            // cmb_CompanyName
            // 
            this.cmb_CompanyName.FormattingEnabled = true;
            this.cmb_CompanyName.Location = new System.Drawing.Point(137, 225);
            this.cmb_CompanyName.Name = "cmb_CompanyName";
            this.cmb_CompanyName.Size = new System.Drawing.Size(169, 21);
            this.cmb_CompanyName.TabIndex = 28;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Search.Location = new System.Drawing.Point(380, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(169, 20);
            this.txt_Search.TabIndex = 29;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Search.Location = new System.Drawing.Point(333, 15);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 30;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_ItemCount
            // 
            this.lbl_ItemCount.AutoSize = true;
            this.lbl_ItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ItemCount.Location = new System.Drawing.Point(555, 15);
            this.lbl_ItemCount.Name = "lbl_ItemCount";
            this.lbl_ItemCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_ItemCount.TabIndex = 31;
            this.lbl_ItemCount.Text = "0";
            // 
            // frm_ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.lbl_ItemCount);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_CompanyName);
            this.Controls.Add(this.cmb_CategoryName);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.lbl_CategoryName);
            this.Controls.Add(this.txt_UnitsInStock);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_UnitsInStock);
            this.Controls.Add(this.lbl_UnitPrice);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lst_Products);
            this.Name = "frm_ProductUpdate";
            this.Text = "frm_Update";
            this.Load += new System.EventHandler(this.frm_ProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UnitsInStock;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_UnitsInStock;
        private System.Windows.Forms.Label lbl_UnitPrice;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ListView lst_Products;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader UnitsInStock;
        private System.Windows.Forms.ColumnHeader CategoryName;
        private System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.ComboBox cmb_CategoryName;
        private System.Windows.Forms.ComboBox cmb_CompanyName;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_ItemCount;
    }
}