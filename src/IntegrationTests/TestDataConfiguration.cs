
using ProgrammingWithPalermo.ChurchBulletin.DataAccess;

public class TestDataConfiguration : IDataConfiguration
{


    public TestDataConfiguration()
    {

    }

    public string GetConnectionString()
    {
        return "server=(LocalDb)\\MSSQLLocalDB;database=ChurchBulletin;Integrated Security=true;";
    }
}