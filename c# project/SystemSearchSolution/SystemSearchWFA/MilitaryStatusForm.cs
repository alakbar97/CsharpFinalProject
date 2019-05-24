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
    public partial class MilitaryStatusForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        MilitaryStatu selectedMilitary;
        public MilitaryStatusForm()
        {
            InitializeComponent();
            db = new SearchSystemEntities();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void updateInfo()
        {
            dgvMilitary.DataSource = db.MilitaryStatus.Select(s => new { s.ID, s.Name, s.DeletedDate }).ToList();
            dgvMilitary.Columns["ID"].Visible = false;
        }
        private void clearTxt()
        {
            tbxMilitary.Text = "";
        }
        private void MilitaryStatusForm_Load(object sender, EventArgs e)
        {
            updateInfo();
        }

        private void dgvMilitary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvMilitary.Rows[e.RowIndex].Cells[0].Value;
            selectedMilitary = db.MilitaryStatus.Where(w => w.ID == id).FirstOrDefault();
            tbxMilitary.Text = selectedMilitary.Name;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxMilitary.Text))
                {
                    errorProviderMilitary.SetError(tbxMilitary, "Add Military Status!");
                    return;
                }
                else
                {
                    MilitaryStatu military = new MilitaryStatu
                    {
                        Name = tbxMilitary.Text
                    };
                    db.MilitaryStatus.Add(military);
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
                if (string.IsNullOrWhiteSpace(tbxMilitary.Text))
                {
                    errorProviderMilitary.SetError(tbxMilitary, "Choose Military Status!");
                    return;
                }
                else
                {
                    string name = tbxMilitary.Text;
                    selectedMilitary.Name = name;
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
                string name = tbxMilitary.Text;
                if (string.IsNullOrWhiteSpace(tbxMilitary.Text))
                {
                    errorProviderMilitary.SetError(tbxMilitary, "Choose Military Status!");
                    return;
                }
                else
                {
                    selectedMilitary.DeletedDate = DateTime.Now;
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
