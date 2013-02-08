using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace SqLiteQuery
{
    public class Read : SqLiteQuery
    {
        SQLiteDataReader _SqLiteDataReader;

        public Read(string Source) : base(Source){}
        public Read(string Source, string Version) : base(Source, Version){}
        public Read(string Source, string Version, Boolean New) : base(Source, Version, New){}
        public Read(string Source, string Version, Boolean New, Boolean Compress) : base(Source, Version, New, Compress) { }

        public SQLiteDataReader ReadData(String Query)
        {
            base._SqLiteCommand.CommandText = Query;
            _SqLiteDataReader = base._SqLiteCommand.ExecuteReader();
            return _SqLiteDataReader;
        }
    }
}
