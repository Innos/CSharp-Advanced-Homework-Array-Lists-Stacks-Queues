package WebCrawler;

import com.sun.corba.se.impl.orbutil.closure.Future;

import java.io.Console;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class WebCrawlerMain {

    private static WebCrawler crawler;

    private static final String source = "source.txt";

    public static void main(String[] args) {

        crawler = new WebCrawler();
        try(Scanner scanner = new Scanner(new File(source));){
            while (true){
                if(scanner.hasNextLine()){
                    String url = scanner.nextLine();
                    runCrawl(url);
                }
            }
        }catch (FileNotFoundException ex){
            System.out.println(ex.getMessage());
        }
    }

    private static void runCrawl(String url){
        Thread crawl = new Thread(() -> {
            crawler.crawl(url,0,1);
        });
        crawl.start();
//        try{
//            crawl.join();
//        }catch (InterruptedException ex){
//        }
//
//        System.out.printf("%s has been crawled.\n", url);
    }
}
