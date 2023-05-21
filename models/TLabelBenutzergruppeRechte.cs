using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLabelBenutzergruppeRechte
{
    public int KLabelBenutzergruppeRechte { get; set; }

    public int KLabel { get; set; }

    public int KRechtBenutzerGruppe { get; set; }

    public bool NIstSichtbar { get; set; }

    public virtual TLabel KLabelNavigation { get; set; } = null!;
}
