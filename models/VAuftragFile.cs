﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftragFile
{
    public int KAuftrag { get; set; }

    public int KFile { get; set; }

    public int KBenutzer { get; set; }

    public string? CFilename { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? NDokumentTyp { get; set; }
}
