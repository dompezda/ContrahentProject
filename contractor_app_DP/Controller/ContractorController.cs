using contractor_app_DP.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Newtonsoft.Json;

namespace contractor_app_DP.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ContractorController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public ContractorController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public string Get()
        {
    
            var settings = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Error = (sender, args) =>
                {
                    args.ErrorContext.Handled = true;
                },
            };

            using (var context = new ContractortDbContext())
            {
                var myEntity = context.Contractors.ToList();
                return JsonConvert.SerializeObject(myEntity, settings);
            }
           
        }

        [HttpPost]
        public JsonResult Post(RegisterModel con)
        {
            using (var context = new ContractortDbContext())
            {
                
                context.Contractors.Add(con);
                context.SaveChanges();
            }

            return new JsonResult("Dodano nowy rekord");
        }


        [HttpPut]
        public JsonResult Put(RegisterModel con)
        {


            using (var context = new ContractortDbContext())
            {

                context.Contractors.Update(con);
                context.SaveChanges();
            }
          

            return new JsonResult("Rekord z id "+con.ContractorId+ " zaktualizowany");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            using (var context = new ContractortDbContext())
            {
                var ContractorToRemove = context.Contractors.Where(x => x.ContractorId == id).FirstOrDefault();
                context.Contractors.Remove(ContractorToRemove);
                context.SaveChanges();
            }

            return new JsonResult("Rekord z id " + id+ " usunięty");
        }


    }
}
