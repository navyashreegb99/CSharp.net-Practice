using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorPractice
{
   public class CopyConstructorEx
    {
        String VehicleName;
        String VehicleNo;
        String State;

       public CopyConstructorEx(String Vehiclename,String VehicleNo, String State)
        {
            this.VehicleName = Vehiclename;
            this.VehicleNo = VehicleNo;
            this.State = State;
        }

       public CopyConstructorEx(CopyConstructorEx vehicle)
        {
            VehicleName = vehicle.VehicleName;
            VehicleNo = vehicle.VehicleNo;
            State = vehicle.State;
        }

        public String Data
        {
            get
            {
                return "Vehicle name is: " + VehicleName + "Vehicle no is: " + VehicleNo + "It belongs to " + State;
            }
        }

    }

    class Testing
    {
        public static void Main()
        {
            CopyConstructorEx vehicle1 = new CopyConstructorEx("Maruthi Suzuki", "KA23DF08", "Karnataka");
            CopyConstructorEx vehicle2 = new CopyConstructorEx(vehicle1);
            Console.WriteLine(vehicle1.Data);
            Console.WriteLine(vehicle2.Data);
        }
    }
}
