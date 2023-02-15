﻿// <auto-generated />
using System;
using MarketService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MarketService.Migrations
{
    [DbContext(typeof(MarketContext))]
    [Migration("20230209112048_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ItemProductModelSkillModel", b =>
                {
                    b.Property<Guid>("ItemProductsProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("itemproductsproductid");

                    b.Property<int>("SkillsId")
                        .HasColumnType("integer")
                        .HasColumnName("skillsid");

                    b.HasKey("ItemProductsProductId", "SkillsId")
                        .HasName("pk_itemproductmodelskillmodel");

                    b.HasIndex("SkillsId")
                        .HasDatabaseName("ix_itemproductmodelskillmodel_skillsid");

                    b.ToTable("itemproductmodelskillmodel", (string)null);
                });

            modelBuilder.Entity("ItemProductModelStatModel", b =>
                {
                    b.Property<Guid>("ItemProductsProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("itemproductsproductid");

                    b.Property<int>("StatsId")
                        .HasColumnType("integer")
                        .HasColumnName("statsid");

                    b.HasKey("ItemProductsProductId", "StatsId")
                        .HasName("pk_itemproductmodelstatmodel");

                    b.HasIndex("StatsId")
                        .HasDatabaseName("ix_itemproductmodelstatmodel_statsid");

                    b.ToTable("itemproductmodelstatmodel", (string)null);
                });

            modelBuilder.Entity("MarketService.Models.ProductModel", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("productid");

                    b.Property<bool>("Exist")
                        .HasColumnType("boolean")
                        .HasColumnName("exist");

                    b.Property<bool>("Legacy")
                        .HasColumnType("boolean")
                        .HasColumnName("legacy");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric")
                        .HasColumnName("quantity");

                    b.Property<long>("RegisteredBlockIndex")
                        .HasColumnType("bigint")
                        .HasColumnName("registeredblockindex");

                    b.Property<string>("SellerAgentAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("selleragentaddress");

                    b.Property<string>("SellerAvatarAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("selleravataraddress");

                    b.Property<string>("product_type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_type");

                    b.HasKey("ProductId")
                        .HasName("pk_products");

                    b.HasIndex("Exist")
                        .HasDatabaseName("ix_products_exist");

                    b.ToTable("products", (string)null);

                    b.HasDiscriminator<string>("product_type").HasValue("ProductModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MarketService.Models.SkillModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Chance")
                        .HasColumnType("integer")
                        .HasColumnName("chance");

                    b.Property<int>("Cooldown")
                        .HasColumnType("integer")
                        .HasColumnName("cooldown");

                    b.Property<int>("ElementalType")
                        .HasColumnType("integer")
                        .HasColumnName("elementaltype");

                    b.Property<int>("HitCount")
                        .HasColumnType("integer")
                        .HasColumnName("hitcount");

                    b.Property<int>("Power")
                        .HasColumnType("integer")
                        .HasColumnName("power");

                    b.Property<int>("SkillCategory")
                        .HasColumnType("integer")
                        .HasColumnName("skillcategory");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer")
                        .HasColumnName("skillid");

                    b.HasKey("Id")
                        .HasName("pk_skills");

                    b.HasIndex("SkillId", "Power", "Chance")
                        .IsUnique()
                        .HasDatabaseName("ix_skills_skillid_power_chance");

                    b.ToTable("skills", (string)null);
                });

            modelBuilder.Entity("MarketService.Models.StatModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Additional")
                        .HasColumnType("boolean")
                        .HasColumnName("additional");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.Property<int>("Value")
                        .HasColumnType("integer")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_stats");

                    b.HasIndex("Value", "Type", "Additional")
                        .IsUnique()
                        .HasDatabaseName("ix_stats_value_type_additional");

                    b.ToTable("stats", (string)null);
                });

            modelBuilder.Entity("MarketService.Models.FungibleAssetValueProductModel", b =>
                {
                    b.HasBaseType("MarketService.Models.ProductModel");

                    b.Property<byte>("DecimalPlaces")
                        .HasColumnType("smallint")
                        .HasColumnName("decimalplaces");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ticker");

                    b.HasDiscriminator().HasValue("fav");
                });

            modelBuilder.Entity("MarketService.Models.ItemProductModel", b =>
                {
                    b.HasBaseType("MarketService.Models.ProductModel");

                    b.Property<int>("CombatPoint")
                        .HasColumnType("integer")
                        .HasColumnName("combatpoint");

                    b.Property<int>("ElementalType")
                        .HasColumnType("integer")
                        .HasColumnName("elementaltype");

                    b.Property<int>("Grade")
                        .HasColumnType("integer")
                        .HasColumnName("grade");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer")
                        .HasColumnName("itemid");

                    b.Property<int>("ItemSubType")
                        .HasColumnType("integer")
                        .HasColumnName("itemsubtype");

                    b.Property<int>("ItemType")
                        .HasColumnType("integer")
                        .HasColumnName("itemtype");

                    b.Property<int>("Level")
                        .HasColumnType("integer")
                        .HasColumnName("level");

                    b.Property<int>("SetId")
                        .HasColumnType("integer")
                        .HasColumnName("setid");

                    b.Property<Guid>("TradableId")
                        .HasColumnType("uuid")
                        .HasColumnName("tradableid");

                    b.HasDiscriminator().HasValue("item");
                });

            modelBuilder.Entity("ItemProductModelSkillModel", b =>
                {
                    b.HasOne("MarketService.Models.ItemProductModel", null)
                        .WithMany()
                        .HasForeignKey("ItemProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_itemproductmodelskillmodel_products_itemproductsproductid");

                    b.HasOne("MarketService.Models.SkillModel", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_itemproductmodelskillmodel_skills_skillsid");
                });

            modelBuilder.Entity("ItemProductModelStatModel", b =>
                {
                    b.HasOne("MarketService.Models.ItemProductModel", null)
                        .WithMany()
                        .HasForeignKey("ItemProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_itemproductmodelstatmodel_products_itemproductsproductid");

                    b.HasOne("MarketService.Models.StatModel", null)
                        .WithMany()
                        .HasForeignKey("StatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_itemproductmodelstatmodel_stats_statsid");
                });
#pragma warning restore 612, 618
        }
    }
}
