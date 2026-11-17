using NUnit.Framework;
using Shared;

namespace Tests.Application;

[TestFixture]
public sealed class ResultTests
{
    [Test]
    public void Failure_NosiSifruIPorukuGreske()
    {
        Result rezultat = Result.Failure("provera", "Neispravan unos");
        Assert.Multiple(() =>
        {
            Assert.That(rezultat.IsFailure, Is.True);
            Assert.That(rezultat.Error?.Code, Is.EqualTo("provera"));
        });
    }
}
