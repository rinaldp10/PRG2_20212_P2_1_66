using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20212_P2_1_66
{
    class Mobil_0320210066
    {
        protected string merk;
        protected string color;
        protected string type;

        public Mobil_0320210066(string merk, string color, string type)
        {
            this.MyMerk = merk;
            this.Color = color;
            this.MyType = "Mobil";
            //tipe untuk class ini akan selalu mobil
            //sehingga tidak perlu paramter masukan atau type
            //demikian pula sebenernya dengan class motor

            Console.WriteLine("Ini dari class Mobil");
        }

        public string MyMerk
        {
            get
            {
                return merk;
            }
            set
            {
                merk = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string MyType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
