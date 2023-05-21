using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfLogbuch
{
    public int KLogbuch { get; set; }

    public byte? KPlattform { get; set; }

    public string? CKategorie { get; set; }

    public string? CBetreff { get; set; }

    public string? CLog { get; set; }

    public DateTime? DZeit { get; set; }

    public byte? KUser { get; set; }
}
