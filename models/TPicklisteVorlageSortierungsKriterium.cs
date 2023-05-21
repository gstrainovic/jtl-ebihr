using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageSortierungsKriterium
{
    public int KPicklisteVorlage { get; set; }

    public bool NAktiv { get; set; }

    public byte NSort { get; set; }

    public byte NId { get; set; }

    public bool Aufsteigend { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
