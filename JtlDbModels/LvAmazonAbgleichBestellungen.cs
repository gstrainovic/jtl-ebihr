using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAmazonAbgleichBestellungen
{
    public int KAmazonBestellung { get; set; }

    public string? COrderId { get; set; }

    public string? CBuyerName { get; set; }

    public string? CBuyerEmail { get; set; }

    public string? CBuyerPhonenumber { get; set; }

    public string? CBilladdress1 { get; set; }

    public string? CBilladdress2 { get; set; }

    public string? CBilladdress3 { get; set; }

    public string? CBillCity { get; set; }

    public string? CBillState { get; set; }

    public string? CBillPostalcode { get; set; }

    public string? CBillCountry { get; set; }

    public string? CRecipientName { get; set; }

    public string? CShipAddress1 { get; set; }

    public string? CShipaddress2 { get; set; }

    public string? CShipaddress3 { get; set; }

    public string? CShipCity { get; set; }

    public string? CShipState { get; set; }

    public string? CShipPostalcode { get; set; }

    public string? CShipCountry { get; set; }

    public string? CShipPhonenumber { get; set; }

    public string? CCurrency { get; set; }

    public string? CShipserviceleve { get; set; }

    public decimal FItemPromotionDiscount { get; set; }

    public string? CItemPromotionId { get; set; }

    public string? CShippromotionId { get; set; }

    public DateTime? DPaymentsDate { get; set; }

    public DateTime? DPurchaseDate { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CName { get; set; }

    public int KUser { get; set; }
}
