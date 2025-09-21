using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Interfaces
{
    // interface for usercontrols. Guarantees implmentation of methods
    internal interface IUserControlMethods
    {
        // Construct to apply edit mode to the contsol
        public void ApplyEditMode(bool isEditable);

        // Construct to Load data into controls
        public void LoadData(Person contact);
    }
}
