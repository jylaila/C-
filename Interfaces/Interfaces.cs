
namespace myApp.Interfaces
{
    interface IControl
    {
        void Paint();
    }

    interface IListBox
    {
        void setText(string text);
    }

    interface IDataBound
    {
        void Bind(string b);
    }

    //herança multipla
    interface IComboBox : IControl, IListBox{    }


    public class EditBox : IComboBox, IDataBound
    {
        public void Paint() { }
        public void Bind(string b) { }
        public void setText(string text) { }
    }
}