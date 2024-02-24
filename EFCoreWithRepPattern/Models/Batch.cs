using System;
using System.Collections.Generic;

namespace EFCoreWithRepPattern.Models;

public partial class Batch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Strength { get; set; }

    public string Course { get; set; } = null!;
}
