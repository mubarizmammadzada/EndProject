﻿// <auto-generated />
using EndProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EndProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200907131840_AddIsMainColumn")]
    partial class AddIsMainColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EndProject.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("AsistancePhoneNumber")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FacebookAddress")
                        .IsRequired();

                    b.Property<string>("LinkedinAddress")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("PinterestAddress")
                        .IsRequired();

                    b.Property<string>("TwitterAddress")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Bio");
                });

            modelBuilder.Entity("EndProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutBlog")
                        .IsRequired();

                    b.Property<string>("AuthorName")
                        .IsRequired();

                    b.Property<int>("BlogCategoryId");

                    b.Property<string>("Date")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BlogCategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EndProject.Models.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("EndProject.Models.OurTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("AirConditioning");

                    b.Property<int>("BeltsandHoses");

                    b.Property<int>("BrakeRepair");

                    b.Property<string>("DateOfBirth")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("EngineDiagnostics");

                    b.Property<string>("FacebookAddress")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("LinkedinAddress")
                        .IsRequired();

                    b.Property<int>("LubeOilandFilters");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("Profession")
                        .IsRequired();

                    b.Property<int>("TireandWheelServices");

                    b.Property<string>("TwitterAddress")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("OurTeams");
                });

            modelBuilder.Entity("EndProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired();

                    b.Property<int>("Count");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<int>("ProductCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EndProject.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("EndProject.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<bool>("IsMain");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("EndProject.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Axle")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("FrontBrakesRepair")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("RearBrakesRepair")
                        .IsRequired();

                    b.Property<string>("RearBrakesShoes")
                        .IsRequired();

                    b.Property<int>("ServiceCategoryId");

                    b.Property<string>("StartersAlternators")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ServiceCategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EndProject.Models.ServiceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ServiceCategories");
                });

            modelBuilder.Entity("EndProject.Models.ServiceImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<bool>("IsMain");

                    b.Property<int>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceImages");
                });

            modelBuilder.Entity("EndProject.Models.Blog", b =>
                {
                    b.HasOne("EndProject.Models.BlogCategory", "BlogCategory")
                        .WithMany("Blog")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EndProject.Models.Product", b =>
                {
                    b.HasOne("EndProject.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EndProject.Models.ProductImage", b =>
                {
                    b.HasOne("EndProject.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EndProject.Models.Service", b =>
                {
                    b.HasOne("EndProject.Models.ServiceCategory", "ServiceCategory")
                        .WithMany("Services")
                        .HasForeignKey("ServiceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EndProject.Models.ServiceImage", b =>
                {
                    b.HasOne("EndProject.Models.Service", "Service")
                        .WithMany("ServiceImages")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
