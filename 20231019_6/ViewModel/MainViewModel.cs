using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace _20231019_6.ViewModel
{

    internal class MainViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)//handler가 비어있지 않다면
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                //
            }
        }

        private Model.MainModel model = null;

        public MainViewModel()
        {
            this.model = new Model.MainModel();
        }

        public Model.MainModel Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
                OnPropertyChanged("Model");
            }
        }

    }
}
