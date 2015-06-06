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
/* FORMA RECEPCJONISTY */ 

namespace Rezerwacja_w_hotelu
{ 
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            numberroom_box.Enabled = false;
        }


     

        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((checkBox1.CheckState == CheckState.Checked) && (checkBox2.CheckState == CheckState.Checked))
            {
                GetData("SELECT * FROM pokoje where ilosc_miejsc = '" + numberroom_box.Text + "' AND stan_pokoju = 'false'");

            }
            else if (checkBox1.CheckState == CheckState.Checked)
            {
                GetData("SELECT * FROM pokoje where stan_pokoju = 'false' ");
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {

                GetData("SELECT * FROM pokoje where ilosc_miejsc = '"+numberroom_box.Text+"'");

            }
            else
            {
                GetData("SELECT * FROM pokoje");
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GetData( string command )
        {
            try
            {
                SqlConnection connect = sql_connection.GetConnection();
                SqlDataAdapter  adapter = new SqlDataAdapter(command, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                // wyświetlenie tabeli pokoi
                dataGridView1.DataSource = dt;  
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState != CheckState.Checked) numberroom_box.Enabled = false;
            else numberroom_box.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form4 form = new Form4();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            grid_operation grid = new grid_operation();
            grid.value_return(dataGridView1);
            Form3 form = new Form3();
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

 


    }
}
