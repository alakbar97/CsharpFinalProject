using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSearchWFA.Model;
using SystemSearchWFA.Extension;
using System.IO;

namespace SystemSearchWFA
{
    public partial class UsersForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        User selectedUser;
        public UsersForm()
        {
            db = new SearchSystemEntities();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void UsersForm_Load(object sender, EventArgs e)
        {
            updateInfo();
            cbxRoles.DataSource = db.Roles.Select(s => new ComboItem { Text = s.Name, Value = s.ID }).ToList();
        }
        private void updateInfo()
        {
            dgvUsers.DataSource = db.Users.Select(s => new { s.ID, s.Email, s.Password, s.Role.Name, s.DeletedDate }).ToList();
            dgvUsers.Columns["ID"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
        }
        private void clearTxt()
        {
            tbxEmail.Text = "";
            tbxPassowrd.Text = "";
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvUsers.Rows[e.RowIndex].Cells[0].Value;
            selectedUser = db.Users.Where(w => w.ID == id).FirstOrDefault();
            btnAdd.Enabled = false;
            tbxEmail.Text = selectedUser.Email;
            tbxPassowrd.Text = selectedUser.Password;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    errorProviderEmail.SetError(tbxEmail, "Enter Email!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxPassowrd.Text))
                {
                    errorProviderPassword.SetError(tbxPassowrd, "Enter Password!");
                    return;
                }
                else
                {
                    string password = tbxPassowrd.Text;
                    string myPassword = Extension.Password.HashPassword(password);
                    ComboItem roleId = cbxRoles.SelectedItem as ComboItem;
                    User newUser = new User
                    {
                        Email = tbxEmail.Text,
                        Password = myPassword,
                        RoleID = roleId.Value
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    updateInfo();
                    clearTxt();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    errorProviderEmail.SetError(tbxEmail, "Choose User from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxPassowrd.Text))
                {
                    errorProviderEmail.SetError(tbxPassowrd, "Choose User from Table!");
                    return;
                }
                else
                {
                    ComboItem roleId = cbxRoles.SelectedItem as ComboItem;
                    string password = tbxPassowrd.Text;
                    string myPassword = Extension.Password.HashPassword(password);
                    selectedUser.Email = tbxEmail.Text;
                    selectedUser.Password = myPassword;
                    selectedUser.RoleID = roleId.Value;
                    db.SaveChanges();
                    updateInfo();
                    clearTxt();
                    btnAdd.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    errorProviderEmail.SetError(tbxEmail, "Choose User from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxPassowrd.Text))
                {
                    errorProviderEmail.SetError(tbxPassowrd, "Choose User from Table!");
                    return;
                }
                else
                {
                    selectedUser.DeletedDate = DateTime.Now;
                    db.SaveChanges();
                    updateInfo();
                    clearTxt();
                    btnAdd.Enabled = true;
                }
            }
           catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
    }
}
