using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Security.Cryptography;

namespace CounterProject
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        //
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        //        
        private int _newCounter;
        public int NewCounter
        {
            get => _newCounter;
            set { _newCounter = value; OnPropertyChanged(nameof(NewCounter)); }
        }
        

        public ICommand PlusCommand { get; }
        public ICommand MinusCommand { get; }
        
        //
        public CounterViewModel()
        {
            NewCounter = 0;
            PlusCommand = new RelayCommand(Increament);
            MinusCommand = new RelayCommand(Decreament);
        }
        
        public void Increament()
        {

            NewCounter++;
            
        }
        public void Decreament()
        {
            NewCounter--;
            
        }
        
    }
}
