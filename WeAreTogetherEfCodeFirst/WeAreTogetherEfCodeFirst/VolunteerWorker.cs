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
        //With these properties we get our username and password from the login page
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
            tbxVolunteerName.Text = Username.ToString();
            tbxVolunteerName.Enabled = false;
            GetVolunteerId();
            GetManagementFoodsTable();
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
            DataTable d1 = new DataTable();
            d1.Columns.Add("Id");
            d1.Columns.Add("ManagementId");
            d1.Columns.Add("DateOfFood");
            d1.Columns.Add("DeliveryTime");
            d1.Columns.Add("SupplyDelivery");
            d1.Columns.Add("ResponsibleUser");

            foreach (var q in getFoodEntiries)
            {
                d1.Rows.Add(q.Id, q.ManagementId, q.DateOfFood, q.DeliveryTime, q.SupplyDelivery, q.ResponsibleUser);
            }
            dgwVoluteerWorker.DataSource = d1;
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
            DataTable d2 = new DataTable();
            d2.Columns.Add("animalName");
            d2.Columns.Add("shelterId");
            d2.Columns.Add("kindOfAnimal");
            d2.Columns.Add("pet");
            d2.Columns.Add("shelterName");
            d2.Columns.Add("sId");

            foreach (var q in getAnimalAndShelter)
            {
                d2.Rows.Add(q.animalName, q.shelterId, q.kindOfAnimal, q.pet, q.shelterName, q.shelterId);
            }
            dgwVoluteerWorker.DataSource = d2;
        }

        private void GetManagementAndUser()
        {
            var getManagement = from m in _wrt.Managements select m;
            var getUser = from u in _wrt.Users select u;
            var getManagementFood = from mf in _wrt.ManagementFoods select mf;
            var seeEveryone = from mf in getManagementFood
                              join m in getManagement on
                              mf.ManagementId equals m.Id
                              join u in getUser on mf.ResponsibleUser equals u.Id
                              select new
                              {
                                  managmntName = m.Name,
                                  managmntId = m.Id,
                                  userName = u.Name,
                                  userId = u.Id
                              };

            DataTable d3 = new DataTable();
            d3.Columns.Add("managmntName");
            d3.Columns.Add("managmntId");
            d3.Columns.Add("userName");
            d3.Columns.Add("userId");

            foreach (var q in seeEveryone)
            {
                d3.Rows.Add(q.managmntName, q.managmntId, q.userName, q.userId);
            }
            dgwVoluteerWorker.DataSource = d3;
        }



        private void cbxPickWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPickWorkType.SelectedIndex == 0)
            {
                GetManagementAndUser();
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
            if (cbxTrue.Checked == true)
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
        //To update the register which belong to user
        private void btnTakeMission_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[0].Value);
                _managementFood = _wrt.ManagementFoods.FirstOrDefault(mid => mid.Id == id);
                if (cbxTrue.Checked == true)
                {
                    _managementFood.SupplyDelivery = true;
                    int managementId = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[1].Value);
                    _management = _wrt.Managements.FirstOrDefault(mi => mi.Id == managementId);
                    _management.Point += 1;
                    _wrt.SubmitChanges();

                    int userId = Convert.ToInt32(tbxUserId.Text);
                    _user = _wrt.Users.FirstOrDefault(ui => ui.Id == userId);
                    _user.Point += 1;
                    _wrt.SubmitChanges();
                }
                else if (cbxFalse.Checked == true)
                {
                    _managementFood.SupplyDelivery = false;
                }
                _managementFood.DeliveryTime = dtpDeliveryTime.Value;
                _managementFood.ResponsibleUser = Convert.ToInt32(tbxUserId.Text);
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

        //To leave the register which belong to user
        private void btnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[5].Value) == Convert.ToInt32(tbxUserId.Text))
                {
                    int id = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[0].Value);
                    _managementFood = _wrt.ManagementFoods.FirstOrDefault(mid => mid.Id == id);
                    _managementFood.SupplyDelivery = false;
                    _managementFood.DeliveryTime = null;
                    _managementFood.ResponsibleUser = null;

                    int managementId = Convert.ToInt32(dgwVoluteerWorker.CurrentRow.Cells[1].Value);
                    _management = _wrt.Managements.FirstOrDefault(mi => mi.Id == managementId);
                    _management.Point -= 1;
                    _wrt.SubmitChanges();

                    int userId = Convert.ToInt32(tbxUserId.Text);
                    _user = _wrt.Users.FirstOrDefault(ui => ui.Id == userId);
                    _user.Point -= 1;
                    _wrt.SubmitChanges();

                    _wrt.SubmitChanges();
                    GetManagementFoodsTable();
                    cbxFalse.Checked = false;
                    cbxTrue.Checked = false;

                    MessageBox.Show("Register delivered successfully");
                }
                else
                {
                    MessageBox.Show("You cannot leave the register which isn't yours");
                }

            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void VolunteerWorker_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dtpDeliveryTime_ValueChanged(object sender, EventArgs e)
        {
            DateControl();
        }

        private void DateControl()
        {
            string currentTime = DateTime.Now.ToString();
            if (dtpDeliveryTime.Value < Convert.ToDateTime(currentTime))
            {
                dtpDeliveryTime.Value = Convert.ToDateTime(currentTime);
                MessageBox.Show("You cannot select an old date and time from the current time");
            }
            else
            {
                dtpDeliveryTime.Value = dtpDeliveryTime.Value;
            }
        }
    }
}
