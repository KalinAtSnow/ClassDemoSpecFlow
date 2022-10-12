using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{

    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private int _resultm;


        //any number added is good
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }



        //any number multiplied is good
        [Given("the first number m is (.*)")]
        public void GivenTheFirstNumbermIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number m is (.*)")]
        public void GivenTheSecondNumbermIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _resultm = _calculator.Multiply();
        }

        [Then("the result m should be (.*)")]
        public void ThenTheResultmShouldBe(int result)
        {
            _resultm.Should().Be(result);
        }




        //if strings are there, they convert to zero
        [Given(@"the first string is a string '([^']*)'")]
        public void GivenTheFirstStringIsAString(string asdf)
        {
            _calculator.FirstNumber = 0;
        }

        [Given(@"the second string is '([^']*)'")]
        public void GivenTheSecondStringIs(string ghij)
        {
            _calculator.SecondNumber = 0;
        }
    }
}