// Fig. 22.22: DisplayAuthorsTable.cs
// Displaying data from a database table in a DataGridView.
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
   public partial class DisplayAuthorsTable : Form
   {
      // constructor
      public DisplayAuthorsTable()
      {
         InitializeComponent();
      }

      // Entity Framework DbContext                  
      private BooksExamples.BooksEntities dbcontext =
         new BooksExamples.BooksEntities();

      // load data from database into DataGridView
      private void DisplayAuthorsTable_Load(object sender, EventArgs e)
      {
         // load Authors table ordered by LastName then FirstName
         dbcontext.Authors
            .OrderBy(author => author.LastName)
            .ThenBy(author => author.FirstName)
            .Load();

         // specify DataSource for authorBindingSource
         authorBindingSource.DataSource = dbcontext.Authors.Local;
      }

      // click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void authorBindingNavigatorSaveItem_Click(
         object sender, EventArgs e)
      {
         Validate(); // validate the input fields                       
         authorBindingSource.EndEdit(); // complete current edit, if any

         // try to save changes
         try
         {
            dbcontext.SaveChanges(); // write changes to database file
         }
         catch (DbEntityValidationException)
         {
            MessageBox.Show("FirstName and LastName must contain values",
               "Entity Validation Exception");
         }
      }
   }
}

