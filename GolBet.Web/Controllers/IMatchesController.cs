// GolBet.Web/Controllers/MatchesController.cs  (versión completa) 

using GolBet.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace GolBet.Web.Controllers
{
    public interface IMatchesController
    {
        Task<IActionResult> Detail(int id);
        Task<IActionResult> Index(MatchStatus? status);
    }
}