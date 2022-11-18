namespace Lesson18_NTierDesign.UI.Forms.Products
{
    partial class frm_ProductRegistration
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
            this.cmb_CompanyName = new System.Windows.Forms.ComboBox();
            this.cmb_CategoryName = new System.Windows.Forms.ComboBox();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_CategoryName = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_UnitsInStock = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_UnitsInStock = new System.Windows.Forms.Label();
            this.lbl_UnitPrice = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_CompanyName
            // 
            this.cmb_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_CompanyName.FormattingEnabled = true;
            this.cmb_CompanyName.Location = new System.Drawing.Point(377, 319);
            this.cmb_CompanyName.Name = "cmb_CompanyName";
            this.cmb_CompanyName.Size = new System.Drawing.Size(197, 28);
            this.cmb_CompanyName.TabIndex = 24;
            // 
            // cmb_CategoryName
            // 
            this.cmb_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_CategoryName.FormattingEnabled = true;
            this.cmb_CategoryName.Location = new System.Drawing.Point(377, 259);
            this.cmb_CategoryName.Name = "cmb_CategoryName";
            this.cmb_CategoryName.Size = new System.Drawing.Size(197, 28);
            this.cmb_CategoryName.TabIndex = 23;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CompanyName.Location = new System.Drawing.Point(227, 322);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(122, 20);
            this.lbl_CompanyName.TabIndex = 22;
            this.lbl_CompanyName.Text = "Company Name";
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CategoryName.Location = new System.Drawing.Point(230, 262);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(119, 20);
            this.lbl_CategoryName.TabIndex = 21;
            this.lbl_CategoryName.Text = "Category Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(320, 383);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(134, 47);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_UnitsInStock
            // 
            this.txt_UnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UnitsInStock.Location = new System.Drawing.Point(377, 199);
            this.txt_UnitsInStock.Name = "txt_UnitsInStock";
            this.txt_UnitsInStock.Size = new System.Drawing.Size(197, 26);
            this.txt_UnitsInStock.TabIndex = 19;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UnitPrice.Location = new System.Drawing.Point(377, 142);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(197, 26);
            this.txt_UnitPrice.TabIndex = 18;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ProductName.Location = new System.Drawing.Point(377, 87);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(197, 26);
            this.txt_ProductName.TabIndex = 17;
            // 
            // lbl_UnitsInStock
            // 
            this.lbl_UnitsInStock.AutoSize = true;
            this.lbl_UnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UnitsInStock.Location = new System.Drawing.Point(240, 202);
            this.lbl_UnitsInStock.Name = "lbl_UnitsInStock";
            this.lbl_UnitsInStock.Size = new System.Drawing.Size(109, 20);
            this.lbl_UnitsInStock.TabIndex = 16;
            this.lbl_UnitsInStock.Text = "Units In Stock";
            // 
            // lbl_UnitPrice
            // 
            this.lbl_UnitPrice.AutoSize = true;
            this.lbl_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UnitPrice.Location = new System.Drawing.Point(272, 145);
            this.lbl_UnitPrice.Name = "lbl_UnitPrice";
            this.lbl_UnitPrice.Size = new System.Drawing.Size(77, 20);
            this.lbl_UnitPrice.TabIndex = 15;
            this.lbl_UnitPrice.Text = "Unit Price";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Location = new System.Drawing.Point(239, 90);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(110, 20);
            this.lbl_ProductName.TabIndex = 14;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Registration Form";
            // 
            // frm_ProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_CompanyName);
            this.Controls.Add(this.cmb_CategoryName);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.lbl_CategoryName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_UnitsInStock);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_UnitsInStock);
            this.Controls.Add(this.lbl_UnitPrice);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.label1);
            this.Name = "frm_ProductRegistration";
            this.Text = "frm_ProductRegistration";
            this.Load += new System.EventHandler(this.frm_ProductRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_CompanyName;
        private System.Windows.Forms.ComboBox cmb_CategoryName;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_UnitsInStock;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label lbl_UnitsInStock;
        private System.Windows.Forms.Label lbl_UnitPrice;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label label1;
    }
}