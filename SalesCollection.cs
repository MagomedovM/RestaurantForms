using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantForms
{
    public class SalesCollection
    {
        static Menu myMenu = new Menu();

        public List<Sales> array = new List<Sales>()
        {
            // Итоги за январь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 2192, totalEarned = 2192 * myMenu.Kalakeitto,  monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 445,  totalEarned = 445 * myMenu.Hernekeitto,  monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 2004, totalEarned = 2004 * myMenu.Leipajuusto, monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 2932, totalEarned = 2932 * myMenu.Graavilohi,  monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 754,  totalEarned = 754  * myMenu.Kalakukko,   monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 1534, totalEarned = 1534 * myMenu.Sahti,       monthNum = 1, monthName = "Январь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 3765, totalEarned = 3765 * myMenu.Minttu,      monthNum = 1, monthName = "Январь 2022" },

                    // Итоги за февраль 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 2292, totalEarned = 2292 * myMenu.Kalakeitto,  monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 1085, totalEarned = 1085 * myMenu.Hernekeitto, monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 2434, totalEarned = 2434 * myMenu.Leipajuusto, monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 1562, totalEarned = 1562 * myMenu.Graavilohi,  monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 1004, totalEarned = 1004 * myMenu.Kalakukko,   monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Sahti",       quantity = 4564, totalEarned = 4564 * myMenu.Sahti,       monthNum = 2, monthName = "Февраль 2022" },
                new Sales() { dishName = "Minttu",      quantity = 4765, totalEarned = 4765 * myMenu.Minttu,      monthNum = 2, monthName = "Февраль 2022" },

                    // Итоги за март 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 2572, totalEarned = 2572 * myMenu.Kalakeitto,  monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 835,  totalEarned = 835 * myMenu.Hernekeitto,  monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 2544, totalEarned = 2544 * myMenu.Leipajuusto, monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 3252, totalEarned = 3252 * myMenu.Graavilohi,  monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 984,  totalEarned = 984  * myMenu.Kalakukko,   monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Sahti",       quantity = 2354, totalEarned = 2354 * myMenu.Sahti,       monthNum = 3, monthName = "Март 2022" },
                new Sales() { dishName = "Minttu",      quantity = 3735, totalEarned = 3735 * myMenu.Minttu,      monthNum = 3, monthName = "Март 2022" },

                    // Итоги за апрель 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 3192, totalEarned = 3192 * myMenu.Kalakeitto,  monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 915,  totalEarned = 915 * myMenu.Hernekeitto,  monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 3101, totalEarned = 3101 * myMenu.Leipajuusto, monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 2932, totalEarned = 2932 * myMenu.Graavilohi,  monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 1254, totalEarned = 1254 * myMenu.Kalakukko,   monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Sahti",       quantity = 3532, totalEarned = 3532 * myMenu.Sahti,       monthNum = 4, monthName = "Апрель 2022" },
                new Sales() { dishName = "Minttu",      quantity = 2761, totalEarned = 2761 * myMenu.Minttu,      monthNum = 4, monthName = "Апрель 2022" },

                    // Итоги за май 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 3321, totalEarned = 3321 * myMenu.Kalakeitto,  monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 1311, totalEarned = 1311 * myMenu.Hernekeitto, monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 2404, totalEarned = 2404 * myMenu.Leipajuusto, monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 3932, totalEarned = 3932 * myMenu.Graavilohi,  monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 1211, totalEarned = 1211 * myMenu.Kalakukko,   monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Sahti",       quantity = 3134, totalEarned = 3134 * myMenu.Sahti,       monthNum = 5, monthName = "Май 2022" },
                new Sales() { dishName = "Minttu",      quantity = 3722, totalEarned = 3722 * myMenu.Minttu,      monthNum = 5, monthName = "Май 2022" },

                    // Итоги за июнь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 3794, totalEarned = 3794 * myMenu.Kalakeitto,  monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 1548, totalEarned = 1548 * myMenu.Hernekeitto, monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 3304, totalEarned = 3304 * myMenu.Leipajuusto, monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 3431, totalEarned = 3431 * myMenu.Graavilohi,  monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 1854, totalEarned = 1854 * myMenu.Kalakukko,   monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 3522, totalEarned = 3522 * myMenu.Sahti,       monthNum = 6, monthName = "Июнь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 2965, totalEarned = 2965 * myMenu.Minttu,      monthNum = 6, monthName = "Июнь 2022" },

                    // Итоги за июль 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 4691, totalEarned = 4691 * myMenu.Kalakeitto,  monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 1645, totalEarned = 1645 * myMenu.Hernekeitto, monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 4201, totalEarned = 4201 * myMenu.Leipajuusto, monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 3937, totalEarned = 3937 * myMenu.Graavilohi,  monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 2251, totalEarned = 2251 * myMenu.Kalakukko,   monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Sahti",       quantity = 4531, totalEarned = 4531 * myMenu.Sahti,       monthNum = 7, monthName = "Июль 2022" },
                new Sales() { dishName = "Minttu",      quantity = 3722, totalEarned = 3722 * myMenu.Minttu,      monthNum = 7, monthName = "Июль 2022" },

                    // Итоги за август 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 5172, totalEarned = 5172 * myMenu.Kalakeitto,  monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 2945, totalEarned = 2945 * myMenu.Hernekeitto, monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 5204, totalEarned = 5204 * myMenu.Leipajuusto, monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 5432, totalEarned = 5432 * myMenu.Graavilohi,  monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 3254, totalEarned = 3254 * myMenu.Kalakukko,   monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Sahti",       quantity = 5134, totalEarned = 5134 * myMenu.Sahti,       monthNum = 8, monthName = "Август 2022" },
                new Sales() { dishName = "Minttu",      quantity = 3961, totalEarned = 3961 * myMenu.Minttu,      monthNum = 8, monthName = "Август 2022" },

                    // Итоги за сентябрь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 6592, totalEarned = 6592 * myMenu.Kalakeitto,  monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 2945, totalEarned = 2945 * myMenu.Hernekeitto, monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 7001, totalEarned = 7001 * myMenu.Leipajuusto, monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 6332, totalEarned = 6332 * myMenu.Graavilohi,  monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 3954, totalEarned = 3954 * myMenu.Kalakukko,   monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 6232, totalEarned = 6232 * myMenu.Sahti,       monthNum = 9, monthName = "Сентябрь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 4761, totalEarned = 4761 * myMenu.Minttu,      monthNum = 9, monthName = "Сентябрь 2022" },

                    // Итоги за октябрь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 8192, totalEarned = 8192 * myMenu.Kalakeitto,  monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 3245, totalEarned = 3245 * myMenu.Hernekeitto, monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 8004, totalEarned = 8004 * myMenu.Leipajuusto, monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 7932, totalEarned = 7932 * myMenu.Graavilohi,  monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 4554, totalEarned = 4554 * myMenu.Kalakukko,   monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 7534, totalEarned = 7534 * myMenu.Sahti,       monthNum = 10, monthName = "Октябрь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 8765, totalEarned = 8765 * myMenu.Minttu,      monthNum = 10, monthName = "Октябрь 2022" },

                    // Итоги за ноябрь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 8892, totalEarned = 8892 * myMenu.Kalakeitto,  monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 4764, totalEarned = 4764 * myMenu.Hernekeitto, monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 8454, totalEarned = 8454 * myMenu.Leipajuusto, monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 8932, totalEarned = 8932 * myMenu.Graavilohi,  monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 5145, totalEarned = 5145 * myMenu.Kalakukko,   monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 7987, totalEarned = 7987 * myMenu.Sahti,       monthNum = 11, monthName = "Ноябрь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 8785, totalEarned = 8785 * myMenu.Minttu,      monthNum = 11, monthName = "Ноябрь 2022" },

                    // Итоги за декабрь 2022
                new Sales() { dishName = "Kalakeitto",  quantity = 9192, totalEarned = 9192 * myMenu.Kalakeitto,  monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Hernekeitto", quantity = 5245, totalEarned = 5245 * myMenu.Hernekeitto, monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Leipäjuusto", quantity = 8994, totalEarned = 8994 * myMenu.Leipajuusto, monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Graavilohi",  quantity = 8932, totalEarned = 8932 * myMenu.Graavilohi,  monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Kalakukko",   quantity = 6254, totalEarned = 6254 * myMenu.Kalakukko,   monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Sahti",       quantity = 7994, totalEarned = 7994 * myMenu.Sahti,       monthNum = 12, monthName = "Декабрь 2022" },
                new Sales() { dishName = "Minttu",      quantity = 9765, totalEarned = 9765 * myMenu.Minttu,      monthNum = 12, monthName = "Декабрь 2022" },

                    // Итоги за январь 2023
                new Sales() { dishName = "Kalakeitto",  quantity = 10192, totalEarned = 10192 * myMenu.Kalakeitto,  monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Hernekeitto", quantity = 6245,  totalEarned = 6245 * myMenu.Hernekeitto,  monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Leipäjuusto", quantity = 12767, totalEarned = 12767 * myMenu.Leipajuusto, monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Graavilohi",  quantity = 9932,  totalEarned = 9932  * myMenu.Graavilohi,  monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Kalakukko",   quantity = 7654,  totalEarned = 7654  * myMenu.Kalakukko,   monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Sahti",       quantity = 10534, totalEarned = 10534 * myMenu.Sahti,       monthNum = 13, monthName = "Январь 2023" },
                new Sales() { dishName = "Minttu",      quantity = 9965,  totalEarned = 9965  * myMenu.Minttu,      monthNum = 13, monthName = "Январь 2023" },

                    // Итоги за февраль 2023
                new Sales() { dishName = "Kalakeitto",  quantity = 12291, totalEarned = 12291 * myMenu.Kalakeitto,  monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Hernekeitto", quantity = 5785,  totalEarned = 5785 * myMenu.Hernekeitto,  monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Leipäjuusto", quantity = 11434, totalEarned = 11434 * myMenu.Leipajuusto, monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Graavilohi",  quantity = 10561, totalEarned = 10561 * myMenu.Graavilohi,  monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Kalakukko",   quantity = 8704,  totalEarned = 8704 * myMenu.Kalakukko,    monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Sahti",       quantity = 11561, totalEarned = 11561 * myMenu.Sahti,       monthNum = 14, monthName = "Февраль 2023" },
                new Sales() { dishName = "Minttu",      quantity = 9865,  totalEarned = 9865 * myMenu.Minttu,       monthNum = 14, monthName = "Февраль 2023" },

                    // Итоги за март 2023
                new Sales() { dishName = "Kalakeitto",  quantity = 12571, totalEarned = 12571 * myMenu.Kalakeitto,  monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Hernekeitto", quantity = 6335,  totalEarned = 6335 * myMenu.Hernekeitto,  monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Leipäjuusto", quantity = 11524, totalEarned = 11524 * myMenu.Leipajuusto, monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Graavilohi",  quantity = 10252, totalEarned = 10252 * myMenu.Graavilohi,  monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Kalakukko",   quantity = 8984,  totalEarned = 8984  * myMenu.Kalakukko,   monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Sahti",       quantity = 12154, totalEarned = 12154 * myMenu.Sahti,       monthNum = 15, monthName = "Март 2023" },
                new Sales() { dishName = "Minttu",      quantity = 10732, totalEarned = 10732 * myMenu.Minttu,      monthNum = 15, monthName = "Март 2023" },

                    // Итоги за апрель 2023
                new Sales() { dishName = "Kalakeitto",  quantity = 13192, totalEarned = 13192 * myMenu.Kalakeitto,  monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Hernekeitto", quantity = 7215,  totalEarned = 7215 * myMenu.Hernekeitto,  monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Leipäjuusto", quantity = 13121, totalEarned = 13121 * myMenu.Leipajuusto, monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Graavilohi",  quantity = 12132, totalEarned = 12132 * myMenu.Graavilohi,  monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Kalakukko",   quantity = 8951,  totalEarned = 8951 * myMenu.Kalakukko,    monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Sahti",       quantity = 12532, totalEarned = 12532 * myMenu.Sahti,       monthNum = 16, monthName = "Апрель 2023" },
                new Sales() { dishName = "Minttu",      quantity = 10761, totalEarned = 10761 * myMenu.Minttu,      monthNum = 16, monthName = "Апрель 2023" }
        };
    }
}
