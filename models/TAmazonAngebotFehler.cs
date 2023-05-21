using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAmazonAngebotFehler
{
    public int KAmazonAngebotFehler { get; set; }

    public string CSku { get; set; } = null!;

    public int NPlattform { get; set; }

    public int KUser { get; set; }

    public string CFehlerCode { get; set; } = null!;

    public byte CFehlerTyp { get; set; }

    public string CFehlerText { get; set; } = null!;

    public DateTime DErstellt { get; set; }

    public virtual PfUser KUserNavigation { get; set; } = null!;
}
