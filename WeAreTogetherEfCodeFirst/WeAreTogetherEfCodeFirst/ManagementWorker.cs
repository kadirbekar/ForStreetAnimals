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
    public partial class ManagementWorker : Form
    {
        public ManagementWorker()
        {
            InitializeComponent();
        }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        ManagementFood _managementFood = new ManagementFood();
        public string Username { get; set; }
        public string Password { get; set; }
        private void cbxPickAList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPickAList.SelectedIndex == 0)
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

                DataTable dt = new DataTable();
                dt.Columns.Add("managmntName");
                dt.Columns.Add("managmntId");
                dt.Columns.Add("userName");
                dt.Columns.Add("userId");

                foreach (var q in seeEveryone)
                {
                    dt.Rows.Add(q.managmntName, q.managmntId, q.userName, q.userId);
                }
                dgwManagementWorker.DataSource = dt;
            }
            else if (cbxPickAList.SelectedIndex == 1)
            {
                GetManagementFoodsTable();
            }
            else if (cbxPickAList.SelectedIndex == 2)
            {
                GetAnimalAndShelters();
            }

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
            dgwManagementWorker.DataSource = dt;
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
            dgwManagementWorker.DataSource = dt;
        }

        private void ManagementWorker_Load(object sender, EventArgs e)
        {
            lblPassword.Visible = false;
            lblUsername.Text = Username + " signed";
            lblPassword.Text = Password;
            GetManagementId();
            GetManagementFoodsTable();
            tbxManagementId.Enabled = false;
        }

        private void GetManagementId()
        {
            var managementId = from mi in _wrt.Managements where mi.Username == Username && mi.Password == Password select mi;
            int id = Convert.ToInt32(managementId.ToList()[0].Id.ToString());
            tbxManagementId.Text = id.ToString();
        }

        //We'll create a register on the griedview
        private void btnTakeMission_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new WeAreTogetherDataContext())
                {
                    var managementFood = new ManagementFood
                    {
                        ManagementId = Convert.ToInt32(tbxManagementId.Text),
                        DateOfFood = dtpDateOfFood.Value,
                        SupplyDelivery = false
                    };
                    context.ManagementFoods.InsertOnSubmit(managementFood);
                    context.SubmitChanges();
                    GetManagementFoodsTable();
                    dtpDateOfFood.Text = "";
                    MessageBox.Show("Entity added successfully");
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }

        }

        private void dgwManagementWorker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDateOfFood.Value = Convert.ToDateTime(dgwManagementWorker.CurrentRow.Cells[2].Value);
        }

        //We can update our register with that button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwManagementWorker.CurrentRow.Cells[1].Value) == Convert.ToInt32(tbxManagementId.Text))
                {
                    int id = Convert.ToInt32(dgwManagementWorker.CurrentRow.Cells[0].Value);
                    _managementFood = _wrt.ManagementFoods.FirstOrDefault(mf => mf.Id == id);
                    _managementFood.DateOfFood = dtpDateOfFood.Value;
                    _wrt.SubmitChanges();
                    GetManagementFoodsTable();
                    MessageBox.Show("Entity updated successfully");
                }
                else
                {
                    MessageBox.Show("You cannot update the register which isn't yours");
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgwManagementWorker.CurrentRow.Cells[1].Value) == Convert.ToInt32(tbxManagementId.Text))
                {
                    int id = Convert.ToInt32(dgwManagementWorker.CurrentRow.Cells[0].Value);
                    _managementFood = _wrt.ManagementFoods.FirstOrDefault(mif => mif.Id == id);
                    _wrt.ManagementFoods.DeleteOnSubmit(_managementFood);
                    _wrt.SubmitChanges();
                    GetManagementFoodsTable();
                    MessageBox.Show("Entity deleted successfully");
                }
                else
                {
                    MessageBox.Show("You cannot delete the register which isn't yours");
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void ManagementWorker_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dtpDateOfFood_ValueChanged(object sender, EventArgs e)
        {
            DateControl();
        }

        private void DateControl()
        {
            string currentTime = DateTime.Now.ToString();
            if (dtpDateOfFood.Value < Convert.ToDateTime(currentTime))
            {
                dtpDateOfFood.Value = Convert.ToDateTime(currentTime);
                MessageBox.Show("You cannot select an old date and time from the current time");
            }
            else
            {
                dtpDateOfFood.Value = dtpDateOfFood.Value;
            }
        }
    }
}

