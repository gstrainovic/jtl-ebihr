using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvKunde
{
    public int KKunde { get; set; }

    public string? CKundenNr { get; set; }

    public string? CEbayName { get; set; }

    public string? CGeburtstag { get; set; }

    public string? CWww { get; set; }

    public string? CName { get; set; }

    public string? CVorname { get; set; }

    public string? CTel { get; set; }

    public string? CFax { get; set; }

    public string? CEmail { get; set; }

    public string? CFirma { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CZusatz { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? CStrasse { get; set; }

    public string? CAdressZusatz { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CMobil { get; set; }

    public decimal FRabatt { get; set; }

    public string? CUstid { get; set; }

    public bool? Newsletter { get; set; }

    public string? CPostId { get; set; }

    public int? NZahlungsziel { get; set; }

    public string? CBundesland { get; set; }

    public string? CHerkunft { get; set; }

    public bool? KassenKunde { get; set; }

    public bool? Gesperrt { get; set; }

    public int? KBuyer { get; set; }

    public int KInetKunde { get; set; }

    public string? CHrnr { get; set; }

    public int NDebitorennr { get; set; }

    public string? KundenKategorie { get; set; }

    public string? KundenGruppe { get; set; }

    public int? KKundenKategorie { get; set; }

    public int? KKundenGruppe { get; set; }

    public bool? NJtlFulfillment { get; set; }

    public string? Label { get; set; }
}
