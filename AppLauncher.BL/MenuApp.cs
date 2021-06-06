using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLauncher.BL
{
    public class MenuApp
    {
        public object pnlOption;
        public string IdMenu { get; set; }
        public string Label { get; set; }

        public MenuApp()
        {
            this.pnlOption = null;
            this.IdMenu = this.Label = string.Empty;
        }

        public MenuApp(string pIdMenu, string pLabel)
        {
            this.pnlOption = null;
            this.IdMenu = pIdMenu;
            this.Label = pLabel;
        }
    }
}
