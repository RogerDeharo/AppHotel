using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hotel
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
                Nome = "Super Luxo",
                DiariaAulto = 110.0,
                DiariaCrianca = 55.0
            },
            new Suite()
            {
                Nome = "Executivo",
                DiariaAulto = 90.0,
                DiariaCrianca = 45.0
            },
            new Suite()
            {
                Nome = "Crise",
                DiariaAulto = 45.0,
                DiariaCrianca = 20.0

            }
        };
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            InitializeComponent();

            //MainPage = new MainPage();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            else
                MainPage = new NavigationPage(new View.Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
