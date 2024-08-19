namespace DevOpsTest.Services
{
    public interface IDataService
    {

        string? GetText(int id);
        int SetText(string text);

    }
}
