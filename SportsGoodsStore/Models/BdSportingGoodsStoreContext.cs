using Microsoft.EntityFrameworkCore;

namespace SportsGoodsStore.Models;

public partial class BdSportingGoodsStoreContext : DbContext
{
    public BdSportingGoodsStoreContext()
    {
    }

    public BdSportingGoodsStoreContext(DbContextOptions<BdSportingGoodsStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<PointAddress> PointAddresses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsOrder> ProductsOrders { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UnitMeasurement> UnitMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bd_sporting_goods_store;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategorieName).HasColumnName("categorie_name");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManufacturerName).HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DateDelivery).HasColumnName("date_delivery");
            entity.Property(e => e.DateOrder).HasColumnName("date_order");
            entity.Property(e => e.IdPointAddresses)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_point_addresses");
            entity.Property(e => e.IdStatusess)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_statusess");
            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_user");

            entity.HasOne(d => d.PointAddress).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdPointAddresses)
                .HasConstraintName("orders_id_point_addresses_fkey");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdStatusess)
                .HasConstraintName("orders_id_statusess_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("orders_id_user_fkey");
        });

        modelBuilder.Entity<PointAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("point_addresses_pkey");

            entity.ToTable("point_addresses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Addresse).HasColumnName("addresse");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdCategory)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_category");
            entity.Property(e => e.IdManufacturer)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_manufacturer");
            entity.Property(e => e.IdSupplier)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_supplier");
            entity.Property(e => e.IdUnitMeasurement)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_unit_measurement");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.ProductName).HasColumnName("product_name");
            entity.Property(e => e.QuantityInStock).HasColumnName("quantity_in_stock");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("products_id_category_fkey");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .HasConstraintName("products_id_manufacturer_fkey");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("products_id_supplier_fkey");

            entity.HasOne(d => d.UnitMeasurement).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdUnitMeasurement)
                .HasConstraintName("products_id_unit_measurement_fkey");
        });

        modelBuilder.Entity<ProductsOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_orders_pkey");

            entity.ToTable("products_orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdOrder)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_order");
            entity.Property(e => e.IdProduct)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_product");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Order).WithMany(p => p.ProductsOrders)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("products_orders_id_order_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsOrders)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("products_orders_id_product_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SupplierName).HasColumnName("supplier_name");
        });

        modelBuilder.Entity<UnitMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("unit_measurements_pkey");

            entity.ToTable("unit_measurements");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameUnitMeasurement).HasColumnName("name_unit_measurement");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRoles)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_roles");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic ");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRoles)
                .HasConstraintName("users_id_roles_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
