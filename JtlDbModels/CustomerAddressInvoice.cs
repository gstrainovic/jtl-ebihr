using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerAddressInvoice
{
    public int CustomerOrderId { get; set; }

    public int CustomerId { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? CountryIso { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
