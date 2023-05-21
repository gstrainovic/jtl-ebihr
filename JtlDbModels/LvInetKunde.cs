using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvInetKunde
{
    public int KInetKunde { get; set; }

    public int? KKundenGruppe { get; set; }

    public string? CVorname { get; set; }

    public string? CNachname { get; set; }

    public string? CFirma { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? CStadt { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CMail { get; set; }

    public string? CUstid { get; set; }

    public string? CBenutzername { get; set; }

    public int KShop { get; set; }
}
