﻿using BlazingPizzaSite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}