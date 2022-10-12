using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{

    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the first number m is (.*)")]
        public void GivenTheFirstNumbermIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }
        
        [Given("the second number m is (.*)")]
        public void GivenTheSecondNumbermIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        private int _result;
        private int _resultm;

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _resultm = _calculator.Multiply();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then("the result m should be (.*)")]
        public void ThenTheResultmShouldBe(int result)
        {
            _resultm.Should().Be(result);
        }
    }
}