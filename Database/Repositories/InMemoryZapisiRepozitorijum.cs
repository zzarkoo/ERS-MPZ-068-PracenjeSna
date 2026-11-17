using Application.Interfaces.Repositories;
using Domain.Models;
using Shared;

namespace Database.Repositories;

// TODO: implementirati skladištenje u memoriji.
public sealed class InMemoryZapisiRepozitorijum : IZapisiRepozitorijum
{
    public Result Sacuvaj(Zapis zapis) =>
        Result.Failure("repo.nije_implementirano", "Implementirati cuvanje u memoriji.");

    public Result<Zapis> Pronadji(Guid id) =>
        Result<Zapis>.Failure("repo.nije_implementirano", "Implementirati pretragu po ID-u.");

    public Result<IReadOnlyList<Zapis>> Svi() =>
        Result<IReadOnlyList<Zapis>>.Failure("repo.nije_implementirano", "Implementirati pregled.");

    public Result Obrisi(Guid id) =>
        Result.Failure("repo.nije_implementirano", "Implementirati brisanje.");
}
