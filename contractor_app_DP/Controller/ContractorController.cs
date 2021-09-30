using contractor_app_DP.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

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
        public JsonResult Get()
        {
            string query = @"select ContractorId,FirstName,Surname,REGON,NIP,ContactNumber,Country,City,Street,HomeNumber,PostalCode from dbo.Contractors";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ContrahentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, mycon))
                {
                    reader = sqlCommand.ExecuteReader();
                    table.Load(reader);

                    reader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(RegisterModel con)
        {

            String contractorQuery = "INSERT INTO dbo.Contractors (FirstName,Surname,REGON,NIP,ContactNumber,Country,City,Street,HomeNumber,PostalCode) VALUES (@FN,@SN,@Regon, @Nip,@CN,@Country,@City,@Street,@HN,@PC)";
            


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ContrahentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();

                using (SqlCommand sqlCommand = new SqlCommand(contractorQuery, mycon))
                {
                    sqlCommand.Parameters.AddWithValue("@FN", con.FirstName);
                    sqlCommand.Parameters.AddWithValue("@SN", con.Surname);
                    sqlCommand.Parameters.AddWithValue("@Regon", con.REGON);
                    sqlCommand.Parameters.AddWithValue("@Nip", con.NIP);
                    sqlCommand.Parameters.AddWithValue("@CN", con.ContactNumber);
                    sqlCommand.Parameters.AddWithValue("@Country", con.Country);
                    sqlCommand.Parameters.AddWithValue("@City", con.City);
                    sqlCommand.Parameters.AddWithValue("@Street", con.Street);
                    sqlCommand.Parameters.AddWithValue("@HN", con.HomeNumber);
                    sqlCommand.Parameters.AddWithValue("@PC", con.PostalCode);
                    reader = sqlCommand.ExecuteReader();
                    table.Load(reader);

                    reader.Close();
                    mycon.Close();
                }

            }

            return new JsonResult("Dodano nowy rekord");
        }


        [HttpPut]
        public JsonResult Put(RegisterModel con)
        {

            String query = @"update dbo.Contractors set FirstName = @FN,Surname = @SN,REGON= @Regon,NIP=@Nip,ContactNumber = @CN, Country=@Country,City=@City,Street=@Street,PostalCode=@PC,HomeNumber=@HN where ContractorId = " + con.ContractorId + @"";



            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ContrahentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, mycon))
                {
                    sqlCommand.Parameters.AddWithValue("@FN", con.FirstName);
                    sqlCommand.Parameters.AddWithValue("@SN", con.Surname);
                    sqlCommand.Parameters.AddWithValue("@Regon", con.REGON);
                    sqlCommand.Parameters.AddWithValue("@Nip", con.NIP);
                    sqlCommand.Parameters.AddWithValue("@CN", con.ContactNumber);
                    sqlCommand.Parameters.AddWithValue("@Country", con.Country);
                    sqlCommand.Parameters.AddWithValue("@City", con.City);
                    sqlCommand.Parameters.AddWithValue("@Street", con.Street);
                    sqlCommand.Parameters.AddWithValue("@HN", con.HomeNumber);
                    sqlCommand.Parameters.AddWithValue("@PC", con.PostalCode);
                    reader = sqlCommand.ExecuteReader();
                    table.Load(reader);

                    reader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Rekord zaktualizowany");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {

            String query = @"delete from dbo.Contractors where ContractorId=" + id + @"";



            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ContrahentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, mycon))
                {
                    reader = sqlCommand.ExecuteReader();
                    table.Load(reader);

                    reader.Close();
                    mycon.Close();
                }
            }

            return new JsonResult("Rekord usunięty");
        }


    }
}
