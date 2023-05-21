using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class SqlServerVersion
{
    public byte MajorVersionNumber { get; set; }

    public short MinorVersionNumber { get; set; }

    public string Branch { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public DateTime MainstreamSupportEndDate { get; set; }

    public DateTime ExtendedSupportEndDate { get; set; }

    public string MajorVersionName { get; set; } = null!;

    public string MinorVersionName { get; set; } = null!;
}
