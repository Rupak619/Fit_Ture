using Fit_Menu.Data;
using Fit_Menu.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fit_Menu.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MenuItem : ControllerBase
    {
        public ApplicationDbContext _context;

        public MenuItem(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<MenuItem>
        [HttpGet]
        public IEnumerable<Menu_Item> Get()
        {
            return _context._Items;
        }

        // GET api/<MenuItem>/5
        [HttpGet("{id}")]
        public Menu_Item Get(int id)
        {
            return _context._Items.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<MenuItem>
        [HttpPost]
        public void Post([FromBody] Menu_Item _menu_Item)
        {
            _context._Items.Add(_menu_Item);
            _context.SaveChanges();
        }

        // PUT api/<MenuItem>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Menu_Item menu_Item)
        {
            var MItem = _context._Items.Find(id);
            MItem.item_name = menu_Item.item_name;
            MItem.CreatedAt = menu_Item.CreatedAt;
            _context._Items.Update(MItem);
            _context.SaveChanges();
        }

        // DELETE api/<MenuItem>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var MItem = _context._Items.Find(id);
            _context._Items.Remove(MItem);
            _context.SaveChanges();
        }
    }
}
