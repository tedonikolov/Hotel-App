using hotel.DataLayer.Repository;
using hotel.DataLayer.Entity;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Npgsql;
using Tweetinvi.Security;
using System.Text;

namespace hotel
{
    public partial class Login : Form
    {

        Profile profile;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Profile> profiles = ProfileRepo.getall();
            foreach (Profile profile in profiles)
                username.Items.Add(profile.username);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (profile.role.id == 1)
            {
                Form form = new Admin();
                form.ShowDialog();
            }
            else
            {
                foreach (Profile profile in ProfileRepo.getall())
                {
                    if (profile.id == this.profile.id)
                    {
                        
                        Form form = new Receptionist(profile);
                        form.ShowDialog();
                    }
                }
            }
            this.password.Text = "";
            password.BackColor = Color.White;
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            foreach (Profile profile in ProfileRepo.getall())
            {
                if (profile.username == username.Text)
                {
                    if (profile.password == password.Text)
                    {
                        this.profile = profile;
                        button1.Visible = true;
                        password.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        password.BackColor = Color.Red;
                        button1.Visible = false;
                    }
                }
                
            }
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {
            password.Text = "";
            password.BackColor = Color.White;
        }
    }
}