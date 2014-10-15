package onelevshopapp;

import java.math.RoundingMode;

import onelevshopapp.customexceptions.ProductManagementException;

public class Tester {
	
	public static void main(String[] args) {
		FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 2, AgeRestriction.Adult, "2014-20-10");
		Customer pecata = new Customer("Pecata", 18, 30.00);
		
		System.out.println(pecata.getBalance().setScale(2, RoundingMode.CEILING));
		System.out.println(cigars.getQuantity());
		
		try {
			PurchaseManager.ProcessPurchase(pecata, cigars);
		} catch (ProductManagementException e) {
			System.err.println(e.getMessage());
		}
		
		System.out.println(pecata.getBalance().setScale(2, RoundingMode.CEILING));
		System.out.println(cigars.getQuantity());
		
		Customer gopeto = new Customer("Gopeto", 18, 0.44);
		
		try {
			PurchaseManager.ProcessPurchase(gopeto, cigars);
		} catch (ProductManagementException e) {
			System.err.println(e.getMessage());
		}
	}
}
