using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSkool.Models;
namespace eSkool.Logistics
{
    public class ActiveUser
    {
        static public bool recordActive(string username)
        {
        
            using (eSkoolDBContext db = new eSkoolDBContext())
            {
                var record = db.Tables.Where(x => x.Username == username).SingleOrDefault();
                if (record != null)
                {
      
                    record.UpdatedTime = DateTime.Now;

                    db.Tables.Update(record);
                }
                else
                {
                    Table newRecord = new Table();
                    newRecord.PeTime = DateTime.Now;
                    newRecord.UpdatedTime = DateTime.Now;
                    newRecord.Username = username;

                    db.Tables.Add(newRecord);

                }
                db.SaveChanges();
            }

            return true; ;
        }

      static public bool  recordInActive(string username)
        {
            using (eSkoolDBContext db = new eSkoolDBContext())
            {
                var record = db.Tables.Where(x => x.Username == username).SingleOrDefault();
                if (record != null)
                {
                    db.Tables.Remove(record);
                    db.SaveChanges();
                }
              
            }
            recordFlushOut();
            return true;
        }

        static public bool recordFlushOut()
        {
            using (eSkoolDBContext db = new eSkoolDBContext())
            {
                List<Table> records = db.Tables.ToList();
                
                foreach (var rec in records)
                {
                    if (DateTime.Now - rec.UpdatedTime > new TimeSpan(0, 0, 5, 0) )
                    {
                        db.Tables.Remove(rec);
                    }
                }
                db.SaveChanges();
            }
            
            return true;
        }




    }
}
