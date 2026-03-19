namespace SportsGoodsStore.Models;

public partial class Order
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public DateOnly DateOrder { get; set; }

    public DateOnly DateDelivery { get; set; }

    public int IdPointAddresses { get; set; }

    public int IdUser { get; set; }

    public int Code { get; set; }

    public int IdStatusess { get; set; }

    public virtual PointAddress PointAddress { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}
