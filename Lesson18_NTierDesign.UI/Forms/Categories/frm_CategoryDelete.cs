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
    public partial class frm_CategoryDelete : Form
    {
        public frm_CategoryDelete()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cls_Category cat = new cls_Category();
            var outcome = cat.CategoryDelete(626237);
            if (outcome == "Successful")
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
