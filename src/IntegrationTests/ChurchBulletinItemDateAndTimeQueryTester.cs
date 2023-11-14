using ProgrammingWithPalermo.ChurchBulletin.Core.Model;
using ProgrammingWithPalermo.ChurchBulletin.Core.Queries;
using ProgrammingWithPalermo.ChurchBulletin.DataAccess.Handlers;
using ProgrammingWithPalermo.ChurchBulletin.DataAccess.Mappings;
using Shouldly;

namespace ProgrammingWithPalermo.ChurchBulletin.IntegrationTests;

public class ChurchBulletinItemDateAndTimeQueryTester
{
    [Test]
    public void ShouldGetWithinDate()
    {
        EmptyDatabase();
        var bulletin1 = new ChurchBulletinItem() { Date = new DateTime(2000, 1, 1) };
        var bulletin2 = new ChurchBulletinItem() { Date = new DateTime(1999, 1, 1) };
        var bulletin3 = new ChurchBulletinItem() { Date = new DateTime(2001, 1, 1) };
        var bulletin4 = new ChurchBulletinItem() { Date = new DateTime(2000, 1, 1) };

        using (var context = new DataContext(new TestDataConfiguration()))
        {
            context.AddRange(bulletin1, bulletin2, bulletin3, bulletin4);
            context.SaveChanges();
        }

        var query = new ChurchBulletinItemByDateAndTimeQuery(new DateTime(2000, 1, 1));
        var handler = new ChurchBulletinItemByDateHandler(new DataContext(new TestDataConfiguration()));
        IEnumerable<ChurchBulletinItem> items = handler.Handle(query);

        items.Count().ShouldBe(2);
        items.ShouldContain(bulletin1);
        items.ShouldContain(bulletin4);
        items.ShouldNotContain(bulletin2);
        items.ShouldNotContain(bulletin3);

    }

    private void EmptyDatabase()
    {
        new DatabaseEmptier().DeleteAllData();
    }
}
