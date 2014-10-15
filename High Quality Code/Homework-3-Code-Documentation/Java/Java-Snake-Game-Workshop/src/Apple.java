import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;
/**
 * @author Valleri
 * class Apple represents an apple object in our game. If the snake eats it in grows. The class has it`s own 
 * mechanism for generating apple at random position
 */

public class Apple {
	public static Random randomnumberGenerator;
	private Point applePosition;
	private Color appleColor;
	
	public Apple(Snake snake) {
		applePosition = createApple(snake);
		appleColor = Color.RED;		
	}
	
	private Point createApple(Snake snake) {
		randomnumberGenerator = new Random();
		int x = randomnumberGenerator.nextInt(30) * 20; 
		int y = randomnumberGenerator.nextInt(30) * 20;
		
		for (Point snakePoint : snake.snakeBody) {
			if (x == snakePoint.getX() || y == snakePoint.getY()) {
				return createApple(snake);				
			}
		}
		
		return new Point(x, y);
	}
	
	public void drawApple(Graphics g){
		applePosition.drawPoint(g, appleColor);
	}	
	
	public Point getPosition(){
		return applePosition;
	}
}
