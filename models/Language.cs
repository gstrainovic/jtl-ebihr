using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Language
{
    public int LanguageId { get; set; }

    public string? NameGerman { get; set; }

    public string? Iso2 { get; set; }

    public string? Iso3 { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
