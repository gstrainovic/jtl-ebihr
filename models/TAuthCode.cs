using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuthCode
{
    public int KAuthCode { get; set; }

    public string? CName { get; set; }

    public string? CAuthToken { get; set; }

    public int? KMandant { get; set; }

    public byte NStatus { get; set; }
}
