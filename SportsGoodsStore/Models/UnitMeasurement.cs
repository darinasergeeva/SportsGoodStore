using System;
using System.Collections.Generic;

namespace SportsGoodsStore.Models;

public partial class UnitMeasurement
{
    public int Id { get; set; }

    public string NameUnitMeasurement { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
