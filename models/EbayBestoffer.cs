using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayBestoffer
{
    public string BestOfferId { get; set; } = null!;

    public string? ItemId { get; set; }

    public decimal Price { get; set; }

    public string? Currency { get; set; }

    public int? Quantity { get; set; }

    public string? UserId { get; set; }

    public string? Email { get; set; }

    public int? FeedbackScore { get; set; }

    public string? Message { get; set; }

    public byte? Status { get; set; }

    public decimal CounterPrice { get; set; }

    public int? CounterQuantity { get; set; }

    public string? CounterMessage { get; set; }

    public DateTime? ExpirationTime { get; set; }
}
