using System;

namespace Lab3
{
    
    class Hospital
    {
        public static void RunHospitalProgram()
        {
            Hospital hospital1 = new Apollo();
            hospital1.HospitalDetails();

            Hospital hospital2 = new Wockhardt();
            hospital2.HospitalDetails();

            Hospital hospital3 = new Gokul_Superspeciality();
            hospital3.HospitalDetails();
        }

        public virtual void HospitalDetails()
        {
            Console.WriteLine("General hospital details...");
        }
    }

    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo hospital details...");
        }
    }

    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital details...");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality hospital details...");
        }
    }
}