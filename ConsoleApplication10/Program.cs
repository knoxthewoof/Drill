using serializedDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingDemo
{
    public class MyInfo
    {
        static void Main(string[] args)
        {
            SerializeData sdata = new SerializeData("testBinaryFile.txt");
            HomeObj ho = new HomeObj();
            ho.setHomeType(HomeObj.Type.Condo);
            ho.setYear(2016);
            ComputerObject co = new ComputerObject();
            co.setType(ComputerObject.PC_Type.LINUX);
            co.setCost(0.0);
            ComputerObject co1 = new ComputerObject();
            co1.setType(ComputerObject.PC_Type.WINDOWS);
            co1.setCost(100.0);
            sdata.SerializedObject(ho);
            sdata.SerializedObject(co);
            sdata.SerializedObject(co1);

            sdata.closeStream();


            sdata.DeserializeObjects();
            sdata.closeStream();
        }

    }


}
