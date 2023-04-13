using hotel.DataLayer;
using hotel.DataLayer.Entity;
using hotel.DataLayer.Repository;
using JR.Utils.GUI.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = hotel.DataLayer.Type;

namespace hotel
{
    public partial class Admin : Form
    {


        public Admin()
        {
            InitializeComponent();
        }

        private void Types_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id.Visible = false;
                TypeBox.Visible = false;
                Bathroom.Visible = false;
                button2.Visible = false;
                username.Visible = false;
                password.Visible = false;
                button3.Visible = false;

                if (Types.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    int id = (int)Types.Rows[e.RowIndex - 1].Cells[0].Value + 1;
                    this.id.Text = id.ToString();
                    type.Text = "";
                    Price.Text = "";
                    People.Text = "";
                    button1.Text = "Добавяне";
                }
                else
                {
                    id.Text = Types.Rows[e.RowIndex].Cells[0].Value.ToString();
                    type.Text = Types.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Price.Text = Types.Rows[e.RowIndex].Cells[2].Value.ToString();
                    People.Text = Types.Rows[e.RowIndex].Cells[3].Value.ToString();
                    button1.Text = "Промяна";
                }
                type.Visible = true;
                id.Visible = true;
                id.ReadOnly = true;
                Price.Visible = true;
                People.Visible = true;
                button1.Visible = true;

                label1.Text = "ID:";
                label2.Text = "Вид:";
                label3.Text = "Цена:";
                label4.Text = "Брой хора в стая:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type.Text == "" || id.Text == "" || Price.Text == "" || People.Text == "")
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Попълнете всички полета!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                TypeRepo.update(new DataLayer.Type(Int32.Parse(id.Text), type.Text, Decimal.Parse(Price.Text), Int32.Parse(People.Text)));
                Types.DataSource = TypeRepo.getTable();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Types.DataSource = TypeRepo.getTable();
            Rooms.DataSource = RoomRepo.getTable();
            Profiles.DataSource = ProfileRepo.getTable();
            for (int i = 0; i <= Types.Columns.Count - 1; i++)
            {
                Types.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            for (int i = 0; i <= Rooms.Columns.Count - 1; i++)
            {
                Rooms.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            for (int i = 0; i <= Profiles.Columns.Count - 1; i++)
            {
                Profiles.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                type.Visible = false;
                id.Visible = false;
                Price.Visible = false;
                People.Visible = false;
                button1.Visible = false;
                username.Visible = false;
                password.Visible = false;
                button3.Visible = false;

                id.Text = "";
                Price.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                TypeBox.Text = "";
                TypeBox.Items.Clear();

                List<Type> types = TypeRepo.getall();
                foreach (Type type in types)
                    TypeBox.Items.Add(type.type);

                if (Rooms.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    button2.Text = "Добавяне";
                }
                else
                {
                    id.Text = Rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string type = Rooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TypeBox.SelectedIndex = TypeBox.FindStringExact(type);
                    if (Convert.ToBoolean(Rooms.CurrentRow.Cells[2].Value))
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    button2.Text = "Промяна";
                }
                id.Visible = true;
                id.ReadOnly = false;
                TypeBox.Visible = true;
                Bathroom.Visible = true;

                button2.Visible = true;

                label1.Text = "Номер стая:";
                label2.Text = "Вид:";
                label3.Text = "";
                label4.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TypeBox.Text.ToString() == "" || id.Text == "")
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Попълнете всички полета!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                List<Type> types = TypeRepo.getall();
                foreach (Type type1 in types)
                    if (type1.type == TypeBox.Text.ToString())
                    {
                        RoomRepo.update(new DataLayer.Entity.Room(Int32.Parse(id.Text), radioButton1.Checked, type1));
                    }
                Rooms.DataSource = RoomRepo.getTable();
            }
        }
        private void Profiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id.Visible = false;
                TypeBox.Visible = false;
                Bathroom.Visible = false;
                button2.Visible = false;
                type.Visible = false;
                Price.Visible = false;
                People.Visible = false;
                button1.Visible = false;
                if (Profiles.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    int id = (int)Profiles.Rows[e.RowIndex - 1].Cells[0].Value + 1;
                    this.id.Text = id.ToString();
                    username.Text = "";
                    password.Text = "";
                    button3.Text = "Добавяне";
                }
                else
                {
                    id.Text = Profiles.Rows[e.RowIndex].Cells[0].Value.ToString();
                    username.Text = Profiles.Rows[e.RowIndex].Cells[1].Value.ToString();
                    password.Text = Profiles.Rows[e.RowIndex].Cells[2].Value.ToString();
                    button3.Text = "Промяна";
                }
                username.Visible = true;
                id.Visible = true;
                id.ReadOnly = true;
                password.Visible = true;
                button3.Visible = true;

                label1.Text = "ID:";
                label2.Text = "Име:";
                label3.Text = "Парола:";
                label4.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "" || id.Text == "")
            {
                FlexibleMessageBox.FONT = new Font("Arial", 12, FontStyle.Bold);
                FlexibleMessageBox.Show("Попълнете всички полета!",
                        "Грешка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                ProfileRepo.update(new DataLayer.Entity.Profile(Int32.Parse(id.Text), username.Text, password.Text, new Role(2, "рецепционист")));
                Profiles.DataSource = ProfileRepo.getTable();
            }
        }

        private void Types_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
