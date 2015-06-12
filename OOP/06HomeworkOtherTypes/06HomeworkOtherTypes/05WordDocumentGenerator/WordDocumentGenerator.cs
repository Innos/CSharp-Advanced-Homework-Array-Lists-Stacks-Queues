using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Novacode;
using System.Drawing;
using Image = Novacode.Image;

namespace _05WordDocumentGenerator
{
    class WordDocumentGenerator
    {
        static void Main(string[] args)
        {
            string filePath = @"../../Document.docx";
            string imagePath = @"../../rpg-game.png";

            using (DocX doc = DocX.Create(filePath))
            {
                string headlineText = @"SoftUni OOP Game Contest";

                Paragraph headline = doc.InsertParagraph(headlineText);
                headline.Font(new FontFamily("Calibri"));
                headline.Bold();
                headline.FontSize(30);
                headline.Alignment = Alignment.center;

                Image img = doc.AddImage(imagePath);
                Paragraph picture = doc.InsertParagraph("", false);
                Picture p1 = img.CreatePicture(250, 600);
                picture.InsertPicture(p1);

                Paragraph paragraph = doc.InsertParagraph();
                paragraph.Font(FontFamily.GenericMonospace);
                paragraph.AppendLine();
                paragraph.FontSize(12);
                paragraph.Append("SoftUni is organizing a contest for the best ").Append("role playing game ").Bold()
                    .Append("from the OOP teamwork\n").Append("projects. The winning teams will receive a ")
                    .Append("grand prize").Bold().UnderlineStyle(UnderlineStyle.singleLine).Append("!\n")
                    .Append("The game should be:");


                var list = doc.AddList(listType: ListItemType.Bulleted);
                doc.AddListItem(list, "Properly structured and follow all good OOP practices", 1, ListItemType.Bulleted);
                doc.AddListItem(list, "Awesome", 1, ListItemType.Bulleted);
                doc.AddListItem(list, "..Very Awesome", 1, ListItemType.Bulleted);
                doc.InsertList(list);

                Table table = doc.AddTable(4, 3);
                table.Alignment = Alignment.center;
                table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Color(Color.White).Alignment = Alignment.center;
                table.Rows[0].Cells[0].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Color(Color.White).Alignment = Alignment.center;
                table.Rows[0].Cells[1].FillColor = Color.CornflowerBlue;
                table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Color(Color.White).Alignment = Alignment.center;
                table.Rows[0].Cells[2].FillColor = Color.CornflowerBlue;
                table.Rows[1].Cells[0].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[1].Cells[1].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[1].Cells[2].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[2].Cells[0].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[2].Cells[1].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[2].Cells[2].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[3].Cells[0].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[3].Cells[1].Paragraphs.First().Append("-").Alignment = Alignment.center;
                table.Rows[3].Cells[2].Paragraphs.First().Append("-").Alignment = Alignment.center;

                doc.InsertTable(table);

                Paragraph paragraph2 = doc.InsertParagraph();
                paragraph2.Alignment = Alignment.center;
                paragraph2.Font(FontFamily.GenericMonospace);
                paragraph2.AppendLine();
                paragraph2.FontSize(12);
                paragraph2.Append("The top 3 teams will receive a ").Append("SPECTACULAR").Bold().Append(" prize:\n")
                .Append("A HANDSHAKE FROM NAKOV")
                    .FontSize(20)
                    .Color(Color.DarkBlue)
                    .Bold()
                    .UnderlineStyle(UnderlineStyle.singleLine)
                    .UnderlineColor(Color.DarkBlue);



                doc.Save();

                Process.Start("WINWORD.EXE", filePath);
            }


        }
    }
}
