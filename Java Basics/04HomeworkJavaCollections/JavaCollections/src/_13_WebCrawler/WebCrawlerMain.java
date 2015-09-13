package _13_WebCrawler;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class WebCrawlerMain {

    private static WebCrawler crawler;

    private static final String source = "source.txt";

    //The crawler will create a crawled-urls.txt and a Html files folder (where it will download the html of every crawled site)
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

    //the crawler works, but will not print success messages for each site after crawling them as I can't find a way to
    // implement something akin to async/await from C#
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
