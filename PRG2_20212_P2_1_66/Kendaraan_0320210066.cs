using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20212_P2_1_66
{
    //3 reference
    class Kendaraan_0320210066
    {
        //deklarasi data
        //protected String myType = "Motor";
        private string myType;
        //private string myTitle;
        private string myMerk;

        //deklarasi method, contructor
        
        public Kendaraan_0320210066()
        {

        }

        //method overloading
        public Kendaraan_0320210066(string type, string merk)
        {
            this.myType = type;
            this.myMerk = merk;
        }
        
        //property dari variabel myType
        public string Mytype
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value; 
            }
        }

        //property dari variabel myMerk
        public string MyMerk
        {
            get
            {
                return myMerk;
            }
            set
            {
                myMerk = value;
            }
        }
    }
}
