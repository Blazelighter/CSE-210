namespace ICE {
    public class Program
    {

        public static void Main(string[] args)
        {
            // create a list for holding robots
            List<Robot> robots = new List<Robot>();

            //  populate the list with new robots
            for (int i = 0; i < 5; i++)
            {
                Robot robot = new Robot();
                robots.Add(robot);
            }

            // loop through list and tell each instance to shoot
            foreach (Robot robot in robots)
            {
                robot.Shoot();
            }
        }
    }
}