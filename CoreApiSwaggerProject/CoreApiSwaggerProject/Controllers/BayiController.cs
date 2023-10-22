using CoreApiSwaggerProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace CoreApiSwaggerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BayiController : ControllerBase
    {
        public readonly ApplicationDbContext Context;
        public BayiController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        [Route("GetBayi")]
        public async Task<IEnumerable> GetBayi()
        {
            return await Context.Bayis.ToListAsync();
        }
        [HttpPost]
        [Route("AddBayi")]
        public async Task<Bayi> AddBayi(Bayi bayi)
        {
            Context.Add(bayi);
            Context.SaveChanges();
            return bayi;
        }

        [HttpPut]
        [Route("UpdateBayi/id")]
        public async Task<Bayi> UpdateBayi(Bayi bayi)
        {
            Context.Update(bayi);
            Context.SaveChanges();
            return bayi;
        }
        [HttpDelete]
        [Route("DeleteBayi/id")]
        public bool DeleteBayi(int id)
        {
            bool a=false;
            var result = Context.Bayis.Find(id);
            if (a!=null)
            {
                a = true;
                Context.Remove(result);
                Context.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
