using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVorgangsstatus
{
    public int KVorgangsstatus { get; set; }

    public string? CName { get; set; }

    public byte? NAngebot { get; set; }

    public byte? NAuftrag { get; set; }

    public byte? NRechnung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte? NAbonnement { get; set; }
}
