using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLizenzlog
{
    public int KLizenzlog { get; set; }

    public byte NTyp { get; set; }

    public string? CAufruf { get; set; }

    public string? CLog { get; set; }

    public DateTime? DDatum { get; set; }
}
