using Microsoft.EntityFrameworkCore;

namespace Demo.Models;
[PrimaryKey(nameof(Id))]
public class MachineModel
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Type { get; set; }
}