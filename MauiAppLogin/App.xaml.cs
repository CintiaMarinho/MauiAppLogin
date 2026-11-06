using MauiAppLogin.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppLogin
{
    public partial class App : Application
    {
        List<Usuario> lista_usuario = new()
        {
            new Usuario()
        };
        
        public App()

        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());

            w.Height = 700;
            w.Width = 350;

            return w;
        }
    }
}