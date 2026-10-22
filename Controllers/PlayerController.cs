using FootballClub.Data;
using FootballClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballClub.Controllers;

public class PlayerController : Controller
{
    private readonly AppDbContext _context;

    public PlayerController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var allPlayers = await _context.players.ToListAsync();
        return View(allPlayers);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Player player)
    {
        _context.players.Add(player);
        _context.SaveChanges();
        return Redirect("/Player");
    }
}