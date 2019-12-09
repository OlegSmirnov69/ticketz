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
using MetroFramework.Components;
using MetroFramework.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Kursova
{
    public partial class UserForm : MetroForm
    {
        SqlConnection con;
        private readonly string TemplateFileName = @"d:\template1.docx";
        public UserForm()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.sigendbConnectionString);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.htype". При необходимости она может быть перемещена или удалена.
            this.htypeTableAdapter.Fill(this.sigendbDataSet.htype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.sigendbDataSet.ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.hall". При необходимости она может быть перемещена или удалена.
            this.hallTableAdapter.Fill(this.sigendbDataSet.hall);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.sigendbDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.sigendbDataSet.place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.performer". При необходимости она может быть перемещена или удалена.
            this.performerTableAdapter.Fill(this.sigendbDataSet.performer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.concert". При необходимости она может быть перемещена или удалена.
            this.concertTableAdapter.Fill(this.sigendbDataSet.concert);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroTabControl1.TabPages.Remove(metroTabPage1);

            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select employee_surname from employee where employee_job_id = 2", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list.Add(record.GetValue(i));
                    }
                }
                con.Close();
                reader.Close();
                ComboBoxEmployee.DataSource = list;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                ArrayList list2 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select concert_title, concert_tcount, concert_tprice, concert_place_id, concert_performer_id from concert where concert_id = " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(record.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader.Close();

                cmd = new SqlCommand("select hall_id from hall where hall_place_id = " + list[3].ToString(), con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list1.Add(record1.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader1.Close();

                cmd = new SqlCommand("select performer_id from performer where performer_id = " + list[4].ToString(), con);
                con.Open();
                SqlDataReader reader2 = cmd.ExecuteReader();

                foreach (DbDataRecord record2 in reader2)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list2.Add(record2.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader2.Close();

                ComboBoxperformer.SelectedValue = list[4].ToString();
                TextBoxconcert_title.Text = list[0].ToString();
                TextBoxcount.Text = list[1].ToString();
                TextBoxprice.Text = list[2].ToString();
                ComboBoxplace.SelectedValue = list[3].ToString();
                ComboBoxplace_hall.SelectedValue = list1[0].ToString();
            }
            catch (Exception excep)
            {
                con.Close();
                MessageBox.Show(excep.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (TextBoxconcert_title.Text != "")
            {
                try
                {
                    ArrayList list = new ArrayList(0);
                    SqlCommand cmd = new SqlCommand("select concert_tcount, concert_tprice from concert where concert_title = '" + TextBoxconcert_title.Text + "'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    foreach (DbDataRecord record in reader)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            list.Add(record.GetValue(i));
                        }
                        break;
                    }
                    con.Close();
                    reader.Close();
                    numericUpDown1.Maximum = decimal.Parse(list[0].ToString());
                    TextBoxprice.Text = (long.Parse(list[1].ToString()) * long.Parse(numericUpDown1.Value.ToString()) * Int32.Parse(combo_htype.SelectedValue.ToString())).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ComboBoxperformer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select performer_id from dbo.[performer] where performer_name = '" + ComboBoxperformer.Text + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list.Add(record.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader.Close();

                cmd = new SqlCommand("select concert_id, concert_title, concert_tcount, concert_tprice from concert where concert_performer_id = " + list[0].ToString(), con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        list1.Add(record1.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader1.Close();

                //dataGridView1.DataBindings.Clear();
                //dataGridView1.DataSource = list1;
            }
            catch (Exception excep)
            {
                con.Close();
                MessageBox.Show(excep.Message);
            }
        }

        

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void ComboBoxplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select place_id from dbo.[place] where place_name = '" + ComboBoxplace.Text + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list.Add(record.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader.Close();

                cmd = new SqlCommand("select hall_id, hall_name, hall_place_id from hall where hall_place_id = " + list[0].ToString(), con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    list1.Add(record1);
                }
                con.Close();
                reader1.Close();

                ComboBoxplace_hall.DataBindings.Clear();
                ComboBoxplace_hall.DataSource = list1;
            }
            catch (Exception excep)
            {
                con.Close();
                MessageBox.Show(excep.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                ArrayList list2 = new ArrayList(0);
                ArrayList list3 = new ArrayList(0);
                ArrayList list4 = new ArrayList(0);
                ArrayList list5 = new ArrayList(0);
                ArrayList list6 = new ArrayList(0);

                //--------------------------------------TICKET
                SqlCommand cmd = new SqlCommand("select * from ticket where ticket_id = " + dataGridView2.SelectedRows[0].Cells[0].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();
                reader.Close();
                //--------------------------------------EMPLOYEE
                cmd = new SqlCommand("select employee_surname, employee_name from employee where employee_id = " + list[6].ToString(), con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        list1.Add(record1.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader1.Close();
                //--------------------------------------CONCERT
                cmd = new SqlCommand("select concert_title, concert_performer_id, concert_album_id, concert_date, concert_description, concert_place_id from concert where concert_id = " + list[1].ToString(), con);
                con.Open();
                SqlDataReader reader2 = cmd.ExecuteReader();

                foreach (DbDataRecord record2 in reader2)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        list2.Add(record2.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader2.Close();
                //--------------------------------------PERFORMER
                cmd = new SqlCommand("select performer_name from performer where performer_id = " + list2[1].ToString(), con);
                con.Open();
                SqlDataReader reader3 = cmd.ExecuteReader();

                foreach (DbDataRecord record3 in reader3)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list3.Add(record3.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader3.Close();
                //--------------------------------------ALBUM
                cmd = new SqlCommand("select album_name from album where album_id = " + list2[2].ToString(), con);
                con.Open();
                SqlDataReader reader4 = cmd.ExecuteReader();

                foreach (DbDataRecord record4 in reader4)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list4.Add(record4.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader4.Close();
                //--------------------------------------PLACE
                cmd = new SqlCommand("select place_name, place_adress, place_grade from place where place_id = " + list2[5].ToString(), con);
                con.Open();
                SqlDataReader reader5 = cmd.ExecuteReader();

                foreach (DbDataRecord record5 in reader5)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        list5.Add(record5.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader5.Close();
                //--------------------------------------HALL
                cmd = new SqlCommand("select hall_name from hall where hall_id = " + list[7].ToString(), con);
                con.Open();
                SqlDataReader reader6 = cmd.ExecuteReader();

                foreach (DbDataRecord record6 in reader6)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list6.Add(record6.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader6.Close();

                // Выводим данные в текстовые поля
                lbl_title.Text = list2[0].ToString();
                lbl_performer.Text = list3[0].ToString();
                lbl_album.Text = list4[0].ToString();
                lbl_place.Text = list5[0].ToString();
                lbl_date.Text = list2[3].ToString();
                lbl_count.Text = list[5].ToString();
                lbl_price.Text = list[4].ToString();
                lbl_description.Text = list2[4].ToString();
                lbl_tdate.Text = list[2].ToString();
                lbl_ttime.Text = list[3].ToString();
                lbl_adress.Text = list5[1].ToString();
                lbl_grade.Text = list5[2].ToString();
                lbl_hall.Text = list6[0].ToString();
                lbl_surname.Text = list1[0].ToString();
                lbl_name.Text = list1[1].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            } 
        }

        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTabControl1.TabPages.Remove(metroTabPage1);
            metroTabControl1.TabPages.Add(metroTabPage2);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTabControl1.TabPages.Add(metroTabPage1);
            metroTabControl1.TabPages.Remove(metroTabPage2);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.concertTableAdapter.Fill(this.sigendbDataSet.concert);
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = this.sigendbDataSet.concert;
            dataGridView2.DataBindings.Clear();
            dataGridView2.DataSource = this.sigendbDataSet.ticket;
            ComboBoxplace.DataBindings.Clear();
            ComboBoxplace.DataSource = this.sigendbDataSet.place;
            ComboBoxplace_hall.DataBindings.Clear();
            ComboBoxplace_hall.DataSource = this.sigendbDataSet.hall;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }

        private void ComboBoxplace_hall_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select hall_type_id from dbo.[hall] where hall_name = '" + ComboBoxplace_hall.Text + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list.Add(record.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader.Close();

                cmd = new SqlCommand("select concert_tprice from concert where concert_title = '" + TextBoxconcert_title.Text + "'", con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        list1.Add(record1.GetValue(i));
                    }
                    break;
                }
                con.Close();
                reader1.Close();
                
               // TextBoxprice.Text = (long.Parse(list1[0].ToString()) * long.Parse(numericUpDown1.Value.ToString())).ToString();

                combo_htype.DataBindings.Clear();
                combo_htype.DataSource = list;

                int caseSwitch = Int32.Parse(list[0].ToString()) ;
                switch (caseSwitch)
                {
                    case 1:
                        TextBoxprice.Text = (long.Parse(list1[0].ToString()) * long.Parse(numericUpDown1.Value.ToString()) * 1).ToString();
                        txt_htype.Text = "Звичайний";
                        break;
                    case 2:
                        TextBoxprice.Text = (long.Parse(list1[0].ToString()) * long.Parse(numericUpDown1.Value.ToString()) * 2).ToString();
                        txt_htype.Text = "Преміум";
                        break;
                    case 3:
                        TextBoxprice.Text = (long.Parse(list1[0].ToString()) * long.Parse(numericUpDown1.Value.ToString()) * 3).ToString();
                        txt_htype.Text = "VIP";
                        break;
                    default:
                        txt_htype.Text = "0";
                        break;
                }
                
            }
            catch (Exception excep)
            {
                con.Close();
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{title}", lbl_title.Text, wordDocument);
                ReplaceWordStub("{performer}", lbl_performer.Text, wordDocument);
                ReplaceWordStub("{album}", lbl_album.Text, wordDocument);
                ReplaceWordStub("{place}", lbl_place.Text, wordDocument);
                ReplaceWordStub("{adress}", lbl_adress.Text, wordDocument);
                ReplaceWordStub("{hall}", lbl_hall.Text, wordDocument);
                ReplaceWordStub("{grade}", lbl_grade.Text, wordDocument);
                ReplaceWordStub("{date}", lbl_date.Text, wordDocument);
                ReplaceWordStub("{count}", lbl_count.Text, wordDocument);
                ReplaceWordStub("{description}", lbl_description.Text, wordDocument);
                ReplaceWordStub("{price}", lbl_price.Text, wordDocument);
                ReplaceWordStub("{tdate}", lbl_tdate.Text, wordDocument);
                ReplaceWordStub("{ttime}", lbl_ttime.Text, wordDocument);
                ReplaceWordStub("{surname}", lbl_surname.Text, wordDocument);
                ReplaceWordStub("{name}", lbl_name.Text, wordDocument);

                wordDocument.SaveAs2(@"D:\ticket.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            if (TextBoxconcert_title.Text != "")
            {
                try
                {
                    ArrayList list = new ArrayList(0);
                    ArrayList list1 = new ArrayList(0);
                    SqlCommand cmd = new SqlCommand("select employee_id from employee where employee_surname = '" + ComboBoxEmployee.Text + "'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            list.Add(record.GetValue(i));
                        }
                        break;
                    }
                    con.Close();
                    reader.Close();

                    cmd = new SqlCommand("insert into ticket ( ticket_concert_id, ticket_date, ticket_time, ticket_price, ticket_count, ticket_employee_id, ticket_hall_id) values ('"
                                                    + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "', '"
                                                    + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + System.DateTime.Now.ToLongTimeString() + "', '"
                                                    + TextBoxprice.Text + "', '" + numericUpDown1.Value + "', '"
                                                    + list[0].ToString() + "', '" + ComboBoxplace_hall.SelectedValue.ToString() + "');", con);

                    con.Open();
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    reader1.Close();
                    con.Close();
                    ComboBoxperformer_SelectedIndexChanged(sender, e);
                    MessageBox.Show("Продаж квитка пройшов успішно!!!", "Повідомлення");

                    ticketTableAdapter.Fill(sigendbDataSet.ticket);
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Виберіть квиток!!!", "Попередження");
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
