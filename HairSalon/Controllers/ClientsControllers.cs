using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;

    public ClientsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      var thisItem = _db.Clients
        .Include(item => item.JoinEntities)
        .ThenInclude(join => join.Stylists).ToList();
    return View(thisItem);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client clients, Stylist stylist, int StylistId)
    {
      _db.Clients.Add(clients);
      _db.SaveChanges();
      if (StylistId != 0)
    {
        _db.StylistClients.Add(new StylistClients() { StylistId = StylistId, ClientId = clients.ClientId, Name = clients.Name, StylistName = stylist.StylistName });
        _db.SaveChanges();
    }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisItem = _db.Clients
        .Include(item => item.JoinEntities)
        .ThenInclude(join => join.Stylists)
        .FirstOrDefault(client => client.ClientId == id);
    return View(thisItem);
    }
    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client clients, int StylistId, Stylist stylist)
    {if (StylistId != 0)
      {
        _db.StylistClients.Add(new StylistClients() { StylistId = StylistId, ClientId = clients.ClientId, StylistName = stylist.StylistName });
      }
      _db.Entry(clients).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

[HttpPost]
public ActionResult DeleteStylist(int joinId)
{
    var joinEntry = _db.StylistClients.FirstOrDefault(entry => entry.StylistClientId == joinId);
    _db.StylistClients.Remove(joinEntry);
    _db.SaveChanges();
    return RedirectToAction("Index");
}

    public ActionResult AddStylist(int id)
{
    var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
    ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
    return View(thisClient);
}

[HttpPost]
public ActionResult AddStylist(Client clients, int StylistId)
{
    if (StylistId != 0)
    {
      _db.StylistClients.Add(new StylistClients() { StylistId = StylistId, ClientId = clients.ClientId });
      _db.SaveChanges();
    }
    return RedirectToAction("Index");
}
  }
}