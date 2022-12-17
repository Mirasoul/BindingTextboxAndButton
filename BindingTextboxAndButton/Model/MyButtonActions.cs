namespace BindingTextboxAndButton
{
    interface IToDoButtonable
    {
    string Action();
    }
    public class ToDoButton: IToDoButtonable
    {
        private int _numberOfClick = 0;
        public string Action()
        {
            return string.Format("- he pressed the button {0} times ",_numberOfClick++);
        }
    }
}
