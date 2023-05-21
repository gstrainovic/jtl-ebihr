using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tinetkunde
{
    public int KInetKunde { get; set; }

    public string? CKundenNr { get; set; }

    public string? CBenutzername { get; set; }

    public string? CPasswort { get; set; }

    public string? CAnrede { get; set; }

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

    public string? CHaendler { get; set; }

    public decimal FRabatt { get; set; }

    public string? CUstid { get; set; }

    public string? CTitel { get; set; }

    public string? CNewsletter { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CGeburtstag { get; set; }

    public string? CWww { get; set; }

    public int KShop { get; set; }

    public int? KKundenGruppe { get; set; }

    public string? CMobil { get; set; }

    public byte? NAktiv { get; set; }

    public int? KSprache { get; set; }

    public string? CBundesland { get; set; }

    public string? CHerkunft { get; set; }

    public short? NRegistriert { get; set; }

    public string? CZusatz { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
