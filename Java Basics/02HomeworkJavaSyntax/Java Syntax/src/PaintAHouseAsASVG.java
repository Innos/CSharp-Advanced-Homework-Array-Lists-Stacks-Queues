import org.apache.batik.dom.GenericDOMImplementation;
import org.apache.batik.svggen.SVGGraphics2D;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;

import java.awt.*;
import java.awt.geom.Path2D;
import java.io.FileWriter;
import java.io.Writer;
import java.util.Scanner;

public class PaintAHouseAsASVG {
    public static void main(String[] args) {
        DOMImplementation impl = GenericDOMImplementation.getDOMImplementation();

        String svgNS = "http://www.w3.org/2000/svg";
        Document document = impl.createDocument(svgNS, "svg", null);

        SVGGraphics2D svgGenerator = new SVGGraphics2D(document);
        svgGenerator.setSVGCanvasSize(new Dimension(680, 480));

        paint(svgGenerator);

        System.out.println("Input number of points followed by points:");
        Scanner scanner = new Scanner(System.in);
        int numberOfPoints = scanner.nextInt();

        for (int i = 0;i < numberOfPoints;i++){
            double x = scanner.nextDouble();
            double y = scanner.nextDouble();

            int a = (int)(45 + (x-10)*20);
            int b = (int)(40 + (y-3.5)*20);
            if(PointsInsideTheHouse.isOutsideHouse(x,y)){
                svgGenerator.setColor(Color.gray);
                svgGenerator.fillOval(a-4,b-4,8,8);

                svgGenerator.setColor(Color.black);
                svgGenerator.setStroke(new BasicStroke(1));
                svgGenerator.drawOval(a-4, b-4, 8, 8);
            } else {
                svgGenerator.setColor(Color.black);
                svgGenerator.fillOval(a-4,b-4,8,8);
            }
        }

        try{
            Writer out = new FileWriter("house.html");
            svgGenerator.stream(out, true);
        } catch (Exception ex){
        }

    }

    public static void paint(Graphics2D g2d) {

        Path2D.Double triangle = new Path2D.Double();
        triangle.moveTo(95, 140);
        triangle.lineTo(295, 140);
        triangle.lineTo(195, 40);
        triangle.closePath();
        Shape rect1 = new Rectangle(245,140,50,100);
        Shape rect2 = new Rectangle(95, 140, 100, 100);

        Color transparentGray = new Color(0.2f,0.2f,0.2f,0.5f);
        g2d.setPaint(transparentGray);
        g2d.fill(triangle);
        g2d.fill(rect1);
        g2d.fill(rect2);

        Color colorBorder = new Color(0, 0, 0.5f, 1f);
        g2d.setPaint(colorBorder);
        g2d.setStroke(new BasicStroke(2));

        g2d.draw(triangle);
        g2d.draw(rect1);
        g2d.draw(rect2);


        g2d.setPaint(Color.black);
        g2d.setFont(new Font("Arial", Font.BOLD, 14));
        g2d.drawString("10", 35, 15);
        g2d.drawString("12.5", 85, 15);
        g2d.drawString("15", 135, 15);
        g2d.drawString("17.5",185,15);
        g2d.drawString("20",235,15);
        g2d.drawString("22.5",285,15);


        g2d.drawString("3.5", 0, 45);
        g2d.drawString("6",0,95);
        g2d.drawString("8.5",0,145);
        g2d.drawString("11",0,195);
        g2d.drawString("13.5",0,245);
        g2d.drawString("16", 0, 295);

        float alpha = 0.2f;
        Color color = new Color(0, 0.2f, 1, alpha);
        g2d.setPaint(color);
        Stroke dashed = new BasicStroke(1, BasicStroke.CAP_BUTT, BasicStroke.CAP_ROUND, 0, new float[]{2}, 0);
        g2d.setStroke(dashed);

        g2d.drawLine(45, 25, 45, 325);
        g2d.drawLine(95,25,95,325);
        g2d.drawLine(145, 25, 145, 325);
        g2d.drawLine(195, 25, 195, 325);
        g2d.drawLine(245, 25, 245, 325);
        g2d.drawLine(295, 25, 295, 325);

        g2d.drawLine(35, 40, 310, 40);
        g2d.drawLine(35, 90, 310, 90);
        g2d.drawLine(35, 140, 310, 140);
        g2d.drawLine(35, 190, 310, 190);
        g2d.drawLine(35, 240, 310, 240);
        g2d.drawLine(35, 290, 310, 290);



    }
}
