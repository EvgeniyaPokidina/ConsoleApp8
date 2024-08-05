using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._1

{
 
    public static class RubleConverter
    {
        public static decimal toDollars(decimal rub)=>  rub / 84.95m;
        public static decimal ToEuros(decimal rub) => rub / 93.04m;
        public static decimal ToZlotys(decimal rub) => rub / 21.6m;
        public static decimal ToYuan(decimal rub) => rub / 11.83m;
        public static decimal ToRupes(decimal rub) => rub / 1.01m;
    }
}
