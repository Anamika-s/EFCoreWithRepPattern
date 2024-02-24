using System;
using System.Collections.Generic;

namespace EFCoreWithRepPattern.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Batch { get; set; } = null!;

    public int Marks { get; set; }

    public string Address { get; set; } = null!;
}
