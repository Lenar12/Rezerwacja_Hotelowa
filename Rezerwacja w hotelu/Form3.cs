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
    public partial class Form3 : Form
    {
        public Form2 form;
        grid_operation grid = new grid_operation();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= grid.row_count();i++ )
                MessageBox.Show(grid.row_value()[i]);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text = "Pokój "+grid.row_value()[0].ToString();
            //MessageBox.Show((grid.row_value()[2] == "False").ToString());
            if(grid.row_value()[2]=="False")
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label3.Text = "Wolny";
                label2.Text = grid.row_value()[1];
                checkBox1.Visible = false;
               
            }else
            {
                label5.Text = grid.row_value()[3].Substring(0,10);
                label7.Text = grid.row_value()[4].Substring(0,10);
                label3.Text = "Zajęty";
                label10.Text = grid.row_value()[5];
                label2.Text = grid.row_value()[1];
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                SqlConnection connect = new SqlConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                connect = sql_connection.GetConnection();
                connect.Open();
                cmd.Connection = connect;
                cmd.CommandText = "UPDATE pokoje SET stan_pokoju = 'false', Data_pocz_rezerwacji =NULL, Data_kon_rezerwacji=NULL, Uzytkownik_rezerwujacy=''WHERE numer_pokoju='" + grid.row_value()[0] + "'";
                cmd.ExecuteNonQuery();
                connect.Close();
                form.update_database();
                this.Hide();
            }else
            {
                this.Hide();
            }
        }
       
    }
}
