using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VVcsLiteGutschriftOffenerBeleg
{
    public string? TransactionId { get; set; }

    public int KUser { get; set; }

    public DateTime? DVerarbeitetUtc { get; set; }

    public DateTime? DAktualisiertUtc { get; set; }
}
