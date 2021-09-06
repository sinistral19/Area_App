using System;

namespace Area_Lib
{
    public static class Lib_App
    {

        public static void Area_Fig(int x, params double[] y)
        {
            switch (x)
            {
                case 1:
                    Area_Circle(y);
                    break;
                case 2:
                    Area_Triangle(y);
                    break;
                default:
                    break;
            }
        }


        public static double Area_Circle(double[] Rad)
        {
            double Area = 0;

            Area = 3.14 * Math.Pow(Rad[0], 2); //  м^2

            return Area;

        }

        public static double Area_Triangle(double[] Rad)
        {//площадь м^2
            double a, b, c, P;
            a = Rad[0];
            b = Rad[1];
            c = Rad[2];

            P = (a + b + c) / 2;

            double Area = Math.Round(Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)));


            double Area1 = Math.Round(Area);

            return Area;

        }

        public static bool Cos_Triangle(out string z, params double[] Rad)
        {
            double CosA, CosB, CosC;
            double a, b, c;
            a = 4;
            b = 3;
            c = 5;

            CosA = Math.Round((Math.Acos((b * b + c * c - a * a) / (2 * b * c))) * 57.2958);
            CosB = Math.Round((Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * 57.2958);

            CosC = Math.Round(180 - (CosA + CosB));


            double zzz = Math.Round(CosA + CosB + CosC);



            a = Math.Acos(CosA);
            b = Math.Acos(CosB);
            // c= Math.Acos(CosC);


            if ((CosA == 90) || (CosB == 90) || (CosC == 90))
            {

                z = "the triangle is right-angled";
                return true;
            }
            else
            {
                z = "the triangle is not right-angled";
                return false;
            }

        }




    }
}

