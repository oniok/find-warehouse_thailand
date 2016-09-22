using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findwarehouse.controller
{
    class SubFormController
    { 

        public SubFormController()
        { }
        public static void setForm(Panel Parent,Form Child)
        {
            Parent.Controls.Clear();
            Child.TopLevel = false;
            Child.AutoScroll = true;
            Parent.Controls.Add(Child);
            Child.Show();
        }
    }
}
