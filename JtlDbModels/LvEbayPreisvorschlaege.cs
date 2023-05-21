using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvEbayPreisvorschlaege
{
    public string CBestOfferId { get; set; } = null!;

    public string? CCounterMessage { get; set; }

    public decimal FCounterPrice { get; set; }

    public int? NCounterQuantity { get; set; }

    public string? CCurrency { get; set; }

    public string? CEmail { get; set; }

    public DateTime? DExpirationTime { get; set; }

    public int? NFeedbackScore { get; set; }

    public string? CItemId { get; set; }

    public string? CMessage { get; set; }

    public decimal FPrice { get; set; }

    public int? NQuantity { get; set; }

    public string? CUserId { get; set; }

    public int? KArtikel { get; set; }

    public int? KEbayUser { get; set; }

    public int? NSiteId { get; set; }

    public decimal? FEbayItemPrice { get; set; }

    public string? CTitle { get; set; }

    public string? CPlattform { get; set; }

    public string? CArtikelnummer { get; set; }
}
