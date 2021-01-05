using fantazijos_lyga.db;
using fantazijos_lyga.Duomenu_baze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Data
{
    public interface IFantasyRepository
    {
        public void AddNewUser(User user);
        public void AddNewMatch(Rungtynes rungtynes);

        public void AddNewPlayer(Zaidejas zaidejas);
        public User GetUserByUserName(string username);
        public Rungtynes GetMatchByDate(DateTime data);
        public User GetUserByEmail(string email);

        public IEnumerable<Komanda> GetKomandos();
        public IEnumerable<Zaidejas> GetZaidejai();

        public void AddPlayerStatistic(RungtyniuStatistika rungtyniuStatistika);

        public IEnumerable<Rungtynes> GetAllMatches();

        public Rungtynes GetRungtynesByRungtynesID(int rungtyniuID);
        public RungtyniuStatistika GetRungtyniustatistikosByRungtyniuId(int rungtyniuId);

        public Zaidejas GetZaidejasIdByName(string vardas);

        public void AddUserPicks(NaudotojoPick naudotojoPick);

        public IEnumerable<Zaidejas> GetMatchPlayers(int homeTeamID, int awayTeamID);

        public IEnumerable<Zaidejas> GetPlayers();
        public bool SaveChanges();

        public IEnumerable<NaudotojoPick> GetNaudotojoPickByUserId(int userId);

        public void UpdateNaudotojoPick(NaudotojoPick naudotojoPick);
        public IEnumerable<NaudotojoPick> GetNaudotojoPicksByRungtyniuId(int rungtyniuId);

        public IEnumerable<Komanda> GetAllKomandos();
        public IEnumerable<Zaidejas> GetAllZaidejai();

        public void DeleteKomanda(Komanda komanda);
        public void DeleteMatch(Rungtynes rungtynes);
        public void DeleteZaidejas(Zaidejas zaidejas);

        public void AddKomanda(Komanda komanda);
        public void AddZaidejas(Zaidejas zaidejas);

        public void UpdateKomanda(Komanda komanda);
        public void UpdateZaidejas(Zaidejas zaidejas);

        public void UpdateRungtynes(Rungtynes rungtynes);

    }
}
