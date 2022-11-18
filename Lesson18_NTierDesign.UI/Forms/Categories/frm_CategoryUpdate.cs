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
using Lesson18_NTierDesign.TypeLayer;

namespace Lesson18_NTierDesign.UI.Forms.Categories
{
    public partial class frm_CategoryUpdate : Form
    {
        public frm_CategoryUpdate()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            /*
            cls_Category cat = new cls_Category();
            var outcome = cat.CategoryUpdate("Grocery", 315);
            MessageBox.Show(cls_Message.ShowMessage("Category", "Update", outcome));
            */
        }
    }
}
