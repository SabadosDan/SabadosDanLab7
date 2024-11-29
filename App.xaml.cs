using System;
using SabadosDanLab7.Data;
using System.IO;

namespace SabadosDanLab7
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShopList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
