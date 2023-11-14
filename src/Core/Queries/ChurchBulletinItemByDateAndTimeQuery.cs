namespace ProgrammingWithPalermo.ChurchBulletin.Core.Queries;

public class ChurchBulletinItemByDateAndTimeQuery
{
    private DateTime TargetDate { get; }

    public ChurchBulletinItemByDateAndTimeQuery(DateTime targetDate)
    {
        TargetDate = targetDate;
    }
}
