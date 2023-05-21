using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TCryptoVault
{
    public int KCryptoVault { get; set; }

    public int NSlotId { get; set; }

    public byte[] BDaten { get; set; } = null!;

    public byte[] BIv { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
