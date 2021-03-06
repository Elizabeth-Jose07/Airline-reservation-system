// <auto-generated />
using System;
using Airline_Management_CF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airline_Management_CF.Migrations
{
    [DbContext(typeof(Airline_Management_CF_Context))]
    [Migration("20220207163213_tbls")]
    partial class tbls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airline_Management_CF.Models.Admin", b =>
                {
                    b.Property<int>("Adminid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Adminid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.FlightDetails", b =>
                {
                    b.Property<int>("FlightNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FlightModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightNumber");

                    b.ToTable("FlightDetails");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.FlightInfo", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Bseats")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Eseats")
                        .HasColumnType("int");

                    b.Property<int>("FlightNumber")
                        .HasColumnType("int");

                    b.Property<int>("FlightNumber1")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("FlightId");

                    b.HasIndex("FlightNumber1");

                    b.ToTable("FlightInfo");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Passenger", b =>
                {
                    b.Property<int>("PassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PFirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PLastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("PassId");

                    b.HasIndex("SeatId");

                    b.ToTable("Passenger");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("PaymentAmount")
                        .HasColumnType("real");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TransactionStatus")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("SeatType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("SeatId");

                    b.HasIndex("FlightId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PassId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<bool>("TicketStatus")
                        .HasColumnType("bit");

                    b.HasKey("TicketId");

                    b.HasIndex("PassId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.FlightInfo", b =>
                {
                    b.HasOne("Airline_Management_CF.Models.FlightDetails", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightNumber1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Passenger", b =>
                {
                    b.HasOne("Airline_Management_CF.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Payment", b =>
                {
                    b.HasOne("Airline_Management_CF.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Seat", b =>
                {
                    b.HasOne("Airline_Management_CF.Models.FlightInfo", "FlightInfo")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightInfo");
                });

            modelBuilder.Entity("Airline_Management_CF.Models.Ticket", b =>
                {
                    b.HasOne("Airline_Management_CF.Models.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airline_Management_CF.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");

                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
