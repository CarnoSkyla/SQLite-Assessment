using People.Models;
using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace People
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = "";

            App.PersonRepo.AddNewPerson(newPerson.Text);
            StatusMessage.Text = App.PersonRepo.StatusMessage;
        }
        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            List<Person> people = await App.PersonRepo.GetAllPeople();
            peopleList.ItemsSource = people;
        }

       
    }
}
