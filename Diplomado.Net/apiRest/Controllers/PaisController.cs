using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiRest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        List<Pais> lstPaises;

        public PaisController()
        {
            lstPaises = new List<Pais>();
            lstPaises.Add(new Pais() { iso3 = "COL", nombre = "Colombia", gobierno="Democracia", isValid=true });
            lstPaises.Add(new Pais() { iso3 = "MEX", nombre = "Mexico", gobierno = "Democracia", isValid = true });
            lstPaises.Add(new Pais() { iso3 = "USA", nombre = "Estados Unidos", gobierno = "Democracia", isValid = false });
            lstPaises.Add(new Pais() { iso3 = "ESP", nombre = "España", gobierno = "Monarquia", isValid = true });
            lstPaises.Add(new Pais() { iso3 = "VEN", nombre = "Venezuela", gobierno = "Dictadura", isValid = false });

        }
        // GET: api/Pais
        //[HttpGet]
        //public ActionResult Get()
        //{
        //    return Ok(lstPaises);
        //}

        // GET: Pais/5
        [HttpGet("{iso3}")]
        public ActionResult Get(string iso3)
        {
            var query = from p in lstPaises
                        where p.iso3 == iso3
                        select p;
            Pais response = query.FirstOrDefault();
            return response == null ? NotFound() : (ActionResult)Ok(response);
        }

        [HttpGet]
        public ActionResult<List<Pais>> obtenerPaises([FromQuery] string gobierno, [FromQuery] bool isValid)
        {
            List<Pais> response = lstPaises.Where(x => x.gobierno == gobierno && x.isValid == isValid).ToList();
            return response;
        }

        // POST: api/Pais
        [HttpPost]
        public ActionResult Post([FromBody] Pais value)
        {
            lstPaises.Add(value);
            return Ok(new Response() { code="000", message="success" });
        }

        // PUT: api/Pais/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
