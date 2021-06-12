using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLauncher.CommonUI
{
    public partial class PnlMenuOption : UserControl
    {

        public TextBox TxtId
        {
            get { return txtId; }
        }

        public TextBox TxtLabel
        {
            get { return txtLabel; }
        }

        public PnlMenuOption()
        {
            InitializeComponent();
        }
    }
}
