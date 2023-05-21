using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPreiskalkulationLogbuch
{
    public int KLogbuch { get; set; }

    public string? CPlattform { get; set; }

    public string? CKategorie { get; set; }

    public string? CBetreff { get; set; }

    public string? CLog { get; set; }

    public DateTime? DZeit { get; set; }

    public string? CArtikel { get; set; }

    public string? CArtNr { get; set; }

    public int? KUser { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
