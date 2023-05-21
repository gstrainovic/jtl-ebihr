using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVersanddatenImportVorlage
{
    public int KVersanddatenImportVorlage { get; set; }

    public string CName { get; set; } = null!;

    public string CTrennzeichen { get; set; } = null!;

    public int NKopfzeilen { get; set; }

    public string CDatumsFormat { get; set; } = null!;

    public int NSpalteId { get; set; }

    public int NSpalteVersandDatum { get; set; }

    public int NSpalteTrackingNummer { get; set; }

    public int NSpalteVersandInfo { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
