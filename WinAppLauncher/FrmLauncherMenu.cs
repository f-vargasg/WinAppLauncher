
using Launcher.BL;
using Launcher.Common.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLauncher
{
    public partial class FrmLauncherMenu : Form
    {
        TreeAppMenu treeAppMenu;
        int idLastVisited;


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

        private void xmlTrv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

                Form frm;
                Form lastFrm;
                TreeNode tn = ((TreeView)sender).SelectedNode;
                // MessageBox.Show(((TreeView)sender).SelectedNode.Text);
                Console.WriteLine(tn.Text);
                // obtener información de la clase
                object tag = tn.Tag;
                if (tag is ItemOption)
                {
                    ItemOption itop = (ItemOption)tag;
                    Console.WriteLine("soy un ItemOption");
                    Console.WriteLine(tag.ToString());
                    if (itop.ClassName.CompareTo(string.Empty) != 0)
                    {

                        if (itop.IdNumeric == -1)  // no está creado el objeto
                        {
                            //splitContainer1.Panel2.Controls.Remove()
                            // Assembly assembly = Assembly.LoadFrom("GenMenuFrmUI.dll");
                            Assembly assembly = Assembly.LoadFrom(itop.AssemblyFile);

                            frm = (Form)assembly.CreateInstance(itop.ClassName);
                            frm.TopLevel = false;
                            itop.IdNumeric = splitContainer1.Panel2.Controls.Count;
                            splitContainer1.Panel2.Controls.Add(frm);
                            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            frm.Dock = DockStyle.Fill;
                            ((ItemOption)tag).PnlOptionWork = frm;
                        }
                        else
                        {

                            frm = (Form)itop.PnlOptionWork;
                            Console.WriteLine("Current Form: " + frm.Name);
                        }
                        /*
                        if (splitContainer1.Panel2.Controls.Count > 0)
                        {
                            Form frmDel = (Form)splitContainer1.Panel2.Controls[0];
                            if (frmDel != null)
                            {
                                splitContainer1.Panel2.Controls.RemoveAt(0);
                            }                        
                        }
                        */
                        if (this.idLastVisited >= 0)
                        {
                            lastFrm = (Form)splitContainer1.Panel2.Controls[this.idLastVisited];
                            Console.WriteLine("Old Form: " + lastFrm.Name);
                            lastFrm.Hide();

                        }
                        frm.Show();
                        this.idLastVisited = itop.IdNumeric;
                    }
                }
                if (tag is MenuOption)
                {
                    Console.WriteLine("soy un MenuOption");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
