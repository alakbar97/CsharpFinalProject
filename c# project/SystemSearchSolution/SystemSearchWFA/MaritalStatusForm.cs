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
    public partial class MaritalStatusForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        MaritalStatu selectedMarital;
        public MaritalStatusForm()
        {
            InitializeComponent();
            db = new SearchSystemEntities();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void MaritalStatusForm_Load(object sender, EventArgs e)
        {
            updateInfo();
        }
        private void updateInfo()
        {
            try
            {
                dgvMarital.DataSource = db.MaritalStatus.Select(s => new { s.ID, s.Name, s.DeletedDate }).ToList();
                dgvMarital.Columns["ID"].Visible = false;

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
            tbxMarital.Text = "";
        }
        private void dgvMarital_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                int id = (int)dgvMarital.Rows[e.RowIndex].Cells[0].Value;
                selectedMarital = db.MaritalStatus.Where(w => w.ID == id).FirstOrDefault();
                tbxMarital.Text = selectedMarital.Name;
                btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxMarital.Text))
                {
                    errorProviderMarital.SetError(tbxMarital, "Add Marital Status!");
                    return;
                }
                else
                {
                    MaritalStatu marital = new MaritalStatu
                    {
                        Name = tbxMarital.Text
                    };
                    db.MaritalStatus.Add(marital);
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

                if (string.IsNullOrWhiteSpace(tbxMarital.Text))
                {
                    errorProviderMarital.SetError(tbxMarital, "Choose Marital Status!");
                    return;
                }
                else
                {
                    string name = tbxMarital.Text;
                    selectedMarital.Name = name;
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
                string name = tbxMarital.Text;
                if (string.IsNullOrWhiteSpace(tbxMarital.Text))
                {
                    errorProviderMarital.SetError(tbxMarital, "Choose Marital Status!");
                    return;
                }
                else
                {
                    selectedMarital.DeletedDate = DateTime.Now;
                    db.SaveChanges();
                    updateInfo();
                    btnAdd.Enabled = true;
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
    }
}
