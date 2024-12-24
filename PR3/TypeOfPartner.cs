using System;
using System.Collections.Generic;

namespace PR3;

public partial class TypeOfPartner
{
    public short Id { get; set; }

    public string TypeOfPartner1 { get; set; } = null!;

    public virtual ICollection<Pertner> Pertners { get; set; } = new List<Pertner>();
}
