namespace CommandPattern;

public class DirectionHandler {
    private MarsRover marsRover;

    public DirectionHandler(MarsRover marsRover) {
        this.marsRover = marsRover;
    }

    public void SetAnotherNewDirection() {
        var currentDirectionPosition = marsRover._availableDirections.IndexOf(marsRover._direction);
        if (currentDirectionPosition != 3) {
            marsRover._direction = marsRover._availableDirections[currentDirectionPosition + 1];
        }
        else {
            marsRover._direction = marsRover._availableDirections[0];
        }
    }

    public void SetNewDirection() {
        var currentDirectionPosition = marsRover._availableDirections.IndexOf(marsRover._direction);
        if (currentDirectionPosition != 0) {
            marsRover._direction = marsRover._availableDirections[currentDirectionPosition - 1];
        }
        else {
            marsRover._direction = marsRover._availableDirections[3];
        }
    }
}