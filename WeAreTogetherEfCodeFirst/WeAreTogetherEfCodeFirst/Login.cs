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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        WeAreTogetherDataContext _wrt = new WeAreTogetherDataContext();
        void Temizle()
        {
            foreach (Control item in gbxLogin.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            if (cbxUserType.SelectedIndex == 0)
            {
                var query = from p in _wrt.Users
                            where
                             p.Username == txtSurname.Text &&
                             p.Password == txtPassword.Text
                            select p;
                if (query.Any())
                {
                    VolunteerWorker Vw = new VolunteerWorker();
                    Vw.Show();
                    this.Hide();
                }
                else
                {
                    lblKontrol.Text = "Invalid entrance";
                    Temizle();
                }

            }
            else if (cbxUserType.SelectedIndex == 1)
            {
                var query = from p in _wrt.Managements
                            where
                             p.Username == txtSurname.Text &&
                             p.Password == txtPassword.Text
                            select p;
                if (query.Any())
                {
                    ManagementWorker Mw = new ManagementWorker();
                    Mw.Username = txtSurname.Text;
                    Mw.Password = txtPassword.Text;
                    Mw.Show();
                    this.Hide();
                }
                else
                {
                    lblKontrol.Text = "Invalid entrance";
                    Temizle();
                }
                
            }
            else if (cbxUserType.SelectedIndex == 2)
            {
                var query = from p in _wrt.Managers
                            where
                             p.Username == txtSurname.Text &&
                             p.Password == txtPassword.Text
                            select p;
                if (query.Any())
                {
                    AdminGeneral Ag = new AdminGeneral();
                    Ag.Show();
                    this.Hide();
                }
                else
                {
                    lblKontrol.Text = "Invalid entrance";
                    Temizle();
                }
                
            }
        }
    }
}
