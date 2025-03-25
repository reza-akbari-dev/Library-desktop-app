using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms;

public class MyGridView:DataGridView
{
    public MyGridView() 
    { 
        AutoGenerateColumns = false;
        BackgroundColor = Color.White;
        Dock = DockStyle.Fill;
        AllowUserToAddRows = false;
        AllowUserToDeleteRows = false;
    }

}
