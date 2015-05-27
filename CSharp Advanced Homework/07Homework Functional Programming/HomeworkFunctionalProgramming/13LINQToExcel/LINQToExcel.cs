using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Xml;
using System.Drawing;
using OfficeOpenXml.Style;
using System.Text.RegularExpressions;

class LINQToExcel
{
    static void Main(string[] args)
    {
        //added 2 System libraries and 2 namespaces from the EPPlus library
        //paths
        string path = @"../../Students-data.txt";
        string file = @"../../Students.xlsx";
        //check if the file exists, if it does delete it and make a new one
        FileInfo newFile = new FileInfo(file);
        if (newFile.Exists)
        {
            newFile.Delete();
            newFile = new FileInfo(file);
        }

        string firstLine;
        //list to hold students
        List<Student> students = new List<Student>();
        //initialize a stream reader to read the .txt file
        using (var reader = new StreamReader(path))
        {
            //first line is seperate because it holds the category identifier (ex. ID, FirstName), not real results
            firstLine = reader.ReadLine();
            string information;
            while ((information = reader.ReadLine()) != null)
            {
                //split by a tabulation
                string[] tokens = Regex.Split(information, @"\t");

                //parse the split input from a single line (i.e. a single student's properties)
                int id = int.Parse(tokens[0]);
                string firstName = tokens[1];
                string lastName = tokens[2];
                string email = tokens[3];
                string gender = tokens[4];
                string studentType = tokens[5];
                int examResult = int.Parse(tokens[6]);
                int homeworksSent = int.Parse(tokens[7]);
                int homeworksEvaluated = int.Parse(tokens[8]);
                double teamworkScore = double.Parse(tokens[9]);
                int attendancesCount = int.Parse(tokens[10]);
                double bonus = double.Parse(tokens[11]);

                //create a new student object with the above properties and add him to the list
                students.Add(new Student(
                        id,
                        firstName,
                        lastName,
                        email,
                        gender,
                        studentType,
                        examResult,
                        homeworksSent,
                        homeworksEvaluated,
                        teamworkScore,
                        attendancesCount,
                        bonus));
            }

            //perform query on the list of students
            var onlineStudentsByResult = students.Where(student => student.StudentType == "Online").OrderByDescending(student => student.Result);

            //initialize the excel package from the EPPlus library
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                //initialize a worksheet class from the excelPackage
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Students");

                //split the first line holding the categories and add the Result category
                List<string> types = Regex.Split(firstLine, @"\t").ToList();
                types.Add("Result");

                //Write the categories to the first row in the Excel worksheet, also set the cell width in the same for cycle
                //Important to note that the class actually starts counting from 1 not from 0, thus the need for (i+1)
                for (int i = 0; i < types.Count; i++)
                {
                    worksheet.Cells[1, i+1].Value = types[i];
                    if (i == 3) worksheet.Column(i + 1).Width = 35;
                    else worksheet.Column(i + 1).Width = 15; 
                }
           
                int row = 2;
                //foreach loop to write the contents from the queried list of students, starting from row 2 because row 1 contains the categories
                foreach (var student in onlineStudentsByResult)
                {
                    int col = 1;
                    worksheet.Cells[row, col++].Value = student.ID;
                    worksheet.Cells[row, col++].Value = student.FirstName;
                    worksheet.Cells[row, col++].Value = student.LastName;
                    worksheet.Cells[row, col++].Value = student.Email;
                    worksheet.Cells[row, col++].Value = student.Gender;
                    worksheet.Cells[row, col++].Value = student.StudentType;
                    worksheet.Cells[row, col++].Value = student.ExamResult;
                    worksheet.Cells[row, col++].Value = student.HomeworkSent;
                    worksheet.Cells[row, col++].Value = student.HomeworkEvaluated;
                    worksheet.Cells[row, col++].Value = student.TeamworkScore;
                    worksheet.Cells[row, col++].Value = student.AttendancesCount;
                    worksheet.Cells[row, col++].Value = student.Bonus;
                    worksheet.Cells[row, col++].Value = student.Result;
                    row++;
                }
                //using a class from the EPPlus library to iterate through a range of cells and fill them with a specific color
                using (var range = worksheet.Cells[1, 1, 1, 13])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.DarkOliveGreen);
                    range.Style.Font.Color.SetColor(Color.White);
                }
                using (var range = worksheet.Cells[2, 13, onlineStudentsByResult.Count()+1, 13])
                {
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.OliveDrab);
                }
                //save the file
                package.Save();
            }
        }
    }
}

