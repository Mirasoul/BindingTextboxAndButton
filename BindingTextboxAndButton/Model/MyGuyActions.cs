namespace BindingTextboxAndButton
{
    interface IToDoPersonable
    {
        string Talk();
        string Write();
        string PressMyButton();
    }
    public class ToDoPerson: IToDoPersonable
    {
        private ToDoButton _toDoButton = new ToDoButton();
        public string Talk()
        {
            return "Talk";
        }
        public string Write()
        {
            return "Write";
        }
        //Pressing the button will cause incerement integer inside the Action(),
        //and return the value to textbox control
        public string PressMyButton()
        {
            return _toDoButton.Action(); ;
        }
    }
}
