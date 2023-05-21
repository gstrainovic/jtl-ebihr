using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonFulfillmentAuftragPo
{
    public int KFulfillmentAuftragPos { get; set; }

    public int? KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CName { get; set; }

    public decimal FAnzahl { get; set; }

    public int? NStatus { get; set; }

    public string? CArtikelGeschenkText { get; set; }

    public string? CArtikelHinweis { get; set; }

    public string CIdentCode { get; set; } = null!;

    public string? CErrorType { get; set; }

    public int? NErrorCode { get; set; }

    public string? CErrorMessage { get; set; }

    public string? CAbhilfe { get; set; }

    public int? KFulfillmentAuftrag { get; set; }
}
