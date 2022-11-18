using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_NTierDesign.BusinessLayer
{
    public class cls_Category
    {
        //Save
        //Update
        //Delete
        //List
        public static byte CategorySave(string categoryName)
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool CategoryUpdate(string categoryName, int categoryID)
        {
            try
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string CategoryDelete(int categoryID)
        {
            try
            {
                return "Successful";
            }
            catch (Exception)
            {
                return "Error";
            }
        }
    }
}
