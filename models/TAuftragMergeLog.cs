using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragMergeLog
{
    public int KAuftrag { get; set; }

    public int KAuftragAlt { get; set; }

    public DateTime DMerge { get; set; }

    public int KBenutzer { get; set; }
}
