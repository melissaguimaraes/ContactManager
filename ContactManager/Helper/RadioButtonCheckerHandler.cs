// TODO: To be deleted - deprecated

//using ContactManager.Models;
//using System;
//using System.IO;
//using System.Windows.Forms;

//namespace ContactManager.HelperRB
//{
//    public static class RadioButtonHandler
//    {
//        public static bool IsCustomerChecked { get; private set; } = false;

//        public static string CurrentDataPath() =>
//            IsCustomerChecked
//                ? Path.Combine("Data", "clients.json")
//                : Path.Combine("Data", "employees.json");


//        public static void OnRBCheckedChanged(object sender, EventArgs e)
//        {
//            if (sender is RadioButton rb && rb.Checked)
//            {
//                if (rb.Name == "RbCustomer")
//                    IsCustomerChecked = true;
//                else if (rb.Name == "RbEmployee")
//                    IsCustomerChecked = false;
//            }
//        }
//    }

//}