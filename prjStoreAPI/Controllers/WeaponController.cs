using Microsoft.AspNetCore.Mvc;
using prjStoreAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponController : ControllerBase
    {
        // 新增武器清單
        List<Weapon> weaponList = new List<Weapon>()
        {
            new Weapon { Id = 1, Name = "小刀", Atk = 2, Price = 5 },
            new Weapon { Id = 2, Name = "短劍", Atk = 5, Price = 10 },
            new Weapon { Id = 3, Name = "長劍", Atk = 10, Price = 20 }
        };
        // GET: api/<WeaponController>
        [HttpGet]
        public IEnumerable<Weapon> Get()
        {
            var result = (from a in weaponList
                          select new Weapon
                          {
                              Id = a.Id,
                              Name = a.Name,
                              Atk = a.Atk,
                              Price = a.Price,
                              Info = a.Info
                          }).ToList();
            return result;
        }

        // GET api/<WeaponController>/5
        [HttpGet("{id}")]
        public Weapon Get(int id)
        {
            var result = (from a in weaponList
                          where a.Id == id
                          select new Weapon
                          {
                              Id = a.Id,
                              Name = a.Name,
                              Atk = a.Atk,
                              Price = a.Price,
                              Info = a.Info
                          }).Single();
            return result;
        }
    }
}
