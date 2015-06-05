﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Rezerwacja_w_hotelu
{
    public partial class Form4 : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Form4()
        {
            InitializeComponent();
            //NewAcc_rbutton.Checked = false;
            //ExistAcc_rbutton.Enabled = true;
            button2.Enabled = false;
            Login_box.Enabled = MakeAcc_button.Enabled = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        { // update bazy o wynajęcie pokoju .. // nie apdejtuje lokalnej bazy ..  to pewnie wina nie zdefiniowanego adaptera ??? 
            try
            {
                connect = sql_connection.GetConnection();
                adapter = new SqlDataAdapter("SELECT COUNT(*) FROM uzytkownicy WHERE login='" + Login_box.Text + "'", connect);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update pokoje SET stan_pokoju = 'true', Data_pocz_rezerwacji ='" + fromrez_box.Text + "', Data_kon_rezerwacji='" + Torez_box.Text + "'WHERE numer_pokoju='" + numroom_box.Text + "'";
                cmd.Connection = connect;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Pokój numer " + numroom_box.Text + " zarezerwowany pomyślnie");
                adapter.Update(baza_danychDataSet.)
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form = new Form2();
            //form.Show();
            this.Close();
        }

        private void NewAcc_rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewAcc_rbutton.Checked) MakeAcc_button.Enabled = true;
            else MakeAcc_button.Enabled = false;
        }

        private void ExistAcc_rbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExistAcc_rbutton.Checked) Login_box.Enabled = true;
            else Login_box.Enabled = false;
        }

        private void MakeAcc_button_Click(object sender, EventArgs e)
        { //stworz konto 
            Form5 form = new Form5();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Check login
            connect = sql_connection.GetConnection();
            adapter = new SqlDataAdapter("SELECT COUNT(*) FROM uzytkownicy WHERE login='"+Login_box.Text+"'",connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Tick_label.Text = "\u2714";//"\u221A";
                button2.Enabled = true;
            }
            else
            {
                Tick_label.Text = "";
                button2.Enabled = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
