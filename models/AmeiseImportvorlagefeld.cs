using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AmeiseImportvorlagefeld
{
    public int KImportVorlageFeld { get; set; }

    public int KImportVorlage { get; set; }

    public string? CTable { get; set; }

    public string? CDbname { get; set; }

    public int NSpalte { get; set; }

    public int NKey { get; set; }

    public int NKey2 { get; set; }

    public string? CStandardWert { get; set; }

    public byte NTyp { get; set; }

    public string? CExt { get; set; }

    public string? CName { get; set; }

    public string? CDbtyp { get; set; }

    public int? NLaenge { get; set; }

    public string? CValidation { get; set; }
}
