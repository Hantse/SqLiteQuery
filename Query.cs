using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace SqLiteQuery
{
    public class Query : CUD
    {
        public Query(string Source) : base(Source){}
        public Query(string Source, string Version) : base(Source, Version){}
        public Query(string Source, string Version, string Password) : base(Source, Version, Password) { }
        public Query(string Source, string Version, string Password, Boolean New) : base(Source, Version, Password, New) { }
        public Query(string Source, string Version, string Password, Boolean New, Boolean Compress) : base(Source, Version, Password, New, Compress){}

        public Boolean ExecuteQuery(string Query, ref Exception Error)
        {
            try
            {

                base._SqLiteCommand.CommandText = Query;
                base._SqLiteCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Error = e;
                return false;
            }
            return true;

        }

        public int CountAction(String Query, ref Exception Error)
        {
            try
            {
                base._SqLiteCommand.CommandText = Query;
                String Count = base._SqLiteCommand.ExecuteScalar().ToString();
                return int.Parse(Count);
            }
            catch (Exception e)
            {
                Error = e;
                return 0;
            }
        }
    }
}
