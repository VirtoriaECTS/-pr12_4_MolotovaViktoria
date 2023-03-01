using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osnovu_practica12_zad4
{
    public class Sportsmen
    {
        public string name;
        public string otchestvo;
        public string familia;
        public string pol;
        public DateTime data_roz;
        public double rost;
        public double ves;
        public string vid_sporta;

        public string get_info() //Информация о спортсмене
        {
            string text = "Информация о спортсмене";
            text += $"\nИмя: {name}\nОтчество: {otchestvo}\nФамилия: {familia}\nПол: {pol}\n" +
                $"Дата рождения:{data_roz.ToString("dd MMMM yyyy")}\nРост:{rost}" +
                $"\nВес: {ves}\nВид спорта:{vid_sporta}\n";
            return text;
        }

        public double Brok_ves() //Идеальный вес по формуле брока
        {
            double perfuct_ves;

            int year_age = Convert.ToInt32(data_roz.ToString("yyyy"));
            int age = 2023 - year_age;
            if(age < 40)
            {
                perfuct_ves = rost - 110;
            }
            else
            {
                perfuct_ves =  rost - 100;
            }
            return perfuct_ves;
        }

        public double Kuper_ves() //Идеальный вес по формуле Купера
        {
            double perfect_ves = 1;
            if(pol == "Ж")
            {
                perfect_ves = (rost * 3.5 / 2.54 - 108) * 0.453;
            }
            else
            {
                perfect_ves = (rost * 4.0 / 2.54 - 128) * 0.453;
            }
            return perfect_ves;
        }

        public string imt()
        {
            string text;
            double metr_rost = rost / 100;
            double imt = ves / (Math.Pow(metr_rost, 2));
            if (imt < 16) text = "Выраженный дифицит массы тела";
            else if ((imt > 16) && (imt < 18.5)) text = "Недостаточная масса тела";
            else if ((imt > 18.5) && (imt < 25)) text = "Норма";
            else if ((imt > 25) && (imt < 30)) text = "Избыточная масса тела";
            else if ((imt > 30) && (imt < 35)) text = "Ожирение 1 степени";
            else if ((imt > 35) && (imt < 40)) text = "Ожирение 2 степени";
            else text = "Ожирение 3 степени";
            return text;
        }
    }
}
