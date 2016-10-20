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
        public Counties(int countyID, String countyName, Province province)
        {
            setCountyID(countyID);
            setCountyName(countyName);
            setProvince(province);

        }

        private void setProvince(Province province)
        {
            this.province = province;
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
