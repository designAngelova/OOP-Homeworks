package onelevshopapp;

import java.math.BigDecimal;
import java.math.RoundingMode;

public abstract class Product implements Buyable {
	protected String name;
	protected BigDecimal price;
	protected int quantity;
	protected AgeRestriction ageRestrictionLevel;
	
	public Product(String name, double price, int quantity,
			AgeRestriction ageRestrictionLevel) {
		super();
		this.setName(name);
		this.setPrice(new BigDecimal(price));
		this.setQuantity(quantity);
		this.ageRestrictionLevel = ageRestrictionLevel;
	}
	
	@Override
	public String toString() {
		return "Name: " + name +
				"\nPrice: " + price.setScale(2, RoundingMode.FLOOR) +
				"\nQuantity: " + quantity +
				"\nAge Restriction Level: " + ageRestrictionLevel + "\n";
	}

	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		if (name.isEmpty() || name == null) {
			throw new IllegalArgumentException("product name cannot be empty or null");
		}
		
		this.name = name;
	}
	
	public BigDecimal getPrice() {
		return price;
	}
	
	public void setPrice(BigDecimal price) {
		if (price.compareTo(new BigDecimal(0.0)) == -1) {
			throw new IllegalArgumentException("price cannot be negative");
		}
		
		this.price = price;
	}
	
	public int getQuantity() {
		return quantity;
	}
	
	public void setQuantity(int quantity) {
		if (quantity < 0) {
			throw new IllegalArgumentException("quantity cannot be negative");
		}
		
		this.quantity = quantity;
	}
	
	public AgeRestriction getAgeRestrictionLevel() {
		return ageRestrictionLevel;
	}
	
	public void setAgeRestrictionLevel(AgeRestriction ageRestrictionLevel) {
		this.ageRestrictionLevel = ageRestrictionLevel;
	}
}
