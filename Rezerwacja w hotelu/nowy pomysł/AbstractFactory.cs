﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezerwacja_w_hotelu
{
    class AbstractFactory
    {
        // wszystkie funkcję create...Panel tworzą pierw tworzą nowe Formy a potem przełączają na nie
        public void CreateAdminPanel()
        { // tworzy panel admina

        }

        public void CreateReceptionistPanel()
        { // tworzy panel recepcjonisty
            ReceptionistPanel next = new ReceptionistPanel();
            next.Show();
        }

        public void CreateServicePanel()
        { // tworzy panel sprzątaczki

        }

        public void CheckAuthorization() //login
        {
            CreateReceptionistPanel();
            // sprawdza dla loginu użytkownika jego uprawnienia i uruchamia odpowiednie gui
            
            //switch ("uprawnienia")
            //{
            //    case "1":           //forma recepcjonisty
            //        this.CreateReceptionistPanel();
            //        break;
            //    case "2":           //forma administratora
            //        this.CreateAdminPanel();
            //        break;
            //    case "3":           //forma sprzątaczki
            //       this.CreateServicePanel();
            //        break;
            //};
        }


    }
}
