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
    public partial class EntryForm : Form
    {
        private readonly SearchSystemEntities db;
        const string folder = "Error Folder";
        public EntryForm()
        {
            InitializeComponent();
            db = new SearchSystemEntities();
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "error.txt");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text.Trim();
            string password = tbxPassword.Text.Trim();
            password = Extension.Password.HashPassword(password);
            if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                errorProviderEmail.SetError(tbxEmail, "Enter Email!");
            }
            if (string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                errorProviderPassword.SetError(tbxPassword, "Enter Password!");
                return;
            }
            User user = db.Users.FirstOrDefault(a => a.Email == email && a.Password == password);
            try
            {
                if (user == null)
                {
                    MessageBox.Show("User is not found! Please check your inputs!");
                    return;
                }
                else
                {
                    MainForm mainForm = new MainForm(user);
                    mainForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again after 2 minutes!");
                File.AppendAllText(path, "\n" + ex + ":" + DateTime.Now);
                return;
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
