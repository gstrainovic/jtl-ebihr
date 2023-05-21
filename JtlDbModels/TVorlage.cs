using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVorlage
{
    public int KVorlage { get; set; }

    public Guid BItemId { get; set; }

    public int NVorlagentyp { get; set; }

    public string CTyp { get; set; } = null!;

    public int? KVorlagenset { get; set; }

    public string CName { get; set; } = null!;

    public int? KFirma { get; set; }

    public int? KSprache { get; set; }

    public int? KKundengruppe { get; set; }

    public int? KLieferant { get; set; }

    public int? KWarenlager { get; set; }

    public int? KPlattform { get; set; }

    public string? CMahnstufe { get; set; }

    public string CDescriptor { get; set; } = null!;

    public DateTime? DLastModification { get; set; }

    public Guid? BParentItemId { get; set; }

    public Guid? BOriginItemId { get; set; }

    public string? COriginVersion { get; set; }

    public string? COriginDescription { get; set; }

    public DateTime? DOriginLastModification { get; set; }

    public byte[] BDaten { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public int? NVorlagensettypId { get; set; }

    public int? KVersandart { get; set; }

    public virtual TVorlagenset? KVorlagensetNavigation { get; set; }
}
