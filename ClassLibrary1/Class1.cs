namespace ClassLibrary1
{
    public class Class1
    {
        public static Double Ploshad(Double radiuSus)
        {
            return radiuSus * radiuSus * Math.PI;
        }

        public static Double Treugolinik(Double Storona1, Double Storona2, Double Storona3)
        {
            double[] sides = { Storona1, Storona2, Storona3 };
            Array.Sort(sides); // сортировка масива
            Console.WriteLine(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2) ?
                              "Прямоугольный" : "Не прямоугольный"); // проверяем по формуле прямоугольность
            double vremeno = (Storona1 + Storona2 + Storona3) / 2; // пол периметра
            return Math.Sqrt(vremeno * (vremeno- Storona1) * (vremeno- Storona2)*(vremeno-Storona3));  // по трем сторонам: S = √p · (p — a)(p — b)(p — c),
        }
    }
}