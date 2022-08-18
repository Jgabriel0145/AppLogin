using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppLogin.Model;
using AppLogin.View;

namespace AppLogin
{
    public partial class App : Application
    {

        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Senha = "123",
                Nome = "Joao"
            },

            new DadosUsuario()
            {
                Email = "prof@etec",
                Senha = "456",
                Nome = "Prof"
            }
        };


        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
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
