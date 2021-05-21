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
    public partial class AddFamily : Form
    {
        public static _Contex context;

        public AddFamily()
        {
            context = new _Contex();
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            if (Namevalidation.Text != "" && Namevalidation.Text != "Not Valid")
            {
                Family family = new Family();
                family.Name = nameTxt.Text;

                if (richTextBox1.Text != "")
                    family.Comment = richTextBox1.Text;
               
                    context.Families.Add(family);                             
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
        }


        private void nameTxt_TextChanged_1(object sender, EventArgs e)
        {
            Regex NameReg = new Regex("^([a-zA-Z0-9]|[-._](?![-._])){3,}$");
            string input = nameTxt.Text.Trim();
            if (!NameReg.IsMatch(input))
            {
                Namevalidation.Text = "Not Valid";
                Namevalidation.ForeColor = Color.Red;
            }
            else
            {
                Namevalidation.Text = "Valid";
                Namevalidation.ForeColor = Color.Green;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
