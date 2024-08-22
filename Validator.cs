using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    public class Validator
    {

        // Validate min/max/inventory bounds
        public static bool ValidateMinMaxInventory(int min, int max, int InStock, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (min > max)
            {
                errorMessage = "Minimum value cannot be greater than Maximum value.";
                return false;
            }

            if (InStock < min || InStock > max)
            {
                errorMessage = "Inventory must be within the Min and Max bounds.";
                return false;
            }

            return true;
        }

        // Validate deletion of a part associated with a product
        public static bool CanDeletePart(Part part)
        {
            foreach (var product in MainScreen.inventory.Products)
            {
                if (product.AssociatedParts.Contains(part))
                {
                    return false;
                }
            }

            return true;
        }

        // Confirm deletion
        public static bool ConfirmDeletion()
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }
    }
}
