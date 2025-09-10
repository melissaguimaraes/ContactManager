using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.NewContactWin
{
    public partial class NewContactWin : Form
    {
        public NewContactWin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        // disable text fields - no edit

        protected void ContactFormNoEdit(bool readOnly)
        {
            void Walk(Control parent)
            {
                foreach (Control child in parent.Controls)
                {
                    switch (child)
                    {
                        case TextBox tb:
                            tb.ReadOnly = readOnly;
                            break;
                        case ComboBox cmb:
                            cmb.Enabled = !readOnly;
                            break;
                        case DateTimePicker dtP:
                            dtP.Enabled = !readOnly;
                            break;
                        case NumericUpDown nuD:
                            nuD.Enabled = !readOnly;
                            break;
                        case CheckBox cb:
                            cb.Checked = !readOnly;
                            break;
                        case RadioButton:
                            child.Enabled = !readOnly;
                            break;
                    }

                    if (child.HasChildren) Walk(child);
                }

            }

            Walk(this);
        }


    }
}
