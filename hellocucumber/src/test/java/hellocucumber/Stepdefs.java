package hellocucumber;

import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;


public class Stepdefs {

    WebDriver driver;

    @Given("Chrome is started")
    public void chrome_is_started() {
        System.out.println("Do something");
        driver = new ChromeDriver();


    }

    @Given("Chrome is maximized")
    public void chrome_is_maximized() {
        driver.manage().window().maximize();
    }

    @Given("Gmail is opened")
    public void gmail_is_opened() {
        String baseUrl = "https://login.one.com/mail";
        driver.get(baseUrl);

    }


    @When("I enter my username")
    public void i_enter_my_username() {
        driver.findElement(By.name("displayUsername")).sendKeys("automated@gabriel-balzer.de");
    }

    @When("I enter my password")
    public void i_enter_my_password() {
        driver.findElement(By.name("password")).sendKeys("v40t7DC1LymubS96SYVP");
    }

    @When("I click login")
    public void i_click_login() {
        driver.findElement(By.name("password")).submit();
    }

    @Then("the page title should start with {string}")
    public void the_page_title_should_start_with(String titleStartsWith) {
        driver.getTitle().contains("Webmail");
    }


}
//C:\Maven\apache-maven-3.6.2\bin\mvn test