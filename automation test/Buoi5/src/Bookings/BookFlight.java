package Bookings;

import org.testng.annotations.AfterMethod;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

public class BookFlight {
	@BeforeTest
	public void Beforetesttestcase1() {
		System.out.println("It should be first!");
	}

	@AfterTest
	public void Aftertesttestcase1() {
		System.out.println("It should be last!");
	}
	
	@BeforeMethod
	public void BeforeMethodTestcase1() {
		System.out.println("This test will print before every test case"); 
	}
	
	@AfterMethod
	public void AfterMethodTestcase1() {
		System.out.println("This test will print after every test case"); 
	}
	
	@Test
	public void BookFlight_RoundTrip_TestCase1() {
		System.out.println("Test case 1");
	}

	@Test(dependsOnMethods={"BookFlight_RoundTrip_TestCase1"})
	public void BookFlight_RoundTrip_TestCase2() {
		System.out.println("Test case 2");
	}

	@Test
	public void BookFlight_OneWay_TestCase3() {
		System.out.println("Test case 3");
	}

	@Test
	public void BookFlight_OneWay_TestCase4() {
		System.out.println("Test case 4");
	}
}
