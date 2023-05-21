using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonMappingVersandartVersanddienstleister
{
    public int KVersandartDienstleisterMapping { get; set; }

    public int KVersandArt { get; set; }

    public int KVersanddienstleister { get; set; }

    public bool NIstAktiv { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual Tversandart KVersandArtNavigation { get; set; } = null!;

    public virtual PfAmazonVersanddienstleister KVersanddienstleisterNavigation { get; set; } = null!;
}
