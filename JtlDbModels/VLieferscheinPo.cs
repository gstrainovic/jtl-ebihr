using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VLieferscheinPo
{
    public int KLieferscheinPos { get; set; }

    public int KLieferschein { get; set; }

    public int KBestellPos { get; set; }

    public int KBestellung { get; set; }

    public byte? NTyp { get; set; }

    public int KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CString { get; set; }

    public string? CStringStandard { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal FVknetto { get; set; }

    public decimal FVkpreis { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FRabatt { get; set; }

    public string? CHinweis { get; set; }

    public string? CHinweisBestellung { get; set; }

    public int? NHatUpload { get; set; }

    public string? CUnique { get; set; }

    public int KBestellStueckliste { get; set; }

    public int? KKonfigitem { get; set; }

    public decimal FEknetto { get; set; }

    public string? COrderItemId { get; set; }

    public string? CItemId { get; set; }

    public string? CTransactionId { get; set; }

    public int? KAmazonBestellungPos { get; set; }

    public int NSort { get; set; }

    public decimal FAnzahlBestellung { get; set; }

    public decimal? FAnzahlOffen { get; set; }

    public int? KSessionId { get; set; }
}
