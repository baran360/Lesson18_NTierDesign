using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson18_NTierDesign.BusinessLayer;

namespace Lesson18_NTierDesign.UI.Forms.Categories
{
    public partial class frm_CategoryAdd : Form
    {
        public frm_CategoryAdd()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            byte outcome = cls_Category.CategorySave("Electronic");
            if (outcome == 1)
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
