using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TErlaubterDateityp
{
    public int KErlaubterDateityp { get; set; }

    public string? CDateityp { get; set; }

    public int KBenutzerErsteller { get; set; }

    public DateTime DErstelldatum { get; set; }
}
