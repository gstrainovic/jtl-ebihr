using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVorlagensetEinstellung
{
    public int KVorlagensetEinstellung { get; set; }

    public int KVorlagenset { get; set; }

    public string CRechnername { get; set; } = null!;

    public int KBenutzer { get; set; }

    public string? CDruckername1 { get; set; }

    public int? NKopien1 { get; set; }

    public string? CDruckername2 { get; set; }

    public int? NKopien2 { get; set; }

    public string? CFaxname { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TVorlagenset KVorlagensetNavigation { get; set; } = null!;
}
