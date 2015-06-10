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
    public partial class Form5 : Form
    {
        // Forma do tworzenia konta
        public DataGridView datagrid;
        public Form5()
        {
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            try
            {
                // działa tak samo jak poprzedni update dotyczący pokoi 
            SqlConnection connect = sql_connection.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM uzytkownicy ", connect);
                
                //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            /*(pesel,imie,nazwisko,login,haslo,uprawnienia) VALUES(" + Pesel_box.Text + "," + Imie_box.Text + "," + Nazwisko_box.Text + "," + Imie_box.Text + "," + Pesel_box.Text + ", 0);";
                */
            String query = "INSERT INTO uzytkownicy (pesel,imie,nazwisko,login,haslo,uprawnienia)  VALUES (@pesel, @imie, @nazwisko, @login,@haslo,@uprawnienia)";
            SqlCommand command = new SqlCommand(query, connect);
            command.Connection.Open();
            command.Parameters.AddWithValue("@pesel", Pesel_box.Text);
            command.Parameters.AddWithValue("@imie", Imie_box.Text);
            command.Parameters.AddWithValue("@nazwisko", Nazwisko_box.Text);
            command.Parameters.AddWithValue("@login", Login_box.Text);
            command.Parameters.AddWithValue("@haslo", Pesel_box.Text);
            command.Parameters.AddWithValue("@uprawnienia", "0");
            
            command.ExecuteNonQuery();
            command.Connection.Close();

                MessageBox.Show("Uzytkownik "+Login_box.Text+" zarejstrowany pomyślnie");

                datagrid.Refresh();
                this.Hide();
            }
            catch( SqlException ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
