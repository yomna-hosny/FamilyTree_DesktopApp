using Family_Tree.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Tree
{
    public partial class AddMember : Form 
    {
        public int familyId { get; set; }
        public int MemberId { get; set; }

        public String Fname { get; set; }
        public String Lname { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender  { get; set; }



        public bool edit { get; set; }
        public static _Contex context;
        public  string imagePath { get; set; }

        public AddMember()
        {
            context = new _Contex();
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            Edit();
        }

        private void TitleLb_Click(object sender, EventArgs e)
        {

        }

        private void Edit()
        {
            if (edit)
            {
                TitleLb.Text = "Edit Member";
                FnameTxt.Text = Fname;
                LnameTxt.Text = Lname;
                dateTimePicker1.Value = DOB;
                if (Gender)
                    FemaleRB.Checked=true;
                else
                    MaleRB.Checked = true;
                if (imagePath != null)
                    imag.ImageLocation = imagePath;
            }
            else
            { TitleLb.Text = "Add New Member"; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (FNvalidation.Text != "" && FNvalidation.Text != "Not Valid" && LNvalidation.Text != "" && LNvalidation.Text != "Not Valid" && (MaleRB.Checked || FemaleRB.Checked))
            {
                if (!edit)
                {
                    Models.Member member = new Models.Member();
                    member.FirstName = FnameTxt.Text;
                    member.LastName = LnameTxt.Text;
                    member.DateOfBirth = dateTimePicker1.Value.Date;
                    if (MaleRB.Checked)
                        member.Gender = false;
                    else
                        member.Gender = true;
                    member.FamilyId = familyId;
                    if (imagePath != null)
                        member.Image = imagePath;
                    context.Members.Add(member);
                }
                else
                {
                    var member = context.Members.Find(MemberId);
                    member.FirstName = FnameTxt.Text;
                    member.LastName = LnameTxt.Text;
                    member.DateOfBirth = dateTimePicker1.Value.Date;
                    if (MaleRB.Checked)
                        member.Gender = false;
                    else
                        member.Gender = true;
                    if (imagePath != null)
                        member.Image = imagePath;
                }
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }

        private void FnameTxt_TextChanged(object sender, EventArgs e)
        {
            Regex NameReg = new Regex("^([a-zA-Z0-9]|[-._](?![-._])){3,}$");
            string input = FnameTxt.Text.Trim();
            if (!NameReg.IsMatch(input))
            {
                FNvalidation.Text = "Not Valid";
                FNvalidation.ForeColor = Color.Red;
            }
            else
            {
                FNvalidation.Text = "Valid";
                FNvalidation.ForeColor = Color.Green;
            }
        }

        private void LnameTxt_TextChanged(object sender, EventArgs e)
        {
            Regex NameReg = new Regex("^([a-zA-Z0-9]|[-._](?![-._])){3,}$");
            string input = LnameTxt.Text.Trim();
            if (!NameReg.IsMatch(input))
            {
                LNvalidation.Text = "Not Valid";
                LNvalidation.ForeColor = Color.Red;
            }
            else
            {
                LNvalidation.Text = "Valid";
                LNvalidation.ForeColor = Color.Green;
            }
        }

        private void Imagebtn_Click(object sender, EventArgs e)
        {
            string location = "";
            imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    location = dialog.FileName;
                    imag.ImageLocation = location;
                    imagePath = location;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please check your Image");

            }
        }
    }
}
