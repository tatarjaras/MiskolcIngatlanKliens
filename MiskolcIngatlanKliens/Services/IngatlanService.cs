using MiskolcIngatlanKliens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MiskolcIngatlanKliens.Services
{
    internal class IngatlanService
    {
        public static async Task<List<Ingatlan>> GetAll(HttpClient client)
        {
            List<Ingatlan> result = await client.GetFromJsonAsync<List<Ingatlan>>("Ingatlan");
            if (result is not null)
            {
                return result;
            }
            else
            {
                return new List<Ingatlan>();
            }
            
        }
    }
}
