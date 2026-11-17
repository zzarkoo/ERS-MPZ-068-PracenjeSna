using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Models;
using Shared;

namespace Application.Services;

// Polazna struktura servisa; poslovne operacije nisu implementirane.
public sealed class ZapisServis
{
    private readonly IZapisiRepozitorijum _repozitorijum;
    private readonly ILoggerServis _logger;

    public ZapisServis(IZapisiRepozitorijum repozitorijum, ILoggerServis logger)
    {
        _repozitorijum = repozitorijum ?? throw new ArgumentNullException(nameof(repozitorijum));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Result Dodaj(Zapis zapis)
    {
        // TODO: definisati poslovna pravila i pozvati repozitorijum.
        // Primer pokazuje gde pripada use case, ne daje rešenje zadatka.
        return Result.Failure("zadatak.nije_implementirano", "Implementirati prema specifikaciji.");
    }
}
