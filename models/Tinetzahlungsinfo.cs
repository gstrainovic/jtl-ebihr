using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tinetzahlungsinfo
{
    public int KInetZahlungsInfo { get; set; }

    public int? KInetBestellung { get; set; }

    public string? CBankName { get; set; }

    public string? CBlz { get; set; }

    public string? CKontoNr { get; set; }

    public string? CKartenNr { get; set; }

    public string? CGueltigkeit { get; set; }

    public string? CCvv { get; set; }

    public string? CKartenTyp { get; set; }

    public string? CInhaber { get; set; }

    public int? KBestellung { get; set; }

    public int KShop { get; set; }

    public string? CIban { get; set; }

    public string? CBic { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
