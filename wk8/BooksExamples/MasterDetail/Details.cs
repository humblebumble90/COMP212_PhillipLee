// Fig. 22.37: Details.cs
// Using a DataGridView to display details based on a selection.
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MasterDetail
{
   public partial class Details : Form
   {
      public Details()
      {
         InitializeComponent();
      }

      // Entity Framework DbContext
      BooksExamples.BooksEntities dbcontext =
         new BooksExamples.BooksEntities();

      // initialize data sources when the Form is loaded
      private void Details_Load(object sender, EventArgs e)
      {
         // load Authors table ordered by LastName then FirstName
         dbcontext.Authors
            .OrderBy(author => author.LastName)
            .ThenBy(author => author.FirstName)
            .Load();

         // specify DataSource for authorBindingSource
         authorBindingSource.DataSource = dbcontext.Authors.Local;
      }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}

