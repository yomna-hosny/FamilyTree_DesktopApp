
namespace Family_Tree
{
    partial class AddRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRelation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLb = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Addbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Members = new System.Windows.Forms.ComboBox();
            this.RelationTypes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(385, 31);
            this.panel1.TabIndex = 35;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(342, 6);
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
            this.TitleLb.Location = new System.Drawing.Point(18, 7);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(145, 19);
            this.TitleLb.TabIndex = 2;
            this.TitleLb.Text = "Add New Relation";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 88);
            this.panel5.TabIndex = 1;
            // 
            // Addbtn
            // 
            this.Addbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addbtn.BorderRadius = 0;
            this.Addbtn.ButtonText = "   Add";
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Addbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Addbtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Addbtn.Iconimage = null;
            this.Addbtn.Iconimage_right = null;
            this.Addbtn.Iconimage_right_Selected = null;
            this.Addbtn.Iconimage_Selected = null;
            this.Addbtn.IconMarginLeft = 20;
            this.Addbtn.IconMarginRight = 0;
            this.Addbtn.IconRightVisible = true;
            this.Addbtn.IconRightZoom = 50D;
            this.Addbtn.IconVisible = false;
            this.Addbtn.IconZoom = 50D;
            this.Addbtn.IsTab = true;
            this.Addbtn.Location = new System.Drawing.Point(303, 84);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 843196, 3, 843196);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(154)))), ((int)(((byte)(137)))));
            this.Addbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(209)))), ((int)(((byte)(186)))));
            this.Addbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Addbtn.selected = false;
            this.Addbtn.Size = new System.Drawing.Size(60, 26);
            this.Addbtn.TabIndex = 37;
            this.Addbtn.Text = "   Add";
            this.Addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Addbtn.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 10);
            this.panel3.TabIndex = 36;
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.White;
            this.Members.DisplayMember = "0";
            this.Members.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Members.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.Members.FormattingEnabled = true;
            this.Members.Location = new System.Drawing.Point(19, 53);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(154, 24);
            this.Members.TabIndex = 39;
            this.Members.SelectedIndexChanged += new System.EventHandler(this.Members_SelectedIndexChanged);
            // 
            // RelationTypes
            // 
            this.RelationTypes.BackColor = System.Drawing.Color.White;
            this.RelationTypes.DisplayMember = "0";
            this.RelationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RelationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.RelationTypes.FormattingEnabled = true;
            this.RelationTypes.Location = new System.Drawing.Point(203, 53);
            this.RelationTypes.Name = "RelationTypes";
            this.RelationTypes.Size = new System.Drawing.Size(154, 24);
            this.RelationTypes.TabIndex = 39;
            this.RelationTypes.SelectedIndexChanged += new System.EventHandler(this.Members_SelectedIndexChanged);
            // 
            // AddRelation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(385, 129);
            this.Controls.Add(this.RelationTypes);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(117)))), ((int)(((byte)(113)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRelation";
            this.Load += new System.EventHandler(this.AddRelation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton Addbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Members;
        private System.Windows.Forms.ComboBox RelationTypes;
    }
}