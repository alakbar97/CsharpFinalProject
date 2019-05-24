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
using SystemSearchWFA.Model;

namespace SystemSearchWFA
{
    public partial class BloodGroupForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        BloodGroup selectedBlood;
        public BloodGroupForm()
        {
            db = new SearchSystemEntities();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        private void updateInfo()
        {
            try
            {
                dgvBlood.DataSource = db.BloodGroups.Select(s => new { s.ID, s.Value, s.DeletedDate }).ToList();
                dgvBlood.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
        private void clearTxt()
        {
            tbxBlood.Text = "";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = tbxBlood.Text;
            if (string.IsNullOrWhiteSpace(tbxBlood.Text))
            {
                errorProviderBlood.SetError(tbxBlood, "Choose Blood Type");
                return;
            }
            else
            {
                selectedBlood.DeletedDate = DateTime.Now;
                db.SaveChanges();
                updateInfo();
                btnAdd.Enabled = true;
                clearTxt();
            }

        }

        private void BloodGroupForm_Load(object sender, EventArgs e)
        {
            updateInfo();
        }
        string path = Path.Combine(folder, "error.txt");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(tbxBlood.Text))
                {
                    errorProviderBlood.SetError(tbxBlood, "Enter Blood Type");
                    return;
                }
                else
                {
                    BloodGroup bloodGroup = new BloodGroup
                    {
                        Value = tbxBlood.Text
                    };
                    db.BloodGroups.Add(bloodGroup);
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

        private void dgvBlood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvBlood.Rows[e.RowIndex].Cells[0].Value;
            selectedBlood = db.BloodGroups.Where(w => w.ID == id).FirstOrDefault();
            tbxBlood.Text = selectedBlood.Value;
            btnAdd.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxBlood.Text))
            {
                errorProviderBlood.SetError(tbxBlood, "Choose Blood Type from Table");
                return;
            }
            else
            {
                string name = tbxBlood.Text;
                selectedBlood.Value = name;
                db.SaveChanges();
                updateInfo();
                clearTxt();
                btnAdd.Enabled = true;
            }
        }
    }
}
