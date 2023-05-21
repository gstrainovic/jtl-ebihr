using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPicklisteVorlageStartZielLager
{
    public int KPicklisteVorlage { get; set; }

    public int KWarenlager { get; set; }

    public bool NStartLagerAktiv { get; set; }

    public bool NZiellagerAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
