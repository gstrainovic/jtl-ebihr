using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TFormularEmailVorlageAnhang
{
    public int KFormularEmailVorlageAnhang { get; set; }

    public int KFormularVorlage { get; set; }

    public string CName { get; set; } = null!;

    public byte NTyp { get; set; }

    public int? KFormularAnhangDaten { get; set; }

    public int? NKindElement { get; set; }

    public int? NFormular { get; set; }

    public byte? NAusgabetyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
