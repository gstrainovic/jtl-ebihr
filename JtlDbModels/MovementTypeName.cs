using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class MovementTypeName
{
    public int MovementTypeId { get; set; }

    public string LanguageIso { get; set; } = null!;

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
