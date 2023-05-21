using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseImportvorgang
{
    public int KImportVorgang { get; set; }

    public int KImportVorlage { get; set; }

    public int KImportTyp { get; set; }

    public int NAbZeile { get; set; }

    public int NAnzahlImportiert { get; set; }

    public int NAnzahlAktualisiert { get; set; }

    public int NAnzahlWarnungen { get; set; }

    public int NAnzahlFehler { get; set; }

    public int NDauer { get; set; }

    public byte NStatus { get; set; }

    public string? CImportdatei { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CMandant { get; set; }
}
