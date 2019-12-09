using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;

namespace Kursova
{
    public partial class EmployeeForm : MetroForm
    {
        SqlConnection con;
        string id_employee = "";
        string id_job = "";
        public EmployeeForm()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.sigendbConnectionString);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.sigendbDataSet.job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.sigendbDataSet.employee);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from employee where employee_id = " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                txt_name.Text = list[1].ToString();
                txt_surname.Text = list[2].ToString();
                txt_gender.Text = list[3].ToString();
                txt_phone.Text = list[4].ToString();
                txt_adress.Text = list[5].ToString();
                combo_job.SelectedValue = list[6].ToString();
                id_employee = list[0].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_surname.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into employee (employee_name, employee_surname, employee_gender, employee_phone, employee_adress, employee_job_id) values ('" + txt_name.Text
                                                    + "', '" + txt_surname.Text + "', '" + txt_gender.Text + "', '" + txt_phone.Text + "', '" + txt_adress.Text + "', '" + combo_job.SelectedValue.ToString() + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    employeeTableAdapter.Fill(sigendbDataSet.employee);
                    jobTableAdapter.Fill(sigendbDataSet.job);
                    MessageBox.Show("Дані успішно записані!!!", "Повідомлення");
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

        private void btn_add_job_Click(object sender, EventArgs e)
        {
            if (txt_jobname.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into job (job_name) values ('" + txt_jobname.Text + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    jobTableAdapter.Fill(sigendbDataSet.job);
                    MessageBox.Show("Дані успішно записані!!!", "Повідомлення");
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

        private void btn_clear_job_Click(object sender, EventArgs e)
        {
            txt_jobname.Clear();
        }

        private void btn_update_job_Click(object sender, EventArgs e)
        {
            if (id_job != "" && txt_jobname.Text != "" )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update job set job_name = '" + txt_jobname.Text
                                                     + "' where job_id = " + id_job, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    jobTableAdapter.Fill(sigendbDataSet.job);
                    MessageBox.Show("Дані успішно оновлено!!!", "Повідомлення");
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

        private void btn_del_job_Click(object sender, EventArgs e)
        {
            if (id_job != "" && txt_jobname.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("delete from job where job_id = " + id_job, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                employeeTableAdapter.Fill(sigendbDataSet.employee);
                jobTableAdapter.Fill(sigendbDataSet.job);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт!!!", "Попередження");
            }
        }

        private void btn_update_employee_Click(object sender, EventArgs e)
        {
            if (id_employee != "" && txt_name.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update employee set employee_name = '" + txt_name.Text
                                                    + "', employee_surname = '" + txt_surname.Text + "', employee_gender = '"
                                                    + txt_gender.Text + "', employee_phone = '"
                                                    + txt_phone.Text + "', employee_adress = '"
                                                    + txt_adress.Text + "', employee_job_id = '"
                                                    + combo_job.SelectedValue.ToString() + "' where employee_id = " + id_employee, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    employeeTableAdapter.Fill(sigendbDataSet.employee);
                    MessageBox.Show("Дані успішно оновлено!!!", "Повідомлення");
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

        private void btn_del_employee_Click(object sender, EventArgs e)
        {
            if (id_employee != "" && txt_name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("delete from employee where employee_id = " + id_employee, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                employeeTableAdapter.Fill(sigendbDataSet.employee);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт!!!", "Попередження");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from job where job_id = " + dataGridView2.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                txt_jobname.Text = list[1].ToString();
                id_job = list[0].ToString();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        
        }

        private void btn_clear_employee_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_surname.Clear();
            txt_gender.Clear(); 
            txt_phone.Clear();
            txt_adress.Clear();
        }
    }
}
