import org.apache.hadoop.fs.Path;
import org.apache.hadoop.io.LongWritable;
import org.apache.hadoop.io.Text;
import org.apache.hadoop.mapreduce.Job;
import org.apache.hadoop.mapreduce.Mapper;
import org.apache.hadoop.mapreduce.Reducer;
import org.apache.hadoop.conf.Configuration;
import org.apache.hadoop.mapreduce.lib.input.FileInputFormat;
import org.apache.hadoop.mapreduce.lib.output.FileOutputFormat;

import java.io.IOException;

//if you're wondering I created a maven project and added the libraries from the apache hadoop repository
// though they're also available in the <hadoop default folder>\share\hadoop
// I used hadoop-common and hadoop-client libraries
public class RealEstateCount {
    public static class RealEstateMapper extends Mapper<Object,Text,Text, LongWritable>{

        private Text text = new Text();
        private LongWritable price = new LongWritable();

        public void map(Object offset, Text line,Context context)
                throws IOException,InterruptedException
        {
            if(((LongWritable)offset).get() == 0)
            {
                return;
            }
            String[] fields = line.toString().split(",");
            String city = fields[1];
            String type = fields[7];
            long currentPrice = Long.parseLong(fields[9]);
            text.set(city+" / "+type);
            price.set(currentPrice);
            context.write(text,price);
        }
    }

    public static class RealEstateReducer extends Reducer<Text,LongWritable,Text,LongWritable>
    {
        private LongWritable result = new LongWritable();

        public void reduce(Text city, Iterable<LongWritable> prices,Context context)
                throws IOException,InterruptedException
        {
            long sum = 0;
            for(LongWritable value: prices)
            {
                sum+= value.get();
            }
            result.set(sum);
            context.write(city,result);
        }
    }

    public static void main(String[] args) throws Exception {
        Configuration conf = new Configuration();
        Job job = Job.getInstance(conf, "realestate count");
        job.setJarByClass(RealEstateCount.class);
        job.setMapperClass(RealEstateMapper.class);
        job.setCombinerClass(RealEstateReducer.class);
        job.setReducerClass(RealEstateReducer.class);
        job.setOutputKeyClass(Text.class);
        job.setOutputValueClass(LongWritable.class);
        FileInputFormat.addInputPath(job, new Path(args[0]));
        FileOutputFormat.setOutputPath(job, new Path(args[1]));
        System.exit(job.waitForCompletion(true) ? 0 : 1);
    }
}
