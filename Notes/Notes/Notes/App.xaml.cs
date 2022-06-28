using Notes.Views;
using System.IO;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.Data;

namespace Notes
{
    public partial class App : Application
    {
        static NoteDatabase _database;

        public static NoteDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Notes.db3"));
                }
                return _database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
