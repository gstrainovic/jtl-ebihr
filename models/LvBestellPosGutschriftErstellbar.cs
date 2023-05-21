using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvBestellPosGutschriftErstellbar
{
    public int KBestellPos { get; set; }

    public int? TArtikelKArtikel { get; set; }

    public int TBestellungKBestellung { get; set; }

    public decimal? FVkpreis { get; set; }

    public decimal FMwSt { get; set; }

    public decimal? NAnzahl { get; set; }

    public decimal FRabatt { get; set; }

    public string? CString { get; set; }

    public decimal FVkNetto { get; set; }

    public string? CArtNr { get; set; }

    public byte NType { get; set; }

    public string? CHinweis { get; set; }

    public int? NHatUpload { get; set; }

    public string? CUnique { get; set; }

    public int? KKonfigItem { get; set; }

    public byte? NDropshipping { get; set; }

    public decimal FEkNetto { get; set; }

    public string? COrderItemId { get; set; }

    public string? CItemId { get; set; }

    public string? CTransactionId { get; set; }

    public int? KAmazonBestellungPos { get; set; }

    public int NSort { get; set; }

    public int? KBestellStueckliste { get; set; }

    public string? CStringStandard { get; set; }

    public string? CEinheit { get; set; }
}
