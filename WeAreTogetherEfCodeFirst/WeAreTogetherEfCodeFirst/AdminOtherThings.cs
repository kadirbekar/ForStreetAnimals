using LinqToSql;
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
    public partial class AdminOtherThings : Form
    {
        public AdminOtherThings()
        {
            InitializeComponent();
        }
        PhoneType _phoneType = new PhoneType();
        ManagementType _managementType = new ManagementType();
        KindOfAnimal _kindOfAnimal = new KindOfAnimal();
        UserPhone _userPhone = new UserPhone();
        ManagementPhone _ManagementPhone = new ManagementPhone();
        ManagementShelter _ManagementShelter = new ManagementShelter();
        ResponsibleOfManagement _rOf = new ResponsibleOfManagement();
        ShelterOfUser _sOu = new ShelterOfUser();
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        DataTable _d1 = new DataTable();
        private void btnAddPart1_Click(object sender, EventArgs e)
        {
            PhoneType phoneType = new PhoneType();
            ManagementType managementType = new ManagementType();
            KindOfAnimal kindOfAnimal = new KindOfAnimal();
            
            try
            {
                if (cbxType.SelectedIndex == 0)
                {
                    phoneType.Name = tbxName.Text;
                    _wrt.PhoneTypes.InsertOnSubmit(phoneType);
                    _wrt.SubmitChanges();
                    GetPhoneTypes();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex==1)
                {
                    managementType.Name = tbxName.Text;
                    _wrt.ManagementTypes.InsertOnSubmit(managementType);
                    _wrt.SubmitChanges();
                    GetManagementTypes();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex==2)
                {
                    kindOfAnimal.Name = tbxName.Text;
                    _wrt.KindOfAnimals.InsertOnSubmit(kindOfAnimal);
                    _wrt.SubmitChanges();
                    GetKindOfAnimals();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
           
        }

        private void GetKindOfAnimals()
        {
            var a = from koa in _wrt.KindOfAnimals select koa;
            _d1.Rows.Clear();
            foreach (var entity in a)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        private void GetPhoneTypes()
        {
            var x = from p in _wrt.PhoneTypes select p;
            _d1.Rows.Clear();
            foreach (var entity in x)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        private void GetManagementTypes()
        {
            var y = from m in _wrt.ManagementTypes select m;
            _d1.Rows.Clear();
            foreach (var entity in y)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        private void btnAddPart2_Click(object sender, EventArgs e)
        {
            UserPhone userPhone = new UserPhone();
            ManagementPhone managementPhone = new ManagementPhone();
            ManagementShelter managementShelter = new ManagementShelter();
            ShelterOfUser shelterOfUser = new ShelterOfUser();
            ResponsibleOfManagement RoM = new ResponsibleOfManagement();
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    userPhone.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    userPhone.PhoneId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    userPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.UserPhones.InsertOnSubmit(userPhone);
                    _wrt.SubmitChanges();
                    MessageBox.Show("Entity deleted successfully");
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    managementPhone.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    managementPhone.PhoneTypeId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    managementPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.ManagementPhones.InsertOnSubmit(managementPhone);
                    _wrt.SubmitChanges();
                    MessageBox.Show("Entity deleted successfully");
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    managementShelter.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    managementShelter.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        managementShelter.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        managementShelter.Active = false;
                    }
                    _wrt.ManagementShelters.InsertOnSubmit(managementShelter);
                    _wrt.SubmitChanges();
                    MessageBox.Show("Entity deleted successfully");
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    RoM.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    RoM.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _wrt.ResponsibleOfManagements.InsertOnSubmit(RoM);
                    _wrt.SubmitChanges();
                    MessageBox.Show("Entity deleted successfully");
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    shelterOfUser.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    shelterOfUser.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked == true)
                    {
                        shelterOfUser.Active = true;
                    }
                    else if (cbxFalse.Checked == true)
                    {
                        shelterOfUser.Active = false;
                    }
                    _wrt.ShelterOfUsers.InsertOnSubmit(shelterOfUser);
                    _wrt.SubmitChanges();
                    MessageBox.Show("Entity deleted successfully");
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                }
            
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        private void AdminOtherThings_Load(object sender, EventArgs e)
        {
            GetUserId();
            GetPhoneTypeId();
            GetManagementId();
            GetShelterId();
            _d1.Columns.Add("Id");
            _d1.Columns.Add("Name");
        }


        private void GetShelterId()
        {
            var getShelterId = from s in _wrt.Shelters select s;
            cbxShelterId.DataSource = getShelterId.ToList();
            cbxShelterId.ValueMember = "Id";
        }

        private void GetManagementId()
        {
            var getManagementId = from m in _wrt.Managements select m;
            cbxManagementId.DataSource = getManagementId.ToList();
            cbxManagementId.ValueMember = "Id";
        }

        private void GetPhoneTypeId()
        {
            var getPhoneTypeId = from p in _wrt.PhoneTypes select p;
            cbxPhoneTypeId.DataSource = getPhoneTypeId.ToList();
            cbxPhoneTypeId.ValueMember = "Id";
        }

        private void GetUserId()
        {
            var getUserId = from u in _wrt.UserPhones select u;
            cbxUserId.DataSource = getUserId.ToList();
            cbxUserId.ValueMember = "Id";
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex==0)
            {
                GetPhoneTypes();
            }
            else if (cbxType.SelectedIndex==1)
            {
                GetManagementTypes();
            }
            else if (cbxType.SelectedIndex == 2)
            {
                GetKindOfAnimals();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxType.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _phoneType = _wrt.PhoneTypes.FirstOrDefault(p => p.Id == id);
                    _wrt.PhoneTypes.DeleteOnSubmit(_phoneType);
                    _wrt.SubmitChanges();
                    GetPhoneTypes();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _managementType = _wrt.ManagementTypes.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementTypes.DeleteOnSubmit(_managementType);
                    _wrt.SubmitChanges();
                    GetManagementTypes();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _kindOfAnimal = _wrt.KindOfAnimals.FirstOrDefault(p => p.Id == id);
                    _wrt.KindOfAnimals.DeleteOnSubmit(_kindOfAnimal);
                    _wrt.SubmitChanges();
                    GetKindOfAnimals();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void dgwOtherThings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbxType.SelectedIndex==0)
            {
                tbxName.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            }
            else if (cbxType.SelectedIndex == 1)
            {
                tbxName.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            }
            else if (cbxType.SelectedIndex == 2)
            {
                tbxName.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            }
            //else if (cbxList2.SelectedIndex==0)
            //{
            //    cbxUserId.Text = "";
            //    tbxNameIki.Text = "";
            //    cbxPhoneTypeId.Text = "";
            //    cbxUserId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            //    tbxNameIki.Text= Convert.ToString(dgwOtherThings.CurrentRow.Cells[2].Value);
            //    cbxPhoneTypeId.SelectedText= Convert.ToString(dgwOtherThings.CurrentRow.Cells[3].Value);
            //}
            //else if (cbxList2.SelectedIndex == 1)
            //{
            //    cbxManagementId.Text = "";
            //    cbxPhoneTypeId.Text = "";
            //    tbxNameIki.Text = "";
            //    cbxManagementId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            //    cbxPhoneTypeId.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[2].Value);
            //    tbxNameIki.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[3].Value);
            //}
            //else if (cbxList2.SelectedIndex == 2)
            //{
            //    cbxManagementId.Text = "";
            //    cbxShelterId.Text = "";
            //    cbxTrue.Checked = false;
            //    cbxFalse.Checked = false;
            //    cbxManagementId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            //    cbxShelterId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[2].Value);
            //    if (Convert.ToBoolean(dgwOtherThings.CurrentRow.Cells[3].Value) == true)
            //    {
            //        cbxTrue.Checked = true;
            //        cbxFalse.Checked = false;
            //    }
            //    else if (Convert.ToBoolean(dgwOtherThings.CurrentRow.Cells[3].Value) == true)
            //    {

            //        cbxFalse.Checked = true;
            //        cbxTrue.Checked = false;
            //    }
            //}
            //else if (cbxList2.SelectedIndex == 3)
            //{
            //    cbxUserId.Text = "";
            //    cbxManagementId.Text = "";
            //    cbxUserId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            //    cbxManagementId.Text = Convert.ToString(dgwOtherThings.CurrentRow.Cells[2].Value);
            //}
            //else if (cbxList2.SelectedIndex == 4)
            //{
            //    cbxUserId.Text = "";
            //    cbxShelterId.Text = "";
            //    cbxUserId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[1].Value);
            //    cbxShelterId.SelectedText = Convert.ToString(dgwOtherThings.CurrentRow.Cells[2].Value);
            //    if (Convert.ToBoolean(dgwOtherThings.CurrentRow.Cells[3].Value) == true)
            //    {
            //        cbxTrue.Checked = true;
            //        cbxFalse.Checked = false;
            //    }
            //    else if (Convert.ToBoolean(dgwOtherThings.CurrentRow.Cells[3].Value) == true)
            //    {
            //        cbxFalse.Checked = true;
            //        cbxTrue.Checked = false;
            //    }
            //}

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxType.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _phoneType = _wrt.PhoneTypes.FirstOrDefault(p => p.Id == id);
                    _phoneType.Name = tbxName.Text;
                    _wrt.SubmitChanges();
                    GetPhoneTypes();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _managementType = _wrt.ManagementTypes.FirstOrDefault(p => p.Id == id);
                    _managementType.Name = tbxName.Text;
                    _wrt.SubmitChanges();
                    GetManagementTypes();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _kindOfAnimal = _wrt.KindOfAnimals.FirstOrDefault(p => p.Id == id);
                    _kindOfAnimal.Name = tbxName.Text;
                    _wrt.SubmitChanges();
                    GetKindOfAnimals();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void cbxList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    GetUserPhone();
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    GetManagementPhone();
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    GetManagementShelter();
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    GetResponsibleOfManagement();
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    GetShelterOfUser();
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        private void GetUserPhone()
        {
            DataTable d4 = new DataTable();
            var getUserPhone = from up in _wrt.UserPhones select up;
            d4.Columns.Add("Id");
            d4.Columns.Add("UserId");
            d4.Columns.Add("PhoneNumber");
            d4.Columns.Add("PhoneId");
            foreach (var entity in getUserPhone)
            {
                d4.Rows.Add(entity.Id, entity.UserId, entity.PhoneNumber, entity.PhoneId);
            }
            dgwOtherThings.DataSource = d4;
        }

        private void GetShelterOfUser()
        {
            DataTable d5 = new DataTable();
            var s = from sou in _wrt.ShelterOfUsers select sou;
            d5.Columns.Add("Id");
            d5.Columns.Add("UserId");
            d5.Columns.Add("ShelterId");
            d5.Columns.Add("Active");
            foreach (var entity in s)
            {
                d5.Rows.Add(entity.Id, entity.UserId, entity.ShelterId, entity.Active);
            }
            dgwOtherThings.DataSource = d5;
        }

        private void GetResponsibleOfManagement()
        {
            DataTable d6 = new DataTable();
            var rop = from r in _wrt.ResponsibleOfManagements select r;
            d6.Columns.Add("Id");
            d6.Columns.Add("UserId");
            d6.Columns.Add("ManagementId");
            foreach (var entity in rop)
            {
                d6.Rows.Add(entity.Id, entity.UserId, entity.ManagementId);
            }
            dgwOtherThings.DataSource = d6;
        }

        private void GetManagementShelter()
        {
            DataTable d7 = new DataTable();
            var a = from ms in _wrt.ManagementShelters select ms;
            d7.Columns.Add("Id");
            d7.Columns.Add("ManagementId");
            d7.Columns.Add("ShelterId");
            d7.Columns.Add("Active");
            foreach (var entity in a)
            {
                d7.Rows.Add(entity.Id, entity.ManagementId, entity.ShelterId, entity.Active);
            }
            dgwOtherThings.DataSource = d7;
        }

        private void GetManagementPhone()
        {
            DataTable d8 = new DataTable();
            var y = from mp in _wrt.ManagementPhones select mp;
            d8.Columns.Add("Id");
            d8.Columns.Add("ManagementId");
            d8.Columns.Add("PhoneTypeId");
            d8.Columns.Add("PhoneNumber");
            foreach (var entity in y)
            {
                d8.Rows.Add(entity.Id, entity.ManagementId, entity.PhoneTypeId, entity.PhoneNumber);
            }
            dgwOtherThings.DataSource = d8;
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxList2.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _userPhone = _wrt.UserPhones.FirstOrDefault(p => p.Id == id);
                    _wrt.UserPhones.DeleteOnSubmit(_userPhone);
                    _wrt.SubmitChanges();
                    GetUserPhone();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _ManagementPhone = _wrt.ManagementPhones.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementPhones.DeleteOnSubmit(_ManagementPhone);
                    _wrt.SubmitChanges();
                    GetManagementPhone();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _ManagementShelter = _wrt.ManagementShelters.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementShelters.DeleteOnSubmit(_ManagementShelter);
                    _wrt.SubmitChanges();
                    GetManagementShelter();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _rOf = _wrt.ResponsibleOfManagements.FirstOrDefault(p => p.Id == id);
                    _wrt.ResponsibleOfManagements.DeleteOnSubmit(_rOf);
                    _wrt.SubmitChanges();
                    GetResponsibleOfManagement();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _sOu = _wrt.ShelterOfUsers.FirstOrDefault(p => p.Id == id);
                    _wrt.ShelterOfUsers.DeleteOnSubmit(_sOu);
                    _wrt.SubmitChanges();
                    GetShelterOfUser();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
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
                if (cbxList2.SelectedIndex==0)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _userPhone = _wrt.UserPhones.FirstOrDefault(up=>up.Id==id);
                    _userPhone.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _userPhone.PhoneId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _userPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.SubmitChanges();
                    GetUserPhone();
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _ManagementPhone = _wrt.ManagementPhones.FirstOrDefault(up => up.Id == id);
                    _ManagementPhone.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementPhone.PhoneTypeId = Convert.ToInt32(cbxPhoneTypeId.SelectedValue);
                    _ManagementPhone.PhoneNumber = tbxNameIki.Text;
                    _wrt.SubmitChanges();
                    GetManagementPhone();
                    tbxNameIki.Text = "";
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _ManagementShelter = _wrt.ManagementShelters.FirstOrDefault(up => up.Id == id);
                    _ManagementShelter.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _ManagementShelter.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked==true)
                    {
                        _ManagementShelter.Active = true;
                    }
                    else if (cbxFalse.Checked==true)
                    {
                        _ManagementShelter.Active = false;
                    }
                    _wrt.SubmitChanges();
                    GetManagementShelter();
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    cbxTrue.Checked = false;
                    cbxFalse.Checked = false;
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 3)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _rOf = _wrt.ResponsibleOfManagements.FirstOrDefault(up => up.Id == id);
                    _rOf.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _rOf.ManagementId = Convert.ToInt32(cbxManagementId.SelectedValue);
                    _wrt.SubmitChanges();
                    GetResponsibleOfManagement();
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
                    tbxNameIki.Text = "";
                    MessageBox.Show("Entity updated successfully");
                }
                else if (cbxList2.SelectedIndex == 4)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _sOu = _wrt.ShelterOfUsers.FirstOrDefault(up => up.Id == id);
                    _sOu.UserId = Convert.ToInt32(cbxUserId.SelectedValue);
                    _sOu.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                    if (cbxTrue.Checked==true)
                    {
                        _sOu.Active = true;
                    }
                    else if (cbxFalse.Checked==true)
                    {
                        _sOu.Active = false;
                    }
                    _wrt.SubmitChanges();
                    GetShelterOfUser();
                    GetUserId();
                    GetPhoneTypeId();
                    GetManagementId();
                    GetShelterId();
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

        private void adminUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUser au = new AdminUser();
            au.Show();
            this.Hide();
        }

        private void adminOtherThingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminOtherThings aot = new AdminOtherThings();
            aot.Show();
            this.Hide();
        }
    }
}
