using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tkategorie
{
    public int KKategorie { get; set; }

    public int? KOberKategorie { get; set; }

    public string? CInet { get; set; }

    public string? CAktiv { get; set; }

    public string? CDelInet { get; set; }

    public int? NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TCategoryRef> TCategoryRefs { get; set; } = new List<TCategoryRef>();

    public virtual ICollection<TVerkaufskanalKategoriemapping> TVerkaufskanalKategoriemappings { get; set; } = new List<TVerkaufskanalKategoriemapping>();
}
