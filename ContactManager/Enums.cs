using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public enum FormState
    {
        View,
        Edit,
        AddNew
    }

    public enum ContactType 
    { 
        Employee, 
        Customer 
        // Trainee 
    }

    public enum ContactStatus
    {
        Active,
        Passive
    }
}
