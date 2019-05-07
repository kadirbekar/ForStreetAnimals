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
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }
        //We've created a instance to have DBContext connection
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        private void AdminUser_Load(object sender, EventArgs e)
        {
            GetUsers();
            GetCities(); 
        }

        //To clear our tools on the form
        public void Clear()
        {
            GetCities();
            GetDistricts();
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            dtpBirthday.Text = "";
            txtUsername.Text = "";
            txtIdentidyNumber.Text = "";
            txtPassword.Text = "";
            chcMale.Checked = false;
            chcFemale.Checked = false;
        }
        //We get our cities from database
        private void GetCities()
        {
            var query = from c in _wrt.Cities select c;
            cbxCity.DataSource = query.ToList();
            cbxCity.DisplayMember = "Name";
            cbxCity.ValueMember = "Id";
            GetDistricts();
        }

        //We get our users from database
        private void GetUsers()
        {
            var s1 = from x in _wrt.Users select x;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("IdentityNumber");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dt.Columns.Add("City");
            dt.Columns.Add("District");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Point");
            dt.Columns.Add("Address");
            
            foreach (var item in s1)
            {
                var getCityId = from x in _wrt.Cities where x.Id == item.CityId select x;
                string Cityname = getCityId.ToList()[0].Name.ToString();
                var getDistrictId = from x in _wrt.Districts where x.Id == item.DistrictId select x;
                string DistrictName = getDistrictId.ToList()[0].District1.ToString();
                dt.Rows.Add(item.Id, item.Name, item.Surname,item.IdentityNumber,item.Gender, item.Username, item.Password, Cityname, DistrictName, item.Birthday,item.Point,item.Address);
            }
            dgwAdminUser.DataSource = dt;
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDistricts();
        }

        //We get our districts from database
        private void GetDistricts()
        {
            if (cbxCity.SelectedIndex != -1)
            {
                var CityDistrics = from d in _wrt.Districts
                                   where
                                            d.City == Convert.ToInt32(cbxCity.SelectedValue)
                                   select d;
                cbxDistrict.ValueMember = "Id";
                cbxDistrict.DisplayMember = "District1";
                cbxDistrict.DataSource = CityDistrics;
            }
        }

        //Adding a new user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.CityId = Convert.ToInt32(cbxCity.SelectedValue);
                user.DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue);
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.IdentityNumber = txtIdentidyNumber.Text;
                if (chcMale.Checked==true)
                {
                    user.Gender = true;
                }
                else if (chcFemale.Checked==true)
                {
                    user.Gender = false;
                }
                user.Birthday = dtpBirthday.Value;
                user.Address = txtAddress.Text;
                user.Point = 0;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                _wrt.Users.InsertOnSubmit(user);
                _wrt.SubmitChanges();
                GetUsers();
                Clear();
                MessageBox.Show("Entity added successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }

        }

        //Getting information about users to the tools 
        private void dgwAdminUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var getCityAndDistrictId = from u in _wrt.Users where u.Id == Convert.ToInt32(dgwAdminUser.CurrentRow.Cells[0].Value) select u;
                cbxCity.Text = "";
                cbxDistrict.Text = "";
                txtName.Text = dgwAdminUser.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = dgwAdminUser.CurrentRow.Cells[2].Value.ToString();
                txtIdentidyNumber.Text = dgwAdminUser.CurrentRow.Cells[3].Value.ToString();
                if (Convert.ToBoolean(dgwAdminUser.CurrentRow.Cells[4].Value) == true)
                {
                    chcMale.Checked = true;
                    chcFemale.Checked = false;
                }
                else if (Convert.ToBoolean(dgwAdminUser.CurrentRow.Cells[4].Value) == false)
                {
                    chcFemale.Checked = true;
                    chcMale.Checked = false;
                }
                txtUsername.Text = dgwAdminUser.CurrentRow.Cells[5].Value.ToString();
                txtPassword.Text = dgwAdminUser.CurrentRow.Cells[6].Value.ToString();
                cbxCity.SelectedText = Convert.ToString(dgwAdminUser.CurrentRow.Cells[7].Value);
                cbxCity.SelectedValue = Convert.ToInt32(getCityAndDistrictId.ToList().FirstOrDefault().CityId.ToString());
                cbxDistrict.SelectedText = Convert.ToString(dgwAdminUser.CurrentRow.Cells[8].Value);
                cbxDistrict.SelectedValue = Convert.ToInt32(getCityAndDistrictId.ToList().FirstOrDefault().DistrictId.ToString());
                dtpBirthday.Value = Convert.ToDateTime(dgwAdminUser.CurrentRow.Cells[9].Value);
                txtAddress.Text = dgwAdminUser.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        //Deleting a user with their id number
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                int id = Convert.ToInt32(dgwAdminUser.CurrentRow.Cells[0].Value);
                user = _wrt.Users.FirstOrDefault(u => u.Id == id);
                _wrt.Users.DeleteOnSubmit(user);
                _wrt.SubmitChanges();
                GetUsers();
                Clear();
                MessageBox.Show("Entity deleted successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        //Updating a user with their id number
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
                User user = new User();
                try
                {
                    int id = Convert.ToInt32(dgwAdminUser.CurrentRow.Cells[0].Value);
                    user = _wrt.Users.FirstOrDefault(u => u.Id == id);
                    user.CityId = Convert.ToInt32(cbxCity.SelectedValue);
                    user.DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue);
                    user.Name = txtName.Text;
                    user.Surname = txtSurname.Text;
                    user.IdentityNumber = txtIdentidyNumber.Text;
                    if (chcMale.Checked == true)
                    {
                        user.Gender = true;
                    }
                    else if (chcFemale.Checked == true)
                    {
                        user.Gender = false;
                    }
                    user.Birthday = dtpBirthday.Value;
                    user.Address = txtAddress.Text;
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    _wrt.SubmitChanges();
                    GetUsers();
                    Clear();
                    MessageBox.Show("Entity updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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

        private void chcMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMale.Checked==true)
            {
                chcMale.Checked = true;
                chcFemale.Checked = false;
            }
        }

        private void chcFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chcFemale.Checked == true)
            {
                chcMale.Checked = false;
                chcFemale.Checked = true;
            }
        }

        private void adminAddPart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddPartOne one = new AdminAddPartOne();
            one.Show();
            this.Hide();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length<=0)
            {
                errorProvider.SetError(txtName,"This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (txtSurname.Text.Length <= 0)
            {
                errorProvider.SetError(txtSurname, "This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtIdentidyNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdentidyNumber.Text.Length<11 || txtIdentidyNumber.Text.Length > 11)
            {
                errorProvider.SetError(txtIdentidyNumber, "This field must have 11 character");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Length <= 0)
            {
                errorProvider.SetError(txtAddress, "This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Length <= 0)
            {
                errorProvider.SetError(txtUsername, "This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length <= 0)
            {
                errorProvider.SetError(txtPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void AdminUser_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtFindSomeone_TextChanged(object sender, EventArgs e)
        {
            searchSomeone(txtFindSomeone.Text);
        }
        public void searchSomeone(string valueToFind)
        {
            var searchSomeone = from u in _wrt.Users where u.Name.Contains(valueToFind) select u;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("IdentityNumber");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dt.Columns.Add("City");
            dt.Columns.Add("District");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Point");
            dt.Columns.Add("Address");

            foreach (var item in searchSomeone)
            {
                var getCityId = from x in _wrt.Cities where x.Id == item.CityId select x;
                string Cityname = getCityId.ToList()[0].Name.ToString();
                var getDistrictId = from x in _wrt.Districts where x.Id == item.DistrictId select x;
                string DistrictName = getDistrictId.ToList()[0].District1.ToString();
                dt.Rows.Add(item.Id, item.Name, item.Surname, item.IdentityNumber, item.Gender, item.Username, item.Password, Cityname, DistrictName, item.Birthday, item.Point, item.Address);
            }
            dgwAdminUser.DataSource = dt;
        }
    }
}
