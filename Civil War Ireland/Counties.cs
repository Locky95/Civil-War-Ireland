using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civil_War_Ireland
{
    class Counties
    {
        int countyID;
        enum Province { Leinster, Munster, Ulster, Connaught };
        String countyName;

        public Counties()
        {

        }
        public Counties(int countyID, String countyName)
        {
            setCountyID(countyID);
            setCountyName(countyName);
            setProvince(countyID);

        }

        void setProvince(int countyID)
        {
            // this.province = province;
            // the countyID should be used to pick the province 
        }

        void setCountyName(string countyName)
        {
            this.countyName = countyName;
        }

        void setCountyID(int countyID)
        {
            this.countyID = countyID;
        }
        void getProvince()
        {
            //void for now till we sort out the set code
        }
        int getCountyID()
        {
            return countyID;
        }
        String getCountyName()
        {
            return countyName;
        }

    }
}
