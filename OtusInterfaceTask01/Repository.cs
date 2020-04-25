using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace OtusInterfaceTask01
{
    public class Repository: IRepository<Account>
    {
        private string file = "account.json";
        public IEnumerable<Account> GetAll()
        {
            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.EndOfStream != null)
                {
                    var acc = JsonSerializer.Deserialize<Account>(sr.ReadLine());
                    if (acc != null)
                        yield return acc;
                }
            }
        }

        public Account GetOne(Func<Account, bool> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }

        public void Add(Account item)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine((JsonSerializer.Serialize(item)));
            }
        }
    }
}