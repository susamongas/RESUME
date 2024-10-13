namespace ClassLibrary1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }
    public class Class1Tests
    {
        [Fact] 
        public void Ploshad_ReturnsCorrectArea_ForGivenRadius()
        {
            // Arrange (подготовка)
            double radius = 3;
            double expected = Math.PI * radius * radius;
            // выполнение
            double actual = Class1.Ploshad(radius);
            // проверка
            Assert.Equal(expected, actual);
        }
    }

    public class Class1Tests2
    {
        [Fact]
        public void Treugolinik_ReturnsCorrectArea_ForGivenSides()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;  // Площадь треугольника со сторонами 3, 4, 5
            double actual = Class1.Treugolinik(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}