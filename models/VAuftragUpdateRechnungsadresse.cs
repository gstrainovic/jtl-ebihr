using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragUpdateRechnungsadresse
{
    public int KAuftrag { get; set; }

    public string? CAnrede { get; set; }

    public string? CVorname { get; set; }

    public string? CNachname { get; set; }

    public string? CTitel { get; set; }

    public string CFirma { get; set; } = null!;

    public string? CStrasse { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CBundesland { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CMobil { get; set; }

    public string? CFax { get; set; }

    public string? CUstid { get; set; }

    public string? CWww { get; set; }

    public string? CMail { get; set; }
}
