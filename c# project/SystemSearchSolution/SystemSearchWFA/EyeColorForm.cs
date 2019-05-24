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
    public partial class EyeColorForm : Form
    {
        const string folder = "Error Folder";
        private readonly SearchSystemEntities db;
        EyeColor selectedEye;
        public EyeColorForm()
        {
            InitializeComponent();
            db = new SearchSystemEntities();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void EyeColorForm_Load(object sender, EventArgs e)
        {
            updateInfo();
        }
        private void updateInfo()
        {
            try
            {
            dgvEyeColor.DataSource = db.EyeColors.Select(s => new { s.ID, s.ColorName, s.DeletedDate }).ToList();
            dgvEyeColor.Columns["ID"].Visible = false;
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
            tbxEye.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxEye.Text))
                {
                    errorProviderEye.SetError(tbxEye, "Add Eye Color!");
                    return;
                }
                else
                {
                    EyeColor eye = new EyeColor
                    {
                        ColorName = tbxEye.Text
                    };
                    db.EyeColors.Add(eye);
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
                if (string.IsNullOrWhiteSpace(tbxEye.Text))
                {
                    errorProviderEye.SetError(tbxEye, "Choose Eye Color!");
                    return;
                }
                else
                {
                    string name = tbxEye.Text;
                    selectedEye.ColorName = name;
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

        private void dgvEyeColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dgvEyeColor.Rows[e.RowIndex].Cells[0].Value;
            selectedEye = db.EyeColors.Where(w => w.ID == id).FirstOrDefault();
            tbxEye.Text = selectedEye.ColorName;
            btnAdd.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                string name = tbxEye.Text;
                if (string.IsNullOrWhiteSpace(tbxEye.Text))
                {
                    errorProviderEye.SetError(tbxEye, "Choose Eye Color!");
                    return;
                }
                else
                {
                    selectedEye.DeletedDate = DateTime.Now;
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
