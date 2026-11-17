using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Services;
using Database.Repositories;
using Infrastructure.Services;
using Presentation.Console;
using Presentation.Interfaces;

namespace Presentation.Composition;

// Sastavljanje zavisnosti na jednom mestu; Domain/Application ne biraju adaptere.
public sealed class AppContainer
{
    public required IConsoleIO Io { get; init; }
    public required IZapisiRepozitorijum Repozitorijum { get; init; }
    public required ILoggerServis Logger { get; init; }
    public required ZapisServis Servis { get; init; }

    public static AppContainer Create(string rezim)
    {
        IZapisiRepozitorijum repo = rezim.Equals("json", StringComparison.OrdinalIgnoreCase)
            ? new JsonZapisiRepozitorijum("podaci.json")
            : new InMemoryZapisiRepozitorijum();
        ILoggerServis logger = new FileLoggerServis();
        return new AppContainer
        {
            Io = new SystemConsoleIO(),
            Repozitorijum = repo,
            Logger = logger,
            Servis = new ZapisServis(repo, logger)
        };
    }
}
