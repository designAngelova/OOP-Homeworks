import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
/**
 * @author Valleri
 * 
 * SnakeGameCanvas class is the "Canvas" on which we will draw the field, snake, apples, etc.
 * It holds the methods to draw all needed objects
 */
@SuppressWarnings("serial")
public class SnakeGameCanvas extends Canvas implements Runnable {
	public static Snake snake;
	public static Apple apple;
	static int points;
	
	private Graphics globalGraphics;
	private Thread runThread;
	public static final int WIDTH = 600;
	public static final int HEIGHT = 600;
	private final Dimension gameFieldDimension = new Dimension(WIDTH, HEIGHT);
	
	static boolean gameRunning = false;
	
	/**
	 * @param g A Graphics object
	 */
	public void paint(Graphics g){
		this.setPreferredSize(gameFieldDimension);
		globalGraphics = g.create();
		points = 0;
		
		if(runThread == null){
			runThread = new Thread(this);
			runThread.start();
			gameRunning = true;
		}
	}
	
	/**
	 * Main game loop - moves the snake and redraws canvas
	 */
	public void run(){
		while(gameRunning){
			snake.tick();
			render(globalGraphics);
			try {
				Thread.sleep(100);
			} catch (Exception e) {
				// TODO: handle exception here
			}
		}
	}
	
	/**
	 * Constructor
	 */
	public SnakeGameCanvas(){	
		snake = new Snake();
		apple = new Apple(snake);
	}
	
	/**
	 * Renders the grid, snake and apple, also displays score
	 * @param g Graphics object
	 */
	public void render(Graphics g){
		g.clearRect(0, 0, WIDTH, HEIGHT+25);
		g.drawRect(0, 0, WIDTH, HEIGHT);			
		snake.drawSnake(g);
		apple.drawApple(g);
		g.drawString("score= " + points, 10, HEIGHT + 25);		
	}
}

