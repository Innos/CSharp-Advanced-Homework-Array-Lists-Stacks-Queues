package Excel;

import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.ss.usermodel.Sheet;
import org.apache.poi.ss.usermodel.Workbook;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.FileInputStream;
import java.io.IOException;
import java.math.BigDecimal;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Locale;
import java.util.stream.Collectors;

public class Excel {
    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        final String report = "src/main/java/5. Incomes-Report.xlsx";
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("d-MMM-yyyy");

        ArrayList<Office> offices = new ArrayList<Office>();

        try(FileInputStream fs = new FileInputStream(report)){

            Workbook wb = new XSSFWorkbook(fs);
            Sheet sheet = wb.getSheetAt(0);
            for (Row row : sheet) {
                if(row.getRowNum()== 0){
                    continue;
                }
                String name = row.getCell(0).toString();
                LocalDate date = LocalDate.parse(row.getCell(1).toString(), dtf);
                String description = row.getCell(2).toString();
                BigDecimal income = new BigDecimal(row.getCell(3).toString());

                Office office = offices.stream()
                        .filter(o->o.getName().equals(name))
                        .findFirst()
                        .orElse(null);
                if(office == null){
                    office = new Office(name,date,description,income);
                    offices.add(office);
                }else{
                    office.setIncome(office.getIncome().add(income));
                }
            }
            Collections.sort(offices);
            BigDecimal total = offices.stream().map(o->o.getTotalIncome()).reduce(BigDecimal.ZERO, BigDecimal::add);
            System.out.println(String.join("\n", offices.stream().map(o -> o.toString()).collect(Collectors.toList())));
            System.out.println(String.format("Grand Total -> %.2f",total));

        }catch (IOException ex){
            System.out.println(ex.getMessage());
        }

    }
}
