using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VHealthCheck
{
    public int KHc { get; set; }

    public string? CHerkunftText { get; set; }

    public string? CSchweregrad { get; set; }

    public string? CFehlercode { get; set; }

    public string? CMeldung { get; set; }

    public string? CObjekt { get; set; }

    public string? CBezugsObjekt { get; set; }

    public string? CObjektTyp { get; set; }

    public string? CObjektDetailIst { get; set; }

    public string? CObjektDetailSoll { get; set; }

    public string? CObjektReparatur { get; set; }

    public string? CLink { get; set; }

    public DateTime DErstelltUtc { get; set; }
}
