using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TStatistikvorlagenOrdnerzuordnung
{
    public int KStatistikBenutzerordner { get; set; }

    public int KStatistikvorlagenserialisierung { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
