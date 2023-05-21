using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersanddatenExportVorlage
{
    public int KVersanddatenExportVorlage { get; set; }

    public string CName { get; set; } = null!;

    public string CContentXml { get; set; } = null!;

    public string CFilenameTemplate { get; set; } = null!;

    public byte NExistingFileAction { get; set; }

    public int? KAdressExportVorlage { get; set; }

    public byte NExpertenmodus { get; set; }

    public string CPathTemplate { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
