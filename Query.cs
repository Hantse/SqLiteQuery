﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Data.SQLite;

namespace SqLiteQuery
{
    public sealed class Query : CUD
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

        public Boolean ExecuteSqlFile(string File, ref Exception Error)
        {
            try
            {
                StreamReader SR = new StreamReader(File);
                string sBatchString;
                int Pos = 0;
                int PosGo = 0;
                string Query = "";

                if (SR != null)
                {
                    sBatchString = SR.ReadToEnd();
                    SR.Close();

                    while ((PosGo = sBatchString.IndexOf("\r\nGO", Pos)) > -1)
                    {
                        Query = sBatchString.Substring(Pos, PosGo - Pos);
                        Pos = PosGo + 4;
                        ExecuteQuery(Query, ref Error);
                    }

                }

                ExecuteQuery(Query, ref Error);
            }
            catch (Exception e)
            {
                Error = e;
                return false;
            }

            return true;
        }

        public Boolean ExecuteSqlFile(string File, ref Exception Error, ref string RQuery)
        {
            try
            {
                StreamReader SR = new StreamReader(File);
                string Line = "";
                string Query = "";

                do
                {
                    Line = SR.ReadLine() + "\n";
                    Query += Line;
                } while (Line != null);

                RQuery = Query;
                ExecuteQuery(Query, ref Error);
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
