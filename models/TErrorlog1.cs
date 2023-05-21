using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TErrorlog1
{
    public int KMandant { get; set; }

    public byte NAbgleichstyp { get; set; }

    public int KZiel { get; set; }

    public DateTime DZeitstempelUtc { get; set; }

    public string CMeldung { get; set; } = null!;
}
