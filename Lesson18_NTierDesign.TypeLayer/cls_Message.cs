using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_NTierDesign.TypeLayer
{
    public enum Operation
    {
        Save,
        Update,
        Delete
    }
    public class cls_Message
    {
        public static string ShowMessage(string tableName, Operation operation, bool success)
        {
            string message = "Error.";
            
            if (success)
            {
                switch (operation)
                {
                    case Operation.Save:
                        message = "Item successfully saved to the " + tableName + " table.";
                        break;
                    case Operation.Update:
                        message = "Item successfully updated in the " + tableName + " table.";
                        break;
                    case Operation.Delete:
                        message = "Item successfully deleted from the " + tableName + " table.";
                        break;
                }
            }
            else
            {
                switch (operation)
                {
                    case Operation.Save:
                        message = "Error! The item couldn't saved to the " + tableName + " table.";
                        break;
                    case Operation.Update:
                        message = "Error! The item couldn't updated in the " + tableName + " table.";
                        break;
                    case Operation.Delete:
                        message = "Error! The item couldn't deleted from the " + tableName + " table.";
                        break;
                }
            }
            return message;
        }
    }
}
