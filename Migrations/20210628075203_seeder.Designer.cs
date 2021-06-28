﻿// <auto-generated />
using DungeonsAndDragonsCharacter.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DungeonsAndDragonsCharacter.API.Migrations
{
    [DbContext(typeof(CharacterDbContext))]
    [Migration("20210628075203_seeder")]
    partial class seeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExperiencePoints")
                        .HasColumnType("float");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterBackground", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bonds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("FeaturesAndTraits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flaws")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ideals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalityTraits")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CharacterBackgrounds");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CharacterEquipments");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("CurrentHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Failures")
                        .HasColumnType("int");

                    b.Property<int>("Initiatve")
                        .HasColumnType("int");

                    b.Property<int>("Inteligence")
                        .HasColumnType("int");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Strenght")
                        .HasColumnType("int");

                    b.Property<int>("Success")
                        .HasColumnType("int");

                    b.Property<int>("TemporaryHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Windsom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CharacterProperties");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acrobatics")
                        .HasColumnType("int");

                    b.Property<int>("AnimalHandling")
                        .HasColumnType("int");

                    b.Property<int>("Arcana")
                        .HasColumnType("int");

                    b.Property<int>("Athletics")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Deception")
                        .HasColumnType("int");

                    b.Property<int>("History")
                        .HasColumnType("int");

                    b.Property<int>("Insight")
                        .HasColumnType("int");

                    b.Property<int>("Intimidation")
                        .HasColumnType("int");

                    b.Property<int>("Investigation")
                        .HasColumnType("int");

                    b.Property<int>("Medicine")
                        .HasColumnType("int");

                    b.Property<int>("Nature")
                        .HasColumnType("int");

                    b.Property<bool>("PassiveWindsomPerception")
                        .HasColumnType("bit");

                    b.Property<int>("Perception")
                        .HasColumnType("int");

                    b.Property<int>("Performance")
                        .HasColumnType("int");

                    b.Property<int>("Persuasion")
                        .HasColumnType("int");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<int>("SleightOfHand")
                        .HasColumnType("int");

                    b.Property<int>("Stealth")
                        .HasColumnType("int");

                    b.Property<int>("Survival")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CharacterSkillsSet");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterBackground", b =>
                {
                    b.HasOne("DungeonsAndDragonsCharacter.API.Entities.Character", "Character")
                        .WithOne("CharacterBackground")
                        .HasForeignKey("DungeonsAndDragonsCharacter.API.Entities.CharacterBackground", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterEquipment", b =>
                {
                    b.HasOne("DungeonsAndDragonsCharacter.API.Entities.Character", "Character")
                        .WithOne("CharacterEquipment")
                        .HasForeignKey("DungeonsAndDragonsCharacter.API.Entities.CharacterEquipment", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterProperty", b =>
                {
                    b.HasOne("DungeonsAndDragonsCharacter.API.Entities.Character", "Character")
                        .WithOne("CharacterProperties")
                        .HasForeignKey("DungeonsAndDragonsCharacter.API.Entities.CharacterProperty", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.CharacterSkills", b =>
                {
                    b.HasOne("DungeonsAndDragonsCharacter.API.Entities.Character", "Character")
                        .WithOne("CharacterSkills")
                        .HasForeignKey("DungeonsAndDragonsCharacter.API.Entities.CharacterSkills", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DungeonsAndDragonsCharacter.API.Entities.Character", b =>
                {
                    b.Navigation("CharacterBackground");

                    b.Navigation("CharacterEquipment");

                    b.Navigation("CharacterProperties");

                    b.Navigation("CharacterSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
