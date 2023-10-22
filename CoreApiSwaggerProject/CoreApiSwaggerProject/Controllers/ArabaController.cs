using CoreApiSwaggerProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreApiSwaggerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaController : ControllerBase
    {

        public readonly ApplicationDbContext Context;
        public ArabaController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        [Route("GetAraba")]
        public async Task<IEnumerable<Araba>> GetAraba()
        {
            return await Context.Arabas.ToListAsync();
        }
        [HttpPost]
        [Route("AddAraba")]
        public async Task<Araba> AddAraba(Araba araba)
        {
            Context.Add(araba);
            Context.SaveChanges();
            return araba;
        }

        [HttpPut]
        [Route("UpdateAraba/{id}")]
        public async Task<Araba> UpdateAraba(Araba araba)
        {
            Context.Update(araba);
            Context.SaveChanges();
            return araba;
        }

        [HttpDelete]
        [Route("DeleteAraba/{id}")]
        public bool DeleteAraba(int id)
        {
            bool a = false;
            var result = Context.Arabas.Find(id);
            if (result != null)
            {
                a = true;
                Context.Arabas.Remove(result);
                Context.SaveChanges();
            }
            else
            {
                return false;
            }
            return a;
        }
    }
}
