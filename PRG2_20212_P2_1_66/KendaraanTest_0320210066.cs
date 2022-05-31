using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20212_P2_1_66
{
    class KendaraanTest_0320210066
    {
        static void Main(string[] args)
        {
            // intstanstiasi object myKendaraan dari class Kendaraan_0320210066
            //Kendaraan_0320210066 myKendaraan = new Kendaraan_0320210066();

            //myKendaraan.MyType = "Motor";

            //menuliskan data myType dari myProduct ke layar
            //Console.WriteLine(myKendaraan.MyType);

            // intstanstiasi object myKendaraan dari class Kendaraan_0320210066
            //Motor_0320210066 myMotor = new Motor_0320210066("Motor", "Honda", "1000");

            //menuliskan state dari myKendaraan ke layar
            //Console.WriteLine("\" kendaraam type {0} dengan merk {1} berjumlah {2} \"", myMotor.MyType, myMotor.MyMerk, myMotor.Quantity);

            //instansi class motor
            Motor_0320210066 kendaraan1 = new Motor_0320210066("Motor", "Honda", "1000");
            //menuliskan state dari kendaraam ke layar
            Console.WriteLine("Produk kendaraan 1 adalah type {0} dengan merk {1} berjumlah {2}",
                kendaraan1.MyType, kendaraan1.MyMerk, kendaraan1.Quantity);

            //instansi class mobil
            Mobil_0320210066 kendaraan2 = new Mobil_0320210066("Toyota", "", "Silver");
            //menuliskan state dari kendaraam ke layar
            Console.WriteLine("Produk kendaraan 2 adalah type {0} dengan merk {1} berwarna {2}",
                kendaraan2.MyType, kendaraan2.MyMerk, kendaraan2.Color);
        }
    }
}
