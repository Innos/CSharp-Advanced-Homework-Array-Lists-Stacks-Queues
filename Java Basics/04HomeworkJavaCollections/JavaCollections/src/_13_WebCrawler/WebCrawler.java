package _13_WebCrawler;

import java.io.*;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

public class WebCrawler {

    private static int counter = 0;

    private final File DownloadDirectory;

    private static File crawledUrls;

    private final CopyOnWriteArrayList<String> visitedSites;

    private final HtmlParser htmlParser;

    public WebCrawler(){
        this.htmlParser = new HtmlParser();
        this.visitedSites = new CopyOnWriteArrayList<>();
        this.DownloadDirectory = new File("Html Files");
        crawledUrls = new File("crawled-urls.txt");
        if(crawledUrls.exists()){
            crawledUrls.delete();
            crawledUrls = new File("crawled-urls.txt");
        }
    }

    public void crawl(String url, int currentLevel, int maxLevel) {

        if(!DownloadDirectory.exists()){
            DownloadDirectory.mkdir();
        }

        //writing the url in the visited sites and the text file that keeps track of them
        this.visitedSites.add(url);
        try(PrintWriter writer = new PrintWriter(new FileOutputStream(crawledUrls,true))){
            writer.write(url + "\r\n");
        }catch (FileNotFoundException ex){
            System.out.println(ex.getMessage());
        }

        //download html
        String html;
        StringBuilder htmlSB = new StringBuilder();
        URL urlAddress;
        InputStream inputStream = null;
        BufferedReader br;
        String line;

        try {
            urlAddress = new URL(url);
            inputStream = urlAddress.openStream();  // throws an IOException
            br = new BufferedReader(new InputStreamReader(inputStream));

            while ((line = br.readLine()) != null) {
                htmlSB.append(line);
                htmlSB.append("\n");
            }
        } catch (MalformedURLException mue) {
        } catch (IOException ioe) {
        } finally {
            try {
                if (inputStream != null) inputStream.close();
            } catch (IOException ioe) {
            }
        }
        html = htmlSB.toString();

        //writing the html of every crawled site to an html file
        try(PrintWriter writer = new PrintWriter(new File(DownloadDirectory + "/" + counter++ + ".html"))){
            writer.write(html);
        }catch (FileNotFoundException ex){
        }

        if(currentLevel < maxLevel){
            List<String> anchors = this.htmlParser.parseAnchors(html);

            for (String anchor : anchors) {
                String adress = getRightAdress(url,anchor);
                if(!this.visitedSites.contains(adress)){
                    this.crawl(adress,currentLevel+1,maxLevel);
                }
            }
        }
    }

    private static String getRightAdress(String domainUrl, String subUrl){
        if(subUrl.startsWith("http")){
            return subUrl;
        }
        return String.format("%s/%s",domainUrl,subUrl);
    }

    private static String getName(String url)
    {
        int IndexOfSeperator = url.indexOf("/")+1;

        return url.substring(IndexOfSeperator + 1);
    }
}
