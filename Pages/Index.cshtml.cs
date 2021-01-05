using fantazijos_lyga.Data;
using fantazijos_lyga.Duomenu_baze;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fantazijos_lyga.Pages
{
    public class IndexModel : PageModel
    {
        public List<Rungtynes> rungtynes {get; set; }
        public List<Zaidejas> zaidejas { get; set; }

        public RungtyniuStatistika rungtyniuStatistika { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly IFantasyRepository _repository;

        public IndexModel(ILogger<IndexModel> logger, IFantasyRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public double CalculateAvg(double up, double down)
        {
            try
            {
                return (up / down);
            }
            catch
            {
                return 0;
            }
        }

        public void OnGet()
        {
            rungtynes = _repository.GetAllMatches().ToList();

            rungtynes.ForEach(item => 
                {
                    item.HomeTeam.Zaidejai = item.HomeTeam.Zaidejai.OrderByDescending(item => CalculateAvg(item.TotalPoints, item.GamesPlayer) + CalculateAvg(item.TotalAssist, item.GamesPlayer) + CalculateAvg(item.TotalBlocks, item.GamesPlayer) + CalculateAvg(item.TotalRebounds, item.GamesPlayer)).ToList();
                    item.AwayTeam.Zaidejai = item.AwayTeam.Zaidejai.OrderByDescending(item => CalculateAvg(item.TotalPoints, item.GamesPlayer) + CalculateAvg(item.TotalAssist, item.GamesPlayer) + CalculateAvg(item.TotalBlocks, item.GamesPlayer) + CalculateAvg(item.TotalRebounds, item.GamesPlayer)).ToList();
                });
        }
    }
}
