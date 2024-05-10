using System;
using System.ComponentModel;

namespace Step10_MVVM
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Model model = new Model();

        private string won;
        private string dollar;

        
        public string Won
        {
            get { return won; }
            set 
            {
                won = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Won"));
            }
        }

        public string Dollar
        {
            get { return dollar; }
            set
            {
                dollar = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Dollar"));

                Double d = Double.Parse(value);

                Won = (d * 1500).ToString();
            }
        }

        // View 에서 국가명을 사용하기 위해
        public Model ModelData { get => model; }
    }

}