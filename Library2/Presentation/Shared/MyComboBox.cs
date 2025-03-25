using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Shared
{
    public class MyComboBox:ComboBox
    {
        public MyComboBox() 
        {
            SelectedIndex = -1;
            DisplayMember = "Name";
            ValueMember = "Id";
           
        }
    }
}
