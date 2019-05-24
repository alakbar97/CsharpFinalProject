using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemSearchWFA.Extension;
using SystemSearchWFA.Model;

namespace SystemSearchWFA
{
    public partial class RolesForm : Form
    {
        private readonly SearchSystemEntities db;
        Role selectedRole;
        const string folder = "Error Folder";
        public RolesForm()
        {
            db = new SearchSystemEntities();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void updateInfo()
        {
            dgvRoles.DataSource = db.Roles.Select(s => new { s.ID, s.Name, s.DeletedDate }).ToList();
            dgvRoles.Columns["ID"].Visible = false;
        }
        private void clearTxt()
        {
            tbxRoles.Text = "";
        }
        private void RolesForm_Load(object sender, EventArgs e)
        {
            updateInfo();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxRoles.Text))
                {
                    errorProviderRoles.SetError(tbxRoles, "Add Roles Type!");
                    return;
                }
                else
                {
                    Role role = new Role
                    {
                        Name = tbxRoles.Name
                    };
                    db.Roles.Add(role);
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

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvRoles.Rows[e.RowIndex].Cells[0].Value;
            selectedRole = db.Roles.Where(w => w.ID == id).FirstOrDefault();
            tbxRoles.Text = selectedRole.Name;
            btnAdd.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxRoles.Text))
                {
                    errorProviderRoles.SetError(tbxRoles, "Choose Roles Type!");
                    return;
                }
                else
                {
                    selectedRole.Name = tbxRoles.Text;
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
                if (string.IsNullOrWhiteSpace(tbxRoles.Text))
                {
                    errorProviderRoles.SetError(tbxRoles, "Choose Roles Type!");
                    return;
                }
                else
                {
                    selectedRole.DeletedDate = DateTime.Now;
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
