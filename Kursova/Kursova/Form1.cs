using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Kursova
{
    public partial class Form1 : MetroForm
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light;
            con = new SqlConnection(Properties.Settings.Default.sigendbConnectionString);
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    SqlCommand da = new SqlCommand("select user_id from users where username = '" + txtUsername.Text + "' and password ='" + txtPassword.Text + "'", con);
                    con.Open();
                    int x = Convert.ToInt32(da.ExecuteScalar());
                    con.Close();
                    bool auth_admin = false;
                    bool auth_user = false;

                    if (x == 1) auth_admin = true;
                    if (x == 2) auth_user = true;

                    if (auth_admin && metroCheckBox1.Checked)
                    {
                        new EditForm().ShowDialog();
                    }
                    else if (auth_admin && !metroCheckBox1.Checked)
                    {
                        new EditForm().ShowDialog();
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                
                    if (auth_user && metroCheckBox1.Checked)
                    {
                        new UserForm().ShowDialog();
                    }
                    else if (auth_user && !metroCheckBox1.Checked)
                    {
                        new UserForm().ShowDialog();
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                   
                    
                    
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!!!", "Попередження");
            }
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (metroTrackBar1.Value == 0) { MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light; }
            else
            {
                MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            new EditForm().ShowDialog();
        }


    }
}
