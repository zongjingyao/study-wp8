using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace SilverlightToolkit
{
    public class Names : INotifyPropertyChanged
    {
        //定义属性改变事件
        public event PropertyChangedEventHandler PropertyChanged;

        //名字集合属性
        private ObservableCollection<Name> _listOfnames;
        public ObservableCollection<Name> ListOfNames
        {
            get { return _listOfnames; }
            set
            {
                _listOfnames = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ListOfNames"));
            }
        }

        public Names()
        {
            ListOfNames = new ObservableCollection<Name>();
            string namesString = "Fernando Sucre,Scofield,Alexander Mahone,Theodore Bagwell,Sara Tancredi ,Lincoln Burrows,John Abruzzi,Fluorine";
            foreach (var name in namesString.Split(','))
                ListOfNames.Add(new Name() { MyName = name });
        }
    }
}
