using Behavioral.Automation.Configs;
using Behavioral.Automation.Playwright.Configs;
using Behavioral.Automation.Playwright.ElementSelectors;

namespace Behavioral.Automation.Playwright.Pages;

class MainPage : ISelectorStorage
{
    private static readonly string Id = ConfigManager.GetConfig<Config>().SearchAttribute;
    
    //Login
    public ElementSelector Username = new() { IdSelector = "username"};
    public ElementSelector Password = new() { IdSelector = "password"};
    public ElementSelector LoginButton = new() { IdSelector = "login-button"};
    
    //Items
    public ElementSelector AddBackpackToCart = new() { IdSelector = "add-to-cart-sauce-labs-backpack" };
    public ElementSelector Items = new() { Selector = "//div[@class='inventory_list']/child::*" };


    //ShoppingCart
    public ElementSelector ShoppingCartBadge = new() { Selector = "//span[@class='shopping_cart_badge']"};
    public ElementSelector ShoppingCartLink = new() { Selector = "//a[@class='shopping_cart_link']" };

    //Checkout
    public ElementSelector Checkout = new() { IdSelector = "checkout" };
    public ElementSelector FirstName = new() { IdSelector = "firstName" };
    public ElementSelector LastName = new() { IdSelector = "lastName" };
    public ElementSelector PostalCode = new() { IdSelector = "postalCode" };
    public ElementSelector ContinueButton = new() { IdSelector = "continue" };
    public ElementSelector FinishButton = new() { IdSelector = "finish" };
    public ElementSelector Title = new() { Selector = "//span[@class='title']" };

}
