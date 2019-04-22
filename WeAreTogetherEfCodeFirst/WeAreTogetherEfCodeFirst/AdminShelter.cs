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
    public partial class AdminShelter : Form
    {
        public AdminShelter()
        {
            InitializeComponent();
        }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        public void Clear()
        {
            tbxName.Text = "";
            tbxAddress.Text = "";
            tbxPhone.Text = "";
            GetCities();
            GetDistricts();
        }
        private void AdminShelter_Load(object sender, EventArgs e)
        {
            GetShelters();
            GetCities();
            GetDistricts();
        }

        private void GetShelters()
        {
            //We get our shelters from database
            var s1 = from x in _wrt.Shelters select x;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("CityId");
            dt.Columns.Add("DistrictId");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phone");

            foreach (var item in s1)
            {
                var s2 = from x in _wrt.Cities where x.Id == item.CityId select x;
                string Cityname = s2.ToList()[0].Name.ToString();
                var s3 = from x in _wrt.Districts where x.City == s2.ToList()[0].Id select x;
                string DistrictName = s3.ToList()[0].District1.ToString();
                dt.Rows.Add(item.Id, item.CityId, item.DistrictId, item.Name, item.Address, item.Phone);
            }
            dgwAdminShelter.DataSource = dt;
        }

        private void GetCities()
        {
            var query = from c in _wrt.Cities select c; //We get our cities from database
            cbxCity.DataSource = query.ToList();
            cbxCity.DisplayMember = "Name";
            cbxCity.ValueMember = "Id";
        }

        private void GetDistricts()
        {
            if (cbxCity.SelectedIndex!=1)
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

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDistricts();
        }

        private void dgwAdminShelter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var getCityAndDistrictId = from u in _wrt.Shelters where u.Id == Convert.ToInt32(dgwAdminShelter.CurrentRow.Cells[0].Value) select u;
            cbxCity.Text = "";
            cbxDistrict.Text = "";
            cbxCity.SelectedText = Convert.ToString(dgwAdminShelter.CurrentRow.Cells[1].Value);
            cbxCity.SelectedValue = Convert.ToInt32(getCityAndDistrictId.ToList().FirstOrDefault().CityId.ToString());
            cbxDistrict.SelectedText = Convert.ToString(dgwAdminShelter.CurrentRow.Cells[2].Value);
            cbxDistrict.SelectedValue = Convert.ToInt32(getCityAndDistrictId.ToList().FirstOrDefault().DistrictId.ToString());
            tbxName.Text = Convert.ToString(dgwAdminShelter.CurrentRow.Cells[3].Value);
            tbxAddress.Text = Convert.ToString(dgwAdminShelter.CurrentRow.Cells[4].Value);
            tbxPhone.Text = Convert.ToString(dgwAdminShelter.CurrentRow.Cells[5].Value);
        }

        private void btnAddShelter_Click(object sender, EventArgs e)
        {
            Shelter shelter = new Shelter();
            try
            {
                shelter.CityId = Convert.ToInt32(cbxCity.SelectedValue);
                shelter.DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue);
                shelter.Name = tbxName.Text;
                shelter.Address = tbxAddress.Text;
                shelter.Phone = tbxPhone.Text;
                _wrt.Shelters.InsertOnSubmit(shelter);
                _wrt.SubmitChanges();
                GetShelters();
                Clear();
                MessageBox.Show("Entity deleted successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        private void btnUpdateShelter_Click(object sender, EventArgs e)
        {
            Shelter shelter = new Shelter();
            try
            {
                int id = Convert.ToInt32(dgwAdminShelter.CurrentRow.Cells[0].Value);
                shelter = _wrt.Shelters.FirstOrDefault(s => s.Id == id);
                shelter.CityId = Convert.ToInt32(cbxCity.SelectedValue);
                shelter.DistrictId = Convert.ToInt32(cbxDistrict.SelectedValue);
                shelter.Name = tbxName.Text;
                shelter.Address = tbxAddress.Text;
                shelter.Phone = tbxPhone.Text;
                _wrt.SubmitChanges();
                GetShelters();
                Clear();
                MessageBox.Show("Entity deleted successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void btnDeleteShelter_Click(object sender, EventArgs e)
        {
            Shelter shelter = new Shelter();
            try
            {
                int id = Convert.ToInt32(dgwAdminShelter.CurrentRow.Cells[0].Value);
                shelter = _wrt.Shelters.FirstOrDefault(s=>s.Id==id);
                _wrt.Shelters.DeleteOnSubmit(shelter);
                _wrt.SubmitChanges();
                GetShelters();
                Clear();
                MessageBox.Show("Entity deleted successfully");
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
