﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_w_hotelu
{
    public partial class UserEditor : Form
    {
        public UserEditor()
        {
            InitializeComponent();
        }

        public void EditUser()
        {
            // modyfikacja danych użytkownika
        }

        public void GetData()
        {
            // pobieranie danych z textboxów
        }

        public void Sync()
        {
            //synchronizacja zmian z bazą danych
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
