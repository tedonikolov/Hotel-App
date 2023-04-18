using hotel.DataLayer.Entity;
using hotel.DataLayer.Repository;
using JR.Utils.GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Receptionist : Form
    {
        Profile profile;
        Room roomDTO;
        int reservationid = 0;

        public Receptionist(Profile profile)
        {
            InitializeComponent();
            this.profile = profile;
        }

        private void button_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(room);
            Button button = sender as Button;
            string text = button.Text;
            room.Text = text;
            tabControl.SelectedTab = room;
            foreach(Room roomItem in RoomRepo.getall())
            {
                if(Int32.Parse(room.Text.Substring(5)) == roomItem.id)
                {
                    roomDTO = roomItem;
                    createTable();
                    break;
                }
            }
            
            dateTimePicker3.Value = checkin.Value;
            dateTimePicker4.Value = checkout.Value;
            egn.Text = "";
            name.Text = "";
            phone.Text = "";
            email.Text = "";
            ((Control)this.room).Enabled = true;
            tabControl.TabPages.Insert(1,room);
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(room);
            typeBox.Items.Add("Всички");
            List<DataLayer.Type> types = TypeRepo.getall();
            foreach (DataLayer.Type type in types) 
                {
                    typeBox.Items.Add(type.type);
                }

            ((Control)this.room).Enabled = false;
            List<Room> rooms = RoomRepo.getall();
            int br = 1;
            int r = 1;
            int c = 1;
            foreach (Room room in rooms)
            {
                if (r > 7)
                {
                    r = 1;
                    c++;
                }
                Button btn = new Button();
                btn.Text = "Стая:"+room.id.ToString();
                btn.Size = new Size(180, 80);
                btn.Location = new Point(185 * (r-1), 90 * (c-1));
                btn.Click += new EventHandler(button_Click);
                pane.Controls.Add(btn);
                buttons.Add(btn);
                r++;
            }
            typeBox_SelectedIndexChanged_1(sender, e);

        }

        private void typeBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<Room> rooms = RoomRepo.getall();
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
                btn.BackColor = Color.Gray;
            }
            foreach (Room room in rooms)
            {
                if(typeBox.Text.ToString() == "" || typeBox.Text.ToString() == "Всички")
                {
                    foreach (Button btn in buttons)
                    {
                        if (Int32.Parse(btn.Text.Substring(5)) == room.id)
                        {
                            bool flag = true;
                            if (ReservationRepo.hasReservation(room.id, checkin.Value, checkout.Value) || bathroom.Checked != room.bathroom)
                            {
                                btn.Enabled = false;
                                flag = false;
                                btn.BackColor = Color.Gray;

                            }
                            if (flag && bathroom.Checked == room.bathroom)
                            {
                                btn.BackColor = Color.Black;
                                btn.Enabled = true;
                            }
                        }
                    }
                }
                else if (typeBox.Text.ToString() == room.type.type)
                {
                    foreach (Button btn in buttons)
                    {
                        if (Int32.Parse(btn.Text.Substring(5)) == room.id)
                        {
                            bool flag = true;
                            if (ReservationRepo.hasReservation(room.id, checkin.Value, checkout.Value) || bathroom.Checked != room.bathroom)
                            {
                                btn.Enabled = false;
                                btn.BackColor = Color.Gray;
                                flag = false;
                            }
                            if(flag && bathroom.Checked == room.bathroom)
                            {
                                btn.BackColor = Color.Black;
                                btn.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            typeBox_SelectedIndexChanged_1(sender,e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            typeBox_SelectedIndexChanged_1(sender, e);
        }
        private void reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationid = 0;
            List<Client> clients = ClientRepo.getall();
            if (e.RowIndex >= 0)
            {
                if (reservation.Rows[e.RowIndex].Cells[1].Value.ToString() == "")
                {
                    egn.Text = "";
                    egn.BackColor = Color.White;
                    name.Text = "";
                    name.BackColor = Color.White;
                    phone.Text = "";
                    phone.BackColor = Color.White;
                    email.Text = "";
                    email.BackColor = Color.White;
                    button1.Text = "Добавяне";
                }
                else if (reservation.Columns[e.ColumnIndex].Name == "Delete")
                {
                    FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                    DialogResult result = FlexibleMessageBox.Show("Сигурни ли сте че искате да изтриет резервация с номер:"+ reservation.Rows[e.RowIndex].Cells[1].Value+"!",
                            "Грешка",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                        ReservationRepo.delete(Int32.Parse(reservation.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    createTable();
                }
                else
                {
                    foreach (Client client in clients)
                    {
                        if (client.egn == reservation.Rows[e.RowIndex].Cells[this.reservation.Columns.Count - 5].Value.ToString())
                        {
                            egn.Text = client.egn;
                            name.Text = client.fullname;
                            phone.Text = client.phoneNumber;
                            email.Text = client.email;
                        }
                    }
                    foreach (Reservation reservation in ReservationRepo.getall())
                    {
                        if (reservation.id == (int)this.reservation.Rows[e.RowIndex].Cells[this.reservation.Columns.Count-7].Value)
                        {
                            reservationid = reservation.id;
                            dateTimePicker3.Value = reservation.checkIn.ToDateTime(TimeOnly.FromDateTime(DateTime.Now));
                            dateTimePicker4.Value = reservation.checkOut.ToDateTime(TimeOnly.FromDateTime(DateTime.Now));
                        }
                    }

                    button1.Text = "Промяна";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || email.Text == "" || egn.Text == "" )
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Попълнете всички полета!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else if(egn.BackColor == Color.OrangeRed || name.BackColor == Color.OrangeRed || phone.BackColor == Color.OrangeRed || email.BackColor == Color.OrangeRed)
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Попълнете валидни данни в полета!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else if (dateTimePicker3.Value > dateTimePicker4.Value)
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Избрали сте грешна дата!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                bool flag = true;
                foreach (Reservation reservation in ReservationRepo.getall())
                {
                    if (reservation.id == reservationid)
                    {
                        flag = false;
                        break;
                    }
                }
                List<Client> clients = ClientRepo.getall();
                int id = 0; ;
                foreach (Client client1 in clients)
                {
                    if (client1.egn == egn.Text) { id = client1.id; break; }
                }
                if (id == 0)
                {
                    id = clients.Last().id + 1;
                }
                Client client = new Client(id, name.Text, phone.Text, email.Text, egn.Text);
                ClientRepo.update(client);
                decimal price;
                if (roomDTO.bathroom)
                {
                    price = (decimal)((dateTimePicker4.Value - dateTimePicker3.Value).TotalDays) * roomDTO.type.price * (decimal)1.20;
                }
                else
                    price = (decimal)((dateTimePicker4.Value - dateTimePicker3.Value).TotalDays) * roomDTO.type.price;

                if (!flag)
                {
                    ReservationRepo.update(new Reservation(reservationid, client, roomDTO, DateOnly.FromDateTime(dateTimePicker3.Value), DateOnly.FromDateTime(dateTimePicker4.Value), profile, price));
                    createTable();
                }
                else if (ReservationRepo.hasReservation(roomDTO.id, dateTimePicker3.Value, dateTimePicker4.Value))
                {
                    if (ReservationRepo.NoMorePpl(roomDTO.id, dateTimePicker3.Value, dateTimePicker4.Value) == roomDTO.type.people)
                    {
                        FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                        FlexibleMessageBox.Show("Не може да добавяте повече хора за този период!",
                                "Грешка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    else if(ReservationRepo.NoMorePpl(roomDTO.id, dateTimePicker3.Value, dateTimePicker4.Value) != 0)
                    {
                        if (!flag)
                        {
                            ReservationRepo.update(new Reservation(reservationid, client, roomDTO, DateOnly.FromDateTime(dateTimePicker3.Value), DateOnly.FromDateTime(dateTimePicker4.Value), profile, price));
                        }
                        else
                            ReservationRepo.update(new Reservation(ReservationRepo.getall().Last().id + 1, client, roomDTO, DateOnly.FromDateTime(dateTimePicker3.Value), DateOnly.FromDateTime(dateTimePicker4.Value), profile, price));
                        createTable();
                        egn.Text = "";
                        egn.BackColor = Color.White;
                        name.Text = "";
                        name.BackColor = Color.White;
                        phone.Text = "";
                        phone.BackColor = Color.White;
                        email.Text = "";
                        email.BackColor = Color.White;
                    }
                    else
                    { 
                        FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                        FlexibleMessageBox.Show("За този период има резервация!",
                                "Грешка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ReservationRepo.update(new Reservation(ReservationRepo.getall().Last().id + 1, client, roomDTO, DateOnly.FromDateTime(dateTimePicker3.Value), DateOnly.FromDateTime(dateTimePicker4.Value), profile, price));
                    createTable();
                    egn.Text = "";
                    egn.BackColor = Color.White;
                    name.Text = "";
                    name.BackColor = Color.White;
                    phone.Text = "";
                    phone.BackColor = Color.White;
                    email.Text = "";
                    email.BackColor = Color.White;
                }
            }
        }

        private void bathroom_CheckedChanged(object sender, EventArgs e)
        {
            typeBox_SelectedIndexChanged_1(sender, e);
        }

        private void createTable()
        {
            reservation.DataSource = null;
            if (reservation.Rows.Count < 1)
            {
                DataGridViewButtonColumn buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Delete";
                buttoncol.HeaderText = "Изтрий";
                buttoncol.Text = "Изтрий";
                buttoncol.UseColumnTextForButtonValue = true;
                reservation.Columns.Add(buttoncol);
            }
            reservation.DataSource = ReservationRepo.getTableById(roomDTO.id, dateTimePicker3.Value, dateTimePicker4.Value);
            if (DateTime.Now > dateTimePicker3.Value.AddDays(1) && DateTime.Now < dateTimePicker4.Value)
            {
                reservation.Columns.Remove(reservation.Columns[0]);
            }
            else if (DateTime.Now > dateTimePicker3.Value.AddDays(1))
            {
                reservation.Columns.Remove(reservation.Columns[0]);
            }
        }

        private void egn_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(egn.Text, @"^(^[0-9]{10}$)"))
            {
                egn.BackColor = Color.GreenYellow;
                foreach (Client client in ClientRepo.getall())
                {
                    if (egn.Text == client.egn)
                    {
                        name.Text = client.fullname;
                        phone.Text = client.phoneNumber;
                        email.Text = client.email;
                    }
                }
            }
            else
            {
                egn.BackColor = Color.OrangeRed;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(name.Text, @"^(^[А-Я,A-Z,\s]+$)"))
            {
                name.BackColor = Color.GreenYellow;
            }
            else
            {
                name.BackColor = Color.OrangeRed;
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(phone.Text, @"^0(87|88|89)[0-9]{7}$|^\+359(87|88|89)[0-9]{7}$"))
            {
                phone.BackColor = Color.GreenYellow;
            }
            else
            {
                phone.BackColor = Color.OrangeRed;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(email.Text, @"^(\S+)@(\S+)\.(\S+)$"))
            {
                email.BackColor = Color.GreenYellow;
            }
            else
            {
                email.BackColor = Color.OrangeRed;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReservationRepo.getTable();
                dataGridView1.Columns["Дата на настаняване"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridView1.Columns["Дата на напускане"].DefaultCellStyle.Format = "yyyy-MM-dd";
                comboBox2.Items.Clear();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    comboBox2.Items.Add(dataGridView1.Columns[i].HeaderText);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClientRepo.getTable();
                comboBox2.Items.Clear();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    comboBox2.Items.Add(dataGridView1.Columns[i].HeaderText);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ReservationRepo.getTable(comboBox2.Text, textBox1.Text);
                    dataGridView1.Columns["Дата на настаняване"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    dataGridView1.Columns["Дата на напускане"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ClientRepo.getTable(comboBox2.Text, textBox1.Text); ;
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ReservationRepo.getTable();
                    dataGridView1.Columns["Дата на настаняване"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    dataGridView1.Columns["Дата на напускане"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ClientRepo.getTable();
                }
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            createTable();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            createTable();
        }
    }
}
