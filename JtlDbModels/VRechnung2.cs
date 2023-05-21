using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VRechnung2
{
    public int? KAuftrag { get; set; }

    public int? KRechnung { get; set; }

    public string? CRechnungsnr { get; set; }

    public DateTime DErstellt { get; set; }

    public int NIstEntwurf { get; set; }

    public int? KKunde { get; set; }

    public int? KFarbe { get; set; }

    public int? KFirmaHistory { get; set; }

    public int? KBenutzer { get; set; }

    public int? KZahlungsart { get; set; }

    public int? KSprache { get; set; }

    public string? CVersandlandIso { get; set; }

    public int? KPlattform { get; set; }

    public int? KVersandArt { get; set; }

    public decimal FFaktor { get; set; }

    public bool NStorno { get; set; }

    public int NKorrigiert { get; set; }

    public byte NIstExterneRechnung { get; set; }
}
