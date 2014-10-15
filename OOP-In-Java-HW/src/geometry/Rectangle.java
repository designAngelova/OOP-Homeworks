package geometry;

public class Rectangle extends PlaneShape {
	private double width;
	private double height;
	
	public Rectangle(double x, double y, double width, double height) {
		super(x, y);
		this.setWidth(width);
		this.setHeight(height);
	}
	
	@Override
	public double getArea() {
		return width * height;
	}

	@Override
	public double getPerimeter() {
		return (2 * width) + (2 * height);
	}
	
	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width < 0) {
			throw new IllegalArgumentException("width cannot be negative");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height < 0) {
			throw new IllegalArgumentException("height cannot be negative");
		}
		
		this.height = height;
	}
}
