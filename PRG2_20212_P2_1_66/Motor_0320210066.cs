using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20212_P2_1_66
{
    class Motor_0320210066
    {
        //deklarasi variabel dengan access modifier protected
        protected string type;
        protected string quantity;
        protected string merek;

        //berikut ini merupakan constructor untuk class motor
        //constructor ini meng-overdrive constructor dari class induknya

        //cara memanggil constructor dari class induk, dengan string keyword base
        public Motor_0320210066(string type, string merek, string quantity)
           // : base(type, merek)
        {
            this.type = type;
            this.merek = merek;
            this.quantity = quantity;
        }

        //property dari variabel quantity
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

        public string MyMerk
        {
            get
            {
                return merek;
            }
            set
            {
                merek = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity; 
            }
            set
            {
                quantity = value;
            }
        }
    }
}
