using InternTestTask.Models;

namespace InternTestTask
{
    public class PointCreator
    {
        public List<Point> points = new List<Point>();
        public PointCreator() 
        {
            /*var Point1 = new Point
            {
                X = 25,
                Y = 50,
                Radius = 10,
                Colour = "grey"
            };
            var Point2 = new Point
            {
                X = 300,
                Y = 200,
                Radius = 30,
                Colour = "red"
            };*/
            points = new List<Point> {
                new Point
            {
                X = 25,
                Y = 50,
                Radius = 10,
                Colour = "grey"
            },
                new Point
                {
                X = 300,
                Y = 200,
                Radius = 30,
                Colour = "red"
                }
            };
        }
    }
}
