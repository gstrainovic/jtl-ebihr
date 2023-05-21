using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TStatistikvorlagenOrdnerzuordnung
{
    public int KStatistikBenutzerordner { get; set; }

    public int KStatistikvorlagenserialisierung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
