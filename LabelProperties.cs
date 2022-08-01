using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public class LabelProperties
    {
        public virtual void LabelForeColor(Label label)
        {
            label.ForeColor = Color.White;
        }
    }
    public class LabelMove : LabelProperties
    {
        public override void LabelForeColor(Label label)
        {
            label.ForeColor = Color.Plum;
        }  
    }

    public class LabelLeave : LabelProperties
    {
        public override void LabelForeColor(Label label)
        {
            label.ForeColor = Color.White;
        } 
    }

    public class LabelPress : LabelProperties
    {
        public override void LabelForeColor(Label label)
        {
            label.ForeColor = Color.Orchid;
        } 
    }
}
