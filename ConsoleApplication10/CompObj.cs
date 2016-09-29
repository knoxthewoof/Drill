using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingDemo
{
    [Serializable]
    class ComputerObject
    {
        public enum PC_Type { WINDOWS, LINUX, MAC};

        PC_Type ptype;

        double cost = 0;
        public ComputerObject()
        {

        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public double getCost()
        {
            return cost;
        }

        public void setType(PC_Type type)
        {
            ptype = type; 
        }

        public PC_Type getType()
        {
            return ptype;
        }

        public String printContent()
        {
            String msg = "PC Type: " + ptype + " Cost: " + cost;
            return msg;
        }
    }
}
