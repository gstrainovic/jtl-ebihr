using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFormularLlvorlageDaten
{
    public int KFormularLlvorlageDaten { get; set; }

    public DateTime DAktualisiert { get; set; }

    public byte[] BDaten { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
