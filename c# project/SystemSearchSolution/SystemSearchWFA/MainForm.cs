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
    public partial class MainForm : Form
    {
        const string folder2 = "Error Folder";
        private readonly SearchSystemEntities db;
        const string folder = "image";
        Person selectedPerson;
        User myUser;
        public MainForm(User user)
        {
            try
            {
                db = new SearchSystemEntities();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
            InitializeComponent();
            Directory.CreateDirectory(folder);
            myUser = user;
            Directory.CreateDirectory(folder2);
        }
        string path2 = Path.Combine(folder2, "error.txt");
        private void nationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NationalityForm nation = new NationalityForm();
                nation.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (myUser.RoleID == 2)
                {
                    btnRemove.Enabled = false;
                    removeToolStripMenuItem.Enabled = false;
                    catalogToolStripMenuItem.Enabled = false;
                    postionToolStripMenuItem.Enabled = false;
                }
                updateInfo();
                dtpIssueDate.MaxDate = DateTime.Now;
                dtpBirthDate.MaxDate = DateTime.Now;
                dtpExpiryDate.MinDate = DateTime.Now;
                cbxBloodGroup.DataSource = db.BloodGroups.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    Text = s.Value,
                    Value = s.ID
                }).Distinct().ToList();
                cbxEyeColor.DataSource = db.EyeColors.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    Text = s.ColorName,
                    Value = s.ID
                }).Distinct().ToList();
                cbxMarital.DataSource = db.MaritalStatus.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    Text = s.Name,
                    Value = s.ID
                }).Distinct().ToList();
                cbxMilitary.DataSource = db.MilitaryStatus.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    Text = s.Name,
                    Value = s.ID
                }).Distinct().ToList();
                cbxNationality.DataSource = db.Nationalities.Where(w => w.DeletedDate == null).Select(s => new ComboItem
                {
                    Text = s.Name,
                    Value = s.ID
                }).Distinct().ToList();
                cbxGender.DataSource = db.Genders.Select(w => new ComboItem
                {
                    Text = w.Name,
                    Value = w.ID
                }).Distinct().ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
        private void clearTxt()
        {
            try
            {
                tbxName.Text = "";
                tbxSurname.Text = "";
                tbxFatherName.Text = "";
                tbxBirthPlace.Text = "";
                tbxLivingPlace.Text = "";
                tbxSeries.Text = "";
                tbxNumber.Text = "";
                tbxIssueAuthority.Text = "";
                pictureBox1.Image = null;
                nudHeight.Value = 50;
                errorProviderMain.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
        private void updateInfo()
        {
            try
            {
                dgvPerson.DataSource = db.People.Where(w => w.DeletedDate == null).Select(s => new
                {
                    ID = s.ID,
                    NSF = s.FirstName + " " + s.LastName + " " + s.FatherName,
                    BirthPlace = s.BirthPlace,
                    BirthDate = s.BirthofDate,
                    Gender = s.Gender.Name,
                    Nationality = s.Nationality.Name,
                    BloodGroup = s.BloodGroup.Value,
                    MaritalStatus = s.MaritalStatu.Name,
                    Height = s.Height,
                    MilitaryStatus = s.MilitaryStatu.Name,
                    EyeColor = s.EyeColor.ColorName,
                    LivingPlace = s.LivingPlace,
                    IssueDate = s.IssueDate,
                    ExpiryDate = s.ExpiryDate,
                    Series = s.Series,
                    Number = s.Number,
                    IssueAuthority = s.IssuingAuthority
                }).ToList();
                dgvPerson.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                BloodGroupForm bloodGroupForm = new BloodGroupForm();
                bloodGroupForm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void eyeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EyeColorForm eye = new EyeColorForm();
                eye.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void maritalStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaritalStatusForm marital = new MaritalStatusForm();
                marital.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void militaryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MilitaryStatusForm military = new MilitaryStatusForm();
                military.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                var result = openImage.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openImage.FileName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxName.Text))
                {
                    errorProviderMain.SetError(tbxName, "Enter Name!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSurname.Text))
                {
                    errorProviderMain.SetError(tbxSurname, "Enter Surname!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSeries.Text))
                {
                    errorProviderMain.SetError(tbxSeries, "Enter Series!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxNumber.Text))
                {
                    errorProviderMain.SetError(tbxNumber, "Enter Number!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxIssueAuthority.Text))
                {
                    errorProviderMain.SetError(tbxIssueAuthority, "Enter Authority!");
                    return;
                }
                else
                {
                    ComboItem nation = cbxNationality.SelectedItem as ComboItem;
                    ComboItem blood = cbxBloodGroup.SelectedItem as ComboItem;
                    ComboItem military = cbxMilitary.SelectedItem as ComboItem;
                    ComboItem marital = cbxMarital.SelectedItem as ComboItem;
                    ComboItem eye = cbxEyeColor.SelectedItem as ComboItem;
                    ComboItem gender = cbxGender.SelectedItem as ComboItem;
                    Person newPerson = new Person
                    {
                        FirstName = tbxName.Text,
                        LastName = tbxSurname.Text,
                        FatherName = tbxFatherName.Text,
                        BirthPlace = tbxBirthPlace.Text,
                        BirthofDate = dtpBirthDate.Value,
                        EyeColorID = eye.Value,
                        NationalityID = nation.Value,
                        BloodGroupID = blood.Value,
                        MaritalStatusID = marital.Value,
                        MilitaryStatusID = military.Value,
                        GenderID = gender.Value,
                        Height = (byte)nudHeight.Value,
                        LivingPlace = tbxLivingPlace.Text,
                        IssueDate = dtpIssueDate.Value,
                        ExpiryDate = dtpExpiryDate.Value,
                        Series = tbxSeries.Text,
                        Number = tbxNumber.Text,
                        IssuingAuthority = tbxIssueAuthority.Text
                    };
                    db.People.Add(newPerson);
                    db.SaveChanges();
                    string path = Path.Combine(folder, newPerson.ID + ".jpg");
                    pictureBox1.Image.Save(path);
                    updateInfo();
                    clearTxt();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
            {
                return;
            }
            try
            {
                int id = (int)dgvPerson.Rows[e.RowIndex].Cells[0].Value;
                selectedPerson = db.People.Where(w => w.ID == id).FirstOrDefault();
                btnAdd.Enabled = false;
                tbxName.Text = selectedPerson.FirstName;
                tbxSurname.Text = selectedPerson.LastName;
                tbxFatherName.Text = selectedPerson.FatherName;
                tbxBirthPlace.Text = selectedPerson.BirthPlace;
                dtpBirthDate.Value = (DateTime)selectedPerson.BirthofDate;
                nudHeight.Value = (int)selectedPerson.Height;
                tbxLivingPlace.Text = selectedPerson.LivingPlace;
                dtpIssueDate.Value = selectedPerson.IssueDate;
                dtpExpiryDate.Value = (DateTime)selectedPerson.ExpiryDate;
                tbxSeries.Text = selectedPerson.Series;
                tbxNumber.Text = selectedPerson.Number;
                tbxIssueAuthority.Text = selectedPerson.IssuingAuthority;
                cbxBloodGroup.SelectedValue = selectedPerson.BloodGroupID;
                cbxEyeColor.SelectedValue = selectedPerson.EyeColorID;
                cbxMarital.SelectedValue = selectedPerson.MaritalStatusID;
                cbxMilitary.SelectedValue = selectedPerson.MilitaryStatusID;
                cbxNationality.SelectedValue = selectedPerson.NationalityID;
                cbxGender.SelectedValue = selectedPerson.GenderID;
                string path = Path.Combine(folder, selectedPerson.ID + ".jpg");
                pictureBox1.Image = Image.FromFile(path);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxName.Text))
                {
                    errorProviderMain.SetError(tbxName, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSurname.Text))
                {
                    errorProviderMain.SetError(tbxSurname, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSeries.Text))
                {
                    errorProviderMain.SetError(tbxSeries, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxNumber.Text))
                {
                    errorProviderMain.SetError(tbxNumber, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxIssueAuthority.Text))
                {
                    errorProviderMain.SetError(tbxIssueAuthority, "Choose Person from Table!");
                    return;
                }
                else
                {
                    ComboItem nation = cbxNationality.SelectedItem as ComboItem;
                    ComboItem blood = cbxBloodGroup.SelectedItem as ComboItem;
                    ComboItem military = cbxMilitary.SelectedItem as ComboItem;
                    ComboItem marital = cbxMarital.SelectedItem as ComboItem;
                    ComboItem eye = cbxEyeColor.SelectedItem as ComboItem;
                    ComboItem gender = cbxGender.SelectedItem as ComboItem;
                    selectedPerson.FirstName = tbxName.Text;
                    selectedPerson.LastName = tbxSurname.Text;
                    selectedPerson.FatherName = tbxFatherName.Text;
                    selectedPerson.BirthPlace = tbxBirthPlace.Text;
                    selectedPerson.BirthofDate = dtpBirthDate.Value;
                    selectedPerson.NationalityID = nation.Value;
                    selectedPerson.BloodGroupID = blood.Value;
                    selectedPerson.MilitaryStatusID = military.Value;
                    selectedPerson.MaritalStatusID = marital.Value;
                    selectedPerson.GenderID = gender.Value;
                    selectedPerson.EyeColorID = eye.Value;
                    selectedPerson.Height = (byte)nudHeight.Value;
                    selectedPerson.LivingPlace = tbxLivingPlace.Text;
                    selectedPerson.IssueDate = dtpIssueDate.Value;
                    selectedPerson.ExpiryDate = dtpExpiryDate.Value;
                    selectedPerson.Series = tbxSeries.Text;
                    selectedPerson.Number = tbxNumber.Text;
                    selectedPerson.IssuingAuthority = tbxIssueAuthority.Text;
                    db.SaveChanges();
                    updateInfo();
                    clearTxt();
                    pictureBox1.Image = null;
                    btnAdd.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxName.Text))
                {
                    errorProviderMain.SetError(tbxName, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSurname.Text))
                {
                    errorProviderMain.SetError(tbxSurname, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSeries.Text))
                {
                    errorProviderMain.SetError(tbxSeries, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxNumber.Text))
                {
                    errorProviderMain.SetError(tbxNumber, "Choose Person from Table!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxIssueAuthority.Text))
                {
                    errorProviderMain.SetError(tbxIssueAuthority, "Choose Person from Table!");
                    return;
                }
                else
                {
                    selectedPerson.DeletedDate = DateTime.Now;
                    db.SaveChanges();
                    updateInfo();
                    clearTxt();
                    btnAdd.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm();
            rolesForm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
        int count = 0;
        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {

                count++;
                if (count > dgvPerson.Rows.Count - 1)
                {
                    MessageBox.Show("End of Table!");
                    return;
                }
                else
                {
                    dgvPerson.CurrentCell = dgvPerson.Rows[count].Cells[1];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (count == 0)
                {
                    MessageBox.Show("End of Table");
                    return;
                }
                if (count > dgvPerson.Rows.Count - 1)
                {
                    count = dgvPerson.Rows.Count - 1;
                }
                else
                {
                    count--;
                    dgvPerson.CurrentCell = dgvPerson.Rows[count].Cells[1];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTxt();
            btnAdd.Enabled = true;
        }

        private void dgvPerson_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvPerson.Rows[e.RowIndex].Cells[0].Value;
                selectedPerson = db.People.Where(w => w.ID == id).FirstOrDefault();
                tbxName.Text = selectedPerson.FirstName;
                tbxSurname.Text = selectedPerson.LastName;
                tbxFatherName.Text = selectedPerson.FatherName;
                tbxBirthPlace.Text = selectedPerson.BirthPlace;
                dtpBirthDate.Value = (DateTime)selectedPerson.BirthofDate;
                nudHeight.Value = (int)selectedPerson.Height;
                tbxLivingPlace.Text = selectedPerson.LivingPlace;
                dtpIssueDate.Value = selectedPerson.IssueDate;
                dtpExpiryDate.Value = (DateTime)selectedPerson.ExpiryDate;
                tbxSeries.Text = selectedPerson.Series;
                tbxNumber.Text = selectedPerson.Number;
                tbxIssueAuthority.Text = selectedPerson.IssuingAuthority;
                cbxBloodGroup.SelectedValue = selectedPerson.BloodGroupID;
                cbxEyeColor.SelectedValue = selectedPerson.EyeColorID;
                cbxMarital.SelectedValue = selectedPerson.MaritalStatusID;
                cbxMilitary.SelectedValue = selectedPerson.MilitaryStatusID;
                cbxNationality.SelectedValue = selectedPerson.NationalityID;
                cbxGender.SelectedValue = selectedPerson.GenderID;
                string path = Path.Combine(folder, selectedPerson.ID + ".jpg");
                pictureBox1.Image = Image.FromFile(path);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path2, "\n" + ex + ":" + DateTime.Now);
                return;
            }
        }
    }
}
