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
    public partial class VolunteerWorker : Form
    {
        public VolunteerWorker()
        {
            InitializeComponent();
        }
        public string Username { get; set; }
        public string Password { get; set; }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        ManagementFood _managementFood = new ManagementFood();
        Management _management = new Management();
        User _user = new User();
        private void VolunteerWorker_Load(object sender, EventArgs e)
        {
            tbxUserId.Enabled = false;
            lblUsername.Text = Username + " signed";
            GetVolunteerId();
        }

        private void GetVolunteerId()
        {
            var getVolunteerId = from Vw in _wrt.Users where Vw.Username == Username && Vw.Password == Password select Vw;
            int id = Convert.ToInt32(getVolunteerId.ToList()[0].Id.ToString());
            tbxUserId.Text = id.ToString();
        }

        private void GetManagementFoodsTable()
        {
            var getFoodEntiries = from mf in _wrt.ManagementFoods select mf;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("ManagementId");
            dt.Columns.Add("DateOfFood");
            dt.Columns.Add("DeliveryTime");
            dt.Columns.Add("SupplyDelivery");
            dt.Columns.Add("ResponsibleUser");

            foreach (var q in getFoodEntiries)
            {
                dt.Rows.Add(q.Id, q.ManagementId, q.DateOfFood, q.DeliveryTime, q.SupplyDelivery, q.ResponsibleUser);
            }
            dgwVoluteerWorker.DataSource = dt;
        }

        private void GetAnimalAndShelters()
        {
            var getAnimalAndShelter = from a in _wrt.Animals
                                      join s in _wrt.Shelters on
                                      a.ShelterId equals s.Id
                                      select new
                                      {
                                          animalName = a.Name,
                                          shelterId = a.ShelterId,
                                          kindOfAnimal = a.KindOfAnimalId,
                                          pet = a.Pet,
                                          shelterName = s.Name,
                                          sId = s.Id
                                      };
            DataTable dt = new DataTable();
            dt.Columns.Add("animalName");
            dt.Columns.Add("shelterId");
            dt.Columns.Add("kindOfAnimal");
            dt.Columns.Add("pet");
            dt.Columns.Add("shelterName");
            dt.Columns.Add("sId");

            foreach (var q in getAnimalAndShelter)
            {
                dt.Rows.Add(q.animalName, q.shelterId, q.kindOfAnimal, q.pet, q.shelterName, q.sId);
            }
            dgwVoluteerWorker.DataSource = dt;
        }

        private void cbxPickWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPickWorkType.SelectedIndex == 0)
            {
                var getShelterOfUser = from sou in _wrt.ShelterOfUsers select sou;
                var getCity = from c in _wrt.Cities select c;
                var getManagement = from m in _wrt.Managements select m;
                var getManagementShelter = from ms in _wrt.ManagementShelters select ms;
                var getUser = from u in _wrt.Users select u;
                var getShelter = from sou in _wrt.Shelters select sou;
                var seeEveryone = from m in getManagement
                                  join ms in getManagementShelter on
                                  m.Id equals ms.ManagementId
                                  join s in getShelter on ms.ShelterId equals s.Id
                                  join sou in getShelterOfUser on s.Id equals sou.ShelterId
                                  join u in getUser on sou.UserId equals u.Id
                                  where (m.CityId == 11)
                                  select new
                                  {
                                      managmntName = m.Name,
                                      managmntId = m.Id,
                                      managmntCity = m.CityId,
                                      managmntShlterId = ms.ShelterId,
                                      userName = u.Name,
                                      userId = u.Id,
                                  };

                DataTable dt = new DataTable();
                dt.Columns.Add("managmntName");
                dt.Columns.Add("managmntId");
                dt.Columns.Add("managmntCity");
                dt.Columns.Add("managmntShlterId");
                dt.Columns.Add("userName");
                dt.Columns.Add("userId");

                foreach (var q in seeEveryone)
                {
                    dt.Rows.Add(q.managmntName, q.managmntId, q.managmntCity, q.managmntShlterId, q.userName, q.userId);
                }
                dgwVoluteerWorker.DataSource = dt;
            }
            else if (cbxPickWorkType.SelectedIndex == 1)
            {
                GetManagementFoodsTable();
            }
            else if (cbxPickWorkType.SelectedIndex == 2)
            {
                GetAnimalAndShelters();
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

        private void cbxFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFalse.Checked == true)
            {
                cbxFalse.Checked = true;
                cbxTrue.Checked = false;
            }
        }

        private void dgwVoluteerWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTakeMission_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[0].Value);
                _managementFood = _wrt.ManagementFoods.FirstOrDefault(mid => mid.Id == id);
                if (cbxTrue.Checked == true)
                {
                    _managementFood.SupplyDelivery = true;
                }
                else if (cbxFalse.Checked == true)
                {
                    _managementFood.SupplyDelivery = false;
                }
                _managementFood.DeliveryTime = dtpDeliveryTime.Value;
                _managementFood.ResponsibleUser = Convert.ToInt32(tbxUserId.Text);
                _wrt.SubmitChanges();

                int managementId = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[1].Value);
                _management = _wrt.Managements.FirstOrDefault(mi => mi.Id == managementId);
                _management.Point += 1;
                _wrt.SubmitChanges();

                int userId = Convert.ToInt32(tbxUserId.Text);
                _user = _wrt.Users.FirstOrDefault(ui => ui.Id == userId);
                _user.Point += 1;
                _wrt.SubmitChanges();


                GetManagementFoodsTable();
                cbxFalse.Checked = false;
                cbxTrue.Checked = false;
                MessageBox.Show("Register delivered successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[0].Value);
                _managementFood = _wrt.ManagementFoods.FirstOrDefault(mid => mid.Id == id);
                _managementFood.SupplyDelivery = false;
                _managementFood.DeliveryTime = null;
                _managementFood.ResponsibleUser = null;

                int managementId = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[1].Value);
                _management = _wrt.Managements.FirstOrDefault(mi => mi.Id == managementId);
                if (_management.Point==0)
                {
                    MessageBox.Show("You cannot leave any register anymore");
                }
                else
                {
                    _management.Point -= 1;
                }
                _wrt.SubmitChanges();

                int userId = Convert.ToInt32(tbxUserId.Text);
                _user = _wrt.Users.FirstOrDefault(ui => ui.Id == userId);
                if (_user.Point==0)
                {
                    MessageBox.Show("You cannot leave any register anymore");
                }
                else
                {
                    _user.Point -= 1;
                }
                _wrt.SubmitChanges();

                _wrt.SubmitChanges();
                GetManagementFoodsTable();
                cbxFalse.Checked = false;
                cbxTrue.Checked = false;

                MessageBox.Show("Register delivered successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }
    }
}
