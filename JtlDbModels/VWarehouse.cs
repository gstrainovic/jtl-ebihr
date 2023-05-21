using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VWarehouse
{
    public int Pk { get; set; }

    public string? Name { get; set; }

    public string? WarehouseId { get; set; }

    public string? AddressSalutation { get; set; }

    public string? AddressFirstname { get; set; }

    public string? AddressLastname { get; set; }

    public string? AddressCompany { get; set; }

    public string? AddressStreet { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressCountry { get; set; }

    public string? AddressEmail { get; set; }

    public string? AddressPhone { get; set; }

    public string? AddressState { get; set; }

    public string? AddressFax { get; set; }

    public string? AddressZip { get; set; }

    public byte Active { get; set; }

    public byte FulfillmentType { get; set; }
}
