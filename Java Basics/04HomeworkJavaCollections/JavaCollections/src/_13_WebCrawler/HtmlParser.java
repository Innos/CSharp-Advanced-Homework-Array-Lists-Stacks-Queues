package _13_WebCrawler;

import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class HtmlParser {

    private final Pattern anchorPattern;

    public HtmlParser() {
        anchorPattern = Pattern.compile("<a.+?href=\"(.*?)\".*?>");
    }

    public List<String> parseAnchors(String html) {
        Matcher anchorMatcher = this.anchorPattern.matcher(html);
        ArrayList<String> anchors = new ArrayList<>();

        while (anchorMatcher.find()) {
            anchors.add(anchorMatcher.group(1));
        }

        return anchors;
    }
}
