using ProgrammingWithPalermo.ChurchBulletin.Core.Model;
using ProgrammingWithPalermo.ChurchBulletin.DataAccess.Mappings;
using Shouldly;

namespace ProgrammingWithPalermo.ChurchBulletin.IntegrationTests;

public class ChurchBulletinMappingTester

{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldNapChurchBulletin()
    {
        var bulletin = new ChurchBulletinItem();
        bulletin.Name = "worship service";
        bulletin.Place = "Sanctuary";
        bulletin.Date = new DateTime(2022, 1, 1);

        using (var context = new DataContext(new TestDataConfiguration()))
        {
            context.Add(bulletin);
            context.SaveChanges();
        }

        ChurchBulletinItem? rehydratedEntity;
        using (var context = new DataContext(new TestDataConfiguration()))
        {
            rehydratedEntity = context.Set<ChurchBulletinItem>()
                .SingleOrDefault(b => b == bulletin);
        }
        rehydratedEntity.ShouldBe(bulletin);
        rehydratedEntity!.Id.ShouldBe(bulletin.Id);
        rehydratedEntity!.Name.ShouldBe(bulletin.Name);
        rehydratedEntity!.Place.ShouldBe(bulletin.Place);

    }
}
