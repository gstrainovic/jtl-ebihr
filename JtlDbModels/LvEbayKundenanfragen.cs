using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEbayKundenanfragen
{
    public string? DCreationDate { get; set; }

    public string? CItemId { get; set; }

    public int KMemberMessageIn { get; set; }

    public byte? NPublic { get; set; }

    public string? CMessageId { get; set; }

    public string? CSenderId { get; set; }

    public string? CSubject { get; set; }

    public string? CMessage { get; set; }

    public byte? NStatus { get; set; }

    public int? KArtikel { get; set; }

    public int? KEbayUser { get; set; }

    public int? KEbayItem { get; set; }

    public int? NSiteId { get; set; }

    public decimal? FEbayItemPrice { get; set; }

    public string? CTitle { get; set; }

    public string? CEbayUserName { get; set; }

    public string? CPlattform { get; set; }

    public string? CArtikelnummer { get; set; }

    public decimal? FVerfuegbar { get; set; }
}
