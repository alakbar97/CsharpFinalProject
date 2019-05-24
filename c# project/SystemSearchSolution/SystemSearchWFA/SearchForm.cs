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

namespace SystemSearchWFA
{
    public partial class SearchForm : Form
    {
        private readonly SearchSystemEntities db;
        public SearchForm()
        {
            db = new SearchSystemEntities();
            InitializeComponent();
        }
        private void updateInfo()
        {
            dgvSearch.DataSource = db.People.Select(s => new
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
                IssueAuthority = s.IssuingAuthority,
                DeletedDate = s.DeletedDate
            }).ToList();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
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
        List<Person> person;
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.FirstName.Contains(tbxName.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.FirstName.Contains(tbxName.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }


        }

        private void tbxSurname_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.LastName.Contains(tbxSurname.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.LastName.Contains(tbxSurname.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxFatherName_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.FatherName.Contains(tbxFatherName.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.FatherName.Contains(tbxFatherName.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxBirthPlace_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.BirthPlace.Contains(tbxBirthPlace.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.BirthPlace.Contains(tbxBirthPlace.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpBirthDate.Value.Date;
            if (dgvSearch.Rows.Count == 0)
            {
                
                person = db.People.Where(w => w.BirthofDate.Value == date).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.BirthofDate.Value == date).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem nation = cbxNationality.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.Nationality.Name == nation.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.Nationality.Name == nation.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxMarital_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem marital = cbxMarital.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.MaritalStatu.Name == marital.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.MaritalStatu.Name == marital.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxMilitary_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem military = cbxMilitary.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.MilitaryStatu.Name == military.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.MilitaryStatu.Name == military.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxEyeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem eye = cbxEyeColor.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.EyeColor.ColorName == eye.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.EyeColor.ColorName == eye.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxLivingPlace_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.LivingPlace.Contains(tbxLivingPlace.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.LivingPlace.Contains(tbxLivingPlace.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxSeries_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.Series.Contains(tbxSeries.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.Series.Contains(tbxSeries.Text)).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem gender = cbxGender.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.Gender.Name == gender.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.Gender.Name == gender.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void cbxBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboItem blood = cbxBloodGroup.SelectedItem as ComboItem;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.BloodGroup.Value == blood.Text).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.BloodGroup.Value == blood.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxIssueAuthority_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.IssuingAuthority.Contains(tbxIssueAuthority.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.IssuingAuthority == tbxIssueAuthority.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.Height==nudHeight.Value).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.Height == nudHeight.Value).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void tbxNumber_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.Number.Contains(tbxNumber.Text)).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.Number == tbxNumber.Text).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpIssueDate.Value.Date;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w=>w.IssueDate.Date==date).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.IssueDate.Date == date).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }

        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dtpExpiryDate.Value.Date;
            if (dgvSearch.Rows.Count == 0)
            {
                person = db.People.Where(w => w.ExpiryDate.Value == date).ToList();
                dgvSearch.DataSource = person.Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
            else
            {
                dgvSearch.DataSource = person.Where(w => w.ExpiryDate.Value == date).Select(s => new
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
                    IssueAuthority = s.IssuingAuthority,
                    DeletedDate = s.DeletedDate
                }).ToList();
                dgvSearch.Columns["ID"].Visible = false;
            }
        }
    }
}

