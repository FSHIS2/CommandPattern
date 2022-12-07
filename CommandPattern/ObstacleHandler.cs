namespace CommandPattern;

public class ObstacleHandler : IExecute {
    private MarsRover marsRover;

    public ObstacleHandler(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void IExecute() {
        switch (marsRover._direction) {
            case 'E':
                marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x + 1}:{marsRover._y}");
                // check if rover reached plateau limit or found an obstacle
                marsRover._x = marsRover._x < 9 && !marsRover._obstacleFound ? marsRover._x += 1 : marsRover._x;
                break;
            case 'S':
                marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x}:{marsRover._y + 1}");
                // check if rover reached plateau limit or found an obstacle
                marsRover._y = marsRover._y < 9 && !marsRover._obstacleFound ? marsRover._y += 1 : marsRover._y;
                break;
            case 'W':
                marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x - 1}:{marsRover._y}");
                // check if rover reached plateau limit or found an obstacle
                marsRover._x = marsRover._x > 0 && !marsRover._obstacleFound ? marsRover._x -= 1 : marsRover._x;
                break;
            case 'N':
                marsRover._obstacleFound = marsRover._obstacles.Contains($"{marsRover._x}:{marsRover._y - 1}");
                // check if rover reached plateau limit or found an obstacle
                marsRover._y = marsRover._y > 0 && !marsRover._obstacleFound ? marsRover._y -= 1 : marsRover._y;
                break;
        }
    }
}