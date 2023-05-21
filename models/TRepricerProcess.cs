using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRepricerProcess
{
    public int NId { get; set; }

    public string CMandant { get; set; } = null!;

    public DateTime DUpdated { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
