import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

public class Snake{
	LinkedList<Point> snakeBody = new LinkedList<Point>();
	private Color snakeColor;
	int velocityX, velocityY;
	
	public Snake() {
		snakeColor = Color.GREEN;
		snakeBody.add(new Point(300, 100)); 
		snakeBody.add(new Point(280, 100)); 
		snakeBody.add(new Point(260, 100)); 
		snakeBody.add(new Point(240, 100)); 
		snakeBody.add(new Point(220, 100)); 
		snakeBody.add(new Point(200, 100)); 
		snakeBody.add(new Point(180, 100));
		snakeBody.add(new Point(160, 100));
		snakeBody.add(new Point(140, 100));
		snakeBody.add(new Point(120, 100));

		velocityX = 20;
		velocityY = 0;
	}
	
	public void drawSnake(Graphics g) {		
		for (Point point : this.snakeBody) {
			point.drawPoint(g, snakeColor);
		}
	}
	
	public void tick() {
		Point newPoint = new Point((snakeBody.get(0).getX() + velocityX), (snakeBody.get(0).getY() + velocityY));
		
		if (newPoint.getX() > SnakeGameCanvas.WIDTH - 20) {
		 	SnakeGameCanvas.gameRunning = false;
		} else if (newPoint.getX() < 0) {
			SnakeGameCanvas.gameRunning = false;
		} else if (newPoint.getY() < 0) {
			SnakeGameCanvas.gameRunning = false;
		} else if (newPoint.getY() > SnakeGameCanvas.HEIGHT - 20) {
			SnakeGameCanvas.gameRunning = false;
		} else if (SnakeGameCanvas.apple.getPosition().equals(newPoint)) {
			snakeBody.add(SnakeGameCanvas.apple.getPosition());
			SnakeGameCanvas.apple = new Apple(this);
			SnakeGameCanvas.points += 50;
		} else if (snakeBody.contains(newPoint)) {
			SnakeGameCanvas.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = snakeBody.size()-1; i > 0; i--) {
			snakeBody.set(i, new Point(snakeBody.get(i-1)));
		}	
		snakeBody.set(0, newPoint);
	}

	public int getVelX() {
		return velocityX;
	}

	public void setVelX(int velX) {
		this.velocityX = velX;
	}

	public int getVelY() {
		return velocityY;
	}

	public void setVelY(int velY) {
		this.velocityY = velY;
	}
}
