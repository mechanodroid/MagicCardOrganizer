using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MagicCardOrganizer.Models;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;


namespace MagicCardOrganizer.ViewModels
{
    class BrowseViewModel : INotifyPropertyChanged
    {
        private Card card = new Card("foo");
        private MagicCardCollectionModel magicCardCollectionModel = new MagicCardCollectionModel();
        public String CardName
        {
            get { return card.Name; }
            set 
            { 
                card.Name = value;
                OnPropertyChanged("CardName");
            }
        }
        public String Power
        {
            get { return card.Power; }
            set
            {
                card.Power = value;
                OnPropertyChanged("Power");
            }
        }
        public String Defense
        {
            get { return card.Defense; }
            set
            {
                card.Defense = value;
                OnPropertyChanged("Defense");
            }
        }
        public String Special
        {
            get { return card.Special; }
            set
            {
                card.Special = value;
                OnPropertyChanged("Special");
            }
        }
        public BitmapImage Image
        {
            get { return card.Image; }
            set
            {
                card.Image = value;
                OnPropertyChanged("Image");
            }
        }
        public BrowseViewModel()
        {
            //We have now tied the Model to the ViewModel.
            card = new Card(""); //this is the card as it's being entered


        }
        //Commands
        //This method just returns true. It is used for data validation at a later time.
        private bool CanExecute()
        {
            return  true;
        }
        private void ShowFileBox()
        {
            OpenFileDialog file = new OpenFileDialog();
            Nullable<bool> result = file.ShowDialog();

            if (File.Exists(file.FileName))
            {
                card.Image = Image = new BitmapImage(new Uri(file.FileName, UriKind.Absolute));
            }
        }
        //This property is how we link it to the View.
        public ICommand LaunchFileBox
        {
            get
            {
                return new Command(CanExecute, ShowFileBox);
            }
        }
        //This method will launch a messagebox for us.
        private void ShowCardName()
        {
            MessageBox.Show(CardName+" power is "+Power);
            magicCardCollectionModel.Insert(card);
        }
        //This property is how we link it to the View.
        public ICommand LaunchCardName
        {
            get
            {
                return new Command(CanExecute,ShowCardName);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                         handler(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
