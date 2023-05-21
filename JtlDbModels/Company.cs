using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? CountryIso { get; set; }

    public string? Country { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
