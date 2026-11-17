namespace Presentation.Interfaces;

public interface IConsoleIO
{
    void Write(string value);
    void WriteLine(string value = "");
    string ReadLine();
}
