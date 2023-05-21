using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVorlagenset
{
    public int KVorlagenset { get; set; }

    public int NVorlagensettyp { get; set; }

    public string CName { get; set; } = null!;

    public bool NIstStandard { get; set; }

    public int NFlags { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NIstGlobal { get; set; }

    public virtual ICollection<TArtikelMehrzweckGutschein> TArtikelMehrzweckGutscheins { get; set; } = new List<TArtikelMehrzweckGutschein>();

    public virtual ICollection<TProdItem> TProdItems { get; set; } = new List<TProdItem>();

    public virtual ICollection<TVorlagensetEinstellung> TVorlagensetEinstellungs { get; set; } = new List<TVorlagensetEinstellung>();

    public virtual ICollection<TVorlage> TVorlages { get; set; } = new List<TVorlage>();
}
