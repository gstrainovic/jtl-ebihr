using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TRechnungKorrektur
{
    public int KRechnungskorrektur { get; set; }

    public int KRechnung { get; set; }

    public int KRechnungNeu { get; set; }

    public virtual TRechnung1 KRechnungNavigation { get; set; } = null!;

    public virtual TRechnung1 KRechnungNeuNavigation { get; set; } = null!;

    public virtual Tgutschrift KRechnungskorrekturNavigation { get; set; } = null!;
}
