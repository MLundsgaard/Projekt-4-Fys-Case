using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;
using FysioterapiApp.ModelKlasser;
using FysioterapiApp.Database;

namespace FysioterapiApp.UI_Klasser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private SQLiteAsyncConnection connection;

        public Login()
        {
            InitializeComponent();

            connection = DependencyService.Get<ISQLiteDB>().GetConnection();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}