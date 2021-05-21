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

namespace Family_Tree
{
    public partial class AddRelation : Form
    {
        public int familyId { get; set; }
        public int SelectedMemberId { get; set; }
   
        public static _Contex context;

        public AddRelation()
        {
            context = new _Contex();
            InitializeComponent();
        }

        private void LoadMembers()
        {
           var members = context.Members.Where(m=>m.Id!=SelectedMemberId).ToList();
            Members.Items.Clear();
            ComboboxItem initialItem = new ComboboxItem();
          
            initialItem.Text = "Select Member";
            initialItem.Value = 0;
       
            Members.Items.Add(initialItem);
            Members.SelectedIndex = 0;

            foreach (var member in members)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = member.FirstName + " " + member.LastName;
                item.Value = member.Id;
                Members.Items.Add(item);
            }
        }
        private void LoadRelationTypes()
        {
            var relationTypes = context.RelationTypes.ToList();
            RelationTypes.Items.Clear();
            ComboboxItem initialItem = new ComboboxItem();
          
                initialItem.Text = "Select Relation Type";
                initialItem.Value = 0;
           
            RelationTypes.Items.Add(initialItem);
            RelationTypes.SelectedIndex = 0;

            foreach (var type in relationTypes)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = type.Name;
                item.Value = type.Id;
                RelationTypes.Items.Add(item);
            }
        }
        private void MemberDropDown_onItemSelected(object sender, EventArgs e)
        {

        }

        private void AddRelation_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadRelationTypes();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (Members.SelectedIndex > 0 && RelationTypes.SelectedIndex>0)
            {
                RelationShip relation = new RelationShip();
                relation.Member1 = SelectedMemberId;
                relation.Member2= (Members.SelectedItem as ComboboxItem).Value;
                relation.FamilyId = familyId;
                relation.RelationStart = context.Members.Find(SelectedMemberId).DateOfBirth;
                int type = (RelationTypes.SelectedItem as ComboboxItem).Value;
                switch (type)
                {
                    case 1:
                        {
                            relation.Member1_RelationType = 1;
                            relation.Member2_RelationType = 1;
                            break;
                        }
                    case 2:
                        {
                            relation.Member1_RelationType = 3;
                            relation.Member2_RelationType = 2;
                            break;
                        }
                    case 3:
                        {
                            if(context.Members.Find(SelectedMemberId).Gender)
                            relation.Member1_RelationType = 2;
                            else
                                relation.Member1_RelationType = 5;
                            relation.Member2_RelationType = 3;
                            break;
                        }
                    case 4:
                        {
                            relation.Member1_RelationType = 4;
                            relation.Member2_RelationType = 4;
                            break;
                        }
                    case 5:
                        {
                            relation.Member1_RelationType = 3;
                            relation.Member2_RelationType = 5;
                            break;
                        }
                    case 6:
                        {
                            relation.Member1_RelationType = 9;
                            relation.Member2_RelationType = 6;
                            break;
                        }
                    case 7:
                        {
                            relation.Member1_RelationType = 7;
                            relation.Member2_RelationType = 7;
                            break;
                        }
                    case 8:
                        {
                            relation.Member1_RelationType = 9;
                            relation.Member2_RelationType = 8;
                            break;
                        }
                    case 9:
                        {
                            if (context.Members.Find(SelectedMemberId).Gender)
                                relation.Member1_RelationType = 6;
                            else
                                relation.Member1_RelationType = 8;
                            relation.Member2_RelationType = 9;
                            break;
                        }
                }
             
                context.RelationShips.Add(relation);
                context.SaveChanges();
                this.Close();

            }
            else
            {
                MessageBox.Show("please select your data");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Members_SelectedIndexChanged(object sender, EventArgs e)
        {
            int  data =( Members.SelectedItem as ComboboxItem).Value;
                    
        }
    }
}
