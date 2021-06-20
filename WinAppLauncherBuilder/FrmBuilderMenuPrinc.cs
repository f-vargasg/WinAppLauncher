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

namespace WinAppLauncherBuilder
{
    public partial class FrmBuilderMenuPrinc : Form
    {
        TreeAppMenu treeAppMenu;
        PnlItemOption pnlItemOption;
        PnlMenuOption pnlMenuOption;
        object lastPnlVisited;

        public FrmBuilderMenuPrinc()
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
                this.lastPnlVisited = null;
                this.Text = ConfigurationManager.AppSettings["appCaption"] +
                             " (" + this.Name + ")";
            }
            else
            {
                MessageBox.Show("Archivo de configuracion de menu no existe");
            }
        }

        private void tlstrPrincMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitTlStrp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void xmlTrv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            object objNode = e.Node.Tag;
            UserControl pnlToShow = null;
            if (objNode is ItemOption)
            {
                ItemOption itemOption = (ItemOption)objNode;
                if (this.pnlItemOption == null)  // no está creado el objeto
                {    // cree el objeto
                    pnlItemOption = new PnlItemOption
                    {
                        BorderStyle = BorderStyle.None,
                        Dock = DockStyle.Fill

                    };
                    splitContainer1.Panel2.Controls.Add(pnlItemOption);
                }
                ItemOption item = (ItemOption)objNode;
                pnlItemOption.TxtId.Text = item.IdMenu;
                pnlItemOption.TxtLabel.Text = item.Label;
                pnlItemOption.TxtClass.Text = item.ClassName;
                pnlItemOption.TxtAssemblyFile.Text = item.AssemblyFile;
                pnlItemOption.TxtInvoker.Text = item.Invoker;



                pnlToShow = pnlItemOption;

                Console.WriteLine("soy un ItemOption Label: " + ((ItemOption)objNode).Label);
            }
            else if (objNode is MenuOption)
            {
                MenuOption menuOption = (MenuOption)objNode;
                if (pnlMenuOption == null)
                {
                    pnlMenuOption = new PnlMenuOption()
                    {
                        BorderStyle = BorderStyle.None,
                        Dock = DockStyle.None
                    };
                    // menuOption.IdNumeric = splitContainer1.Panel2.Controls.Count;
                    splitContainer1.Panel2.Controls.Add(pnlMenuOption);
                }
                pnlMenuOption.TxtId.Text = menuOption.IdMenu;
                pnlMenuOption.TxtLabel.Text = menuOption.Label;
                pnlToShow = pnlMenuOption;
                Console.WriteLine("soy un MenuOption. Label: " + ((MenuOption)objNode).Label);
            }
            // esconder el panel anterior
            if (this.lastPnlVisited != null)
            {
                ((UserControl)this.lastPnlVisited).Hide();
            }

            if (pnlToShow != null)
            {
                pnlToShow.Show();
            }
            this.lastPnlVisited = pnlToShow;
        }
    }
}
