using System;
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
    public partial class Form1 : Form
    {
        //SqlConnection connect;
        //SqlDataAdapter adapter;
        //DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            accept_button.TabStop = true;   
            try
            {
                SqlConnection connect = sql_connection.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM uzytkownicy WHERE login='"+login_box.Text+"' and haslo='"+password_box.Text+"'",connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand cmd = connect.CreateCommand();
                    Form form;

                    cmd.CommandText = "SELECT uprawnienia FROM uzytkownicy WHERE login='" + login_box.Text + "'";
                    cmd.CommandType = CommandType.Text;

                    connect.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.Hide();
                        switch (reader["uprawnienia"].ToString())
                        {
                            case "1":           //forma recepcjonisty
                                form = new Form2();
                                form.Show();
                                break;
                            case "2":           //forma administratora
                                form = new Form3();
                                form.Show();
                                break;
                            case "3":           //forma sprzątaczki
                                //form= new Form4();
                                break;
                        };

                        //form.Show();
                    }
                }
                else
                    MessageBox.Show("Some invalid entries have been detected.", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);


                connect.Close();
            }  catch 
            {
                MessageBox.Show("Connection ERROR");
            }
            
            
          
        }
    }
}
