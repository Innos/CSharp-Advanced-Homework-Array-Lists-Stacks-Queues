var Geometry2D = (function () {

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    var Point = (function (){
        function Point(x,y){
            this.X = x;
            this.Y = y;
        }

        Point.prototype.toString = function (){
            return "(" + this.X + ", " + this.Y + ")";
        };

        return Point;
    })();

    var Shape = (function (){
        function Shape(color){
            if(this.constructor === Shape){
                throw new Error("Cannot instantiate an abstract class.");
            }
            this.color = color;
        }

        Shape.prototype.toString = function(){
            return "Color: " + this.color;
        };

        return Shape;
    })();

    var Circle = (function (){
        function Circle(center,radius,color){
            Shape.call(this,color);
            this.center = center;
            this.radius = radius;
        }

        Circle.extends(Shape);

        Circle.prototype.toString = function(){
            var print = this.constructor.name + "\n"
                + Shape.prototype.toString.call(this)+ "\n"
                + "Center: " + this.center.toString.call(this.center) + "\n"
                + "Radius: " + this.radius;
            return print;
        };

        return Circle;
    })();

    var Rectangle = (function () {
        function Rectangle(startPoint,width,height,color){
            Shape.call(this,color);
            this.startPoint = startPoint;
            this.width = width;
            this.height = height;
        }

        Rectangle.extends(Shape);

        Rectangle.prototype.toString = function(){
            var print = this.constructor.name + "\n"
                + Shape.prototype.toString.call(this)+ "\n"
                + "Start Point: " + this.startPoint.toString.call(this.startPoint) + "\n"
                + "Width: " + this.width + "\n"
                + "Height: " + this.height;
            return print;
        };

        return Rectangle;
    })();

    var Segment = (function () {
        function Segment(a,b,color){
            Shape.call(this,color);
            this.A = a;
            this.B = b;
        }

        Segment.extends(Shape);

        Segment.prototype.toString = function(){
            var print = this.constructor.name + "\n"
                + Shape.prototype.toString.call(this) + "\n"
                + "A: " + this.A.toString.call(this.A) + "\n"
                + "B: " + this.B.toString.call(this.B);
            return print;
        };

        return Segment;
    })();

    var Line = (function(){
        function Line(a,b,color){
            Segment.call(this,a,b,color);
        }

        Line.extends(Segment);

        Line.prototype.toString = function(){
            return Segment.prototype.toString.call(this);
        };

        return Line;
    })();

    var Triangle = (function(){
        function Triangle(a,b,c,color){
            Segment.call(this,a,b,color);
            this.C = c;
        }

        Triangle.extends(Segment);

        Triangle.prototype.toString = function(){
            var print = Segment.prototype.toString.call(this)+ "\n"
                + "C: " + this.C.toString.call(this.C);
            return print;
        };

        return Triangle;
    })();

    return{
        Point: Point,
        Segment: Segment,
        Line: Line,
        Triangle: Triangle,
        Circle: Circle,
        Rectangle: Rectangle
    }
})();

var a = new Geometry2D.Point(0,0);
var b = new Geometry2D.Point(10,10);
var c = new Geometry2D.Point(20,5);
var segment = new Geometry2D.Segment(a,b,"#FF00FF");
var line = new Geometry2D.Line(a,b,"#000000");
var triangle = new Geometry2D.Triangle(a,b,c,"#FF00FF");
var circle = new Geometry2D.Circle(a,15,"#FF00FF");
var rectangle = new Geometry2D.Rectangle(a,5,15,"#FF00FF");
console.log(a.toString());
console.log();
console.log(segment.toString());
console.log();
console.log(line.toString());
console.log();
console.log(triangle.toString());
console.log();
console.log(circle.toString());
console.log();
console.log(rectangle.toString());