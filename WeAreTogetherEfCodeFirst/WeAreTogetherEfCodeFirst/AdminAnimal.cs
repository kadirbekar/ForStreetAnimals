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
    public partial class AdminAnimal : Form
    {
        void Clear()
        {
            cbxKindOfAnimal.Text = "";
            cbxShelterId.Text = "";
            tbxName.Text = "";
            dtpAnimal.Text = "";
            tbxNote.Text = "";
            cbxTrue.Checked = false;
            cbxFalse.Checked = false;
            GetKindOfAnimals();
            GetShelterId();
        }
        public AdminAnimal()
        {
            InitializeComponent();
        }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        private void AdminAnimal_Load(object sender, EventArgs e)
        {
            GetAnimals();
            GetKindOfAnimals();
            GetShelterId();
        }

        private void GetKindOfAnimals()
        {
            var getKindOfAnimals = from koa in _wrt.KindOfAnimals select koa;
            cbxKindOfAnimal.ValueMember = "Id";
            cbxKindOfAnimal.DisplayMember = "Name";
            cbxKindOfAnimal.DataSource = getKindOfAnimals.ToList();
        }

        private void GetShelterId()
        {
            var getShelterId = from s in _wrt.Shelters select s;
            cbxShelterId.ValueMember = "Id";
            cbxShelterId.DataSource = getShelterId.ToList();
        }

        private void GetAnimals()
        {
            var getAnimals = from an in _wrt.Animals select an;
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("KindOfAnimalId");
            dt.Columns.Add("ShelterId");
            dt.Columns.Add("Name");
            dt.Columns.Add("DateOfRegister");
            dt.Columns.Add("Note");
            dt.Columns.Add("Pet");
            foreach (var animal in getAnimals)
            {
                dt.Rows.Add(animal.Id, animal.KindOfAnimalId, animal.ShelterId, animal.Name, animal.DateOfRegister, animal.Note, animal.Pet);
            }
            dgwAnimal.DataSource = dt;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal();
                animal.KindOfAnimalId = Convert.ToInt32(cbxKindOfAnimal.SelectedValue);
                animal.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                animal.Name = tbxName.Text;
                animal.DateOfRegister = dtpAnimal.Value;
                animal.Note = tbxNote.Text;
                if (cbxTrue.Checked == true)
                {
                    animal.Pet = true;
                }
                else if (cbxFalse.Checked == false)
                {
                    animal.Pet = false;
                }
                _wrt.Animals.InsertOnSubmit(animal);
                _wrt.SubmitChanges();
                GetAnimals();
                Clear();
                MessageBox.Show("Entity deleted successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
            
        }

        private void dgwAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var getAnimalAndShelterId = from a in _wrt.Animals where a.Id == Convert.ToInt32(dgwAnimal.CurrentRow.Cells[0].Value) select a;
            cbxKindOfAnimal.Text = "";
            cbxShelterId.Text = "";
            cbxKindOfAnimal.SelectedText = Convert.ToString(dgwAnimal.CurrentRow.Cells[1].Value);
            cbxKindOfAnimal.SelectedValue = Convert.ToInt32(getAnimalAndShelterId.ToList().First().KindOfAnimalId.ToString());
            cbxShelterId.SelectedText = Convert.ToString(dgwAnimal.CurrentRow.Cells[2].Value);
            cbxShelterId.SelectedValue = Convert.ToInt32(getAnimalAndShelterId.ToList().First().ShelterId.ToString());
            tbxName.Text = Convert.ToString(dgwAnimal.CurrentRow.Cells[3].Value);
            dtpAnimal.Value = Convert.ToDateTime(dgwAnimal.CurrentRow.Cells[4].Value);
            tbxNote.Text = Convert.ToString(dgwAnimal.CurrentRow.Cells[5].Value);
            if (Convert.ToBoolean(dgwAnimal.CurrentRow.Cells[6].Value) == true)
            {
                cbxTrue.Checked = true;
                cbxFalse.Checked = false;
            }
            else if (Convert.ToBoolean(dgwAnimal.CurrentRow.Cells[6].Value) == false)
            {
                cbxFalse.Checked = true;
                cbxTrue.Checked = false;
            }
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            try
            {
                int id = Convert.ToInt32(dgwAnimal.CurrentRow.Cells[0].Value);
                animal = _wrt.Animals.FirstOrDefault(a => a.Id == id);
                animal.KindOfAnimalId = Convert.ToInt32(cbxKindOfAnimal.SelectedValue);
                animal.ShelterId = Convert.ToInt32(cbxShelterId.SelectedValue);
                animal.Name = tbxName.Text;
                animal.DateOfRegister = dtpAnimal.Value;
                animal.Note = tbxNote.Text;
                if (cbxTrue.Checked == true)
                {
                    animal.Pet = true;
                }
                else if (cbxFalse.Checked == true)
                {
                    animal.Pet = false;
                }
                _wrt.SubmitChanges();
                GetAnimals();
                Clear();
                MessageBox.Show("Entity deleted successfully");
            }
            catch
            {
                MessageBox.Show("We got a problem on the system.Try it another time.");
            }
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal();
                int id = Convert.ToInt32(dgwAnimal.CurrentRow.Cells[0].Value);
                animal = _wrt.Animals.FirstOrDefault(a => a.Id == id);
                _wrt.Animals.DeleteOnSubmit(animal);
                _wrt.SubmitChanges();
                GetAnimals();
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
                cbxTrue.Checked = false;
                cbxFalse.Checked = true;
            }
        }
    }
}
