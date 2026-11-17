using Domain.Models;
using Application.Services;
using Database.Repositories;
using Infrastructure.Services;
using NUnit.Framework;

namespace Tests.Architecture;

[TestFixture]
public sealed class LayeringTests
{
    [Test]
    public void Domain_NemaZavisnostiOdSpoljasnjihProjekata()
    {
        string[] zabranjeni = ["Application", "Database", "Infrastructure", "Presentation"];
        string?[] reference = typeof(Zapis).Assembly.GetReferencedAssemblies().Select(x => x.Name).ToArray();
        Assert.That(reference.Intersect(zabranjeni), Is.Empty);
    }

    [Test]
    public void Application_NeZavisiOdAdaptera()
    {
        string[] zabranjeni = ["Database", "Infrastructure", "Presentation"];
        string?[] reference = typeof(ZapisServis).Assembly.GetReferencedAssemblies().Select(x => x.Name).ToArray();
        Assert.That(reference.Intersect(zabranjeni), Is.Empty);
    }

    [Test]
    public void Slojevi_SuUOdvojenimProjektima()
    {
        Assert.That(typeof(Zapis).Assembly, Is.Not.EqualTo(typeof(ZapisServis).Assembly));
        Assert.That(typeof(ZapisServis).Assembly, Is.Not.EqualTo(typeof(InMemoryZapisiRepozitorijum).Assembly));
        Assert.That(typeof(ZapisServis).Assembly, Is.Not.EqualTo(typeof(FileLoggerServis).Assembly));
    }
}
