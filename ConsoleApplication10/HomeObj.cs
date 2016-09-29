using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingDemo
{
    [Serializable]
    class HomeObj
    {
        int yearBuilt = 0;
        public enum Type { Single_Family, Town_Home, Condo};
        Type htype;

        public void HomeObject()
        {

        }
        public void setYear(int year)
        {
            yearBuilt = year;
        }
        public int getYear()
        {
            return yearBuilt;
        }

        public Type getHomeType()
        {
            return htype;
        }

        public void setHomeType(Type type_)
        {
            htype = type_;
        }

        public String printContent()
        {
            String msg = "HomeType: " + htype + " Year Built: " + yearBuilt;
            return msg;
        }
    }
}
