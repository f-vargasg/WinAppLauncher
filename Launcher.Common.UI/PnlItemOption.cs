using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Common.UI
{
    public partial class PnlItemOption : UserControl
    {

        public TextBox TxtId
        {
            get { return this.txtId; }
            set { txtId = value; }
        }


        public TextBox TxtLabel
        {
            get { return this.txtLabel; }
        }

        public TextBox TxtClass
        {
            get { return this.txtClass; }
        }

        public TextBox TxtAssemblyFile
        {
            get { return this.txtAssemblyFile; }
        }

        public TextBox TxtInvoker
        {
            get { return this.txtInvoker; }
        }


        public PnlItemOption()
        {
            InitializeComponent();
        }
    }
}
