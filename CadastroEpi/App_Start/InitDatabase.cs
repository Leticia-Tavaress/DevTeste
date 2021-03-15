using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using CadastroEpi.Domain.Model;
using Newtonsoft.Json;

namespace CadastroEpi
{
    public class InitDatabase
    {
        public static void SeedData()
        {
            using (var ctx = new Db.Entities())
            {
                if (!ctx.Epis.Any())
                {
                    var dir = AppDomain.CurrentDomain.BaseDirectory;
                    var arquivo = Path.Combine(dir, "bin\\Setup\\epi.json");
                    var lstEpi = JsonConvert.DeserializeObject<List<Epi>>(File.ReadAllText(arquivo));

                    foreach (var epi in lstEpi)
                    {
                        ctx.Epis.Add(epi);
                    }

                    ctx.SaveChanges();
                }
            }
        }
    }
}