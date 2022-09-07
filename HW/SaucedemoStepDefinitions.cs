using Behavioral.Automation.Playwright.WebElementsWrappers;
using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Behavioral.Automation.Demo
{
    [Binding]
    public class SaucedemoStepDefinitions
    {
        [Then(@"the ""(.+?)"" list should have ""(.+?)"" items")]
        public async Task ThenTheListShouldHaveItems(WebElementWrapper webElement, int q)
        {
            await Assertions.Expect(webElement.Locator).ToHaveCountAsync(q);
        }
    }
}
