using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CategoryName
{
    public int CategoryId { get; set; }

    public string? LanguageIso { get; set; }

    public string? Name { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
