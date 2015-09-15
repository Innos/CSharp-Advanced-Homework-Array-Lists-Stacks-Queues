package _13_WebCrawler;

import com.sun.jmx.snmp.tasks.Task;

import java.io.*;
import java.net.MalformedURLException;
import java.net.URL;
import java.nio.file.*;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class WebCrawler {

    private static int counter = 0;

    private final File DownloadDirectory;

    private static BufferedWriter writer;

    private final CopyOnWriteArrayList<String> visitedSites;

    private final HtmlParser htmlParser;

    public WebCrawler(BufferedWriter bufferedWriter) {
        this.htmlParser = new HtmlParser();
        this.visitedSites = new CopyOnWriteArrayList<>();
        this.DownloadDirectory = new File("Html Files");
        if (!DownloadDirectory.exists()) {
            DownloadDirectory.mkdir();
        }
        writer = bufferedWriter;
    }

    public void crawl(String url, int currentLevel, int maxLevel) {

        //writing the url in the visited sites and the text file that keeps track of them
        this.visitedSites.add(url);
        try {
            writer.write(url + "\r\n");
            writer.flush();
        } catch (IOException ex) {
            System.out.println(ex.toString());
        }

        //download html
        StringBuilder htmlSB = new StringBuilder();
        InputStream inputStream = null;

        try {
            URL urlAddress = new URL(url);
            inputStream = urlAddress.openStream();  // throws an IOException
            BufferedReader br = new BufferedReader(new InputStreamReader(inputStream));
            String line;
            while ((line = br.readLine()) != null) {
                htmlSB.append(line);
                htmlSB.append("\n");
            }
        } catch (MalformedURLException mue) {
            System.out.println(mue.toString());
        } catch (IOException ioe) {
            System.out.println(ioe.toString());
        } finally {
            try {
                if (inputStream != null) inputStream.close();
            } catch (IOException ioe) {
                System.out.println(ioe.toString());
            }
        }
        String html = htmlSB.toString();

        //writing the html of every crawled site to an html file
        try (PrintWriter writer = new PrintWriter(new File(DownloadDirectory + "/" + counter++ + ".html"))) {
            writer.write(html);
        } catch (FileNotFoundException ex) {
            System.out.println(ex.toString());
        }

        if (currentLevel < maxLevel) {
            List<String> anchors = this.htmlParser.parseAnchors(html);

            ExecutorService executor = Executors.newFixedThreadPool(10);
            for (String anchor : anchors) {
                executor.submit(() -> {
                    String adress = getRightAdress(url, anchor);
                    if (!this.visitedSites.contains(adress)) {
                        this.crawl(adress, currentLevel + 1, maxLevel);
                    }
                });
            }
            executor.shutdown();
            try {
                executor.awaitTermination(2, TimeUnit.MINUTES);
            } catch (InterruptedException ex) {
                System.out.println(ex.toString());
                ;
            }

        }
    }

    private static String getRightAdress(String domainUrl, String subUrl) {
        if (subUrl.startsWith("http")) {
            return subUrl;
        }
        return String.format("%s/%s", domainUrl, subUrl);
    }

    private static String getName(String url) {
        int IndexOfSeperator = url.indexOf("/") + 1;

        return url.substring(IndexOfSeperator + 1);
    }
}
