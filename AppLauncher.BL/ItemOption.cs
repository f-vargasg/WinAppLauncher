using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLauncher.BL
{
    public class ItemOption : MenuApp
    {
        public string ClassName { get; set; }
        public string AssemblyFile { get; set; }
        public string Invoker { get; set; }
        public object PnlOptionWork { get; set; }

        public ItemOption() : base()
        {
            this.ClassName = this.AssemblyFile = this.Invoker = string.Empty;
        }

        public ItemOption(string pIdMenu, string pLabel, string pClassName,
                          string pAssemblyFile, string pInvoker) : base(pIdMenu, pLabel)
        {
            this.ClassName = pClassName;
            this.AssemblyFile = pAssemblyFile;
            this.Invoker = pInvoker;
        }
    }
}
