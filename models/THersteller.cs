using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class THersteller
{
    public int KHersteller { get; set; }

    public string? CName { get; set; }

    public string? CHomepage { get; set; }

    public int? NSort { get; set; }

    public string? CMetaTitle { get; set; }

    public string? CMetaKeywords { get; set; }

    public string? CMetaDescription { get; set; }

    public string? CBeschreibung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
