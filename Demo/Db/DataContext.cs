using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Demo.Components.Pages;
using Demo.Models;

public class DataContext : DbContext
{
    public DbSet<BaseDataModel> BaseData { get; set; }
    public DbSet<AreaModel> Areas { get; set; }
    public DbSet<MachineModel> Machines { get; set; }
    public DbSet<StorageModel> Stores { get; set; }

    public string DbPath { get; }

    public DataContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "demo2.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}