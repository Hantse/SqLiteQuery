using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;

namespace SqLiteQuery
{
    class CUD : Read
    {
        public CUD(string Source) : base(Source){}
        public CUD(string Source, string Version) : base(Source, Version){}
        public CUD(string Source, string Version, string Password) : base(Source, Version, Password) { }
        public CUD(string Source, string Version, string Password, Boolean New) : base(Source, Version, Password, New) { }
        public CUD(string Source, string Version, string Password, Boolean New, Boolean Compress) : base(Source, Version, Password, New, Compress) { }

        public Boolean Insert(string Table, string[] Field, string[] Values, ref Exception Error)
        {
            string Query = "INSERT INTO " + Table + "(";

            if (Field.Length != Values.Length)
            {
                Error = new Exception("Field & Values has a differents number of values.");
                return false;
            }
            else
            {
                foreach(string V in Values){
                    Query += V + ", ";
                }
                Query += ") VALUES (";
                foreach (string F in Field)
                {
                    Query += F + ", ";
                }
                Query += ")";
            }

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
    }
}
