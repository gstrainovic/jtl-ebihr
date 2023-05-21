using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPlattform
{
    public int NPlattform { get; set; }

    public string CName { get; set; } = null!;

    public string CId { get; set; } = null!;

    public int NInet { get; set; }

    public string? CWaehrung { get; set; }

    public int NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftrag> TAuftrags { get; set; } = new List<TAuftrag>();

    public virtual ICollection<TExterneRechnung> TExterneRechnungs { get; set; } = new List<TExterneRechnung>();

    public virtual ICollection<TExternerBeleg> TExternerBelegs { get; set; } = new List<TExternerBeleg>();

    public virtual ICollection<TPlattformUeberverkaeufeMoeglich> TPlattformUeberverkaeufeMoegliches { get; set; } = new List<TPlattformUeberverkaeufeMoeglich>();

    public virtual ICollection<TRechnung1> TRechnung1s { get; set; } = new List<TRechnung1>();

    public virtual ICollection<TShopUeberverkaeufeMoeglich> TShopUeberverkaeufeMoegliches { get; set; } = new List<TShopUeberverkaeufeMoeglich>();
}
