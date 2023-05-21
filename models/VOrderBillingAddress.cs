using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderBillingAddress
{
    public int KOrder { get; set; }

    public string? CFirstName { get; set; }

    public string? CLastName { get; set; }

    public string? CCompany { get; set; }

    public string? CStreet { get; set; }

    public string? CZip { get; set; }

    public string? CCity { get; set; }

    public string? CPhone { get; set; }

    public string? CFax { get; set; }

    public string? CMail { get; set; }

    public string? CSalutation { get; set; }

    public string? CExtraAddressLine { get; set; }

    public string? CMobile { get; set; }

    public string? CTitle { get; set; }

    public string? CState { get; set; }

    public string? CIso { get; set; }

    public string? CAddressAddition { get; set; }

    public decimal? FDiscount { get; set; }

    public int? KCustomerGroupId { get; set; }

    public string? CDateOfBirth { get; set; }
}
