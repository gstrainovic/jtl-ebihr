using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TSendungsdatenaustausch
{
    public int KVorlage { get; set; }

    public byte? NVorlagenTyp { get; set; }

    public int? KVersanddatenVorlage { get; set; }

    public string? CVorlagenName { get; set; }

    public string? CSpeicherpfad { get; set; }

    public bool? NImportServiceActive { get; set; }

    public bool? NIsActive { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
