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
        public Form2 form;
        SqlConnection connect = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        PokojeDataContext pokoj = new PokojeDataContext();

        public Form4()
        {
            InitializeComponent();
            //NewAcc_rbutton.Checked = false;
            //ExistAcc_rbutton.Enabled = true;
            fromrez_box.Text = (DateTime.Today).ToString().Substring(0,10);
            button2.Enabled = false;
            Login_box.Enabled = false;

        }

       

        private void button2_Click(object sender, EventArgs e)
        { // update bazy o wynajęcie pokoju .. // nie apdejtuje lokalnej bazy ..  to pewnie wina nie zdefiniowanego adaptera ??? 
            try
            {      
                connect = sql_connection.GetConnection();
                
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "UPDATE pokoje SET stan_pokoju = 'true', Data_pocz_rezerwacji ='" + fromrez_box.Text + "', Data_kon_rezerwacji='" + Torez_box.Text + "', Uzytkownik_rezerwujacy='" + Login_box.Text + "'WHERE numer_pokoju='" + numroom_box.Text + "'";
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Pokój numer " + numroom_box.Text + " zarezerwowany pomyślnie");
                form.update_database();
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
            var query = (from c in pokoj.pokojes where c.numer_pokoju== 202 select new { c.ilosc_miejsc }).ToArray();
            numroom_box.Text = query[0].ilosc_miejsc.ToString();
            Form5 form = new Form5();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Check login
            connect = sql_connection.GetConnection();
            adapter = new SqlDataAdapter("SELECT COUNT(*) FROM uzytkownicy WHERE login='" + Login_box.Text + "'", connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                Tick_label.Text = "\u2714";//"\u221A";
                Tick_label.ForeColor = Color.Green;
                button2.Enabled = true;
            }
            else
            {
                Tick_label.Text = "X";
                Tick_label.ForeColor = Color.Red;
                button2.Enabled = false;
            }
        }

        private void visible_calendar1(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;  
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
             fromrez_box.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
             monthCalendar1.Visible = false;
        }
        private void visible_calendar2(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Torez_box.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
            monthCalendar2.Visible = false;
        }

        private void Login_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromrez_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void numroom_box_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
