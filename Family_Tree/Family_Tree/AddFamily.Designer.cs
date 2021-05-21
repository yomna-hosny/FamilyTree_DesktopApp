
namespace Family_Tree
{
    partial class AddFamily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFamily));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NameLb = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.FirestNameLB = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Donebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Namevalidation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 10);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.TitleLb);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 31);
            this.panel1.TabIndex = 3;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(292, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(431, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TitleLb.Location = new System.Drawing.Point(18, 7);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(132, 19);
            this.TitleLb.TabIndex = 2;
            this.TitleLb.Text = "Add New Family";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 88);
            this.panel5.TabIndex = 1;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.Location = new System.Drawing.Point(19, 49);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(100, 16);
            this.NameLb.TabIndex = 31;
            this.NameLb.Text = "Family Name :";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(129, 49);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(161, 22);
            this.nameTxt.TabIndex = 29;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged_1);
            // 
            // FirestNameLB
            // 
            this.FirestNameLB.AutoSize = true;
            this.FirestNameLB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirestNameLB.Location = new System.Drawing.Point(19, 83);
            this.FirestNameLB.Name = "FirestNameLB";
            this.FirestNameLB.Size = new System.Drawing.Size(65, 16);
            this.FirestNameLB.TabIndex = 32;
            this.FirestNameLB.Text = "Coment :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(129, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 41);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Donebtn
            // 
            this.Donebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Donebtn.BorderRadius = 0;
            this.Donebtn.ButtonText = "   Add";
            this.Donebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Donebtn.DisabledColor = System.Drawing.Color.Gray;
            this.Donebtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.Iconimage = null;
            this.Donebtn.Iconimage_right = null;
            this.Donebtn.Iconimage_right_Selected = null;
            this.Donebtn.Iconimage_Selected = null;
            this.Donebtn.IconMarginLeft = 20;
            this.Donebtn.IconMarginRight = 0;
            this.Donebtn.IconRightVisible = true;
            this.Donebtn.IconRightZoom = 50D;
            this.Donebtn.IconVisible = false;
            this.Donebtn.IconZoom = 50D;
            this.Donebtn.IsTab = true;
            this.Donebtn.Location = new System.Drawing.Point(230, 130);
            this.Donebtn.Margin = new System.Windows.Forms.Padding(3, 843196, 3, 843196);
            this.Donebtn.Name = "Donebtn";
            this.Donebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(186)))));
            this.Donebtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.selected = false;
            this.Donebtn.Size = new System.Drawing.Size(60, 26);
            this.Donebtn.TabIndex = 34;
            this.Donebtn.Text = "   Add";
            this.Donebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Donebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebtn.Click += new System.EventHandler(this.Donebtn_Click);
            // 
            // Namevalidation
            // 
            this.Namevalidation.AutoSize = true;
            this.Namevalidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namevalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Namevalidation.Location = new System.Drawing.Point(129, 34);
            this.Namevalidation.Name = "Namevalidation";
            this.Namevalidation.Size = new System.Drawing.Size(0, 14);
            this.Namevalidation.TabIndex = 35;
            // 
            // AddFamily
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(321, 169);
            this.Controls.Add(this.Namevalidation);
            this.Controls.Add(this.Donebtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.FirestNameLB);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFamily";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFamily";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label FirestNameLB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton Donebtn;
        private System.Windows.Forms.Label Namevalidation;
    }
}