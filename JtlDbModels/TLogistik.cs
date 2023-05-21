using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLogistik
{
    public int KLogistik { get; set; }

    public string? CName { get; set; }

    public string? CUrl { get; set; }

    public byte? NStandard { get; set; }

    public string? CAmazonCc { get; set; }

    public string? CEbayCc { get; set; }

    public int KVersanddatenExportVorlage { get; set; }

    public int? KVersanddatenImportVorlage { get; set; }

    public byte? NPaketeAutomatischErzeugen { get; set; }

    public decimal FMaxGewicht { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
