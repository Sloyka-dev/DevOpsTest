using DevOpsTest.Models;

namespace DevOpsTest.Services;

public class BdDataService : IDataService
{

    private readonly GameBdContext context;

    public BdDataService(GameBdContext context)
    {
        this.context = context;
    }   

    public string? GetText(int id)
    {
        return context.Users.FirstOrDefault(x => x.Id == id)?.Text;
    }

    public int SetText(string text)
    {
        var data = new UserData()
        {
            Text = text
        };
        lock (context.Users)
        {
            context.Users.Add(data);
            context.SaveChanges();
        }
        return data.Id;
    }
}
