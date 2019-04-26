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
    public partial class AdminGeneral : Form
    {
        public AdminGeneral()
        {
            InitializeComponent();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            AdminAnimal an = new AdminAnimal();
            an.Show();
            this.Hide();
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            AdminShelter As = new AdminShelter();
            As.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            AdminManagement AdminM = new AdminManagement();
            AdminM.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminUser au = new AdminUser();
            au.Show();
            this.Hide();
        }

        private void btnOtherThings_Click(object sender, EventArgs e)
        {
            AdminOtherThings aot = new AdminOtherThings();
            aot.Show();
            this.Hide();
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

        private void btnAddPart1_Click(object sender, EventArgs e)
        {
            AdminAddPartOne one = new AdminAddPartOne();
            one.Show();
            this.Hide();
        }
    }
}
