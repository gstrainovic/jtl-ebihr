using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierNumber { get; set; }

    public string? SupplierName { get; set; }

    public string? Postalcode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? CountryIso { get; set; }

    public int? DaysForPayment { get; set; }

    public decimal MinimumOrderValue { get; set; }

    public decimal MinimumQuantitySurcharge { get; set; }

    public decimal DeliveryCost { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
