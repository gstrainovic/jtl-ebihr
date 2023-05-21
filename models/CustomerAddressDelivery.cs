﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class CustomerAddressDelivery
{
    public int CustomerOrderId { get; set; }

    public int CustomerId { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? CountryIso { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
