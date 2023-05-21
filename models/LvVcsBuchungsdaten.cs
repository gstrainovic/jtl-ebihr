using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvVcsBuchungsdaten
{
    public string? VatinvoiceNumber { get; set; }

    public string? OrderId { get; set; }

    public int KUser { get; set; }

    public DateTime? ShipmentDate { get; set; }
}
