using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tkontodaten
{
    public int KKontoDaten { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferant { get; set; }

    public string? CBankName { get; set; }

    public string? CBlz { get; set; }

    public string? CKontoNr { get; set; }

    public string? CKartenNr { get; set; }

    public string? CGueltigkeit { get; set; }

    public string? CCvv { get; set; }

    public string? CKartenTyp { get; set; }

    public string? CInhaber { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NStandard { get; set; }
}
