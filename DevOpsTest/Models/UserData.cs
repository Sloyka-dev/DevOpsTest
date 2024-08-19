using System.ComponentModel.DataAnnotations;

namespace DevOpsTest.Models;

public class UserData
{

    private static int count = 0;
    public static int Count {  get { return ++count; } }

    [Key]
    public int Id { get; set; }
    public string Text { get; set; }

}
