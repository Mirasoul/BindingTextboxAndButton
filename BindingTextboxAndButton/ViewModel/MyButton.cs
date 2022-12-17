namespace BindingTextboxAndButton
{
    public class MyButton
    {
        private string _action = "empty";

         public string Action
         {
            get
            {
                return _action;
            }
            set
            {
                _action = value;
            }
        }
        public MyButton()
        {

        }
    }
}
