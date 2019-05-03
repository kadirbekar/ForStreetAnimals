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

        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();

        //With that DataTable we list our 3 tables on the griedview
        DataTable _d1 = new DataTable();

        private void btnAddPart1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxType.SelectedIndex == 0)
                {
                    _phoneType.Name = tbxName.Text;
                    _wrt.PhoneTypes.InsertOnSubmit(_phoneType);
                    _wrt.SubmitChanges();
                    GetPhoneTypesTable();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex==1)
                {
                    _managementType.Name = tbxName.Text;
                    _wrt.ManagementTypes.InsertOnSubmit(_managementType);
                    _wrt.SubmitChanges();
                    GetManagementTypesTable();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex==2)
                {
                    _kindOfAnimal.Name = tbxName.Text;
                    _wrt.KindOfAnimals.InsertOnSubmit(_kindOfAnimal);
                    _wrt.SubmitChanges();
                    GetKindOfAnimalsTable();
                    MessageBox.Show("Entity added successfully");
                    tbxName.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
           
        }

        private void GetKindOfAnimalsTable()
        {
            var a = from koa in _wrt.KindOfAnimals select koa;
            _d1.Rows.Clear();
            foreach (var entity in a)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        private void GetPhoneTypesTable()
        {
            var x = from p in _wrt.PhoneTypes select p;
            _d1.Rows.Clear();
            foreach (var entity in x)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        //We get our management types table with that method
        private void GetManagementTypesTable()
        {
            var y = from m in _wrt.ManagementTypes select m;
            _d1.Rows.Clear();
            foreach (var entity in y)
            {
                _d1.Rows.Add(entity.Id, entity.Name);
            }
            dgwOtherThings.DataSource = _d1;
        }

        private void AdminOtherThings_Load(object sender, EventArgs e)
        {
            _d1.Columns.Add("Id");
            _d1.Columns.Add("Name");
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex==0)
            {
                GetPhoneTypesTable();
            }
            else if (cbxType.SelectedIndex==1)
            {
                GetManagementTypesTable();
            }
            else if (cbxType.SelectedIndex == 2)
            {
                GetKindOfAnimalsTable();
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
                    GetPhoneTypesTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _managementType = _wrt.ManagementTypes.FirstOrDefault(p => p.Id == id);
                    _wrt.ManagementTypes.DeleteOnSubmit(_managementType);
                    _wrt.SubmitChanges();
                    GetManagementTypesTable();
                    MessageBox.Show("Entity deleted successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _kindOfAnimal = _wrt.KindOfAnimals.FirstOrDefault(p => p.Id == id);
                    _wrt.KindOfAnimals.DeleteOnSubmit(_kindOfAnimal);
                    _wrt.SubmitChanges();
                    GetKindOfAnimalsTable();
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
                    GetPhoneTypesTable();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 1)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _managementType = _wrt.ManagementTypes.FirstOrDefault(p => p.Id == id);
                    _managementType.Name = tbxName.Text;
                    _wrt.SubmitChanges();
                    GetManagementTypesTable();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
                }
                else if (cbxType.SelectedIndex == 2)
                {
                    int id = Convert.ToInt32(dgwOtherThings.CurrentRow.Cells[0].Value);
                    _kindOfAnimal = _wrt.KindOfAnimals.FirstOrDefault(p => p.Id == id);
                    _kindOfAnimal.Name = tbxName.Text;
                    _wrt.SubmitChanges();
                    GetKindOfAnimalsTable();
                    MessageBox.Show("Entity updated successfully");
                    tbxName.Text = "";
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

        private void adminAddPart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAddPartOne one = new AdminAddPartOne();
            one.Show();
            this.Hide();
        }

        private void tbxName_Validating(object sender, CancelEventArgs e)
        {
            if (tbxName.Text.Length <= 0)
            {
                errorProvider.SetError(tbxName, "This field cannot be empty");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void AdminOtherThings_FormClosing(object sender, FormClosingEventArgs e)
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
