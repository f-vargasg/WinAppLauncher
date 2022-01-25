
namespace Launcher.Common.UI
{
    partial class PnlItemOption
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInvoker = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssemblyFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInvoker
            // 
            this.txtInvoker.Location = new System.Drawing.Point(124, 232);
            this.txtInvoker.Name = "txtInvoker";
            this.txtInvoker.Size = new System.Drawing.Size(250, 20);
            this.txtInvoker.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Invoker:";
            // 
            // txtAssemblyFile
            // 
            this.txtAssemblyFile.Location = new System.Drawing.Point(124, 192);
            this.txtAssemblyFile.Name = "txtAssemblyFile";
            this.txtAssemblyFile.Size = new System.Drawing.Size(250, 20);
            this.txtAssemblyFile.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Assembly File:";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(124, 151);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(250, 20);
            this.txtClass.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Class:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(124, 104);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(250, 20);
            this.txtLabel.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Label:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(124, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 20);
            this.txtId.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id";
            // 
            // butReload
            // 
            this.butReload.Location = new System.Drawing.Point(12, 12);
            this.butReload.Name = "butReload";
            this.butReload.Size = new System.Drawing.Size(80, 31);
            this.butReload.TabIndex = 30;
            this.butReload.Text = "Reload Data";
            this.butReload.UseVisualStyleBackColor = true;
            // 
            // PnlItemOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butReload);
            this.Controls.Add(this.txtInvoker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAssemblyFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "PnlItemOption";
            this.Size = new System.Drawing.Size(427, 336);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssemblyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butReload;
    }
}
