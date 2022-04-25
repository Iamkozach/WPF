using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class Person : INotifyPropertyChanged
    {

        private string fName;
        public string FName
        {
            get { return fName; }
            set { fName = value; /*OnPropertyChanged(FName);*/ }
        }


        private string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; /* OnPropertyChanged(LName);*/ }
        }


        private string fullName;
        public string FullName
        {
            get { return fullName = FName + " " + LName; }
            set 
            {
                if (fullName != value)
                {
                    fullName = value;
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;


        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));
        }
    }
}
