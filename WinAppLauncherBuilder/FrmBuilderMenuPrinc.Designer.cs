
namespace WinAppLauncherBuilder
{
    partial class FrmBuilderMenuPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilderMenuPrinc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xmlTrv = new System.Windows.Forms.TreeView();
            this.tlstrPrincMenu = new System.Windows.Forms.ToolStrip();
            this.ExitTlStrp = new System.Windows.Forms.ToolStripButton();
            this.LoadMenuTlstr = new System.Windows.Forms.ToolStripButton();
            this.StoreMenuTlstr = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tlstrPrincMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xmlTrv);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 516);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 5;
            // 
            // xmlTrv
            // 
            this.xmlTrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlTrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlTrv.Location = new System.Drawing.Point(0, 0);
            this.xmlTrv.Margin = new System.Windows.Forms.Padding(2);
            this.xmlTrv.Name = "xmlTrv";
            this.xmlTrv.Size = new System.Drawing.Size(302, 516);
            this.xmlTrv.TabIndex = 0;
            this.xmlTrv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTrv_AfterSelect);
            // 
            // tlstrPrincMenu
            // 
            this.tlstrPrincMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlstrPrincMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitTlStrp,
            this.LoadMenuTlstr,
            this.StoreMenuTlstr});
            this.tlstrPrincMenu.Location = new System.Drawing.Point(0, 0);
            this.tlstrPrincMenu.Name = "tlstrPrincMenu";
            this.tlstrPrincMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlstrPrincMenu.Size = new System.Drawing.Size(1048, 27);
            this.tlstrPrincMenu.TabIndex = 6;
            this.tlstrPrincMenu.Text = "toolStrip1";
            this.tlstrPrincMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlstrPrincMenu_ItemClicked);
            // 
            // ExitTlStrp
            // 
            this.ExitTlStrp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitTlStrp.Image = ((System.Drawing.Image)(resources.GetObject("ExitTlStrp.Image")));
            this.ExitTlStrp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitTlStrp.Name = "ExitTlStrp";
            this.ExitTlStrp.Size = new System.Drawing.Size(24, 24);
            this.ExitTlStrp.Text = "toolStripButton1";
            this.ExitTlStrp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitTlStrp.ToolTipText = "Exit";
            this.ExitTlStrp.Click += new System.EventHandler(this.ExitTlStrp_Click);
            // 
            // LoadMenuTlstr
            // 
            this.LoadMenuTlstr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadMenuTlstr.Image = ((System.Drawing.Image)(resources.GetObject("LoadMenuTlstr.Image")));
            this.LoadMenuTlstr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadMenuTlstr.Name = "LoadMenuTlstr";
            this.LoadMenuTlstr.Size = new System.Drawing.Size(24, 24);
            this.LoadMenuTlstr.Text = "toolStripButton1";
            this.LoadMenuTlstr.ToolTipText = "Load Menu";
            // 
            // StoreMenuTlstr
            // 
            this.StoreMenuTlstr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StoreMenuTlstr.Image = ((System.Drawing.Image)(resources.GetObject("StoreMenuTlstr.Image")));
            this.StoreMenuTlstr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StoreMenuTlstr.Name = "StoreMenuTlstr";
            this.StoreMenuTlstr.Size = new System.Drawing.Size(24, 24);
            this.StoreMenuTlstr.Text = "toolStripButton2";
            this.StoreMenuTlstr.ToolTipText = "Save Menu";
            // 
            // FrmBuilderMenuPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tlstrPrincMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuilderMenuPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tlstrPrincMenu.ResumeLayout(false);
            this.tlstrPrincMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView xmlTrv;
        private System.Windows.Forms.ToolStrip tlstrPrincMenu;
        private System.Windows.Forms.ToolStripButton ExitTlStrp;
        private System.Windows.Forms.ToolStripButton LoadMenuTlstr;
        private System.Windows.Forms.ToolStripButton StoreMenuTlstr;
    }
}

