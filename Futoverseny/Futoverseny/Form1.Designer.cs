
namespace Futoverseny
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredménylistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1_Resztvevok = new System.Windows.Forms.ListBox();
            this.button1_adatBe = new System.Windows.Forms.Button();
            this.button2_Bezar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Rajtszam = new System.Windows.Forms.TextBox();
            this.textBox2_Orszag = new System.Windows.Forms.TextBox();
            this.textBox3_Ido = new System.Windows.Forms.TextBox();
            this.textBox4_eletkor = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.eredménylistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitToolStripMenuItem
            // 
            this.megnyitToolStripMenuItem.Name = "megnyitToolStripMenuItem";
            this.megnyitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.megnyitToolStripMenuItem.Text = "Megnyit";
            this.megnyitToolStripMenuItem.Click += new System.EventHandler(this.megnyitToolStripMenuItem_Click);
            // 
            // eredménylistaToolStripMenuItem
            // 
            this.eredménylistaToolStripMenuItem.Name = "eredménylistaToolStripMenuItem";
            this.eredménylistaToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.eredménylistaToolStripMenuItem.Text = "Eredménylista";
            this.eredménylistaToolStripMenuItem.Click += new System.EventHandler(this.eredménylistaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(457, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maratoni verseny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "RÉSZTVEVŐK";
            // 
            // listBox1_Resztvevok
            // 
            this.listBox1_Resztvevok.FormattingEnabled = true;
            this.listBox1_Resztvevok.ItemHeight = 16;
            this.listBox1_Resztvevok.Location = new System.Drawing.Point(102, 78);
            this.listBox1_Resztvevok.Name = "listBox1_Resztvevok";
            this.listBox1_Resztvevok.Size = new System.Drawing.Size(237, 276);
            this.listBox1_Resztvevok.TabIndex = 3;
            this.listBox1_Resztvevok.SelectedIndexChanged += new System.EventHandler(this.listBox1_Resztvevok_SelectedIndexChanged);
            // 
            // button1_adatBe
            // 
            this.button1_adatBe.Location = new System.Drawing.Point(102, 381);
            this.button1_adatBe.Name = "button1_adatBe";
            this.button1_adatBe.Size = new System.Drawing.Size(146, 23);
            this.button1_adatBe.TabIndex = 4;
            this.button1_adatBe.Text = "adatBe";
            this.button1_adatBe.UseVisualStyleBackColor = true;
            this.button1_adatBe.Click += new System.EventHandler(this.button1_adatBe_Click);
            // 
            // button2_Bezar
            // 
            this.button2_Bezar.Location = new System.Drawing.Point(497, 369);
            this.button2_Bezar.Name = "button2_Bezar";
            this.button2_Bezar.Size = new System.Drawing.Size(227, 23);
            this.button2_Bezar.TabIndex = 5;
            this.button2_Bezar.Text = "bezár";
            this.button2_Bezar.UseVisualStyleBackColor = true;
            this.button2_Bezar.Click += new System.EventHandler(this.button2_Bezar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "időeredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "életkor:";
            // 
            // textBox1_Rajtszam
            // 
            this.textBox1_Rajtszam.Location = new System.Drawing.Point(464, 99);
            this.textBox1_Rajtszam.Name = "textBox1_Rajtszam";
            this.textBox1_Rajtszam.ReadOnly = true;
            this.textBox1_Rajtszam.Size = new System.Drawing.Size(260, 22);
            this.textBox1_Rajtszam.TabIndex = 10;
            // 
            // textBox2_Orszag
            // 
            this.textBox2_Orszag.Location = new System.Drawing.Point(464, 185);
            this.textBox2_Orszag.Name = "textBox2_Orszag";
            this.textBox2_Orszag.ReadOnly = true;
            this.textBox2_Orszag.Size = new System.Drawing.Size(260, 22);
            this.textBox2_Orszag.TabIndex = 11;
            // 
            // textBox3_Ido
            // 
            this.textBox3_Ido.Location = new System.Drawing.Point(464, 244);
            this.textBox3_Ido.Name = "textBox3_Ido";
            this.textBox3_Ido.ReadOnly = true;
            this.textBox3_Ido.Size = new System.Drawing.Size(260, 22);
            this.textBox3_Ido.TabIndex = 12;
            // 
            // textBox4_eletkor
            // 
            this.textBox4_eletkor.Location = new System.Drawing.Point(464, 305);
            this.textBox4_eletkor.Name = "textBox4_eletkor";
            this.textBox4_eletkor.ReadOnly = true;
            this.textBox4_eletkor.Size = new System.Drawing.Size(260, 22);
            this.textBox4_eletkor.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Szövegfájl (*.txt)|*.txt|Minden (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4_eletkor);
            this.Controls.Add(this.textBox3_Ido);
            this.Controls.Add(this.textBox2_Orszag);
            this.Controls.Add(this.textBox1_Rajtszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2_Bezar);
            this.Controls.Add(this.button1_adatBe);
            this.Controls.Add(this.listBox1_Resztvevok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "futóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredménylistaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1_Resztvevok;
        private System.Windows.Forms.Button button1_adatBe;
        private System.Windows.Forms.Button button2_Bezar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Rajtszam;
        private System.Windows.Forms.TextBox textBox2_Orszag;
        private System.Windows.Forms.TextBox textBox3_Ido;
        private System.Windows.Forms.TextBox textBox4_eletkor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

