using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dtproperties
    {
        private int id;

        public int Id
        {
          get { return id;}
          set { id=value;}
        }
        private int objectid;

        public int Objectid
        {
          get { return objectid;}
          set { objectid=value;}
        }
        private string property;

        public string Property
        {
          get { return property;}
          set { property=value;}
        }
        private string value;

        public string Value
        {
          get { return value;}
          set { value=value;}
        }
        private string uvalue;

        public string Uvalue
        {
          get { return uvalue;}
          set { uvalue=value;}
        }
        private string lvalue;

        public string Lvalue
        {
          get { return lvalue;}
          set { lvalue=value;}
        }
        private int version;

        public int Version
        {
          get { return version;}
          set { version=value;}
        }
    }
}
