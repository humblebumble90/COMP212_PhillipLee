using BooksExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise01
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }
        // Entity Framework DbContext
        private BooksExample.BooksEntities dbcontext = new BooksExample.BooksEntities();
        private void Exercise1_Load(object sender, EventArgs e)
        {
            var ex1_a_query =
                from book in dbcontext.Titles
                orderby book.Title1
                select new {
                    Title = book.Title1,
                    Authors = book.Authors
                };
            var ex2_b_query =
                from author in dbcontext.Authors
                orderby author.FirstName,author.LastName
                select new
                {
                    Name = author.FirstName + "" + author.LastName,
                    Title = from title in author.Titles
                            orderby title.Title1
                            select title.Title1
                };
            queryTxtBx
                .AppendText("\r\n\ta.Get a count of all the authors grouped by title, sorted by title." +
                "\r\n\tIt should display a title and number of authors who have written that title.");
            queryTxtBx.AppendText("\r\n\t");
            foreach(var title in ex1_a_query)
            {
                queryTxtBx.AppendText($"\r\n\tBook title: {title.Title}");
                queryTxtBx.AppendText($"\r\n\tNum of authors: {title.Authors.Count()}");
                queryTxtBx.AppendText("\r\n\tAuthors of the book: ");
                foreach(var name in title.Authors)
                {
                    queryTxtBx.AppendText($"\r\n\t{name.FirstName} {name.LastName}");
                }
                queryTxtBx.AppendText("\r\n\t");
            }
            queryTxtBx
                .AppendText("\r\n\tb. Get a list of all the titles grouped by author name," +
                "\r\n\t sorted by author; for a given author name sort the titles alphabetically.");
            queryTxtBx.AppendText("\r\n\t");
            foreach (var author in ex2_b_query)
            {
                queryTxtBx.AppendText($"\r\n\tAuthor name: {author.Name}");
                if (author.Title.Count() == 0)
                {
                    queryTxtBx.AppendText("\r\n\tThe author hasn't written any book");
                }
                foreach (var title in author.Title)
                {
                    queryTxtBx.AppendText($"\r\n\tBook title: {title}");
                }
                queryTxtBx.AppendText("\r\n\t");
            }
        }
    }
}
