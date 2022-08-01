using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Diplom
{
    public class ButtonProperties
    {
        public virtual void ButtonForeColor (Button button)
        {
            button.ForeColor = Color.White;
        }
    }

    public class ButtonLeave : ButtonProperties
    {
        public override void ButtonForeColor(Button button)
        {
            button.ForeColor = Color.White;
        }
    }

    public class ButtonMove : ButtonProperties
    {
        public override void ButtonForeColor(Button button)
        {
            button.ForeColor = Color.Plum;
        }
    }

    public class ButtonPress : ButtonProperties
    {
        public override void ButtonForeColor(Button button)
        {
            button.ForeColor = Color.Orchid;
        }
    }
}
