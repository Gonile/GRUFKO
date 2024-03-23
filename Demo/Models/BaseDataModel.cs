using Microsoft.EntityFrameworkCore;

namespace Demo.Models;
[PrimaryKey(nameof(Id))]
public class BaseDataModel
{

    public int Id { get; set; }
    public string TvdNumber { get; set; }
    public string Name { get; set; }
    public string  Adress { get; set; }
    public string Place { get; set; }
    public string Telephone { get; set; }
    public string Canton { get; set; }
    public string EMail { get; set; }
    public string Altitude { get; set; }
    public string ProductionForm { get; set; }
    public string ProductionZone { get; set; }
    public bool SiloFeeding { get; set; }
    public string Precipitation { get; set; }
    public string LastName { get; set; }
    public string GrazingArea { get; set; }
    public string AvgBarnFieldDistance { get; set; }
}