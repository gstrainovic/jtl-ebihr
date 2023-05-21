using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TResourceAbsenteeism
{
    public int KResourceAbsenteeism { get; set; }

    public int KResource { get; set; }

    public DateTimeOffset DFrom { get; set; }

    public DateTimeOffset DTo { get; set; }

    public string? CDescription { get; set; }

    public int KAbsenteeismType { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TAbsenteeismType KAbsenteeismTypeNavigation { get; set; } = null!;

    public virtual TResource KResourceNavigation { get; set; } = null!;
}
