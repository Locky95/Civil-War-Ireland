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
        enum Province {Leinster,Munster,Ulster,Connaught};
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

        private void setProvince(int countyID)
        {
           // this.province = province;
        }

        private void setCountyName(string countyName)
        {
            throw new NotImplementedException();
        }

        private void setCountyID(int countyID)
        {
            throw new NotImplementedException();
        }
    }
}
