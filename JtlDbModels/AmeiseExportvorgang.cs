using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class AmeiseExportvorgang
{
    public int KExportVorgang { get; set; }

    public int KExportVorlage { get; set; }

    public int KExportTyp { get; set; }

    public int NAnzahlExportiert { get; set; }

    public int NAnzahlExportiertVon { get; set; }

    public int NDauer { get; set; }

    public byte NStatus { get; set; }

    public string? CDatei { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CMandant { get; set; }
}
