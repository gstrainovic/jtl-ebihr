using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLizenz
{
    public string CAuthId { get; set; } = null!;

    public string? CAuthToken { get; set; }

    public byte[]? BLizenzen { get; set; }

    public byte[]? BSignatur { get; set; }

    public DateTime? DDatum { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public DateTime DLetzteAktualisierung { get; set; }

    public int NAktualisierungsZaehler { get; set; }

    public int NAktualisierungsSperrZaehler { get; set; }
}
