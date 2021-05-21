
namespace Family_Tree
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Imagebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.FirestNameLB = new System.Windows.Forms.Label();
            this.FnameTxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Donebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FNvalidation = new System.Windows.Forms.Label();
            this.LNvalidation = new System.Windows.Forms.Label();
            this.DOBvalidation = new System.Windows.Forms.Label();
            this.Gendervalidation = new System.Windows.Forms.Label();
            this.imag = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.TitleLb);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 31);
            this.panel1.TabIndex = 0;
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.TitleLb.Location = new System.Drawing.Point(21, 7);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(143, 19);
            this.TitleLb.TabIndex = 2;
            this.TitleLb.Text = "Add New Member";
            this.TitleLb.Click += new System.EventHandler(this.TitleLb_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 88);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 10);
            this.panel3.TabIndex = 2;
            // 
            // Imagebtn
            // 
            this.Imagebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Imagebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Imagebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Imagebtn.BorderRadius = 0;
            this.Imagebtn.ButtonText = " Upload Image";
            this.Imagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imagebtn.DisabledColor = System.Drawing.Color.Gray;
            this.Imagebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Imagebtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Imagebtn.Iconimage = null;
            this.Imagebtn.Iconimage_right = null;
            this.Imagebtn.Iconimage_right_Selected = null;
            this.Imagebtn.Iconimage_Selected = null;
            this.Imagebtn.IconMarginLeft = 20;
            this.Imagebtn.IconMarginRight = 0;
            this.Imagebtn.IconRightVisible = true;
            this.Imagebtn.IconRightZoom = 50D;
            this.Imagebtn.IconVisible = false;
            this.Imagebtn.IconZoom = 50D;
            this.Imagebtn.IsTab = true;
            this.Imagebtn.Location = new System.Drawing.Point(324, 62);
            this.Imagebtn.Margin = new System.Windows.Forms.Padding(3, 1277268, 3, 1277268);
            this.Imagebtn.Name = "Imagebtn";
            this.Imagebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Imagebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(186)))));
            this.Imagebtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Imagebtn.selected = false;
            this.Imagebtn.Size = new System.Drawing.Size(114, 22);
            this.Imagebtn.TabIndex = 26;
            this.Imagebtn.Text = " Upload Image";
            this.Imagebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imagebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Imagebtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imagebtn.Click += new System.EventHandler(this.Imagebtn_Click);
            // 
            // LnameTxt
            // 
            this.LnameTxt.Location = new System.Drawing.Point(121, 115);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(161, 22);
            this.LnameTxt.TabIndex = 27;
            this.LnameTxt.TextChanged += new System.EventHandler(this.LnameTxt_TextChanged);
            // 
            // FirestNameLB
            // 
            this.FirestNameLB.AutoSize = true;
            this.FirestNameLB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirestNameLB.Location = new System.Drawing.Point(21, 116);
            this.FirestNameLB.Name = "FirestNameLB";
            this.FirestNameLB.Size = new System.Drawing.Size(83, 16);
            this.FirestNameLB.TabIndex = 28;
            this.FirestNameLB.Text = "Last Name :";
            // 
            // FnameTxt
            // 
            this.FnameTxt.Location = new System.Drawing.Point(121, 62);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.Size = new System.Drawing.Size(161, 22);
            this.FnameTxt.TabIndex = 27;
            this.FnameTxt.TextChanged += new System.EventHandler(this.FnameTxt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date Of Birth :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRB.ForeColor = System.Drawing.Color.Black;
            this.FemaleRB.Location = new System.Drawing.Point(118, 223);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(79, 22);
            this.FemaleRB.TabIndex = 30;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRB.ForeColor = System.Drawing.Color.Black;
            this.MaleRB.Location = new System.Drawing.Point(206, 223);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(60, 22);
            this.MaleRB.TabIndex = 30;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gender :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // Donebtn
            // 
            this.Donebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Donebtn.BorderRadius = 0;
            this.Donebtn.ButtonText = "    Add";
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
            this.Donebtn.Location = new System.Drawing.Point(26, 276);
            this.Donebtn.Margin = new System.Windows.Forms.Padding(3, 843196, 3, 843196);
            this.Donebtn.Name = "Donebtn";
            this.Donebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Donebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(186)))));
            this.Donebtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.selected = false;
            this.Donebtn.Size = new System.Drawing.Size(60, 26);
            this.Donebtn.TabIndex = 31;
            this.Donebtn.Text = "    Add";
            this.Donebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Donebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Donebtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Firest Name :";
            // 
            // FNvalidation
            // 
            this.FNvalidation.AutoSize = true;
            this.FNvalidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.FNvalidation.Location = new System.Drawing.Point(124, 48);
            this.FNvalidation.Name = "FNvalidation";
            this.FNvalidation.Size = new System.Drawing.Size(0, 14);
            this.FNvalidation.TabIndex = 32;
            // 
            // LNvalidation
            // 
            this.LNvalidation.AutoSize = true;
            this.LNvalidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.LNvalidation.Location = new System.Drawing.Point(124, 101);
            this.LNvalidation.Name = "LNvalidation";
            this.LNvalidation.Size = new System.Drawing.Size(0, 14);
            this.LNvalidation.TabIndex = 32;
            // 
            // DOBvalidation
            // 
            this.DOBvalidation.AutoSize = true;
            this.DOBvalidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBvalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.DOBvalidation.Location = new System.Drawing.Point(124, 154);
            this.DOBvalidation.Name = "DOBvalidation";
            this.DOBvalidation.Size = new System.Drawing.Size(0, 14);
            this.DOBvalidation.TabIndex = 32;
            // 
            // Gendervalidation
            // 
            this.Gendervalidation.AutoSize = true;
            this.Gendervalidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendervalidation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Gendervalidation.Location = new System.Drawing.Point(272, 226);
            this.Gendervalidation.Name = "Gendervalidation";
            this.Gendervalidation.Size = new System.Drawing.Size(0, 14);
            this.Gendervalidation.TabIndex = 32;
            // 
            // imag
            // 
            this.imag.Location = new System.Drawing.Point(324, 89);
            this.imag.Name = "imag";
            this.imag.Size = new System.Drawing.Size(114, 146);
            this.imag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imag.TabIndex = 4;
            this.imag.TabStop = false;
            // 
            // AddMember
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(463, 328);
            this.Controls.Add(this.Gendervalidation);
            this.Controls.Add(this.DOBvalidation);
            this.Controls.Add(this.LNvalidation);
            this.Controls.Add(this.FNvalidation);
            this.Controls.Add(this.Donebtn);
            this.Controls.Add(this.MaleRB);
            this.Controls.Add(this.FemaleRB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirestNameLB);
            this.Controls.Add(this.FnameTxt);
            this.Controls.Add(this.LnameTxt);
            this.Controls.Add(this.Imagebtn);
            this.Controls.Add(this.imag);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imag;
        private Bunifu.Framework.UI.BunifuFlatButton Imagebtn;
        private System.Windows.Forms.TextBox LnameTxt;
        private System.Windows.Forms.Label FirestNameLB;
        private System.Windows.Forms.TextBox FnameTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FemaleRB;
        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuFlatButton Donebtn;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FNvalidation;
        private System.Windows.Forms.Label LNvalidation;
        private System.Windows.Forms.Label DOBvalidation;
        private System.Windows.Forms.Label Gendervalidation;
    }
}