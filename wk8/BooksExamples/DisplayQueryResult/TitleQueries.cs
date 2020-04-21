﻿// Fig. 22.26: TitleQueries.cs
// Displaying the result of a user-selected query in a DataGridView.
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DisplayQueryResult
{
   public partial class TitleQueries : Form
   {
      public TitleQueries()
      {
         InitializeComponent();
      }

      // Entity Framework DbContext
      private BooksExamples.BooksEntities dbcontext =
         new BooksExamples.BooksEntities();

      // load data from database into DataGridView
      private void TitleQueries_Load(object sender, EventArgs e)
      {
         dbcontext.Titles.Load(); // load Titles table into memory

         // set the ComboBox to show the default query that
         // selects all books from the Titles table
         queriesComboBox.SelectedIndex = 0;
      }

      // loads data into titleBindingSource based on user-selected query
      private void queriesComboBox_SelectedIndexChanged(
         object sender, EventArgs e)
      {
         // set the data displayed according to what is selected
         switch (queriesComboBox.SelectedIndex)
         {
            case 0: // all titles
               // use LINQ to order the books by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local.OrderBy(book => book.Title1);
               break;
            case 1: // titles with 2016 copyright
               // use LINQ to get titles with 2016
               // copyright and sort them by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local
                     .Where(book => book.Copyright == "2016")
                     .OrderBy(book => book.Title1);
               break;
            case 2: // titles ending with "How to Program"
               // use LINQ to get titles ending with
               // "How to Program" and sort them by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local
                     .Where(
                        book => book.Title1.EndsWith("How to Program"))
                     .OrderBy(book => book.Title1);
               break;
         }

         titleBindingSource.MoveFirst(); // move to first entry
      }

        private void titleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

