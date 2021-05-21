using Family_Tree.Models;
using Family_Tree.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Tree.UserControls
{
    public partial class WindowMember : UserControl
    {
        public WindowMember()
        {
            InitializeComponent();
        }
        private String _FirestName;
        private String _LastName;
        private string _Image;
        private int _Age;
        private string _Gender;
        public static _Contex context;
       
        [Category("Custom Props")]
        public String FirestName
        {
            get { return _FirestName; }
            set { _FirestName = value; Fname_lb.Text = value; }
        }
        [Category("Custom Props")]

        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; Lname_lb.Text = value; }
        }


        [Category("Custom Props")]

        public string Image
        {
            get { return _Image; }
            set { _Image = value; pictureBox.ImageLocation = value; }
        }

        [Category("Custom Props")]

        public int Age
        {
            get { return _Age; }
            set { _Age = value; Age_Lb.Text = value.ToString(); }
        }

        [Category("Custom Props")]

        public int Id
        {
            get { return _Age; }
            set { _Age = value; Id_Lb.Text = value.ToString(); }
        }

        [Category("Custom Props")]

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; Gender_lb.Text = value; }
        }

        private void WindowMember_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 209, 186);
            this.ForeColor = Color.FromArgb(85, 117, 113);
        }

        private void WindowMember_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(85, 117, 113);
            this.ForeColor = Color.FromArgb(244, 244, 244);

        }

     

        private void WindowMember_Load(object sender, EventArgs e)
        {
            context = new _Contex();
        }
    }
}
