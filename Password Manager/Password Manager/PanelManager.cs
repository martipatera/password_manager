using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{

    //Forms delam pres panely a pracuju s nima pres skryvani a odkryvani
    public static class PanelManager 
    {
        public static void HidePanel(Panel panel) 
        {
            panel.Visible = false;
        }

        public static void ShowPanel(Panel panel)
        {
            panel.Visible = true;
        }
    }
}
