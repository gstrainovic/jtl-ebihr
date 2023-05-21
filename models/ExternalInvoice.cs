using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class ExternalInvoice
{
    public int InternalId { get; set; }

    public int? CustomerId { get; set; }

    public int? UserId { get; set; }

    public int CompanyInternalId { get; set; }

    public int PlatformId { get; set; }

    public int? AmazonUserId { get; set; }

    public string ExternalInvoiceNumber { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string SellerVatid { get; set; } = null!;

    public string SellerVatcountryIso { get; set; } = null!;

    public string BuyerVatid { get; set; } = null!;

    public string BuyerVatcountryIso { get; set; } = null!;

    public byte BuyerVatidType { get; set; }

    public string? SdiaccountNumber { get; set; }

    public bool VatidCalculationAddress { get; set; }

    public string TaxAuthorityLevel { get; set; } = null!;

    public string TaxAuthority { get; set; } = null!;

    public string? CurrencyIso { get; set; }

    public decimal CurrencyFactor { get; set; }

    public DateTime? CurrencyFactorDate { get; set; }

    public decimal? FUmgerechneterGesamtUstBetrag { get; set; }

    public string? BillingAddressCompany { get; set; }

    public string? BillingAddressSalutation { get; set; }

    public string? BillingAddressTitle { get; set; }

    public string? BillingAddressFirstname { get; set; }

    public string? BillingAddressLastname { get; set; }

    public string? BillingAddressStreet { get; set; }

    public string? BillingAddressCity { get; set; }

    public string? BillingAddressZipCode { get; set; }

    public string? BillingAddressCountry { get; set; }
}
