using fantazijos_lyga.db;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Zaidejas> Zaidejai { get; set; }
        public DbSet<RungtyniuStatistika> RungtyniuStatistikos { get; set; }
        public DbSet<Rungtynes> Rungtynes { get; set; }
        public DbSet<NaudotojoPick> NaudotojoPicks { get; set; }
        public DbSet<Komanda> Komandos { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NaudotojoPick>()
                .HasOne(pirmas => pirmas.ZaidejasPirmas)
                .WithMany(m => m.PirmoZaidejoList);

            modelBuilder.Entity<NaudotojoPick>()
                .HasOne(antras => antras.ZaidejasAntras)
                .WithMany(m => m.AntroZaidejoList);

            modelBuilder.Entity<NaudotojoPick>()
                .HasOne(trecias => trecias.ZaidejasTrecias)
                .WithMany(m => m.TrecioZaidejoList);

            modelBuilder.Entity<NaudotojoPick>()
                .HasOne(ketvirtas => ketvirtas.ZaidejasKetvirtas)
                .WithMany(m => m.KetvirtoZaidejoList);

            modelBuilder.Entity<NaudotojoPick>()
                .HasOne(penktas => penktas.ZaidejasPenktas)
                .WithMany(m => m.PenktoZaidejoList);

            modelBuilder.Entity<Rungtynes>()
              .HasOne(homeTeam => homeTeam.HomeTeam)
              .WithMany(m => m.HomeTeamList);

            modelBuilder.Entity<Rungtynes>()
              .HasOne(awayTeam => awayTeam.AwayTeam)
              .WithMany(m => m.AwayTeamList);


            modelBuilder.Entity<Komanda>().HasData(
                new Komanda() { ID = 1, Pavadinimas = "Boston Celtics", ShortName = "BOS", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612738/global/L/logo.svg" },
                new Komanda() { ID = 2, Pavadinimas = "Brooklyn Nets", ShortName = "BKN", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612751/global/L/logo.svg" },
                new Komanda() { ID = 3, Pavadinimas = "New York Knicks", ShortName = "NYK", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612752/global/L/logo.svg" },
                new Komanda() { ID = 4, Pavadinimas = "Philadelphia 76ers", ShortName = "PHI", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612755/global/L/logo.svg" },
                new Komanda() { ID = 5, Pavadinimas = "Toronto Raptors", ShortName = "TOR", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612761/global/L/logo.svg" },
                new Komanda() { ID = 6, Pavadinimas = "Chicago Bulls", ShortName = "CHI", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612741/global/L/logo.svg" },
                new Komanda() { ID = 7, Pavadinimas = "Cleveland Cavaliers", ShortName = "CLE", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612739/global/L/logo.svg" },
                new Komanda() { ID = 8, Pavadinimas = "Detroit Pistons", ShortName = "DET", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612765/global/L/logo.svg" },
                new Komanda() { ID = 9, Pavadinimas = "Indiana Pacers", ShortName = "IND", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612754/global/L/logo.svg" },
                new Komanda() { ID = 10, Pavadinimas = "Milwaukee Bucks", ShortName = "MIL", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612749/global/L/logo.svg" },
                new Komanda() { ID = 11, Pavadinimas = "Atlanta Hawks", ShortName = "ATL", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612737/global/L/logo.svg" },
                new Komanda() { ID = 12, Pavadinimas = "Charlotte Hornets", ShortName = "CHA", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612766/global/L/logo.svg" },
                new Komanda() { ID = 13, Pavadinimas = "Miami Heat", ShortName = "MIA", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612748/global/L/logo.svg" },
                new Komanda() { ID = 14, Pavadinimas = "Orlando Magic", ShortName = "ORL", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612753/global/L/logo.svg" },
                new Komanda() { ID = 15, Pavadinimas = "Washington Wizards", ShortName = "WAS", Region = Enums.RegionEnum.Rytai, Logo = "https://cdn.nba.com/logos/nba/1610612764/global/L/logo.svg" },
                new Komanda() { ID = 16, Pavadinimas = "Denver Nuggets", ShortName = "DEN", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612743/global/L/logo.svg" },
                new Komanda() { ID = 17, Pavadinimas = "Minnesota Timberwolves", ShortName = "MIN", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612750/global/L/logo.svg" },
                new Komanda() { ID = 18, Pavadinimas = "Oklahoma City Thunder", ShortName = "OKC", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612760/global/L/logo.svg" },
                new Komanda() { ID = 19, Pavadinimas = "Portland Trail Blazers", ShortName = "POR", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612757/global/L/logo.svg" },
                new Komanda() { ID = 20, Pavadinimas = "Utah Jazz", ShortName = "UTA", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612762/global/L/logo.svg" },
                new Komanda() { ID = 21, Pavadinimas = "Golden State Warriors", ShortName = "GSW", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612744/global/L/logo.svg" },
                new Komanda() { ID = 22, Pavadinimas = "Los Angeles Clippers", ShortName = "LAC", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612746/global/L/logo.svg" },
                new Komanda() { ID = 23, Pavadinimas = "Los Angeles Lakers", ShortName = "LAL", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612747/global/L/logo.svg" },
                new Komanda() { ID = 24, Pavadinimas = "Phoenix Suns", ShortName = "PHX", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612756/global/L/logo.svg" },
                new Komanda() { ID = 25, Pavadinimas = "Sacramento Kings", ShortName = "SAC", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612758/global/L/logo.svg" },
                new Komanda() { ID = 26, Pavadinimas = "Dallas Mavericks", ShortName = "DAL", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612742/global/L/logo.svg" },
                new Komanda() { ID = 27, Pavadinimas = "Houston Rockets", ShortName = "HOU", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612745/global/L/logo.svg" },
                new Komanda() { ID = 28, Pavadinimas = "Memphis Grizzlies", ShortName = "MEM", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612763/global/L/logo.svg" },
                new Komanda() { ID = 29, Pavadinimas = "New Orleans Pelicans", ShortName = "NOP", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612740/global/L/logo.svg" },
                new Komanda() { ID = 30, Pavadinimas = "San Antonio Spurs", ShortName = "SAN", Region = Enums.RegionEnum.Vakarai, Logo = "https://cdn.nba.com/logos/nba/1610612759/global/L/logo.svg" }
            ); ;

            modelBuilder.Entity<Zaidejas>().HasData(
                    new Zaidejas()
                    {
                        ID = 1,
                        Vardas = "Jayson Tatum",
                        Kaina = 2000,
                        FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628369.png",
                        Position = Enums.PositionEnum.Puolėjas,
                        KomandaID = 1,
                        GamesPlayer = 1,
                        TotalAssist = 1,
                        TotalPoints = 1,
                        TotalRebounds = 1,
                        TotalBlocks = 1,
                        TotalPersonalFouls = 1,
                        TotalTurnovers = 1
                    },
                    new Zaidejas()
                    {
                        ID = 2,
                        Vardas = "Carsen Edwards",
                        Kaina = 2000,
                        FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629035.png",
                        Position = Enums.PositionEnum.Gynėjas,
                        KomandaID = 1,
                        GamesPlayer = 1,
                        TotalAssist = 1,
                        TotalPoints = 1,
                        TotalRebounds = 1,
                        TotalBlocks = 1,
                        TotalPersonalFouls = 1,
                        TotalTurnovers = 1
                    },
                     new Zaidejas()
                     {
                         ID = 3,
                         Vardas = "Tacko Fall",
                         Kaina = 2000,
                         FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629605.png",
                         Position = Enums.PositionEnum.Centras,
                         KomandaID = 1,
                         GamesPlayer = 1,
                         TotalAssist = 1,
                         TotalPoints = 1,
                         TotalRebounds = 1,
                         TotalBlocks = 1,
                         TotalPersonalFouls = 1,
                         TotalTurnovers = 1
                     },
                      new Zaidejas()
                      {
                          ID = 4,
                          Vardas = "Javonte Green",
                          Kaina = 2000,
                          FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629750.png",
                          Position = Enums.PositionEnum.Gynėjas,
                          KomandaID = 1,
                          GamesPlayer = 1,
                          TotalAssist = 1,
                          TotalPoints = 1,
                          TotalRebounds = 1,
                          TotalBlocks = 1,
                          TotalPersonalFouls = 1,
                          TotalTurnovers = 1
                      },
                      new Zaidejas()
                      {
                          ID = 5,
                          Vardas = "Amile Jefferson",
                          Kaina = 2000,
                          FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628518.png",
                          Position = Enums.PositionEnum.Puolėjas,
                          KomandaID = 1,
                          GamesPlayer = 1,
                          TotalAssist = 1,
                          TotalPoints = 1,
                          TotalRebounds = 1,
                          TotalBlocks = 1,
                          TotalPersonalFouls = 1,
                          TotalTurnovers = 1
                      },
                       new Zaidejas()
                       {
                           ID = 6,
                           Vardas = "Romeo Langford",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629641.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 7,
                           Vardas = "Semi Ojeleye",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1628400.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                        new Zaidejas()
                        {
                            ID = 8,
                            Vardas = "Marcus Smart",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/203935.png",
                            Position = Enums.PositionEnum.Gynėjas,
                            KomandaID = 1,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                        new Zaidejas()
                        {
                            ID = 9,
                            Vardas = "Jeff Teague",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/201952.png",
                            Position = Enums.PositionEnum.Gynėjas,
                            KomandaID = 1,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                        new Zaidejas()
                        {
                            ID = 10,
                            Vardas = "Daniel Theis",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/201952.png",
                            Position = Enums.PositionEnum.Centras,
                            KomandaID = 1,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                          new Zaidejas()
                          {
                              ID = 11,
                              Vardas = "Tristan Thompson",
                              Kaina = 2000,
                              FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/202684.png",
                              Position = Enums.PositionEnum.Centras,
                              KomandaID = 1,
                              GamesPlayer = 1,
                              TotalAssist = 1,
                              TotalPoints = 1,
                              TotalRebounds = 1,
                              TotalBlocks = 1,
                              TotalPersonalFouls = 1,
                              TotalTurnovers = 1
                          },

                     new Zaidejas()
                     {
                         ID = 12,
                         Vardas = "Kemba Walker",
                         Kaina = 2000,
                         FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202689.png",
                         Position = Enums.PositionEnum.Gynėjas,
                         KomandaID = 1,
                         GamesPlayer = 1,
                         TotalAssist = 1,
                         TotalPoints = 1,
                         TotalRebounds = 1,
                         TotalBlocks = 1,
                         TotalPersonalFouls = 1,
                         TotalTurnovers = 1
                     },
                       new Zaidejas()
                       {
                           ID = 13,
                           Vardas = "Jaylen Brown",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1627759.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 14,
                           Vardas = "Tremont Waters",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629682.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 15,
                           Vardas = "Grant Williams",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629684.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 16,
                           Vardas = "Robert Williams",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/1040x760/1629057.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 1,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 17,
                           Vardas = "Jarrett Allen",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628386.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 18,
                           Vardas = "Bruce Brown",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628971.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 19,
                           Vardas = "Chris Chiozza",
                           Kaina = 1,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629185.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 20,
                           Vardas = "Nicolas Claxton",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629651.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 21,
                           Vardas = "Spencer Dinwiddie",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203915.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 22,
                           Vardas = "Kevin Durant",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201142.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 23,
                           Vardas = "Jeff Green",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201145.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 24,
                           Vardas = "Joe Harris",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203925.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 25,
                           Vardas = "Kyrie Irving",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202681.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 26,
                           Vardas = "Tyler Johnson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/204020.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 27,
                           Vardas = "Deandre Jordan",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201599.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 28,
                           Vardas = "Rodions Kurucs",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629066.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },

                       new Zaidejas()
                       {
                           ID = 29,
                           Vardas = "Caris LeVert",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627747.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 30,
                           Vardas = "Timothe Luwawu-Cabarrot",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627789.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 31,
                           Vardas = "Jeremiah Martin",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629725.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 2,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                        new Zaidejas()
                        {
                            ID = 32,
                            Vardas = "Taurean Prince",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627752.png",
                            Position = Enums.PositionEnum.Puolėjas,
                            KomandaID = 2,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                        new Zaidejas()
                        {
                            ID = 33,
                            Vardas = "Landry Shamer",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629013.png",
                            Position = Enums.PositionEnum.Gynėjas,
                            KomandaID = 2,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                       new Zaidejas()
                       {
                           ID = 34,
                           Vardas = "Julius Randle",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203944.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 35,
                           Vardas = "RJ Barrett",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629628.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 36,
                           Vardas = "Ignas Brazdeikis",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629649.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 37,
                           Vardas = "Reggie Bullock",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203493.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 38,
                           Vardas = "Damyean Dotson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628422.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 39,
                           Vardas = "Wayne Ellington",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201961.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 40,
                           Vardas = "Taj Gibson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201959.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 41,
                           Vardas = "Maurice Harkless",
                           Kaina = 2000,
                           FotoPath = "https://images.ctfassets.net/u31h9rzvvynu/6NIDwBaVvnquGbCgeDgM6Y/28ccceffc392b3b1010fd15f521d4603/Harkless-Maurice-Headshot-1920.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 42,
                           Vardas = "Jared Harper",
                           Kaina = 2000,
                           FotoPath = "https://images.ctfassets.net/u31h9rzvvynu/2Iui3tdfJSCIAYqIepgtXU/b573f60849734a089fb3c8c81966cc6e/Harper-Jared-Headshot-1920.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 43,
                           Vardas = "Kevin Knox",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628995.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 44,
                           Vardas = "Frank Ntilikina",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628373.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 45,
                           Vardas = "Elfrid Payton",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203901.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 46,
                           Vardas = "Theo Pinson",
                           Kaina = 2000,
                           FotoPath = "https://images.ctfassets.net/u31h9rzvvynu/3hEYkfFn5gEbJN01WolOVV/800b421b296896b4dd21666d219d9584/Pinson-Theo-Headshot-1920.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 47,
                           Vardas = "Bobby Portis",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626171.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 48,
                           Vardas = "Mitchell Robinson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629011.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 49,
                           Vardas = "Dennis Smith Jr.",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628372.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 3,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 50,
                           Vardas = "Justin Anderson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626147.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 51,
                           Vardas = "Tony Bradley",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628396.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 52,
                           Vardas = "Seth Curry",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203552.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 53,
                           Vardas = "Joel Embiid",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203954.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 54,
                           Vardas = "Terrance Ferguson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628390.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 55,
                           Vardas = "Danny Green",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201980.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 56,
                           Vardas = "Tobias Harris",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202699.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 57,
                           Vardas = "Dwight Howard",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/2730.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 58,
                           Vardas = "Furkan Korkmaz",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627788.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                        new Zaidejas()
                        {
                            ID = 59,
                            Vardas = "Shake Milton",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629003.png",
                            Position = Enums.PositionEnum.Gynėjas,
                            KomandaID = 4,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                        new Zaidejas()
                        {
                            ID = 60,
                            Vardas = "Vincent Poirier",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629738.png",
                            Position = Enums.PositionEnum.Centras,
                            KomandaID = 4,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                        new Zaidejas()
                        {
                            ID = 61,
                            Vardas = "Mike Scott",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203118.png",
                            Position = Enums.PositionEnum.Puolėjas,
                            KomandaID = 4,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        },
                       new Zaidejas()
                       {
                           ID = 62,
                           Vardas = "Ben Simmons",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627732.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 63,
                           Vardas = "Matisse Thybulle",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629680.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 4,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 64,
                           Vardas = "OG Anunoby",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628384.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 65,
                           Vardas = "Aron Baynes",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203382.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 66,
                           Vardas = "DeAndre' Bembry",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627761.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 67,
                           Vardas = "Chris Boucher",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628449.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 68,
                           Vardas = "Oshae Brissett",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629052.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 69,
                           Vardas = "Terence Davis",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629056.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 70,
                           Vardas = "Henry Ellenson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627740.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 71,
                           Vardas = "Alize Johnson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628993.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 72,
                           Vardas = "Stanley Johnson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626169.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 73,
                           Vardas = "Alex Len",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203458.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 74,
                           Vardas = "Kyle Lowry",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/200768.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 75,
                           Vardas = "Patrick McCaw",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627775.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 76,
                           Vardas = "Norman Powell",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626181.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 77,
                           Vardas = "Pascal Siakam",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627783.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 78,
                           Vardas = "Matt Thomas",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629744.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 79,
                           Vardas = "Fred VanVleet",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627832.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 80,
                           Vardas = "Yuta Watanabe",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629139.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 81,
                           Vardas = "Paul Watson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628778.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 5,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 82,
                           Vardas = "Ryan Arcidiacono",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627853.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 83,
                           Vardas = "Wendell Carter Jr.",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628976.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 84,
                           Vardas = "Cristiano Felício",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626245.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 85,
                           Vardas = "Daniel Gafford",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629655.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 86,
                           Vardas = "Chandler Hutchison",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628990.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 87,
                           Vardas = "Luke Kornet",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628436.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 88,
                           Vardas = "Zach LaVine",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203897.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 89,
                           Vardas = "Lauri Markkanen",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628374.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 90,
                           Vardas = "Adam Mokoka",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629690.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 91,
                           Vardas = "Zach Norvell",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629668.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 92,
                           Vardas = "Otto Porter",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203490.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 93,
                           Vardas = "Tomas Satoransky",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203107.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 94,
                           Vardas = "Garrett Temple",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/202066.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 95,
                           Vardas = "Denzel Valentine",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627756.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 96,
                           Vardas = "Coby White",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629632.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 97,
                           Vardas = "Thaddeus Young",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201152.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 6,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 98,
                           Vardas = "Marques Bolden",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629716.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 99,
                           Vardas = "Matthew Dellavedova",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203521.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 100,
                           Vardas = "Damyean Dotson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628422.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 101,
                           Vardas = "Andre Drummond",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203083.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 102,
                           Vardas = "Dante Exum",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203957.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 103,
                           Vardas = "Darius Garland",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629636.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 104,
                           Vardas = "Kevin Love",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201567.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 105,
                           Vardas = "Thon Maker",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1627748.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 106,
                           Vardas = "JaVale McGee",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201580.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 107,
                           Vardas = "Matt Mooney",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629760.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 108,
                           Vardas = "Larry Nance Jr.",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626204.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 109,
                           Vardas = "Cedi Osman",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626224.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 110,
                           Vardas = "Kevin Porter Jr",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629645.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 111,
                           Vardas = "Collin Sexton",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629012.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 112,
                           Vardas = "Dean Wade",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629731.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 7,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 113,
                           Vardas = "Sekou Doumbouya",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629635.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 114,
                           Vardas = "Wayne Ellington",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201961.png",
                           Position = Enums.PositionEnum.Gynėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 115,
                           Vardas = "Jerami Grant",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203924.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 116,
                           Vardas = "Blake Griffin",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201933.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 117,
                           Vardas = "Josh Jackson",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1628367.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 118,
                           Vardas = "Rodney McGruder",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203585.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 119,
                           Vardas = "Dzanan Musa",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629058.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 120,
                           Vardas = "Sviatoslav Mykhailiuk",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1629004.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 121,
                           Vardas = "Jahlil Okafor",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626143.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 122,
                           Vardas = "Mason Plumlee",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/203486.png",
                           Position = Enums.PositionEnum.Centras,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                       new Zaidejas()
                       {
                           ID = 123,
                           Vardas = "Derrick Rose",
                           Kaina = 2000,
                           FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/201565.png",
                           Position = Enums.PositionEnum.Puolėjas,
                           KomandaID = 8,
                           GamesPlayer = 1,
                           TotalAssist = 1,
                           TotalPoints = 1,
                           TotalRebounds = 1,
                           TotalBlocks = 1,
                           TotalPersonalFouls = 1,
                           TotalTurnovers = 1
                       },
                        new Zaidejas()
                        {
                            ID = 124,
                            Vardas = "Delon Wright",
                            Kaina = 2000,
                            FotoPath = "https://ak-static.cms.nba.com/wp-content/uploads/headshots/nba/latest/260x190/1626153.png",
                            Position = Enums.PositionEnum.Gynėjas,
                            KomandaID = 8,
                            GamesPlayer = 1,
                            TotalAssist = 1,
                            TotalPoints = 1,
                            TotalRebounds = 1,
                            TotalBlocks = 1,
                            TotalPersonalFouls = 1,
                            TotalTurnovers = 1
                        }
                   ); ;

        }
    }

}