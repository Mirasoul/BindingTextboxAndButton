using System.Windows.Input;

namespace BindingTextboxAndButton
{
    public struct PersonFeatures
    {
        // public byte Age;
        // public byte Height;
        public string Name;
        public string Surname;
    }

    public class Person : ObservedObject
    {
        ToDoPerson _toDo = new ToDoPerson();

        private ICommand? _myButton = null;
        private PersonFeatures _name;
        private PersonFeatures _surname;
        private string _numberOfClick = "0";

        public string OurGuyName
        {
            get
            {
                return _name.Name;
            }
        }
        public string OurGuySurname
        {
            get
            {
                return _surname.Surname;
            }
            set
            {
                _surname.Surname = value;
                OnPropertyChanged(nameof(OurGuySurname));
            }
        }
        public string OurGuyActions
        {
            get
            {
                return _numberOfClick.ToString();
            }
            set
            {
                _numberOfClick = value;
                OnPropertyChanged(nameof(OurGuyActions));
            }
        } 
        public ICommand MyButtonCommands
        {
            get
            {
                if (_myButton == null)
                {
                    _myButton = new RelayCommand(OurGuyClick);
                }
                return _myButton;
            }
        }

        public Person()
        {
            /*Inicjalizacja imienia i nazwiska*/
            _name.Name = "Arkadiusz";
            _surname.Surname = "B.";
        }
        public void OurGuyClick(object obj)
        {
            OurGuyActions = _toDo.PressMyButton();
        }
    }


}
