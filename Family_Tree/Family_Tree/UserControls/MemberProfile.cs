using Family_Tree.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_Tree
{
    public partial class MemberProfile : UserControl
    {
        public MemberProfile()
        {
            InitializeComponent();
        }
        private String _FirestName;
        private String _LastName;
        private string _Image;
        private int _Age;
        private string _Gender;


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
            set { _Image = value;pictureBox.ImageLocation = value; }
        }

        [Category("Custom Props")]

        public int Age
        {
            get { return _Age; }
            set { _Age = value; Age_Lb.Text = value.ToString(); }
        }

        [Category("Custom Props")]

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; Gender_lb.Text = value; }
        }



        private void Lname_lb_Click(object sender, EventArgs e)
        {

        }

        

    }
}
