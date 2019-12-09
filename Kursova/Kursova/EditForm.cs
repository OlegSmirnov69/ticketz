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
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con;
        string id_concert = "";
        string id_performer = "";
        string id_album = "";
        string id_song = "";
        string id_place = "";
        string id_hall = "";
        public EditForm()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.sigendbConnectionString);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.htype". При необходимости она может быть перемещена или удалена.
            this.htypeTableAdapter.Fill(this.sigendbDataSet.htype);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.sigendbDataSet.ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.hall". При необходимости она может быть перемещена или удалена.
            this.hallTableAdapter.Fill(this.sigendbDataSet.hall);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.song". При необходимости она может быть перемещена или удалена.
            this.songTableAdapter.Fill(this.sigendbDataSet.song);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.album". При необходимости она может быть перемещена или удалена.
            this.albumTableAdapter.Fill(this.sigendbDataSet.album);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.sigendbDataSet.place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.performer". При необходимости она может быть перемещена или удалена.
            this.performerTableAdapter.Fill(this.sigendbDataSet.performer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sigendbDataSet.concert". При необходимости она может быть перемещена или удалена.
            this.concertTableAdapter.Fill(this.sigendbDataSet.concert);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
            metroTabControl1.TabPages.Remove(metroTabPage2);
            metroTabControl1.TabPages.Remove(metroTabPage3);
            metroTabControl1.TabPages.Remove(metroTabPage4);
            metroTabControl1.TabPages.Remove(metroTabPage5);
            metroTabControl1.TabPages.Remove(metroTabPage6);
            metroTabControl1.TabPages.Remove(metroTabPage7);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from concert where concert_id = " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();
                reader.Close();

                cmd = new SqlCommand("select album_name from album where album_id = " + dataGridView1.SelectedRows[0].Cells[8].Value.ToString(), con);
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

                // Выводим данные в текстовые поля

                TextBoxconcert_title.Text = list[1].ToString();
                ComboBoconcert_performer.SelectedValue = list[2].ToString();
                dateTimePicker1.Text = list[3].ToString();
                ComboBoxconcert_place.SelectedValue = list[4].ToString();
                TextBoxconcert_tcount.Text = list[5].ToString();
                TextBoxconcert_tprice.Text = list[6].ToString();
                richTextBoxconcert_description.Text = list[7].ToString();
                txtalbum.Text = list1[0].ToString();
                id_concert = list[0].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            } 
        }

        private void Buttonadd_concert_Click(object sender, EventArgs e)
        {
            if (TextBoxconcert_title.Text != "" && TextBoxconcert_tcount.Text != "" && TextBoxconcert_tprice.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into concert (concert_title, concert_performer_id, concert_date, concert_place_id, concert_tcount, concert_tprice, concert_description, concert_album_id) values ('" + TextBoxconcert_title.Text + "', '" + ComboBoconcert_performer.SelectedValue.ToString()
                                                    + "', '" + dateTimePicker1.Text + "', '" + ComboBoxconcert_place.SelectedValue.ToString() + "', '" + TextBoxconcert_tcount.Text + "', '" + TextBoxconcert_tprice.Text + "', '" + richTextBoxconcert_description.Text + "', '" + ComboBoxconcert_album.SelectedValue.ToString() + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    concertTableAdapter.Fill(sigendbDataSet.concert);
                    //performerTableAdapter.Fill(sigendbDataSet.performer);
                    //placeTableAdapter.Fill(sigendbDataSet.place);
                    
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from performer where performer_id = " + dataGridView2.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                TextBoxperformer_name.Text = list[1].ToString();
                TextBoxperformer_genre.Text = list[2].ToString();
                TextBoxperformer_country.Text = list[3].ToString();
                id_performer = list[0].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Buttonadd_performer_Click(object sender, EventArgs e)
        {
            if (TextBoxperformer_name.Text != "" && TextBoxperformer_genre.Text != "" && TextBoxperformer_country.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into performer (performer_name, performer_genre, performer_country) values ('" + TextBoxperformer_name.Text
                                                    + "', '" + TextBoxperformer_genre.Text + "', '" + TextBoxperformer_country.Text + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    performerTableAdapter.Fill(sigendbDataSet.performer);
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from album where album_id = " + dataGridView3.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                TextBoxalbum_name.Text = list[1].ToString();
                ComboBoxalbum_performer.SelectedValue = list[2].ToString();
                id_album = list[0].ToString();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Buttonadd_album_Click(object sender, EventArgs e)
        {
            if (TextBoxalbum_name.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into album (album_name, album_performer_id) values ('" + TextBoxalbum_name.Text
                                                    + "', " + ComboBoxalbum_performer.SelectedValue.ToString() + ");", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    albumTableAdapter.Fill(sigendbDataSet.album);
                    performerTableAdapter.Fill(sigendbDataSet.performer);
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

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from song where song_id = " + dataGridView4.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                TextBoxsong_name.Text = list[1].ToString();
                ComboBoxsong_album.SelectedValue = list[2].ToString();
                id_song = list[0].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Buttonadd_song_Click(object sender, EventArgs e)
        {
            if (TextBoxsong_name.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into song (song_name, song_album_id) values ('" + TextBoxsong_name.Text
                                                    + "', " + ComboBoxsong_album.SelectedValue.ToString() + ");", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    songTableAdapter.Fill(sigendbDataSet.song);
                    albumTableAdapter.Fill(sigendbDataSet.album);
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

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from place where place_id = " + dataGridView5.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                TextBoxplace_name.Text = list[1].ToString();
                TextBoxplace_adress.Text = list[2].ToString();
                TextBoxplace_owner.Text = list[3].ToString();
                TextBoxplace_grade.Text = list[4].ToString();
                id_place = list[0].ToString();

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Buttonadd_place_Click(object sender, EventArgs e)
        {
            if (TextBoxplace_name.Text != "" && TextBoxplace_adress.Text != "" && TextBoxplace_owner.Text != "" && TextBoxplace_grade.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into place (place_name, place_adress, place_owner, place_grade) values ('" + TextBoxplace_name.Text
                                                    + "', '" + TextBoxplace_adress.Text + "', '" + TextBoxplace_owner.Text + "', '" + TextBoxplace_grade.Text + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    placeTableAdapter.Fill(sigendbDataSet.place);
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

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select * from hall where hall_id = " + dataGridView6.SelectedRows[0].Cells[1].Value.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Результат запроса записываем в масив
                foreach (DbDataRecord record in reader)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(record.GetValue(i));

                    }
                    break;
                }

                con.Close();

                // Выводим данные в текстовые поля
                TextBoxhall_name.Text = list[1].ToString();
                combo_htype.SelectedValue = list[3].ToString();
                ComboBoxhall_place.SelectedValue = list[2].ToString();
                id_hall = list[0].ToString();
               
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void Buttonadd_hall_Click(object sender, EventArgs e)
        {
            if (TextBoxhall_name.Text != "" )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into hall (hall_name, hall_place_id, hall_type_id) values ('" + TextBoxhall_name.Text
                                                    + "', '" + ComboBoxhall_place.SelectedValue.ToString() + "', '" + combo_htype.SelectedValue.ToString() + "');", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    hallTableAdapter.Fill(sigendbDataSet.hall);
                    placeTableAdapter.Fill(sigendbDataSet.place);
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

        private void Buttonupdate_concert_Click(object sender, EventArgs e)
        {
            if (id_concert != "" && TextBoxconcert_title.Text != "" && TextBoxconcert_tcount.Text != "" && TextBoxconcert_tprice.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update concert set concert_title = '" + TextBoxconcert_title.Text
                                                    + "', concert_performer_id = '" + ComboBoconcert_performer.SelectedValue.ToString() + "', concert_date = '"
                                                    + dateTimePicker1.Text.ToString() + "', concert_place_id = '"
                                                    + ComboBoxconcert_place.SelectedValue.ToString() + "', concert_tcount = '"
                                                    + TextBoxconcert_tcount.Text + "', concert_tprice = '"
                                                    + TextBoxconcert_tprice.Text + "', concert_description = '"
                                                    + richTextBoxconcert_description.Text + "', concert_album_id = '"
                                                    + ComboBoxconcert_album.SelectedValue.ToString() + "' where concert_id = " + id_concert, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    concertTableAdapter.Fill(sigendbDataSet.concert);
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

        private void Buttonupdate_performer_Click(object sender, EventArgs e)
        {
            if (id_performer != "" && TextBoxperformer_name.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update performer set performer_name = '" + TextBoxperformer_name.Text
                                                    + "', performer_genre = '" + TextBoxperformer_genre.Text + "', performer_country = '"
                                                    + TextBoxperformer_country.Text  + "' where performer_id = " + id_performer, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    performerTableAdapter.Fill(sigendbDataSet.performer);
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

        private void Buttonupdate_album_Click(object sender, EventArgs e)
        {
            if (id_album != "" && TextBoxalbum_name.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update album set album_name = '" + TextBoxalbum_name.Text
                                                    + "', album_performer_id = '"
                                                    + ComboBoxalbum_performer.SelectedValue.ToString() + "' where album_id = " + id_album, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    albumTableAdapter.Fill(sigendbDataSet.album);
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

        private void Buttonupdate_song_Click(object sender, EventArgs e)
        {
            if (id_song != "" && TextBoxsong_name.Text != "" )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update song set song_name = '" + TextBoxsong_name.Text
                                                    +  "', song_album_id = '"
                                                    + ComboBoxsong_album.SelectedValue.ToString() + "' where song_id = " + id_song, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    songTableAdapter.Fill(sigendbDataSet.song);
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

        private void Buttonupdate_place_Click(object sender, EventArgs e)
        {
            if (id_place != "" && TextBoxplace_name.Text != "" && TextBoxplace_adress.Text != "" && TextBoxplace_owner.Text != "" && TextBoxplace_grade.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update place set place_name = '" + TextBoxplace_name.Text
                                                    + "', place_adress = '" + TextBoxplace_adress.Text + "', place_owner = '" 
                                                    + TextBoxplace_owner.Text + "', place_grade = '" + TextBoxplace_grade.Text + "' where place_id = " + id_place, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    placeTableAdapter.Fill(sigendbDataSet.place);
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

        private void Buttonupdate_hall_Click(object sender, EventArgs e)
        {
            if (id_hall != "" && TextBoxhall_name.Text != ""  )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update hall set hall_name = '" + TextBoxhall_name.Text
                                                    + "', hall_place_id = '"
                                                    + ComboBoxhall_place.SelectedValue.ToString() + "' where hall_id = " + id_hall, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                    hallTableAdapter.Fill(sigendbDataSet.hall);
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

        private void Buttondel_concert_Click(object sender, EventArgs e)
        {
            if (id_concert != "" )
            {
                SqlCommand cmd = new SqlCommand("delete from concert where concert_id = " + id_concert, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                concertTableAdapter.Fill(sigendbDataSet.concert);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт для видалення!!!", "Попередження");
            }
        }

        private void Buttondel_performer_Click(object sender, EventArgs e)
        {
            if (id_performer != "" && TextBoxperformer_name.Text != "" && TextBoxperformer_genre.Text != "" && TextBoxperformer_country.Text != "")
            {
                SqlCommand cmd = new SqlCommand("delete from performer where performer_id = " + id_performer, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                performerTableAdapter.Fill(sigendbDataSet.performer);
                albumTableAdapter.Fill(sigendbDataSet.album);
                concertTableAdapter.Fill(sigendbDataSet.concert);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт для видалення!!!", "Попередження");
            }
        }

        private void Buttondel_album_Click(object sender, EventArgs e)
        {
            if (id_album != "" && TextBoxalbum_name.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("delete from album where album_id = " + id_album, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                albumTableAdapter.Fill(sigendbDataSet.album);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт для видалення!!!", "Попередження");
            }
        }

        private void Buttondel_song_Click(object sender, EventArgs e)
        {
            if (id_song != "" && TextBoxsong_name.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("delete from song where song_id = " + id_song, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                songTableAdapter.Fill(sigendbDataSet.song);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");

            }
            else
            {
                MessageBox.Show("Виберіть обєкт для видалення!!!", "Попередження");
            }
        }

        private void Buttondel_place_Click(object sender, EventArgs e)
        {
            if (id_place != "" && TextBoxplace_name.Text != "" && TextBoxplace_adress.Text != "" && TextBoxplace_owner.Text != "" && TextBoxplace_grade.Text != "")
            {
                SqlCommand cmd = new SqlCommand("delete from place where place_id = " + id_place, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                placeTableAdapter.Fill(sigendbDataSet.place);
                hallTableAdapter.Fill(sigendbDataSet.hall);
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");
                
            }
            else
            {
                MessageBox.Show("Виберіть обєкт для видалення!!!", "Попередження");
            }
        }

        private void Buttondel_hall_Click(object sender, EventArgs e)
        {
            if (id_hall != "" && TextBoxhall_name.Text != "" )
            {
                SqlCommand cmd = new SqlCommand("delete from hall where hall_id = " + id_hall, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                con.Close();
                hallTableAdapter.Fill(sigendbDataSet.hall);
                
                MessageBox.Show("Видалення запису пройшло успішно!!!", "Повідомлення");
                

            }
            else
            {
                MessageBox.Show("Виберіть обєкт!!!", "Попередження");
            }
        }

        private void metroTile1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
            metroTabControl1.TabPages.Add(metroTabPage1);
            metroTabControl1.TabPages.Remove(metroTabPage2);
            metroTabControl1.TabPages.Remove(metroTabPage3);
            metroTabControl1.TabPages.Remove(metroTabPage4);
            metroTabControl1.TabPages.Remove(metroTabPage5);
            metroTabControl1.TabPages.Remove(metroTabPage6);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTabControl1.Controls.Remove(metroTabPage1);
            metroTabControl1.Controls.Add(metroTabPage2);
            metroTabControl1.Controls.Add(metroTabPage3);
            metroTabControl1.Controls.Remove(metroTabPage4);
            metroTabControl1.Controls.Remove(metroTabPage5);
            metroTabControl1.Controls.Remove(metroTabPage6);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroTabControl1.Controls.Remove(metroTabPage1);
            metroTabControl1.Controls.Remove(metroTabPage2);
            metroTabControl1.Controls.Remove(metroTabPage3);
            metroTabControl1.Controls.Remove(metroTabPage4);
            metroTabControl1.Controls.Add(metroTabPage5);
            metroTabControl1.Controls.Add(metroTabPage6);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroTabControl1.Controls.Remove(metroTabPage1);
            metroTabControl1.Controls.Remove(metroTabPage2);
            metroTabControl1.Controls.Remove(metroTabPage3);
            metroTabControl1.Controls.Remove(metroTabPage4);
            metroTabControl1.Controls.Remove(metroTabPage5);
            metroTabControl1.Controls.Remove(metroTabPage6);
            metroTabControl1.Controls.Add(metroTabPage7);
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
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
                SqlCommand cmd = new SqlCommand("select * from ticket where ticket_id = " + dataGridView7.SelectedRows[0].Cells[1].Value.ToString(), con);
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
                cmd = new SqlCommand("select employee_surname from employee where employee_id = " + list[6].ToString(), con);
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
                lbl_count.Text =list[5].ToString();
                lbl_price.Text = list[4].ToString();
                lbl_description.Text = list2[4].ToString();
                lbl_tdate.Text = list[2].ToString();
                lbl_ttime.Text = list[3].ToString();
                lbl_adress.Text = list5[1].ToString();
                lbl_grade.Text = list5[2].ToString();
                lbl_hall.Text = list6[0].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            } 
        }

        private void ComboBoconcert_performer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList(0);
                ArrayList list1 = new ArrayList(0);
                SqlCommand cmd = new SqlCommand("select performer_id from dbo.[performer] where performer_name = '" + ComboBoconcert_performer.Text + "'", con);
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

                cmd = new SqlCommand("select album_id, album_name, album_performer_id from album where album_performer_id = " + list[0].ToString(), con);
                con.Open();
                SqlDataReader reader1 = cmd.ExecuteReader();

                foreach (DbDataRecord record1 in reader1)
                {
                    list1.Add(record1);
                }
                con.Close();
                reader1.Close();

                ComboBoxconcert_album.DataBindings.Clear();
                ComboBoxconcert_album.DataSource = list1;
            }
            catch (Exception excep)
            {
                con.Close();
                MessageBox.Show(excep.Message);
            }
        }


        private void ComboBoxconcert_album_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    ArrayList list = new ArrayList(0);
            //    ArrayList list1 = new ArrayList(0);
            //    SqlCommand cmd = new SqlCommand("select performer_id from dbo.[performer] where performer_name = '" + ComboBoconcert_performer.Text + "'", con);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    foreach (DbDataRecord record in reader)
            //    {
            //        for (int i = 0; i < 1; i++)
            //        {
            //            list.Add(record.GetValue(i));
            //        }
            //        break;
            //    }
            //    con.Close();
            //    reader.Close();

            //    cmd = new SqlCommand("select album_id, album_name, album_performer_id from album where album_performer_id = " + list[0].ToString(), con);
            //    con.Open();
            //    SqlDataReader reader1 = cmd.ExecuteReader();

            //    foreach (DbDataRecord record1 in reader1)
            //    {
            //        list1.Add(record1);
            //    }
            //    con.Close();
            //    reader1.Close();

            //    ComboBoxconcert_album.DataBindings.Clear();
            //    ComboBoxconcert_album.DataSource = list1;
            //}
            //catch (Exception excep)
            //{
            //    con.Close();
            //    MessageBox.Show(excep.Message);
            //}
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_MouseEnter_1(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void btn_clearsong_Click(object sender, EventArgs e)
        {
            TextBoxsong_name.Clear();
        }

        private void btn_clearhall_Click(object sender, EventArgs e)
        {
            TextBoxhall_name.Clear();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            TextBoxperformer_name.Clear();
            TextBoxperformer_genre.Clear();
            TextBoxperformer_country.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            TextBoxalbum_name.Clear();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            TextBoxplace_name.Clear();
            TextBoxplace_adress.Clear();
            TextBoxplace_grade.Clear();
            TextBoxplace_owner.Clear();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }

        private void ComboBoxalbum_performer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }









    }
}
