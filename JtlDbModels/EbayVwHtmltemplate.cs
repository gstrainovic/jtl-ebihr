using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayVwHtmltemplate
{
    public int KEbayHtmlTemplate { get; set; }

    public string CHtmlTemplateName { get; set; } = null!;

    public string CHtmlTemplateDescription { get; set; } = null!;

    public DateTime DCreated { get; set; }

    public byte NIsDefault { get; set; }

    public DateTime? DUploaded { get; set; }

    public int? NEbayHtmlTemplateParent { get; set; }

    public int KEbayHtmlTemplateData { get; set; }

    public byte NDeleted { get; set; }
}
