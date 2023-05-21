using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayTransaction
{
    public int KTransaction { get; set; }

    public int? KBuyer { get; set; }

    public decimal AdjustmentAmount { get; set; }

    public decimal AmountPaid { get; set; }

    public byte? BestOfferSale { get; set; }

    public string? BuyerPaidStatus { get; set; }

    public decimal ConvertedAdjustmentAmount { get; set; }

    public decimal ConvertedAmountPaid { get; set; }

    public decimal ConvertedTransactionPrice { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? FlCommentText { get; set; }

    public string? FlCommentType { get; set; }

    public string? FlTargetUser { get; set; }

    public string? FrCommentText { get; set; }

    public string? FrCommentType { get; set; }

    public string? FrTargetUser { get; set; }

    public decimal FinalValueFee { get; set; }

    public DateTime? PaidTime { get; set; }

    public int? QuantityPurchased { get; set; }

    public DateTime? ShippedTime { get; set; }

    public byte? SssExpeditedService { get; set; }

    public decimal SssShippingInsuranceCost { get; set; }

    public string? SssShippingService { get; set; }

    public decimal SssShippingServiceAdditionalCost { get; set; }

    public decimal SssShippingServiceCost { get; set; }

    public byte? StatusBuyerSelectedShipping { get; set; }

    public string? StatusCheckoutStatus { get; set; }

    public string? StatusCompleteStatus { get; set; }

    public string? StautsEBayPaymentStatus { get; set; }

    public DateTime? StatusLastTimeModified { get; set; }

    public string? StatusPaymentMethodUsed { get; set; }

    public string? TransactionId { get; set; }

    public decimal TransactionPrice { get; set; }

    public byte? Status { get; set; }

    public string? ItemId { get; set; }

    public DateTime? DZahlungsdatum { get; set; }

    public int? KBestellung { get; set; }

    public byte? KAlien { get; set; }

    public decimal Vat { get; set; }

    public byte? NCheckout { get; set; }

    public string? CDispute { get; set; }

    public string? CDisputeInfo { get; set; }

    public int? KEigenschaftKombi { get; set; }

    public string? VariationTitle { get; set; }

    public string? Sku { get; set; }

    public int SiteId { get; set; }

    public byte? NKonflikt { get; set; }

    public string? Currency { get; set; }

    public int? KEbayUser { get; set; }

    public long? NZuletztAktualisiert { get; set; }

    public virtual ICollection<TAuftragPosition> TAuftragPositions { get; set; } = new List<TAuftragPosition>();
}
