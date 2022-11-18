using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson18_NTierDesign.UI.Forms.Products;
using Lesson18_NTierDesign.UI.Forms.Categories;
using Lesson18_NTierDesign.UI.Forms;

namespace Lesson18_NTierDesign.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Menu());
        }
    }
}
