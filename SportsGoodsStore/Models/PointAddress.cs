using System;
using System.Collections.Generic;

namespace SportsGoodsStore.Models;

public partial class PointAddress
{
    public int Id { get; set; }

    public string Addresse { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
