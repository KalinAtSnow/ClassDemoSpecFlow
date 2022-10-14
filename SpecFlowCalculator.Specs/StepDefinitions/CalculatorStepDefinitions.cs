using FluentAssertions;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{

    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;

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

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [Then("the result m should be (.*)")]
        public void ThenTheResultmShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
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

        [Given(@"the operation \+ is done with (.*)")]
        public void GivenTheOperationIsDoneWith(int value)
        {
            _calculator.SecondNumber = value;
            _result = _calculator.Add();
            _calculator.FirstNumber = _result;
        }

        [Given(@"the operation - is done with (.*)")]
        public void WhenTheOperation_IsDoneWith(int value)
        { 
            _calculator.SecondNumber = value;
            _result = _calculator.Subtract();
            _calculator.FirstNumber = _result;
        }

        [Given(@"the operation \* is done with (.*)")]
        public void WhenTheOperation__IsDoneWith(int value)
        {
            _calculator.SecondNumber = value;
            _result = _calculator.Multiply();
            _calculator.FirstNumber = _result;
        }

        [Given(@"the operation / is done with (.*)")]
        public void GivenTheOperation___IsDoneWith(int value)
        {
            _calculator.SecondNumber = value;
            _result = _calculator.Divide();
            _calculator.FirstNumber = _result;
        }
    }
}