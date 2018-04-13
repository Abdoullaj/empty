namespace DatabaseFirstSample
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GestionalePizzeria : DbContext
    {
        public GestionalePizzeria()
            : base("name=GestionalePizzeria")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<CustomPizza> CustomPizza { get; set; }
        public virtual DbSet<Drink> Drink { get; set; }
        public virtual DbSet<Magazine> Magazine { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Restaurant_table> Restaurant_table { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<RestaurantTable> RestaurantTable { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .Property(e => e.name_client)
                .IsFixedLength();

            modelBuilder.Entity<Clients>()
                .Property(e => e.phone_client)
                .IsFixedLength();

            modelBuilder.Entity<Clients>()
                .Property(e => e.address_client)
                .IsFixedLength();

            modelBuilder.Entity<CustomPizza>()
                .Property(e => e.Ingredient1)
                .IsFixedLength();

            modelBuilder.Entity<CustomPizza>()
                .Property(e => e.ingredient2)
                .IsFixedLength();

            modelBuilder.Entity<CustomPizza>()
                .Property(e => e.ingredient3)
                .IsFixedLength();

            modelBuilder.Entity<Drink>()
                .Property(e => e.name_drink)
                .IsFixedLength();

            modelBuilder.Entity<Magazine>()
                .Property(e => e.name_ingredient)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.hour_order)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.address_client)
                .IsFixedLength();

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Type_pizza)
                .IsFixedLength();

            modelBuilder.Entity<Pizza>()
                .Property(e => e.cost_pizza)
                .IsFixedLength();

            modelBuilder.Entity<Restaurant_table>()
                .Property(e => e.ID_table)
                .IsFixedLength();

            modelBuilder.Entity<Restaurant_table>()
                .Property(e => e.Table_place)
                .IsFixedLength();

            modelBuilder.Entity<Restaurants>()
                .Property(e => e.name_restaurant)
                .IsFixedLength();

            modelBuilder.Entity<Workers>()
                .Property(e => e.name_worker)
                .IsFixedLength();

            modelBuilder.Entity<Workers>()
                .Property(e => e.task)
                .IsFixedLength();
        }
    }
}
