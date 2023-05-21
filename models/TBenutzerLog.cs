using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBenutzerLog
{
    public int KBenutzerLog { get; set; }

    public int? KBenutzer { get; set; }

    public int? NApplikation { get; set; }

    public DateTime? DZeitstempel { get; set; }

    public string? CAktion { get; set; }

    public int? NAktionsTyp { get; set; }
}
