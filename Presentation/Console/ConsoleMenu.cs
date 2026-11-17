using Presentation.Composition;
using Presentation.Interfaces;

namespace Presentation.Console;

// Meni treba dopuniti operacijama F1-F6 iz dodeljenog zadatka.
public sealed class ConsoleMenu
{
    private readonly IConsoleIO _io;
    private readonly AppContainer _container;

    public ConsoleMenu(IConsoleIO io, AppContainer container)
    {
        _io = io;
        _container = container;
    }

    public void Run()
    {
        _io.WriteLine("ERS27 - prakticni zadatak");
        _io.WriteLine("Poslovne operacije nisu implementirane u pocetnom sablonu.");
        _io.WriteLine("Implementirati meni prema funkcionalnim zahtevima F1-F6.");
    }
}
