using System;
using System.Collections.Generic;

namespace EFCoreWithRepPattern.Models;

public partial class CourseDatum
{
    public string Name { get; set; } = null!;

    public int Id { get; set; }

    public int Duration { get; set; }
}
