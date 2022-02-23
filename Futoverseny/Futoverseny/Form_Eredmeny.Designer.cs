
namespace Futoverseny
{
    partial class Form_Eredmeny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Eredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "verseny eredmény lista";
            // 
            // listBox1_Eredmeny
            // 
            this.listBox1_Eredmeny.FormattingEnabled = true;
            this.listBox1_Eredmeny.ItemHeight = 16;
            this.listBox1_Eredmeny.Location = new System.Drawing.Point(284, 103);
            this.listBox1_Eredmeny.Name = "listBox1_Eredmeny";
            this.listBox1_Eredmeny.Size = new System.Drawing.Size(250, 244);
            this.listBox1_Eredmeny.TabIndex = 1;
            this.listBox1_Eredmeny.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_Eredmeny_MouseClick);
            // 
            // Form_Eredmeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1_Eredmeny);
            this.Controls.Add(this.label1);
            this.Name = "Form_Eredmeny";
            this.Text = "eredménylista";
            this.Load += new System.EventHandler(this.Form_Eredmeny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Eredmeny;
    }
}