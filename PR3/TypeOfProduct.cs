using System;
using System.Collections.Generic;

namespace PR3;

public partial class TypeOfProduct
{
    public short Id { get; set; }

    public string TypeOfProduct1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
