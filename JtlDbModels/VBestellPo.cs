using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellPo
{
    public int KBestellPos { get; set; }

    public int KBestellung { get; set; }

    public byte NBestellungTyp { get; set; }

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

    public decimal? FAnzahlOffen { get; set; }

    public decimal? FLagerbestand { get; set; }

    public byte NIstChargenartikel { get; set; }

    public byte NIstMhdartikel { get; set; }

    public int NIstSeriennummernartikel { get; set; }

    public int NIstLagerfuehrend { get; set; }

    public decimal FVersandgewicht { get; set; }

    public decimal? FTeillieferungFaktor { get; set; }

    public string? CVariationen { get; set; }

    public int NSperrungStatus { get; set; }

    public int NWarnungStatus { get; set; }

    public int? KSessionId { get; set; }

    public int NIstUmlagerung { get; set; }
}
