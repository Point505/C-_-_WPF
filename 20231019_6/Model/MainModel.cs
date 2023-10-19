using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace _20231019_6.Model
{

    internal class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // EVent가 발생할때 마다 속성이 바뀜
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)//handler가 비어있지 않다면
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                //
            }
        }

        private int data = 1;
        public int Data//여기서는 값을 입력하는 것 여기서 입력된 값을 화면에 출력
        {
            set { data = value; Data_sum = value * 2; OnPropertyChanged("Data"); }
            get { return data; }// 입력받은 값을 
        }


        private int data_sum = 1;
        public int Data_sum
        {
            get { return data_sum; }
            set { data_sum = value; OnPropertyChanged("Data_sum"); }

        }

    }
}
