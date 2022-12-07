 namespace CommandPattern {
     public class MarsRover {
         public int _x;
         public int _y;
        public char _direction;
        public readonly string _availableDirections = "NESW";
        public readonly string[] _obstacles;
        public bool _obstacleFound;
        private readonly ObstacleHandler obstacleHandler;
        private readonly DirectionHandler directionHandler;

        public MarsRover(int x, int y, char direction, string[] obstacles) {
            _x = x;
            _y = y;
            _direction = direction;
            _obstacles = obstacles;
            obstacleHandler = new ObstacleHandler(this);
            directionHandler = new DirectionHandler(this);
        }

        public string GetState() {
            return !_obstacleFound ? $"{_x}:{_y}:{_direction}" : $"O:{_x}:{_y}:{_direction}";
        }

        public void Execute(string commands) {
            foreach (char command in commands) {
                if (command == 'M') {
                    obstacleHandler.CheckObstacles();
                }
                else if (command == 'L') {
                    // get new direction
                    directionHandler.SetNewDirection();
                }
                else if (command == 'R') {
                    // get new direction
                    directionHandler.SetAnotherNewDirection();
                }
            }
        }
     }
}