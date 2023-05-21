using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class PfAmazonVersanddienstleister
{
    public int KVersanddienstleister { get; set; }

    public string CName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<PfAmazonMappingVersandartVersanddienstleister> PfAmazonMappingVersandartVersanddienstleisters { get; set; } = new List<PfAmazonMappingVersandartVersanddienstleister>();
}
