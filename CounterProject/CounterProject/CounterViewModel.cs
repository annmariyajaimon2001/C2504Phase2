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
        private Counter _newCounter = null;
        public Counter NewCounter
        {
            get => _newCounter;
            set { _newCounter = value; OnPropertyChanged(nameof(NewCounter)); }
        }
        //
        //private Counter _selectedCounter = null;
        //public Counter SelectedCounter
        //{
        //    get => _selectedCounter;
        //    set { _selectedCounter = value; OnPropertyChanged(nameof(SelectedCounter)); }
        //}

        public ICommand PlusCommand { get; }
        public ICommand MinusCommand { get; }
        
        //
        public CounterViewModel()
        {
            this.NewCounter = new Counter { Number = 0 };
            
            PlusCommand = new RelayCommand(Increament);
            MinusCommand = new RelayCommand(Decreament);
        }
        
        public void Increament()
        {
           
            NewCounter.Number++;
            OnPropertyChanged(nameof(NewCounter));
            
        }
        public void Decreament()
        {

            NewCounter.Number--;
            OnPropertyChanged(nameof(NewCounter));
        }
        
    }
}
