using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ligue
{
    public class Date
    {
        public int diffDates(string d1, string d2)
        {
            string[] dt1 = d1.Split('-');
            string[] dt2 = d2.Split('-');

            DateTime date1 = new DateTime(Convert.ToInt16(dt1[2]), Convert.ToInt16(dt1[1]), Convert.ToInt16(dt1[0]));
            DateTime date2 = new DateTime(Convert.ToInt16(dt2[2]), Convert.ToInt16(dt2[1]), Convert.ToInt16(dt2[0]));

            TimeSpan diff = date2 - date1;
            int resu = diff.Days;
            return resu;
        }
    }
}
