using fantazijos_lyga.db;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Data
{
    public class FantasyRepository : IFantasyRepository
    {
        private readonly DatabaseContext _context;
        public FantasyRepository(DatabaseContext context)
        {
            _context = context;
        }
        public void AddNewUser(User user)
        {
            _context.Users.Add(user);
        }

        public void AddNewMatch(Rungtynes rungtynes)
        {
            _context.Rungtynes.Add(rungtynes);
        }

        public void AddNewPlayer(Zaidejas zaidejas)
        {
            _context.Zaidejai.Add(zaidejas);
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.FirstOrDefault(item => item.Username == username);
        }
        public Rungtynes GetMatchByDate(DateTime date)
        {
            return _context.Rungtynes.FirstOrDefault(item => item.StartDate.Date == date.Date);
        }
        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(item => item.Email == email);
        }

        public RungtyniuStatistika GetRungtyniustatistikosByRungtyniuId(int rungtyniuId)
        {
            return _context.RungtyniuStatistikos
            .FirstOrDefault(item => item.RungtynesID == rungtyniuId);
        }

        public IEnumerable <Komanda> GetKomandos()
        {
            return _context.Komandos;
        }

        public IEnumerable<Zaidejas> GetZaidejai()
        {
            return _context.Zaidejai;
        }


        public IEnumerable<Rungtynes> GetAllMatches()
        {
            return _context.Rungtynes
                .Include(item => item.HomeTeam)
                    .ThenInclude(item => item.Zaidejai)
                .Include(item => item.AwayTeam)
                    .ThenInclude(item => item.Zaidejai)
                .Include(item => item.RungtyniuStatistikos);
        }

        public IEnumerable <Zaidejas> GetPlayers()
        {
            return _context.Zaidejai
                .Include(item => item.Komanda);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public Rungtynes GetRungtynesByRungtynesID(int rungtyniuID)
        {
            return _context.Rungtynes
                .Include(item => item.HomeTeam)
                    .ThenInclude(item => item.Zaidejai)
                .Include(item => item.AwayTeam)
                    .ThenInclude(item => item.Zaidejai)
                .Include(item => item.NaudotojoPicks)
                    .ThenInclude(item => item.ZaidejasPirmas)
                .Include(item => item.NaudotojoPicks)
                    .ThenInclude(item => item.ZaidejasAntras)
                .Include(item => item.NaudotojoPicks)
                    .ThenInclude(item => item.ZaidejasTrecias)
                .Include(item => item.NaudotojoPicks)
                    .ThenInclude(item => item.ZaidejasKetvirtas)
                .Include(item => item.NaudotojoPicks)
                    .ThenInclude(item => item.ZaidejasPenktas)
                .Include(item => item.RungtyniuStatistikos)
                    .ThenInclude(item => item.Zaidejas)
                .FirstOrDefault(item => item.ID == rungtyniuID);
        }

        public Zaidejas GetZaidejasIdByName(string vardas)
        {
            return _context.Zaidejai.FirstOrDefault(item => item.Vardas == vardas);
        }

        public void AddUserPicks(NaudotojoPick naudotojoPick)
        {
            _context.NaudotojoPicks.Add(naudotojoPick);
        }

        public IEnumerable<Zaidejas> GetMatchPlayers(int homeTeamID, int awayTeamID)
        {
            return _context.Zaidejai
             .Include(item => item.Komanda).Where(item => item.KomandaID == homeTeamID || item.KomandaID == awayTeamID);
        }

        public IEnumerable<NaudotojoPick> GetNaudotojoPickByUserId(int userId)
        {
            return _context.NaudotojoPicks
                .Include(item => item.User)
                .Include(item => item.ZaidejasPenktas)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasPirmas)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasAntras)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasTrecias)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasKetvirtas)
                    .ThenInclude(item => item.Komanda)
                .Where(item => item.UserId == userId);
        }

        public void UpdateNaudotojoPick(NaudotojoPick naudotojoPick)
        {
            _context.NaudotojoPicks.Update(naudotojoPick);
        }

        public IEnumerable<NaudotojoPick> GetNaudotojoPicksByRungtyniuId(int rungtyniuId)
        {
            return _context.NaudotojoPicks
                .Include(item => item.User)
                .Include(item => item.ZaidejasPenktas)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasPirmas)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasAntras)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasTrecias)
                    .ThenInclude(item => item.Komanda)
                .Include(item => item.ZaidejasKetvirtas)
                    .ThenInclude(item => item.Komanda)
                .Where(item => item.RungtynesID == rungtyniuId);
        }

        public void AddPlayerStatistic(RungtyniuStatistika rungtyniuStatistika)
        {
            if (rungtyniuStatistika == null) return;

            _context.RungtyniuStatistikos.Add(rungtyniuStatistika);
        }

        public IEnumerable<Komanda> GetAllKomandos()
        {
            return _context.Komandos;
        }
        public IEnumerable<Zaidejas> GetAllZaidejai()
        {
            return _context.Zaidejai.Include(item => item.Komanda);
        }

        public void DeleteKomanda(Komanda komanda)
        {
            _context.Remove(komanda);
        }
        public void DeleteMatch(Rungtynes rungtynes)
        {
            _context.Remove(rungtynes);
        }
        public void DeleteZaidejas(Zaidejas zaidejas)
        {
            _context.Remove(zaidejas);
        }

        public void AddKomanda(Komanda komanda)
        {
            _context.Komandos.Add(komanda);
        }
        public void AddZaidejas(Zaidejas zaidejas)
        {
            _context.Zaidejai.Add(zaidejas);
        }

        public void UpdateKomanda(Komanda komanda)
        {
            Komanda komandaFromDb = GetKomandos().FirstOrDefault(item => item.ID == komanda.ID);

            komandaFromDb.Pavadinimas = komanda.Pavadinimas;
            komandaFromDb.Logo = komanda.Logo;
            komandaFromDb.Region = komanda.Region;
            komandaFromDb.ShortName = komanda.ShortName;
        }

        public void UpdateZaidejas(Zaidejas zaidejas)
        {
            Zaidejas zaidejasFromDb = GetZaidejai().FirstOrDefault(item => item.ID == zaidejas.ID);

            zaidejasFromDb.Vardas = zaidejas.Vardas;
            zaidejasFromDb.FotoPath = zaidejas.FotoPath;
            zaidejasFromDb.GamesPlayer = zaidejas.GamesPlayer;
            zaidejasFromDb.TotalPoints = zaidejas.TotalPoints;
            zaidejasFromDb.TotalRebounds = zaidejas.TotalRebounds;
            zaidejasFromDb.TotalAssist = zaidejas.TotalAssist;
            zaidejasFromDb.TotalBlocks = zaidejas.TotalBlocks;
            zaidejasFromDb.TotalTurnovers = zaidejas.TotalTurnovers;
            zaidejasFromDb.TotalPersonalFouls = zaidejas.TotalPersonalFouls;
            zaidejasFromDb.KomandaID = zaidejas.KomandaID;
            zaidejasFromDb.Position = zaidejas.Position;

            if(zaidejas.GamesPlayer == 0)
            {
                zaidejasFromDb.Kaina = 2000;
            }
            else
            {
                zaidejasFromDb.Kaina = 100 * ((zaidejas.TotalPoints / zaidejas.GamesPlayer) + (zaidejas.TotalAssist / zaidejas.GamesPlayer) + (zaidejas.TotalBlocks / zaidejas.GamesPlayer) + (zaidejas.TotalRebounds / zaidejas.GamesPlayer) - (zaidejas.TotalTurnovers / zaidejas.GamesPlayer) - (zaidejas.TotalPersonalFouls / zaidejas.GamesPlayer));
                if(zaidejasFromDb.Kaina < 0)
                {
                    zaidejasFromDb.Kaina = 500;
                }
            }
        }

        public void UpdateRungtynes(Rungtynes rungtynes)
        {
            Rungtynes rungtynesFromDb = _context.Rungtynes.FirstOrDefault(item => item.ID == rungtynes.ID);

            rungtynesFromDb.HomeTeamScore = rungtynes.HomeTeamScore;
            rungtynesFromDb.AwayTeamScore = rungtynes.AwayTeamScore;
            rungtynesFromDb.HomeTeamID= rungtynes.HomeTeamID;
            rungtynesFromDb.AwayTeamID = rungtynes.AwayTeamID;
            rungtynesFromDb.StartDate = rungtynes.StartDate;
        }
    }
}
