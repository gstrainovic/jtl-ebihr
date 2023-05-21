using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Parcel
{
    public int ParcelId { get; set; }

    public int DeliveryNoteId { get; set; }

    public int? ShippingMethodId { get; set; }

    public int SystemUserId { get; set; }

    public DateTime? CreationDate { get; set; }

    public decimal ParcelWeight { get; set; }

    public DateTime? ArrivedDate { get; set; }

    public string? IdentCode { get; set; }

    public int? PackingDuration { get; set; }

    public byte Status { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
