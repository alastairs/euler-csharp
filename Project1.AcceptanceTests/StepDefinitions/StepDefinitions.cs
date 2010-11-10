using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;
using TechTalk.SpecFlow;

namespace Project1.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        private Calculator calculator;
        private IEnumerable<int> numbers;
        private int result;

        [Given(@"a new calculator")]
        public void GivenANewCalculator()
        {
            calculator = new Calculator();
        }


        [Given(@"a list of all numbers below 1000")]
        public void GivenAListOfAllNumbersBelow1000()
        {
            numbers = Enumerable.Range(1, 999);
        }

        [When(@"the sum of all multiples of 3 and 5 is calculated")]
        public void WhenTheSumOfAllMultiplesOf3And5IsCalculated()
        {
            result = calculator.Calculate(numbers);
        }

        [Then(@"the result should be (\d+)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}