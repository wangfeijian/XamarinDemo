using Notes.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    [QueryProperty(nameof(ItemId),nameof(ItemId))]
    public partial class NoteEntryPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadNote(value);
            }
        }
        public NoteEntryPage()
        {
            InitializeComponent();

            BindingContext = new Note();
        }

        void LoadNote(string fileName)
        {
            try
            {
                Note note = new Note
                {
                    FileName = fileName,
                    Text = File.ReadAllText(fileName),
                    Date = File.GetCreationTime(fileName)
                };

                BindingContext = note;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load note.");
            }
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.FileName))
            {
                var fileName = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(fileName, note.Text);
            }
            else
            {
                File.WriteAllText(note.FileName,note.Text);
            }

            await Shell.Current.GoToAsync("..");
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (File.Exists(note.FileName))
            {
                File.Delete(note.FileName);
            }

            await Shell.Current.GoToAsync("..");
        }
    }
}