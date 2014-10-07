import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class KeyEventHandler implements KeyListener{
	
	public KeyEventHandler(SnakeGameCanvas game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent e) {
		int keyCode = e.getKeyCode();
		
		if (keyCode == KeyEvent.VK_W || keyCode == KeyEvent.VK_UP) {
			if(SnakeGameCanvas.snake.getVelY() != 20){
				SnakeGameCanvas.snake.setVelX(0);
				SnakeGameCanvas.snake.setVelY(-20);
			}
		}
		if (keyCode == KeyEvent.VK_S || keyCode == KeyEvent.VK_DOWN) {
			if(SnakeGameCanvas.snake.getVelY() != -20){
				SnakeGameCanvas.snake.setVelX(0);
				SnakeGameCanvas.snake.setVelY(20);
			}
		}
		if (keyCode == KeyEvent.VK_D || keyCode == KeyEvent.VK_RIGHT) {
			if(SnakeGameCanvas.snake.getVelX() != -20){
			SnakeGameCanvas.snake.setVelX(20);
			SnakeGameCanvas.snake.setVelY(0);
			}
		}
		if (keyCode == KeyEvent.VK_A || keyCode == KeyEvent.VK_LEFT) {
			if(SnakeGameCanvas.snake.getVelX() != 20){
				SnakeGameCanvas.snake.setVelX(-20);
				SnakeGameCanvas.snake.setVelY(0);
			}
		}
		//Other controls
		if (keyCode == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
