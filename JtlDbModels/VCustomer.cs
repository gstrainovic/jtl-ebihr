using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VCustomer
{
    public int KId { get; set; }

    public string? CCustomerNumber { get; set; }

    public string CFirstName { get; set; } = null!;

    public string CLastName { get; set; } = null!;

    public string CTitle { get; set; } = null!;

    public string CCompany { get; set; } = null!;

    public string CAddress { get; set; } = null!;

    public string CAddressSupplement { get; set; } = null!;

    public string CCity { get; set; } = null!;

    public string CPostalCode { get; set; } = null!;

    public string CState { get; set; } = null!;

    public string CCountry { get; set; } = null!;

    public string CPhone { get; set; } = null!;

    public string CEmailAddress { get; set; } = null!;

    public int? KCustomerGroupId { get; set; }

    public string CSalutation { get; set; } = null!;

    public string CDateOfBirth { get; set; } = null!;

    public decimal FDiscount { get; set; }

    public string CFederalTaxId { get; set; } = null!;

    public int? NDebtorNumber { get; set; }

    public byte[]? BLastChanged { get; set; }

    public int? KShop { get; set; }

    public DateTime? DLastModified { get; set; }

    public DateTime? DActive { get; set; }

    public DateTime? DInactive { get; set; }
}
