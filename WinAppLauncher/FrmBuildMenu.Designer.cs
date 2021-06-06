
namespace WinAppLauncher
{
    partial class FrmBuildMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuildMenu));
            this.TreecntMnuStr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrPrincMenu = new System.Windows.Forms.ToolStrip();
            this.ExitTlStrp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xmlTrv = new System.Windows.Forms.TreeView();
            this.TreecntMnuStr.SuspendLayout();
            this.tlstrPrincMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreecntMnuStr
            // 
            this.TreecntMnuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem});
            this.TreecntMnuStr.Name = "TreecntMnuStr";
            this.TreecntMnuStr.Size = new System.Drawing.Size(129, 26);
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            // 
            // tlstrPrincMenu
            // 
            this.tlstrPrincMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlstrPrincMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitTlStrp});
            this.tlstrPrincMenu.Location = new System.Drawing.Point(0, 0);
            this.tlstrPrincMenu.Name = "tlstrPrincMenu";
            this.tlstrPrincMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlstrPrincMenu.Size = new System.Drawing.Size(1067, 27);
            this.tlstrPrincMenu.TabIndex = 3;
            this.tlstrPrincMenu.Text = "toolStrip1";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xmlTrv);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 527);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 4;
            // 
            // xmlTrv
            // 
            this.xmlTrv.ContextMenuStrip = this.TreecntMnuStr;
            this.xmlTrv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlTrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlTrv.Location = new System.Drawing.Point(0, 0);
            this.xmlTrv.Margin = new System.Windows.Forms.Padding(2);
            this.xmlTrv.Name = "xmlTrv";
            this.xmlTrv.Size = new System.Drawing.Size(252, 527);
            this.xmlTrv.TabIndex = 0;
            // 
            // FrmBuildMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tlstrPrincMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBuildMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build Menu";
            this.TreecntMnuStr.ResumeLayout(false);
            this.tlstrPrincMenu.ResumeLayout(false);
            this.tlstrPrincMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip TreecntMnuStr;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlstrPrincMenu;
        private System.Windows.Forms.ToolStripButton ExitTlStrp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView xmlTrv;
    }
}

