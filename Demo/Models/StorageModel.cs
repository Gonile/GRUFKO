using Microsoft.EntityFrameworkCore;

namespace Demo.Models;
[PrimaryKey(nameof(Id))]
public class StorageModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int SpaceM3 { get; set; }
    public int Cost { get; set; }
    public int UsageDurationYears { get; set; }
    public int DeprecationYear => Cost / UsageDurationYears;
    public int YearlyInterest => (int)(Cost * (decimal)0.015);
    public int YearlyCostPerM3 => DeprecationYear / SpaceM3;
}