package _13_WebCrawler;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;
import java.util.Scanner;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class WebCrawlerMain {
    private static final int MAX_LEVEL = 1;

    private static WebCrawler crawler;

    private static Path crawledUrls = Paths.get("crawled-urls.txt");

    private static BufferedWriter writer;

    private static final String source = "source.txt";

    //The crawler will create a crawled-urls.txt and a Html files folder (where it will download the html of every crawled site)
    public static void main(String[] args) {
        try {
            writer = Files.newBufferedWriter(crawledUrls,
                    StandardOpenOption.CREATE,
                    StandardOpenOption.WRITE,
                    StandardOpenOption.TRUNCATE_EXISTING);
        } catch (IOException ex) {
            System.out.println(ex.toString());
        }
        crawler = new WebCrawler(writer);
        ExecutorService executor = Executors.newFixedThreadPool(5);
        try (Scanner scanner = new Scanner(new File(source))) {

            while (true) {
                if (scanner.hasNextLine()) {
                    String url = scanner.nextLine();
                    executor.submit(() -> {
                        crawler.crawl(url, 0, MAX_LEVEL);
                        System.out.printf("%s has been crawled.\n", url);
                    });
                } else {
                    executor.shutdown();
                    try {
                        executor.awaitTermination(2, TimeUnit.MINUTES);
                        try {
                            writer.close();
                        } catch (IOException ex) {
                            System.out.println(ex.toString());
                        }
                        break;

                    } catch (InterruptedException ex) {
                        System.out.println(ex.toString());
                    }
                }

            }
        } catch (FileNotFoundException ex) {
            System.out.println(ex.toString());
        }
    }
}
