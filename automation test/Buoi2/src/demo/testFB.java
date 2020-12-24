package demo;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.Select;

public class testFB {
	public static void main(String[] args) {
		try {
			WebDriver driver;
			System.setProperty("webdriver.chrome.driver",
					"F:\\Programing\\Repository\\CT24301\\automation test\\chromedriver.exe");
			driver = new ChromeDriver();
			driver.manage().deleteAllCookies();
			driver.manage().window().maximize();
			driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
			driver.manage().timeouts().pageLoadTimeout(30, TimeUnit.SECONDS);
			driver.get("http://fb.com");
			TimeUnit.SECONDS.sleep(3);
			//while (true) {
				// Click taoTaiKhoan button
				driver.findElement(By.cssSelector("[data-testid='open-registration-form-button']")).click();
				TimeUnit.SECONDS.sleep(1);

				// Fill Last name
				driver.findElement(By.name("lastname")).sendKeys("Test Selenium!");
				TimeUnit.SECONDS.sleep(1);

				// Select gender
				driver.findElement(By.name("sex")).click();
				TimeUnit.SECONDS.sleep(1);

				// Select day
				Select sel1 = new Select(driver.findElement(By.name("birthday_day")));
				sel1.selectByIndex(5);
				TimeUnit.SECONDS.sleep(1);

				// Select month
				Select sel2 = new Select(driver.findElement(By.name("birthday_month")));
				sel2.selectByIndex(3);
				TimeUnit.SECONDS.sleep(1);

				// Click dangKy
				driver.findElement(By.name("websubmit")).click();
				TimeUnit.SECONDS.sleep(1);

				// Close form
				driver.findElement(By.cssSelector("img[width='24'][height='24']")).click();
				TimeUnit.SECONDS.sleep(1);

				// Goto other page
				driver.findElement(By.cssSelector("#reg_pages_msg > a")).click();
				TimeUnit.SECONDS.sleep(1);

				// Go back
				driver.navigate().back();
				TimeUnit.SECONDS.sleep(1);
			
			// Quit
			driver.quit();
		} catch (Exception e) {
		}
		;
	}

}