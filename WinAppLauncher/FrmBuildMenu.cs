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
    public partial class FrmBuildMenu : Form
    {
        TreeAppMenu treeAppMenu;
        int idLastVisited;
        public FrmBuildMenu()
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
                this.idLastVisited = -1;
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

        private void xmlTrv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            object objNode = e.Node.Tag;

            if (objNode is ItemOption)
            {
                ItemOption itemOption = (ItemOption) objNode  ;
                if (itemOption.pnlOption == null)
                {
                    PnlItemOption pnlItemOption = new PnlItemOption();
                    itemOption.pnlOption = pnlItemOption;

                }
                else
                {

                }
                Console.WriteLine("soy un ItemOption Label: "  + ((ItemOption)objNode).Label );
            }
            else if (objNode is MenuOption)
            {
                Console.WriteLine("soy un MenuOption. Label: " + ((MenuOption)objNode).Label);
            }
           
        }
    }
}
