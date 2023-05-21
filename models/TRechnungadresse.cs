using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungadresse
{
    public int KInetBestellung { get; set; }

    public int KShop { get; set; }

    public int KRechnungadresse { get; set; }

    public int? KInetKunde { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? CVorname { get; set; }

    public string? CNachname { get; set; }

    public string? CFirma { get; set; }

    public string? CZusatz { get; set; }

    public string? CStrasse { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CBundesland { get; set; }

    public string? CLand { get; set; }

    public string? CLandIso { get; set; }

    public string? CTel { get; set; }

    public string? CMobil { get; set; }

    public string? CFax { get; set; }

    public string? CUstid { get; set; }

    public string? CWww { get; set; }

    public string? CMail { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
