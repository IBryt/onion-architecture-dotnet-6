using ProgrammingWithPalermo.ChurchBulletin.Core.Model;
using ProgrammingWithPalermo.ChurchBulletin.Core.Queries;
using ProgrammingWithPalermo.ChurchBulletin.DataAccess.Mappings;

namespace ProgrammingWithPalermo.ChurchBulletin.DataAccess.Handlers;

public class ChurchBulletinItemByDateHandler
{
    private readonly DataContext _dataContext;

    public ChurchBulletinItemByDateHandler(DataContext dataContext)
    {
        this._dataContext = dataContext;
    }

    public IEnumerable<ChurchBulletinItem> Handle(ChurchBulletinItemByDateAndTimeQuery query)
    {
        var items = _dataContext.Set<ChurchBulletinItem>()
            .Where(item => item.Date == query.TargetDate)
            .AsEnumerable();
        return items;
    }
}