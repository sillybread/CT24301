package com.basic;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
public class Buoi1 {
	WebDriver driver;
	JavascriptExecutor jse;
	public void invokeBrowser(){
		try {
			System.setProperty("webdriver.chrome.driver","F:\\Programing\\Repository\\CT24301\\automation test\\chromedriver.exe");
			driver = new ChromeDriver();
			driver.manage().deleteAllCookies();
			driver.manage().window().maximize();
			driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
			driver.manage().timeouts().pageLoadTimeout(30, TimeUnit.SECONDS);
			driver.get("http://www.edureka.co");
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public void searchCourse() {
		try {
			driver.findElement(By.className("open_search_overlay")).click();
			driver.findElement(By.className("new-search-inp")).sendKeys("Java");
			Thread.sleep(1000);
			driver.findElement(By.className("new-search-inp")).sendKeys(Keys.ENTER);

			jse = (JavascriptExecutor)driver;
			jse.executeScript("scroll(0, 2271)"); //execute a script
			driver.findElement(
				By.cssSelector(
					"[data-gi-action-hover='course hover - React with Redux Certification Training ']"
				)
			).click();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public void endSession() {
		try {
			Thread.sleep(3000);
			driver.quit();
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		Buoi1 myObj = new Buoi1();
		myObj.invokeBrowser();
		myObj.searchCourse();
		myObj.endSession();
	}

}