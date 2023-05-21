using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCryptoSlot
{
    public int KCryptoSlot { get; set; }

    public int NSlotId { get; set; }

    public int KBenutzer { get; set; }

    public byte[] BCryptedSlotkey { get; set; } = null!;

    public int KBenutzerZugewiesenDurch { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
