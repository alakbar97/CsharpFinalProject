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
    public partial class NationalityForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        Nationality selectedNation;
        public NationalityForm()
        {
            db = new SearchSystemEntities();
            InitializeComponent();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void Nationality_Load(object sender, EventArgs e)
        {
            updateInfo();
        }
        private void updateInfo()
        {
            dgvNationality.DataSource = db.Nationalities.Select(s => new { s.ID, s.Name, s.DeletedDate }).ToList();
            dgvNationality.Columns["ID"].Visible = false;
        }
        private void clearTxt()
        {
            tbxNation.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxNation.Text;
                if (string.IsNullOrWhiteSpace(tbxNation.Text))
                {
                    errorProviderNation.SetError(tbxNation, "Add Nation Type!");
                    return;
                }
                else
                {
                    Nationality nationality = new Nationality
                    {
                        Name = name
                    };
                    db.Nationalities.Add(nationality);
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

        private void dgvNationality_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvNationality.Rows[e.RowIndex].Cells[0].Value;
            btnAdd.Enabled = false;
            selectedNation = db.Nationalities.Where(w => w.ID == id).FirstOrDefault();
            tbxNation.Text = selectedNation.Name;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxNation.Text;
                if (string.IsNullOrWhiteSpace(tbxNation.Text))
                {
                    errorProviderNation.SetError(tbxNation, "Add Nation Type!");
                    return;
                }
                else
                {
                    selectedNation.Name = name;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxNation.Text;
                if (string.IsNullOrWhiteSpace(tbxNation.Text))
                {
                    errorProviderNation.SetError(tbxNation, "Add Nation Type!");
                    return;
                }
                else
                {
                    selectedNation.DeletedDate = DateTime.Now;
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
