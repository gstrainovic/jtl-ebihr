using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class DunningInvoiceBillToAddress
{
    public int InvoiceInternalId { get; set; }

    public int? CustomerInternalId { get; set; }

    public string Company { get; set; } = null!;

    public string Salutation { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string CompanySupplement { get; set; } = null!;

    public string AddressSupplement { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string State { get; set; } = null!;

    public string CountryIso { get; set; } = null!;

    public string CustomerNumber { get; set; } = null!;

    public string ValueAddedTaxId { get; set; } = null!;
}
