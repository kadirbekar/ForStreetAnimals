﻿using LinqToSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAreTogetherEfCodeFirst
{
    public partial class AdminAddPartOne : Form
    {
        public AdminAddPartOne()
        {
            InitializeComponent();
        }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        UserPhone _userPhone = new UserPhone();
        ManagementPhone _ManagementPhone = new ManagementPhone();
        ManagementShelter _ManagementShelter = new ManagementShelter();
        ResponsibleOfManagement _rOf = new ResponsibleOfManagement();
        ShelterOfUser _sOu = new ShelterOfUser();

        private void AdminAddPartOne_Load(object sender, EventArgs e)
        {
            GetManagementName();
            GetUserName();
            GetShelterName();
            GetPhoneTypeName();
        }

        private void cbxList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxList2.SelectedIndex==0)
            {
                GetUserPhoneTable();
            }
            else if (cbxList2.SelectedIndex==1)
            {
                GetManagementPhoneTable();
            }
            else if (cbxList2.SelectedIndex==2)
            {
                GetManagementShelterTable();
            }
            else if (cbxList2.SelectedIndex==3)
            {
                GetResponsibleOfManagementTable();
            }
            else if (cbxList2.SelectedIndex==4)
            {
                GetShelterOfUserTable();
            }
        }

        //We've created o new method to get Management's id numbers
        private void GetManagementName()
        {
            var name = from m in _wrt.Managements select m;
            cbxManagementId.DataSource = name.ToList();
            cbxManagementId.ValueMember = "Id";
            cbxManagementId.DisplayMember = "Name";
        }

        private void GetUserName()
        {
            var name = from u in _wrt.Users select u;
            cbxUserId.DataSource = name.ToList();
            cbxUserId.ValueMember = "Id";
            cbxUserId.DisplayMember = "Name";
        }

        private void GetShelterName()
        {
            var name = from s in _wrt.Shelters select s;
            cbxShelterId.DataSource = name.ToList();
            cbxShelterId.ValueMember = "Id";
            cbxShelterId.DisplayMember = "Name";
        }

        private void GetPhoneTypeName()
        {
            var name = from r in _wrt.PhoneTypes select r;
            cbxPhoneTypeId.DataSource = name.ToList();
            cbxPhoneTypeId.ValueMember = "Id";
            cbxPhoneTypeId.DisplayMember = "Name";
        }

        //Getting userphone table with that method
        private void GetUserPhoneTable()
        {
            DataTable d1 = new DataTable();
            var getUserPhone = from up in _wrt.UserPhones select up;
            d1.Columns.Add("Id");
            d1.Columns.Add("User");
            d1.Columns.Add("PhoneNumber");
            d1.Columns.Add("PhoneType");
            foreach (var entity in getUserPhone)
            {
                var getUserId = from u in _wrt.Users where entity.UserId == u.Id select u;
                string userName = getUserId.ToList()[0].Name.ToString();
                var phoneTypeId = from pt in _wrt.PhoneTypes where pt.Id == entity.PhoneId select pt;
                string phoneTypeName = phoneTypeId.ToList()[0].Name.ToString();
                d1.Rows.Add(entity.Id, userName, entity.PhoneNumber, phoneTypeName);
            }
            dgwAddPart.DataSource = d1;
        }

        private void GetShelterOfUserTable()
        {
            DataTable d2 = new DataTable();
            var s = from sou in _wrt.ShelterOfUsers select sou;
            d2.Columns.Add("Id");
            d2.Columns.Add("User");
            d2.Columns.Add("Shelter");
            d2.Columns.Add("Active");
            foreach (var entity in s)
            {
                var getUserId = from u in _wrt.Users where entity.UserId == u.Id select u;
                string userName = getUserId.ToList()[0].Name.ToString();
                var shelterId = from sh in _wrt.Shelters where sh.Id == entity.ShelterId select sh;
                string shelterName = shelterId.ToList()[0].Name.ToString();
                d2.Rows.Add(entity.Id, userName, shelterName, entity.Active);
            }
            dgwAddPart.DataSource = d2;
        }

        private void GetResponsibleOfManagementTable()
        {
            DataTable d3 = new DataTable();
            var rop = from r in _wrt.ResponsibleOfManagements select r;
            d3.Columns.Add("Id");
            d3.Columns.Add("User");
            d3.Columns.Add("Management");
            foreach (var entity in rop)
            {
                var getUserId = from u in _wrt.Users where entity.UserId == u.Id select u;
                string userName = getUserId.ToList()[0].Name.ToString();
                var managementId = from m in _wrt.Managements where m.Id == entity.ManagementId select m;
                string managementName = managementId.ToList()[0].Name.ToString();
                d3.Rows.Add(entity.Id, userName, managementName);
            }
            dgwAddPart.DataSource = d3;
        }

        private void GetManagementShelterTable()
        {
            DataTable d4 = new DataTable();
            var getMs = from ms in _wrt.ManagementShelters select ms;
            d4.Columns.Add("Id");
            d4.Columns.Add("Management");
            d4.Columns.Add("ShelterId");
            d4.Columns.Add("Active");
            foreach (var entity in getMs)
            {
                var managementId = from m in _wrt.Managements where m.Id == entity.ManagementId select m;
                string managementName = managementId.ToList()[0].Name.ToString();
                //var shelterId = from sh in _wrt.Shelters where sh.Id == entity.ShelterId select sh;
                //string shelterName = shelterId.ToList()[0].Name.ToString();
                d4.Rows.Add(entity.Id, managementName, entity.ShelterId, entity.Active);
            }
            dgwAddPart.DataSource = d4;
        }

        private void GetManagementPhoneTable()
        {
            DataTable d5 = new DataTable();
            var y = from mp in _wrt.ManagementPhones select mp;
            d5.Columns.Add("Id");
            d5.Columns.Add("Management");
            d5.Columns.Add("PhoneType");
            d5.Columns.Add("PhoneNumber");
            foreach (var entity in y)
            {
                var managementId = from m in _wrt.Managements where m.Id == entity.ManagementId select m;
                string managementName = managementId.ToList()[0].Name.ToString();
                var phoneTypeId = from pt in _wrt.PhoneTypes where pt.Id == entity.PhoneTypeId select pt;
                string phoneTypeName = phoneTypeId.ToList()[0].Name.ToString();
                d5.Rows.Add(entity.Id, managementName, phoneTypeName, entity.PhoneNumber);
            }
            dgwAddPart.DataSource = d5;
        }


        private void adminAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAnimal an = new AdminAnimal();
            an.Show();
            this.Hide();
        }

        private void adminShelterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminShelter As = new AdminShelter();
            As.Show();
            this.Hide();
        }

        private void adminManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminManagement AdminM = new AdminManagement();
            AdminM.Show();
            this.Hide();
        }

        private void adminOtherThingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUser au = new AdminUser();
            au.Show();
            this.Hide();
        }

        private void adminOtherThingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminOtherThings aot = new AdminOtherThings();
            aot.Show();
            this.Hide();
        }

        private void adminAddPart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddPartOne one = new AdminAddPartOne();
            one.Show();
            this.Hide();
        }

        private void cbxFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFalse.Checked==true)
            {
                cbxFalse.Checked = true;
                cbxTrue.Checked = false;
            }
        }

        private void cbxTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTrue.Checked==true)
            {
                cbxTrue.Checked = true;
                cbxFalse.Checked = false;
            }
        }

        private void btnAddPart2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    _userPhone.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _userPhone.PhoneId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _userPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.UserPhones.InsertOnSubmit(_userPhone);
                    _wrt.SubmitChanges();
                    GetUserPhoneTable();
                    MessageBox.Show("Entity added successfully");
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    _ManagementPhone.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementPhone.PhoneTypeId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _ManagementPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.ManagementPhones.InsertOnSubmit(_ManagementPhone);
                    _wrt.SubmitChanges();
                    GetManagementPhoneTable();
                    MessageBox.Show("Entity added successfully");
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    _ManagementShelter.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementShelter.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        _ManagementShelter.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        _ManagementShelter.Active = false;
                    }
                    _wrt.ManagementShelters.InsertOnSubmit(_ManagementShelter);
                    _wrt.SubmitChanges();
                    GetManagementShelterTable();
                    MessageBox.Show("Entity added successfully");
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    _rOf.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _rOf.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _wrt.ResponsibleOfManagements.InsertOnSubmit(_rOf);
                    _wrt.SubmitChanges();
                    GetResponsibleOfManagementTable();
                    MessageBox.Show("Entity added successfully");
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    _sOu.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _sOu.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        _sOu.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        _sOu.Active = false;
                    }
                    _wrt.ShelterOfUsers.InsertOnSubmit(_sOu);
                    _wrt.SubmitChanges();
                    GetShelterOfUserTable();
                    MessageBox.Show("Entity added successfully");
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        private void btUpdate2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _userPhone = _wrt.UserPhones.FirstOrDefault(up => up.Id == id);
                    _userPhone.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _userPhone.PhoneId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _userPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.SubmitChanges();
                    GetUserPhoneTable();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _ManagementPhone = _wrt.ManagementPhones.FirstOrDefault(up => up.Id == id);
                    _ManagementPhone.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementPhone.PhoneTypeId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _ManagementPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.SubmitChanges();
                    GetManagementPhoneTable();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _ManagementShelter = _wrt.ManagementShelters.FirstOrDefault(up => up.Id == id);
                    _ManagementShelter.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementShelter.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        _ManagementShelter.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        _ManagementShelter.Active = false;
                    }
                    _wrt.SubmitChanges();
                    GetManagementShelterTable();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _rOf = _wrt.ResponsibleOfManagements.FirstOrDefault(up => up.Id == id);
                    _rOf.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _rOf.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _wrt.SubmitChanges();
                    GetResponsibleOfManagementTable();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _sOu = _wrt.ShelterOfUsers.FirstOrDefault(up => up.Id == id);
                    _sOu.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _sOu.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        _sOu.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        _sOu.Active = false;
                    }
                    _wrt.SubmitChanges();
                    GetShelterOfUserTable();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                    MessageBox.Show("Entity updated successfully");
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _userPhone = _wrt.UserPhones.FirstOrDefault(p => p.Id == id);
                    _wrt.UserPhones.DeleteOnSubmit(_userPhone);
                    _wrt.SubmitChanges();
                    GetUserPhoneTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxNameIki.Text = "";
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _ManagementPhone = _wrt.ManagementPhones.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementPhones.DeleteOnSubmit(_ManagementPhone);
                    _wrt.SubmitChanges();
                    GetManagementPhoneTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxNameIki.Text = "";
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _ManagementShelter = _wrt.ManagementShelters.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementShelters.DeleteOnSubmit(_ManagementShelter);
                    _wrt.SubmitChanges();
                    GetManagementShelterTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxNameIki.Text = "";
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _rOf = _wrt.ResponsibleOfManagements.FirstOrDefault(p => p.Id == id);
                    _wrt.ResponsibleOfManagements.DeleteOnSubmit(_rOf);
                    _wrt.SubmitChanges();
                    GetResponsibleOfManagementTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxNameIki.Text = "";
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    int id = Convert.ToInt32(dgwAddPart.CurrentRow.Cells[0].Value);
                    _sOu = _wrt.ShelterOfUsers.FirstOrDefault(p => p.Id == id);
                    _wrt.ShelterOfUsers.DeleteOnSubmit(_sOu);
                    _wrt.SubmitChanges();
                    GetShelterOfUserTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxNameIki.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }


        //I got a problem here
        private void dgwAddPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (cbxList2.SelectedIndex == 0)
            //    {
            //        var id = from up in _wrt.UserPhones where up.UserId == Convert.ToInt32(dgwAddPart.CurrentRow.Cells[1].Value) select up;
            //        cbxUserId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[1].Value);
            //        cbxUserId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().UserId.ToString());
            //        tbxNameIki.Text = dgwAddPart.CurrentRow.Cells[2].Value.ToString();
            //        cbxPhoneTypeId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[3].Value);
            //        cbxPhoneTypeId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().PhoneId.ToString());
            //    }
            //    else if (cbxList2.SelectedIndex == 1)
            //    {
            //        var id = from mp in _wrt.ManagementPhones where mp.ManagementId == Convert.ToInt32(dgwAddPart.CurrentRow.Cells[1].Value) select mp;
            //        cbxManagementId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[1].Value);
            //        cbxManagementId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().ManagementId.ToString());
            //        cbxPhoneTypeId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[2].Value);
            //        cbxPhoneTypeId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().PhoneTypeId.ToString());
            //        tbxNameIki.Text = dgwAddPart.CurrentRow.Cells[3].Value.ToString();
            //    }
            //    else if (cbxList2.SelectedIndex == 2)
            //    {
            //        var id = from ms in _wrt.ManagementShelters where ms.ManagementId == Convert.ToInt32(dgwAddPart.CurrentRow.Cells[1].Value) select ms;
            //        cbxManagementId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[1].Value);
            //        cbxManagementId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().ManagementId.ToString());
            //        cbxShelterId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[2].Value);
            //        cbxShelterId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().ShelterId.ToString());
            //        if (Convert.ToBoolean(dgwAddPart.CurrentRow.Cells[3].Value) == true)
            //        {
            //            cbxTrue.Checked = true;
            //            cbxFalse.Checked = false;
            //        }
            //        else if (Convert.ToBoolean(dgwAddPart.CurrentRow.Cells[3].Value) == false)
            //        {
            //            cbxFalse.Checked = true;
            //            cbxTrue.Checked = false;
            //        }
            //    }
            //    else if (cbxList2.SelectedIndex == 3)
            //    {
            //        var id = from rom in _wrt.ResponsibleOfManagements where rom.ManagementId == Convert.ToInt32(dgwAddPart.CurrentRow.Cells[1].Value) select rom;
            //        cbxManagementId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[1].Value);
            //        cbxManagementId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().ManagementId.ToString());
            //        cbxUserId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[2].Value);
            //        cbxUserId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().UserId.ToString());
            //    }
            //    else if (cbxList2.SelectedIndex == 4)
            //    {
            //        var id = from sou in _wrt.ShelterOfUsers where sou.UserId == Convert.ToInt32(dgwAddPart.CurrentRow.Cells[1].Value) select sou;
            //        cbxUserId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[1].Value);
            //        cbxUserId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().UserId.ToString());
            //        cbxShelterId.SelectedText = Convert.ToString(dgwAddPart.CurrentRow.Cells[2].Value);
            //        cbxShelterId.SelectedValue = Convert.ToInt32(id.ToList().FirstOrDefault().ShelterId.ToString());
            //        if (Convert.ToBoolean(dgwAddPart.CurrentRow.Cells[3].Value) == true)
            //        {
            //            cbxTrue.Checked = true;
            //            cbxFalse.Checked = false;
            //        }
            //        else if (Convert.ToBoolean(dgwAddPart.CurrentRow.Cells[3].Value) == false)
            //        {
            //            cbxFalse.Checked = true;
            //            cbxTrue.Checked = false;
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("We got a problem on the system.Try it another time.");
            //}
            
        }

        private void AdminAddPartOne_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseTheForm(e);
        }

        private void CloseTheForm(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wanna exit from application", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login lgn = new Login();
                lgn.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
