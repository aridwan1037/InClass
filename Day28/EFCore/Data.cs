namespace EFCore;

public class Data
{
    private string _message;
    private int _value;
    private bool _status;
    public string Message { get => _message; }
    public int Value { get => _value; }
    public bool Status { get => _status; }

    public Data(string message, bool status)
    {
        _message = message;
        _status = status;
    }
    public Data(int value, bool status)
    {
        _value = value;
        _status = status;
    }
}
