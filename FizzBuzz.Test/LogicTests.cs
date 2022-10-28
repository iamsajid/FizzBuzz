using FizzBuzz.Logic;
using FizzBuzz.Models;

namespace FizzBuzz.Test
{
    public class LogicTests
    {
        [Fact]
        public void DevideByThreeTest()
        {
            //Arrange
            var rule = new DevideByThree();
            ValuesToPrint? expected = new ValuesToPrint
            {
                Id = 6,
                Value = DateTime.Now.DayOfWeek.ToString() == "Wednesday" ? "Wizz" : "Fizz"
            };

            //Act
            var res = rule.Calculation(6);

            //Assert
            Assert.Equal(expected.ToString(), res.ToString());
        }

        [Fact]
        public void DevideByFiveTest()
        {
            //Arrange
            var rule = new DevideByFive();
            ValuesToPrint? expected = new ValuesToPrint
            {
                Id = 10,
                Value = DateTime.Now.DayOfWeek.ToString() == "Wednesday" ? "Wuzz" : "Buzz"
            };

            //Act
            var res = rule.Calculation(10);

            //Assert
            Assert.Equal(expected.ToString(), res.ToString());
        }

        [Fact]
        public void DevideByThreeAndFiveTest()
        {
            //Arrange
            var rule = new DevideByThreeAndFive();
            ValuesToPrint? expected = new ValuesToPrint
            {
                Id = 15,
                Value = DateTime.Now.DayOfWeek.ToString() == "Wednesday" ? "WizzWuzz" : "FizzBuzz"
            };

            //Act
            var res = rule.Calculation(15);

            //Assert
            Assert.Equal(expected.ToString(), res.ToString());
        }

        [Fact]
        public void GeneralRuleTest()
        {
            //Arrange
            var rule = new GeneralRule();
            ValuesToPrint? expected = new ValuesToPrint
            {
                Id = 15,
                Value = Convert.ToString(15)
            };

            //Act
            var res = rule.Calculation(15);

            //Assert
            Assert.Equal(expected.ToString(), res.ToString());
        }
        
        [Fact]
        public void CalculationTest()
        {
            //Arrange
            var calculation = new Calculation();
            var expected = DateTime.Now.DayOfWeek.ToString() == 
                "Wednesday" ? MockData.GetTestDataForWednesday() : MockData.GetTestDataForOtherDays();

            //Act
            var res = calculation.GetValueList(15);

            //Assert
            Assert.Equal(expected.ToString(), res.ToString());
        }


    }
}
