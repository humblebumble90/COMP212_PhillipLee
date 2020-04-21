using System;
using System.Linq;
using System.Windows.Forms;

namespace Hyungseok_Lee_Sec004_Exercise01
{
    public partial class JoiningTableData : Form
    {
        public JoiningTableData()
        {
            InitializeComponent();
        }

        private void JoiningTableData_Load(object sender, EventArgs e)
        {
            // Entity Framework DbContext
            var dbcontext = new BooksExamples.BooksEntities();

            // get authors and ISBNs of each book they co-authored
            var authorsAndISBNs =
               from author in dbcontext.Authors
               from book in author.Titles
               orderby author.LastName, author.FirstName
               select new { author.FirstName, author.LastName, book.ISBN };

            // get authors and titles of each book they co-authored
            var authorsAndTitles1 =
               from book in dbcontext.Titles
               from author in book.Authors
               orderby book.Title1
               select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\n1. Get a list of all the titles and the authors who wrote them." +
                "\n Sort the results by title:");

            //1. Get a list of all the titles and the authors who wrote them. Sort the results by title.
            foreach (var element in authorsAndTitles1)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                   $"{element.LastName,-10} {element.Title1}");
            }

            //2. Get a list of all the titles and the authors who wrote them. 
            //Sort the results by title. Each title sort the authors alphabetically by last name, then first name.

            var authorsAndTitles2 =
   from book in dbcontext.Titles
   from author in book.Authors
   orderby book.Title1,author.LastName,author.FirstName
   select new { author.FirstName, author.LastName, book.Title1 };

            outputTextBox.AppendText("\r\n\r\n2. Get a list of all the titles and the authors who wrote them. " +
                "\nSort the results by title. Each title sort the authors alphabetically by last name, then first name.:\n");

            foreach (var element in authorsAndTitles2)
            {
                outputTextBox.AppendText($"\r\n\t{element.FirstName,-10} " +
                   $"{element.LastName,-10} {element.Title1}");
            }
            /*3. Get a list of all the authors grouped by title, sorted by title;
             * for a given title sort the author names alphabetically by last name then first name.*/

            var titlesByAuthor =
               from author in dbcontext.Authors
               orderby author.LastName, author.FirstName
               select new
               {
                   Name = author.FirstName + " " + author.LastName,
                   Titles =
                     from book in author.Titles
                     orderby book.Title1
                     select book.Title1
               };

            outputTextBox.AppendText("\r\n\r\n" +
                "3. Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names\n" +
                "alphabetically by last name then first name.");

            // display titles written by each author, grouped by author
            foreach (var author in titlesByAuthor)
            {
                // display author's name
                outputTextBox.AppendText($"\r\n\t{author.Name}:");

                // display titles written by that author
                foreach (var title in author.Titles)
                {
                    outputTextBox.AppendText($"\r\n\t\t{title}");
                }
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
