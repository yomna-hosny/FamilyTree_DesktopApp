using Family_Tree.Models;
using Family_Tree.Properties;
using Family_Tree.UserControls;
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
    public partial class Home : Form
    {

        public static _Contex context;
        public static List<Family> Families;
        public static List<Models.Member> Siblings;
        public static List<int> DirectRelationsIds;
        public static int familyId=0;
        public static int SelectedMemberId;
        public static int? childId;

        public Home()
        {
            //initialize Global Data
            context = new _Contex();
            Families = context.Families.ToList();
            familyId = context.Families.FirstOrDefault().Id;
           
            if (familyId != 0)
            {
                SelectedMemberId = context.Members.Where(m => m.Family.Id == familyId).FirstOrDefault().Id;
            }
            familyId = context.Members.Find(SelectedMemberId).Family.Id;

            InitializeComponent();
        }

        //load all home data
        private void Home_Load(object sender, EventArgs e)
        {
            DirectRelationsIds = new List<int>();
            LoadFamilies();
            GetFamilyMembers();
            LoadPartner();
            LoadSelectMemberProfile();
            LoadSiblings(SelectedMemberId );
            LoadMother();
            LoadFather();
            LoadChilds();
            LoadIOtherRelations();
        }

        // load side bar member cards
        private void GetFamilyMembers()
        {

            SidePanel.Controls.Clear();
            var members = context.Members.Where(i => i.FamilyId == familyId).ToList();
            var size = members.Count();
            Member[] memberslist = new Member[size];
            for (int i = 0; i < size; i++)
            {
                memberslist[i] = new Member();
                if (members[i].Image != null)
                    memberslist[i].Image = members[i].Image;
                else memberslist[i].Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png"; ;

                memberslist[i].FirestName = members[i].FirstName;
                memberslist[i].LastName = members[i].LastName;
                if (members[i].Gender) memberslist[i].Gender = "Female"; else memberslist[i].Gender = "Male";
                memberslist[i].Age = DateTime.Now.Year - members[i].DateOfBirth.Year;
                memberslist[i].Id = members[i].Id;
                memberslist[i].Click += new EventHandler(member_Click);
                SidePanel.Controls.Add(memberslist[i]);

            }
        }

        //fill Combopox of Families name
        private void LoadFamilies()
        {
            context = new _Contex();
            Families = context.Families.ToList();
            FamilyDropDown.Clear();
            FamilyDropDown.AddItem("Select Your Family");
            FamilyDropDown.selectedIndex = 0;
            familyId = Families.FirstOrDefault().Id;
            var familiesName = Families.Select(f => f.Name).ToList();

            foreach (var item in familiesName)
            {
                FamilyDropDown.AddItem(item);
            }
        }

        //Close Window
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FamilyDropDown_onItemSelected(object sender, EventArgs e)
        {
            var index = FamilyDropDown.selectedIndex;
            familyId = index;
            GetFamilyMembers();
            LoadSelectMemberProfile();
        }

        //Selected member profile
        private void LoadSelectMemberProfile()
        {
            context = new _Contex();
            var selectedMember = context.Members.Find(SelectedMemberId);
            if (selectedMember != null) {
                memberProfile1.FirestName = selectedMember.FirstName;
                memberProfile1.LastName = selectedMember.LastName;
                if(selectedMember.Image!=null)
                memberProfile1.Image = selectedMember.Image;
                else memberProfile1.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png"; ;

                if (selectedMember.Gender) memberProfile1.Gender = "Female"; else memberProfile1.Gender = "Male";
                memberProfile1.Age = DateTime.Now.Year - selectedMember.DateOfBirth.Year;
            }
        }
        private void LoadPartner()
        {
            Models.Member Partner = new Models.Member();
            PartenerPanel.Controls.Clear();
            //direct Partner
            var PartnerRelatoin = context.RelationShips.Where(r=>r.VirsualMember1.Id == SelectedMemberId || r.VirsualMember2.Id == SelectedMemberId).Where(r => r.Member1_RelationType == 1 || r.Member2_RelationType==1 ).FirstOrDefault() ;
            if (PartnerRelatoin != null)
            {
                 Partner = PartnerRelatoin.VirsualMember1.Id != SelectedMemberId ? PartnerRelatoin.VirsualMember1 : PartnerRelatoin.VirsualMember2;
                WindowMember partnerCard = new WindowMember();
                if (Partner.Image != null)
                    partnerCard.Image = Partner.Image;
                else partnerCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png"; 
                partnerCard.FirestName =Partner.FirstName;
                partnerCard.LastName = Partner.LastName;
                if (Partner.Gender) partnerCard.Gender = "Female"; else partnerCard.Gender = "Male";
                partnerCard.Age = DateTime.Now.Year - Partner.DateOfBirth.Year;
                partnerCard.Id = Partner.Id;
                partnerCard.Click += new EventHandler(WindoMember_Click);
                DirectRelationsIds.Add(Partner.Id);
                PartenerPanel.Controls.Add(partnerCard);
            }
            else
            {
                if(childId!=null)
                {
                    //Get Mother of any child

                    if (!context.Members.Find(SelectedMemberId).Gender) {
                        var motherofChild = context.RelationShips.Where(r => (r.VirsualMember1.Id == childId && r.Member1_RelationType == 3 && r.Member2_RelationType == 2) || (r.VirsualMember2.Id == childId && r.Member2_RelationType == 3 && r.Member1_RelationType == 2)).FirstOrDefault();
                        if (motherofChild == null)
                        {
                            var sibllingOfChild = GetSiblings(childId);
                            foreach (var item in sibllingOfChild)
                            {
                                motherofChild = context.RelationShips.Where(r => (r.VirsualMember1.Id == item.Id && r.Member1_RelationType == 3 && r.Member2_RelationType == 2) || (r.VirsualMember2.Id == item.Id && r.Member2_RelationType == 3 && r.Member1_RelationType == 2)).FirstOrDefault();
                                if (motherofChild != null)
                                {
                                     Partner = motherofChild.VirsualMember1.Id != item.Id ? motherofChild.VirsualMember1 : motherofChild.VirsualMember2;

                                    break;
                                }
                            }
                        }

                        if (motherofChild!=null)
                            {
                            WindowMember partnerCard = new WindowMember();
                                if (Partner.Image != null)
                                    partnerCard.Image = Partner.Image;
                                else partnerCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                                partnerCard.FirestName = Partner.FirstName;
                                partnerCard.LastName = Partner.LastName;
                                if (Partner.Gender) partnerCard.Gender = "Female"; else partnerCard.Gender = "Male";
                                partnerCard.Age = DateTime.Now.Year - Partner.DateOfBirth.Year;
                                partnerCard.Id = Partner.Id;
                                partnerCard.Click += new EventHandler(WindoMember_Click);
                                DirectRelationsIds.Add(Partner.Id);
                                PartenerPanel.Controls.Add(partnerCard);
                            }
                        
                    }
                    else
                    {
                        //Get Father of any child

                        var FatherofChild = context.RelationShips.Where(r => (r.VirsualMember1.Id == childId && r.Member1_RelationType == 3 && r.Member2_RelationType == 5) || (r.VirsualMember2.Id == childId && r.Member2_RelationType == 3 && r.Member1_RelationType == 5)).FirstOrDefault();
                        if (FatherofChild == null)
                        {
                            var sibllingOfChild = GetSiblings(childId);
                            foreach (var item in sibllingOfChild)
                            {
                                FatherofChild = context.RelationShips.Where(r => (r.VirsualMember1.Id == item.Id && r.Member1_RelationType == 3 && r.Member2_RelationType == 5) || (r.VirsualMember2.Id == item.Id && r.Member2_RelationType == 3 && r.Member1_RelationType == 5)).FirstOrDefault();
                                if (FatherofChild != null)
                                {
                                    Partner = FatherofChild.VirsualMember1.Id != item.Id ? FatherofChild.VirsualMember1 : FatherofChild.VirsualMember2;

                                    break;
                                }
                            }
                        }

                        if (FatherofChild != null)
                        {
                            WindowMember partnerCard = new WindowMember();
                            if (Partner.Image != null)
                                partnerCard.Image = Partner.Image;
                            else partnerCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                            partnerCard.FirestName = Partner.FirstName;
                            partnerCard.LastName = Partner.LastName;
                            if (Partner.Gender) partnerCard.Gender = "Female"; else partnerCard.Gender = "Male";
                            partnerCard.Age = DateTime.Now.Year - Partner.DateOfBirth.Year;
                            partnerCard.Id = Partner.Id;
                            partnerCard.Click += new EventHandler(WindoMember_Click);
                            DirectRelationsIds.Add(Partner.Id);
                            PartenerPanel.Controls.Add(partnerCard);
                        }

                    }
                }
            }
        }

        private void LoadMother()
        {
            MotherPanel.Controls.Clear();
            //direct Mother Relation
            var MotherRelatoin = context.RelationShips.Where(r => (r.VirsualMember1.Id == SelectedMemberId && r.Member1_RelationType == 3 && r.Member2_RelationType == 2)||(r.VirsualMember2.Id == SelectedMemberId && r.Member2_RelationType == 3 && r.Member1_RelationType == 2)).FirstOrDefault();        
            if (MotherRelatoin != null)
            {
                var mother = MotherRelatoin.VirsualMember1.Id != SelectedMemberId ? MotherRelatoin.VirsualMember1 : MotherRelatoin.VirsualMember2;
                WindowMember motherCard = new WindowMember();
                if (mother.Image != null)
                    motherCard.Image = mother.Image;
                else motherCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                motherCard.FirestName = mother.FirstName;
                motherCard.LastName = mother.LastName;
                if (mother.Gender) motherCard.Gender = "Female"; else motherCard.Gender = "Male";
                motherCard.Age = DateTime.Now.Year - mother.DateOfBirth.Year;
                motherCard.Id = mother.Id;
                motherCard.Click += new EventHandler(WindoMember_Click);
                DirectRelationsIds.Add(mother.Id);

                MotherPanel.Controls.Add(motherCard);
            }
            else
            {
                //Get Mother of any sibling

                if (Siblings!=null)
                {
                    foreach (var sibling in Siblings)
                    {
                        MotherRelatoin = context.RelationShips.Where(r => (r.VirsualMember1.Id == sibling.Id && r.Member1_RelationType == 3 && r.Member2_RelationType == 2) || (r.VirsualMember2.Id == sibling.Id && r.Member2_RelationType == 3 && r.Member1_RelationType == 2)).FirstOrDefault();
                        if (MotherRelatoin != null)
                        {
                            var mother = MotherRelatoin.VirsualMember1.Id != SelectedMemberId ? MotherRelatoin.VirsualMember1 : MotherRelatoin.VirsualMember2;
                            WindowMember motherCard = new WindowMember();
                            if (mother.Image != null)
                                motherCard.Image = mother.Image;
                            else motherCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                            motherCard.FirestName = mother.FirstName;
                            motherCard.LastName = mother.LastName;
                            if (mother.Gender) motherCard.Gender = "Female"; else motherCard.Gender = "Male";
                            motherCard.Age = DateTime.Now.Year - mother.DateOfBirth.Year;
                            motherCard.Id = mother.Id;
                            motherCard.Click += new EventHandler(WindoMember_Click);
                            DirectRelationsIds.Add(mother.Id);
                            MotherPanel.Controls.Add(motherCard);
                            break;
                        }
                    }
                }
            }
        }

        private void LoadFather()
        {
            FatherPanel.Controls.Clear();
            //direct Father Relation
            var FatherRelatoin = context.RelationShips.Where(r => (r.VirsualMember1.Id == SelectedMemberId && r.Member1_RelationType == 3 && r.Member2_RelationType == 5) || (r.VirsualMember2.Id == SelectedMemberId && r.Member2_RelationType == 3 && r.Member1_RelationType == 5)).FirstOrDefault();
            if (FatherRelatoin != null)
            {
                var Father = FatherRelatoin.VirsualMember1.Id != SelectedMemberId ? FatherRelatoin.VirsualMember1 : FatherRelatoin.VirsualMember2;
                WindowMember FatherCard = new WindowMember();
                if (Father.Image != null)
                    FatherCard.Image = Father.Image;
                else FatherCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                FatherCard.FirestName = Father.FirstName;
                FatherCard.LastName = Father.LastName;
                if (Father.Gender) FatherCard.Gender = "Female"; else FatherCard.Gender = "Male";
                FatherCard.Age = DateTime.Now.Year - Father.DateOfBirth.Year;
                FatherCard.Id = Father.Id;
                FatherCard.Click += new EventHandler(WindoMember_Click);
                DirectRelationsIds.Add(Father.Id);

                FatherPanel.Controls.Add(FatherCard);
            }
            else
            {          
                //Get Father of any child
                if (Siblings != null)
                {
                    foreach (var sibling in Siblings)
                    {
                        FatherRelatoin = context.RelationShips.Where(r => (r.VirsualMember1.Id == sibling.Id && r.Member1_RelationType == 3 && r.Member2_RelationType == 5) || (r.VirsualMember2.Id == sibling.Id && r.Member2_RelationType == 3 && r.Member1_RelationType == 5)).FirstOrDefault();
                        if (FatherRelatoin != null)
                        {
                            var Father = FatherRelatoin.VirsualMember1.Id != sibling.Id ? FatherRelatoin.VirsualMember1 : FatherRelatoin.VirsualMember2;
                            WindowMember FatherCard = new WindowMember();
                            if (Father.Image != null)
                                FatherCard.Image = Father.Image;
                            else FatherCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                            FatherCard.FirestName = Father.FirstName;
                            FatherCard.LastName = Father.LastName;
                            if (Father.Gender) FatherCard.Gender = "Female"; else FatherCard.Gender = "Male";
                            FatherCard.Age = DateTime.Now.Year - Father.DateOfBirth.Year;
                            FatherCard.Id = Father.Id;
                            FatherCard.Click += new EventHandler(WindoMember_Click);
                            FatherPanel.Controls.Add(FatherCard);
                            DirectRelationsIds.Add(Father.Id);
                            break;
                        }
                    }
                }
            }
        }
        private void LoadChilds()
        {
            ChildsFlowLayoutPanel.Controls.Clear();
            var ChildRelatoin = context.RelationShips.Where(r => (r.VirsualMember1.Id == SelectedMemberId && r.Member2_RelationType == 3) || (r.VirsualMember2.Id == SelectedMemberId && r.Member1_RelationType == 3 )).FirstOrDefault();
            if (ChildRelatoin != null)
            {
                var Child = ChildRelatoin.VirsualMember1.Id != SelectedMemberId ? ChildRelatoin.VirsualMember1 : ChildRelatoin.VirsualMember2;
                var childSiblings = GetSiblings(Child.Id);
                childSiblings.Add(Child);
                foreach (var item in childSiblings)
                {

                    WindowMember childCard = new WindowMember();
                    if (item.Image != null)
                        childCard.Image = item.Image;
                    else childCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                    childCard.FirestName = item.FirstName;
                    childCard.LastName = item.LastName;
                    if (item.Gender) childCard.Gender = "Female"; else childCard.Gender = "Male";
                    childCard.Age = DateTime.Now.Year - item.DateOfBirth.Year;
                    childCard.Id = item.Id;
                    childCard.Click += new EventHandler(WindoMember_Click);
                    DirectRelationsIds.Add(item.Id);
                    ChildsFlowLayoutPanel.Controls.Add(childCard);

                }
                childId = Child.Id;
            } 
            else { childId = null; }
        }

        //Rest relations
        private void LoadIOtherRelations()
        {
            OthersflowLayoutPanel.Controls.Clear();
            var otherRelatoins = context.Members.Where(m => m.Family.Id == familyId && !(DirectRelationsIds.Contains(m.Id)) && m.Id!=SelectedMemberId).ToList();
            if (otherRelatoins != null)
            {
                foreach (var item in otherRelatoins)
                {

                    WindowMember otherRelatoinCard = new WindowMember();
                    if (item.Image != null)
                        otherRelatoinCard.Image = item.Image;
                    else otherRelatoinCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                    otherRelatoinCard.FirestName = item.FirstName;
                    otherRelatoinCard.LastName = item.LastName;
                        if (item.Gender) otherRelatoinCard.Gender = "Female"; else otherRelatoinCard.Gender = "Male";
                    otherRelatoinCard.Age = DateTime.Now.Year - item.DateOfBirth.Year;
                    otherRelatoinCard.Id = item.Id;
                    otherRelatoinCard.Click += new EventHandler(WindoMember_Click);
                        OthersflowLayoutPanel.Controls.Add(otherRelatoinCard);                  
                }
            }
        }

        //Save Siblings data to use it in another function
        private HashSet<Models.Member> GetSiblings(int? personId)
        {
            HashSet<Models.Member> result = new HashSet<Models.Member>();
            if (personId != null)
            {
                var SiblingRelatoins = context.RelationShips.Where(r => r.VirsualMember1.Id == personId || r.VirsualMember2.Id == personId).Where(r => r.Member1_RelationType == 4 || r.Member2_RelationType == 4).ToList();
                if (SiblingRelatoins != null)
                {
                    foreach (var item in SiblingRelatoins)
                    {
                        var Sibling = item.VirsualMember1.Id != personId ? item.VirsualMember1 : item.VirsualMember2;
                        result.Add(Sibling);
                        // get Siblings of sibling -- they are also siblings --
                        var OtherSiblingRelatoins = context.RelationShips.Where(r => (r.VirsualMember1.Id == Sibling.Id && r.VirsualMember1.Id != personId) || (r.VirsualMember2.Id == Sibling.Id && r.VirsualMember1.Id != personId)).Where(r => r.Member1_RelationType == 4 || r.Member2_RelationType == 4).ToList();
                        if (OtherSiblingRelatoins != null)
                        {
                            foreach (var item2 in OtherSiblingRelatoins)
                            {
                                var otherSibling = item2.VirsualMember1.Id != personId && item2.VirsualMember1.Id != Sibling.Id ? item2.VirsualMember1 : item2.VirsualMember2;
                                if (otherSibling.Id != personId) // to avoid insert selected member with siblings
                                {
                                    result.Add(otherSibling);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        private void LoadSiblings(int? personId )
        {
            Siblings = new List<Models.Member>();
            HashSet<Models.Member> result = new HashSet<Models.Member>();
            if (personId != null)
            {
                SiblingFlowLayoutPanel.Controls.Clear();
                var SiblingRelatoins = context.RelationShips.Where(r => r.VirsualMember1.Id == personId || r.VirsualMember2.Id == personId).Where(r => r.Member1_RelationType == 4 || r.Member2_RelationType == 4).ToList();
                if (SiblingRelatoins != null)
                {
                    foreach (var item in SiblingRelatoins)
                    {
                        var Sibling = item.VirsualMember1.Id != personId ? item.VirsualMember1 : item.VirsualMember2;
                        result.Add(Sibling);
                    
                        // get Siblings of sibling -- they are also siblings --
                        var OtherSiblingRelatoins = context.RelationShips.Where(r => (r.VirsualMember1.Id == Sibling.Id && r.VirsualMember1.Id != personId) || (r.VirsualMember2.Id == Sibling.Id && r.VirsualMember1.Id != personId)).Where(r => r.Member1_RelationType == 4 || r.Member2_RelationType == 4).ToList();
                        if (OtherSiblingRelatoins != null)
                        {
                            foreach (var item2 in OtherSiblingRelatoins)
                            {
                                var otherSibling = item2.VirsualMember1.Id != personId && item2.VirsualMember1.Id != Sibling.Id ? item2.VirsualMember1 : item2.VirsualMember2;
                                if (otherSibling.Id != personId) // to avoid insert selected member with siblings
                                {
                                    result.Add(otherSibling);
                                }
                            }
                        }
                    }
                    foreach (var Sibling in result)
                    {
                        WindowMember SiblingCard = new WindowMember();
                        if (Sibling.Image != null)
                            SiblingCard.Image = Sibling.Image;
                        else SiblingCard.Image = "C:/Users/Yomna/source/repos/Family_Tree/Family_Tree/Resources/blank-profile-picture-973460_640.png";
                        SiblingCard.FirestName = Sibling.FirstName;
                        SiblingCard.LastName = Sibling.LastName;
                        if (Sibling.Gender) SiblingCard.Gender = "Female"; else SiblingCard.Gender = "Male";
                        SiblingCard.Age = DateTime.Now.Year - Sibling.DateOfBirth.Year;
                        SiblingCard.Id = Sibling.Id;
                        SiblingCard.Click += new EventHandler(WindoMember_Click);
                        SiblingFlowLayoutPanel.Controls.Add(SiblingCard);
                        Siblings.Add(Sibling);
                        DirectRelationsIds.Add(Sibling.Id);
                    }
                }
            }
        }

        private void member_Click(object sender, EventArgs e)
        {
            DirectRelationsIds = new List<int>();
            var SelectedMember =(Member)sender;
            SelectedMemberId = SelectedMember.Id;
            familyId = context.Members.Find(SelectedMemberId).Family.Id;
            //Refresh
            LoadSelectMemberProfile();
            LoadSiblings(SelectedMemberId);
            LoadChilds();
            LoadPartner();
            LoadMother();
            LoadFather();
            LoadIOtherRelations();
        }
        private void WindoMember_Click(object sender, EventArgs e)
        {
            DirectRelationsIds = new List<int>();
            var SelectedMember = (WindowMember)sender;
            SelectedMemberId = SelectedMember.Id;
            familyId = context.Members.Find(SelectedMemberId).Family.Id;
            //Refresh
            LoadSelectMemberProfile();
            LoadSiblings(SelectedMemberId);
            LoadChilds();
            LoadPartner();
            LoadMother();
            LoadFather();
            LoadIOtherRelations();
        }





        private void UpdateIcon_Click(object sender, EventArgs e)
        {
            var member = context.Members.Find(SelectedMemberId);
            Form BackGround = new Form();
            try
            {
                using (AddMember popup = new AddMember())
                {

                    BackGround.StartPosition = this.StartPosition;
                    BackGround.Size = this.Size;
                    BackGround.FormBorderStyle = this.FormBorderStyle;
                    BackGround.Opacity = .80d;
                    BackGround.BackColor = Color.Black;
                    BackGround.Location = this.Location;
                    BackGround.Show();
                    popup.familyId = familyId;
                    popup.Owner = BackGround;
                    popup.edit = true;
                    popup.Fname = member.FirstName;
                    popup.Lname = member.LastName;
                    popup.Gender = member.Gender;
                    popup.DOB = member.DateOfBirth;
                    popup.imagePath = member.Image;
                    popup.MemberId = member.Id;
                    popup.ShowDialog();
                    BackGround.Dispose();
                    context.SaveChanges();
                   

                }
                


            }
            catch
            {
                MessageBox.Show("error with Add Form");
            }
            finally
            {
                BackGround.Dispose();
                LoadSelectMemberProfile();
                GetFamilyMembers();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form BackGround = new Form();
            try
            {
                using (AddMember popup = new AddMember())
                {

                    BackGround.StartPosition = this.StartPosition;
                    BackGround.Size = this.Size;
                    BackGround.FormBorderStyle = this.FormBorderStyle;
                    BackGround.Opacity = .80d;
                    BackGround.BackColor = Color.Black;
                    BackGround.Location = this.Location;
                    BackGround.Show();
                    popup.familyId = familyId;
                    popup.Owner = BackGround;
                    popup.edit = false;
                    popup.ShowDialog();
                    BackGround.Dispose();

                }
                GetFamilyMembers();
                LoadIOtherRelations();


            }
            catch
            {
                MessageBox.Show("error with Add Form");
            }
            finally
            {
                BackGround.Dispose();
            }
        }

        private void btn_AddFamily_Click(object sender, EventArgs e)
        {
            Form BackGround = new Form();
            try
            {
                using (AddFamily popup = new AddFamily())
                {

                    BackGround.StartPosition = this.StartPosition;
                    BackGround.Size = this.Size;
                    BackGround.FormBorderStyle = this.FormBorderStyle;
                    BackGround.Opacity = .80d;
                    BackGround.BackColor = Color.Black;
                    BackGround.Location = this.Location;
                    BackGround.Show();
                    popup.Owner = BackGround;
                    popup.Location = this.Location;
                    popup.ShowDialog();
                    BackGround.Dispose();
                    LoadFamilies();
                    GetFamilyMembers();
                }


            }
            catch
            {
                MessageBox.Show("error with Add Form");
            }
            finally
            {
                BackGround.Dispose();
            }
        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form BackGround = new Form();
            try
            {
                using (AddRelation popup = new AddRelation())
                {

                    BackGround.StartPosition = this.StartPosition;
                    BackGround.Size = this.Size;
                    BackGround.FormBorderStyle = this.FormBorderStyle;
                    BackGround.Opacity = .80d;
                    BackGround.BackColor = Color.Black;
                    BackGround.Show();
                    popup.Owner = BackGround;
                    popup.SelectedMemberId = SelectedMemberId;
                    popup.familyId = familyId;
                    popup.Location = this.Location;
                    popup.ShowDialog();
                    BackGround.Dispose();
                    //Refresh
                    LoadSiblings(SelectedMemberId);
                    LoadChilds();
                    LoadPartner();
                    LoadMother();
                    LoadFather();
                    LoadIOtherRelations();
                }

        }
            catch
            {
                MessageBox.Show("error with Add Form");
            }
            finally
            {
                BackGround.Dispose();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/yomna.hosny.37");
        }
    }
}
