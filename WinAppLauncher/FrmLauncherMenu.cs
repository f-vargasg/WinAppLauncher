using AppLauncher.BL;
using AppLauncher.CommonUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLauncher
{
    public partial class FrmLauncherMenu : Form
    {
        TreeAppMenu treeAppMenu;
        


        public FrmLauncherMenu()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            string archMenu = ConfigurationManager.AppSettings["menuDefFile"];

            bool existeArch = File.Exists(archMenu);
            if (existeArch)
            {
                this.treeAppMenu = new TreeAppMenu(this.xmlTrv, archMenu);
                this.treeAppMenu.LoadFileDefMenu();
                this.Text = ConfigurationManager.AppSettings["appCaption"] +
                             " (" + this.Name + ")";
            }
            else
            {
                MessageBox.Show("Archivo de configuracion de menu no existe");
            }
        }

        private void ExitTlStrp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
