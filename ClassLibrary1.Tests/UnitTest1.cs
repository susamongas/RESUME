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
            // Arrange (����������)
            double radius = 3;
            double expected = Math.PI * radius * radius;
            // ����������
            double actual = Class1.Ploshad(radius);
            // ��������
            Assert.Equal(expected, actual);
        }
    }

    public class Class1Tests2
    {
        [Fact]
        public void Treugolinik_ReturnsCorrectArea_ForGivenSides()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;  // ������� ������������ �� ��������� 3, 4, 5
            double actual = Class1.Treugolinik(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}