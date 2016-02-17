var Geometry2D = (function () {

    Object.prototype.extend = function (properties) {
        function f() {
        };
        f.prototype = Object.create(this);
        for (var prop in properties) {
            f.prototype[prop] = properties[prop];
        }
        f.prototype._super = this;
        return new f();
    };

    var Point = {
        init: function init(x, y) {
            this.X = x;
            this.Y = y;
            return this;
        },
        toString: function toString() {
            return "(" + this.X + ", " + this.Y + ")";
        }
    };

    var Shape = {
        init: function init(color) {
            this.color = color;
            return this;
        },
        toString: function toString() {
            return "Color: " + this.color;
        }
    };

    var Circle = Shape.extend({
        init: function init(center, radius, color) {
            this._super.init(color);
            this.center = center;
            this.radius = radius;
            return this;
        },
        toString: function toString() {
            var print = "Circle" + "\n"
                + this._super.toString() + "\n"
                + "Center: " + this.center.toString.call(this.center) + "\n"
                + "Radius: " + this.radius;
            return print;
        }
    });

    var Rectangle = Shape.extend({
        init: function init(startPoint, width, height, color) {
            this._super.init(color);
            this.startPoint = startPoint;
            this.width = width;
            this.height = height;
            return this;
        },
        toString: function toString() {
            var print = "Rectangle" + "\n"
                + this._super.toString() + "\n"
                + "Start Point: " + this.startPoint.toString.call(this.startPoint) + "\n"
                + "Width: " + this.width + "\n"
                + "Height: " + this.height;
            return print;
        }
    });


    var Segment = Shape.extend({
        init: function init(a, b, color) {
            this._super.init(color);
            this.A = a;
            this.B = b;
            return this;
        },
        toString: function toString() {
            var print = "Segment" +"\n"
                + this._super.toString() + "\n"
                + "A: " + this.A.toString.call(this.A) + "\n"
                + "B: " + this.B.toString.call(this.B);
            return print;
        }
    });

    var Line = Segment.extend({
        init: function init(a, b, color) {
            this._super.init(a, b, color);
            return this;
        },
        toString: function toString() {

            return "Line" +"\n" + this._super.toString();
        }
    });

    var Triangle = Segment.extend({
       init: function init(a,b,c,color){
           this._super.init(a,b,color);
           this.C = c;
           return this;
       },
        toString: function toString(){
            var print = "Triangle" +"\n" + this._super.toString() + "\n"
                + "C: " + this.C.toString.call(this.C);
            return print;
        }
    });

    return {
        Point: Point,
        Segment: Segment,
        Line: Line,
        Triangle: Triangle,
        Circle: Circle,
        Rectangle: Rectangle
    }
})();

// couldn't figure out a good way to overwrite names, prototypal inheritance is pretty limited in some ways
var a = Object.create(Geometry2D.Point).init(0, 0);
var b = Object.create(Geometry2D.Point).init(10, 10);
var c = Object.create(Geometry2D.Point).init(20, 5);
var segment = Object.create(Geometry2D.Segment).init(a, b, "#FF00FF");
var line = Object.create(Geometry2D.Line).init(a, b, "#000000");
var triangle = Object.create(Geometry2D.Triangle).init(a, b, c, "#FF00FF");
var circle = Object.create(Geometry2D.Circle).init(a, 15, "#FF00FF");
var rectangle = Object.create(Geometry2D.Rectangle).init(a, 5, 15, "#FF00FF");
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