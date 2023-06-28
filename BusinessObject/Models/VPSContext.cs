using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObject.Models
{
    public partial class VPSContext : DbContext
    {
        public VPSContext()
        {
        }

        public VPSContext(DbContextOptions<VPSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Blog> Blogs { get; set; } = null!;
        public virtual DbSet<Blogger> Bloggers { get; set; } = null!;
        public virtual DbSet<Buy> Buys { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Consultant> Consultants { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Conversation> Conversations { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<FeedBack> FeedBacks { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDetail> ProductDetails { get; set; } = null!;
        public virtual DbSet<Qrcode> Qrcodes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierProduct> SupplierProducts { get; set; } = null!;
        public virtual DbSet<SupplierStock> SupplierStocks { get; set; } = null!;
        public virtual DbSet<Technical> Technicals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-G9AGGAN; database=VPS;uid=sa;pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Profile).HasMaxLength(500);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_Account_Admin");

                entity.HasOne(d => d.Blogger)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.BloggerId)
                    .HasConstraintName("FK_Account_Blogger");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK_Account_Consultant");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Account_Customers");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Account_Manager");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Account_Role");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_Account_Sale");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_Account_Shipper");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Account_Supplier");

                entity.HasOne(d => d.Technical)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.TechnicalId)
                    .HasConstraintName("FK_Account_Technical");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(250);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PublishDate).HasColumnType("date");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Blogger)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.BloggerId)
                    .HasConstraintName("FK_Blog_Blogger");

                entity.HasOne(d => d.BloggerNavigation)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.BloggerId)
                    .HasConstraintName("FK_Blog_Comment");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Blogs)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Blog_Status");
            });

            modelBuilder.Entity<Blogger>(entity =>
            {
                entity.ToTable("Blogger");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Buy>(entity =>
            {
                entity.ToTable("Buy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Buys)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buy_Customers");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Buys)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buy_Order");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Description).HasColumnType("ntext");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentDate).HasColumnType("date");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.HasOne(d => d.Blogger)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.BloggerId)
                    .HasConstraintName("FK_Comment_Blogger");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Comment_Customers");
            });

            modelBuilder.Entity<Consultant>(entity =>
            {
                entity.ToTable("Consultant");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Contract_Supplier");

                entity.HasOne(d => d.Technical)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.TechnicalId)
                    .HasConstraintName("FK_Contract_Technical");
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.ToTable("Conversation");

                entity.Property(e => e.ConversationName).HasMaxLength(100);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(500);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Customers_Order");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Customers_Status");
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.ToTable("FeedBack");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK_FeedBack_Consultant");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_FeedBack_Customers");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_FeedBack_Order");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_FeedBack_Shipper");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.ImageName).HasMaxLength(100);
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.ManagerId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(250);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK_Messages_Consultant");

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ConversationId)
                    .HasConstraintName("FK_Messages_Conversation");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Messages_Customers");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Messages_Status");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_Order_Sale");

                entity.HasOne(d => d.Ship)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipId)
                    .HasConstraintName("FK_Order_Shipper");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Brand).HasMaxLength(250);

                entity.Property(e => e.DiscountDate).HasColumnType("datetime");

                entity.Property(e => e.Maintaince)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Moneytype).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Product_Status");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("ProductDetail");
            });

            modelBuilder.Entity<Qrcode>(entity =>
            {
                entity.HasKey(e => e.Qrid)
                    .HasName("PK__QRCode__D8E9E6F81E86C960");

                entity.ToTable("QRCode");

                entity.Property(e => e.Qrid).HasColumnName("QRID");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.DayCreate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName).HasMaxLength(200);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar)
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Sale_Status");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("Shipper");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusName).HasMaxLength(250);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Stock_SupplierProduct");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Stock_Supplier");

                entity.HasOne(d => d.Technical)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.TechnicalId)
                    .HasConstraintName("FK_Stock_Technical");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(1);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(100);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Supplier_Status");
            });

            modelBuilder.Entity<SupplierProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Supplier__B40CC6CDED40F181");

                entity.ToTable("SupplierProduct");

                entity.Property(e => e.Brand).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.ProductName).HasMaxLength(250);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SupplierProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SupplierProduct_Category");
            });

            modelBuilder.Entity<SupplierStock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK__Supplier__2C83A9C2CAB9AC91");

                entity.ToTable("SupplierStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SupplierStocks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SupplierStock_SupplierProduct");
            });

            modelBuilder.Entity<Technical>(entity =>
            {
                entity.ToTable("Technical");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Avatar).HasMaxLength(250);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Technicals)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Technical_Status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
