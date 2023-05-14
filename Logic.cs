
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class Logic
    {
        string msgError = "";
        public string getErrorMsg()
        {
           return msgError;
        }

        public Double calcS(double sizeCm)
        {

            var SYellowArea = 0.0;

            if (sizeCm > 0 && sizeCm < 15)
            {
                //сторона треугольника
                var triangleSide = findBottomSideOfRightTrapecia(sizeCm, sizeCm / 2, 60);
                //площад звезды давида, зная радиус описанной окружности
                var sDavidStar = SdavidStar(triangleSide);

                // calculate S 6-sided polygon
                var sPolygon = SPolygon(sizeCm);

                //res S
                SYellowArea = sPolygon - sDavidStar;

            }else if(sizeCm <= 0)
            {
                msgError = "Сторона 6тиугольника не может быть <= 0";
            }
            else
            {
                msgError = "Сторона 6тиугольника не может быть  >= 15";
            }

            return Math.Round(SYellowArea, 3);
        }

        //b - up side, c - rebro, bottom angle
        public Double findBottomSideOfRightTrapecia(double b, double c, int angle)
        {
            double radians = angle * Math.PI / 180.0;

           // Console.WriteLine("cos " + Math.Cos(radians));

            var a = b + 2 * c * Math.Cos(radians);

            return Math.Round(a,3);
        }

        public Double SdavidStar(double side)
        {
            var STriangle = StriangleBySide(side);

            var SDel9 = STriangle / 9;
            var S = SDel9 * 12;

            return Math.Round(S,3);
        }

        public Double StriangleBySide(double side)
        {
            var S = Math.Sqrt(3) * Math.Pow(side, 2) / 4;

            return Math.Round(S,3);
        }

        public Double SPolygon(double sizeSide)
        {
            var SPolygon = (3 * Math.Sqrt(3) / 2) * Math.Pow(sizeSide, 2);
            return Math.Round(SPolygon,3);
        }

    }
}
