using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[PrimaryKey(nameof(Id))]
public class AreaModel
{
    public int Id { get; set; }

    public string Name { get; set; }
    public decimal AreaHa { get; set; }
    public int YearlyYieldInDt { get; set; }
    public int NumberOfHarvests { get; set; }
    
}