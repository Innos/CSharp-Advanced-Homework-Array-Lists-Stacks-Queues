import com.itextpdf.text.*;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.FileOutputStream;
import java.io.IOException;

public class GeneratePDFByExternalLibrary {

    public static String[] cards = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};

    public static char[] suit = new char[] {'\u2665','\u2666','\u2663','\u2660'};

    public static String output = "DeckOfCards.pdf";

    public static void main(String[] args) {
        try {
            createPdf(output);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void createPdf(String filename)
            throws IOException, DocumentException {
        // step 1
        Document document = new Document();
        // step 2
        PdfWriter writer = PdfWriter.getInstance(document, new FileOutputStream(filename));
        // step 3
        document.open();
        // step 4
        addTables(document, writer);
        // step 5
        document.close();
    }

    private static void addTables(Document document, PdfWriter writer) throws DocumentException, IOException {
        for (int i = 0;i < cards.length;i++) {

            BaseFont bf = BaseFont.createFont("c:/windows/fonts/arialbd.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(bf,18);
            font.setColor(BaseColor.RED);

            for (int l = 0; l < suit.length; l++) {
                PdfPTable table = new PdfPTable(1);
                table.setTotalWidth(35f);
                table.setHorizontalAlignment(Element.ALIGN_LEFT);
                table.setLockedWidth(true);
                table.setSpacingAfter(10);

                if (l > 1) {
                    font.setColor(BaseColor.BLACK);
                }

                PdfPCell cell = new PdfPCell(new Phrase(cards[i] + suit[l], font));
                cell.setFixedHeight(50);
                cell.setHorizontalAlignment(Element.ALIGN_CENTER);
                cell.setVerticalAlignment(Element.ALIGN_MIDDLE);
                table.addCell(cell);

                switch (l)
                {
                    case 0:
                        table.writeSelectedRows(0,-1,document.left(),document.top()-i*60,writer.getDirectContent());
                        break;
                    case 1:
                        table.writeSelectedRows(0,-1,document.left()+150,document.top()-i*60,writer.getDirectContent());
                        break;
                    case 2:
                        table.writeSelectedRows(0,-1,document.left()+300,document.top()-i*60,writer.getDirectContent());
                        break;
                    case 3:
                        table.writeSelectedRows(0,-1,document.left()+450,document.top()-i*60,writer.getDirectContent());
                        break;
                }
            }
        }
    }
}
