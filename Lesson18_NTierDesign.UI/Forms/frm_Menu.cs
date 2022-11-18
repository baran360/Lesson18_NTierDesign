using Lesson18_NTierDesign.UI.Forms.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson18_NTierDesign.UI.Forms
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ProductRegistration form = new frm_ProductRegistration();
            form.ShowDialog();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ProductUpdate form = new frm_ProductUpdate();
            form.ShowDialog();
        }
    }
}
