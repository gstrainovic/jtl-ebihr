using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Manufacturer
{
    public int ManufacturerId { get; set; }

    public string? ManufacturerName { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
