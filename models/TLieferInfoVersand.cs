using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLieferInfoVersand
{
    public int KBestellung { get; set; }

    public int NStatus { get; set; }

    public int NStatusEigen { get; set; }

    public int NStatusBestellt { get; set; }

    public int NStatusEigenBestellt { get; set; }

    public int NStatusBestelltBlockiert { get; set; }

    public int NStatusEigenBstelltBlockiert { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
