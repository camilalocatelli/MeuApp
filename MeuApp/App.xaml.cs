using MeuApp.Helpers;
using System.Globalization;

namespace MeuApp
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _Db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_Db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _Db = new SQLiteDatabaseHelper(".... db3");
                }


                return _Db;
            }
        }
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new View.ListaProduto());
        }

    }
}