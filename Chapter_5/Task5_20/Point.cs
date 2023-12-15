namespace Task5_20{
    public class Point{
        private double x; // the x of point
        private double y; // the y of point

        // constructor
        public Point(double x = 0, double y = 0){
            this.x = x;
            this.y = y;
        }
        public Point(Point copy){
            this.x = copy.x;
            this.Y = copy.y;
        }
        // getters and setters
        public double X{
            get {return this.x;}
            set {this.x = value;}
        }
         public double Y{
            get {return this.y;}
            set {this.y = value;}
        }

        public double Distance(Point other){
            return Math.Sqrt(Math.Pow((this.X - other.X), 2) + Math.Pow((this.Y - other.Y), 2));
        }
        // status of an object
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}