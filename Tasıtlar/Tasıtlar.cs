using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasıtlar
{
    class Tasıtlar
    {
        public string marka,vitesTuru,yakit;
        public int modelYili;


        public string Marka
        {

            
            get
            {
                return marka.ToUpper();
            }
            set
            {
                marka=value;
            }
        }
        public int ModelYili
        {
            get { return modelYili; }
            set 
            { 
                modelYili = Math.Abs(value);
            
            }

        }

       

    }
}
