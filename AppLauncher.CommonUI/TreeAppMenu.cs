using AppLauncher.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppLauncher.CommonUI
{
    public class TreeAppMenu
    {
        public TreeView Tv { get; set; }

        public string Fname { get; set; }

        public int IdTreeNode { get; set; }


        public TreeAppMenu(TreeView treeView, string pFnameDefMenu)
        {
            this.Tv = treeView;
            this.Fname = pFnameDefMenu;
        }

        private TreeNode MakeTreeNodeFromXmlNode(XmlNode xmlNode)
        {
            MenuApp mnuApp;
            TreeNode res = null;
            Console.Write(xmlNode.Name + " => ");
            switch (xmlNode.NodeType)
            {
                case XmlNodeType.Attribute:
                    break;
                case XmlNodeType.CDATA:
                    break;
                case XmlNodeType.Comment:
                    break;
                case XmlNodeType.Document:
                    break;
                case XmlNodeType.DocumentFragment:
                    break;
                case XmlNodeType.DocumentType:
                    break;
                case XmlNodeType.Element:
                    string scrap = "Prueba";
                    scrap = xmlNode.Name + (Convert.ToString(this.IdTreeNode++));
                    res = new TreeNode();
                    // process attributes
                    if (xmlNode.Name.CompareTo("menu") == 0)
                    {
                        // mnuApp = new MenuOption(scrap, string.Empty);
                        mnuApp = FactoryItemMenu.GetMenu(MenuTypes.enMenuOption );
                        if (xmlNode.Attributes.Count > 0)
                        {
                            mnuApp.IdMenu = xmlNode.Attributes["id"].Value;
                            mnuApp.Label = xmlNode.Attributes["label"].Value;

                        }
                        res.Name = mnuApp.IdMenu;
                        res.Text = mnuApp.Label;
                        res.Tag = mnuApp;
                    }
                    else
                    {
                        // itmOpt = new ItemOption(scrap, -1, string.Empty, string.Empty, string.Empty, "InvokerTest");
                          mnuApp = FactoryItemMenu.GetMenu(MenuTypes.enItemOption);
                        if (xmlNode.Attributes.Count > 0)
                        {
                            mnuApp.IdMenu= xmlNode.Attributes["id"].Value;
                            mnuApp.Label = xmlNode.Attributes["label"].Value;
                            //itmOpt.ClassNameStr = string.Empty;
                            if (xmlNode.Attributes["assemblyFile"] != null)
                            {
                                ((ItemOption)mnuApp).AssemblyFile = xmlNode.Attributes["assemblyFile"].Value;
                            }

                            if (xmlNode.Attributes["class"] != null)
                            {
                                ((ItemOption)mnuApp).ClassName = xmlNode.Attributes["class"].Value;
                            }
                        }
                        res.Name = ((ItemOption)mnuApp).IdMenu;
                        res.Text = ((ItemOption)mnuApp).Label;
                        res.Tag = mnuApp;
                    }
                    /*
                    if (xmlNode.Attributes.Count > 0)
                    {
                        
                        bool ft = true;
                        for (int i = 0; i < xmlNode.Attributes.Count; i++)
                        {
                            
                            scrap += ((!ft ? ", " : string.Empty) + xmlNode.Attributes[i].Name + "=" + xmlNode.Attributes[i].Value);
                            ft = false;
                        }
                        
                        scrap = " {" + scrap + "}";
                        res.Text += scrap;
                    }
                    */
                    break;
                case XmlNodeType.EndElement:
                    break;
                case XmlNodeType.EndEntity:
                    break;
                case XmlNodeType.Entity:
                    break;
                case XmlNodeType.EntityReference:
                    break;
                case XmlNodeType.None:
                    break;
                case XmlNodeType.Notation:
                    break;
                case XmlNodeType.ProcessingInstruction:
                    break;
                case XmlNodeType.SignificantWhitespace:
                    break;
                case XmlNodeType.Text:
                    if (xmlNode.Value != null)
                    {
                        Console.WriteLine(xmlNode.Value.ToString());
                        res = new TreeNode(xmlNode.Value.ToString());
                    }
                    break;
                case XmlNodeType.Whitespace:
                    break;
                case XmlNodeType.XmlDeclaration:
                    break;
                default:
                    break;
            }

            return res;
        }

        private void LoadXmlToTree(TreeNode treeNode, XmlNodeList xmlNodeList)
        {

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                TreeNode tn = MakeTreeNodeFromXmlNode(xmlNode);
                treeNode.Nodes.Add(tn);
                LoadXmlToTree(tn, xmlNode.ChildNodes);
            }

        }

        private void LoadXmlMenu(string xmlData)
        {
            TreeNode tn;
            Tv.Nodes.Clear();
            var doc = new XmlDocument();
            doc.LoadXml(xmlData);


            if (Tv.Nodes.Count <= 0)
            {
                //tn = XmlTrV.Nodes.Add(doc.ToString());
                tn = Tv.Nodes.Add("Root");

                foreach (XmlNode item in doc.ChildNodes)
                {
                    if (item.Name.CompareTo("menuDef") == 0)
                    {
                        LoadXmlToTree(tn, item.ChildNodes);
                    }
                }
                //tn = XmlTrV.Nodes.Add("First Node");
            }
            Tv.ExpandAll();
        }

        public void LoadFileDefMenu()
        {
            try
            {
                string xmlContents;

                bool existeArch = File.Exists(this.Fname);
                if (existeArch)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(Fname);
                    xmlContents = doc.InnerXml;
                    LoadXmlMenu(xmlContents);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}

