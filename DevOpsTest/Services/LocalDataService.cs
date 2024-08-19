using DevOpsTest.Models;

namespace DevOpsTest.Services;

public class LocalDataService : IDataService
{

    static readonly List<UserData> Data = new List<UserData>();

    public string? GetText(int id)
    {

        return Data.FirstOrDefault(o => o.Id == id)?.Text;

    }

    public int SetText(string text)
    {
        
        lock (Data)
        {

            var data = new UserData()
            {
                Id = UserData.Count,
                Text = text
            };
            Data.Add(data);
            return data.Id;

        }

    }
}
