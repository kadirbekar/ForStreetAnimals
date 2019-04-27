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
        public string Username { get; set; }
        public string Password { get; set; }
        public string ManagementId { get; set; }
        private void cbxPickAList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPickAList.SelectedIndex == 0)
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
                    dt.Rows.Add(q.managmntName, q.managmntId,q.managmntCity,q.managmntShlterId, q.userName,q.userId);
                }
                dgwManagementWorker.DataSource = dt;
            }
            else if (cbxPickAList.SelectedIndex==1)
            {
                GetManagementFoodsTable();
            }
            else if (cbxPickAList.SelectedIndex==2)
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
            lblUsername.Text = Username+" signed";
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
                        SupplyDelivery=false
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
            //tbxManagementId.Text = Convert.ToString(dgwManagementWorker.CurrentRow.Cells[1].Value);
            dtpDateOfFood.Value = Convert.ToDateTime(dgwManagementWorker.CurrentRow.Cells[2].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new WeAreTogetherDataContext())
                {
                    //if (Convert.ToInt32(dgwManagementWorker.CurrentRow.Cells[1].Value)==Convert.ToInt32(tbxManagementId.Text))
                    //{
                        var managementFood = new ManagementFood
                        {
                            DateOfFood = dtpDateOfFood.Value
                        };
                        context.SubmitChanges();
                        GetManagementFoodsTable();
                        dtpDateOfFood.Text = "";
                        MessageBox.Show("Entity updated successfully");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("You cannot update the register which isn't yours");
                    //}
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }
    }
}
