namespace TestingAssignment01.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.fNum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.sNum = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calculator.Add();
        }

     
        //sub
        [When("the two numbers are subrt")]
        public void WhenTheTwoNumbersAreSubrt()
        {
            result = calculator.Sub();
        }
        //multi
        [When("the two numbers are multi")]
        public void WhenTheTwoNumbersAreMulti()
        {
            result = calculator.Multi();
        }
        //Divid
        [When("the two numbers are divid")]
        public void WhenTheTwoNumbersAreDivid()
        {
            result = calculator.Div();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }


    }
}
