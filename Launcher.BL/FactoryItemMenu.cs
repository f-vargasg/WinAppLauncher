using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.BL
{
    public enum MenuTypes : short
    {
        enMenuOption = 1,
        enItemOption = 2
    }
    public class FactoryItemMenu
    {
        public static MenuApp GetMenu(MenuTypes menuTypes)
        {
            MenuApp res = null;
            switch (menuTypes)
            {
                case MenuTypes.enMenuOption:
                    res = new MenuOption();
                    break;
                case MenuTypes.enItemOption:
                    res = new ItemOption();
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
