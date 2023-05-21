using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayDeDependency
{
    public int? ChildAttrId { get; set; }

    public int ParentValueId { get; set; }

    public int? AttributeId { get; set; }

    public int? AttributeSetId { get; set; }

    public byte? Type { get; set; }
}
