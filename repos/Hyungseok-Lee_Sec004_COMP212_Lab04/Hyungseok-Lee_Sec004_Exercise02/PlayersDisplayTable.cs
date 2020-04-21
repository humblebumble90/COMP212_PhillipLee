using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Hyungseok_Lee_Sec004_Exercise02
{
    public partial class PlayersDisplayTable : Form
    {
        public PlayersDisplayTable()
        {
            InitializeComponent();
        }

        private BaseballDb.BaseballEntities dbcontext =
            new BaseballDb.BaseballEntities();
        private void PlayersDisplayTable_Load(object sender, EventArgs e)
        {
            dbcontext.Players
                .OrderBy(player => player.PlayerID)
                .ThenBy(player => player.LastName)
                .ThenBy(player => player.FirstName)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate(); // validate the input fields                       
            playerBindingSource.EndEdit(); // complete current edit, if any

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

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void playerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Find_LastName_Click(object sender, EventArgs e)
        {
            var lastNameQuery =
                from player in dbcontext.Players
                where player.LastName.ToUpper() == txtBx_Find_LastName.Text.ToUpper()
                orderby player.LastName
                select player;
            playerBindingSource.DataSource = lastNameQuery.ToList();
            playerBindingSource.MoveFirst();

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void btn_BrowseAll_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            refresh();
        }

        private void refresh()
        {
            if(dbcontext != null)
            {
                dbcontext.Dispose();
            }
            dbcontext =
            new BaseballDb.BaseballEntities();

            dbcontext.Players
            .OrderBy(player => player.PlayerID)
            .ThenBy(player => player.LastName)
            .ThenBy(player => player.FirstName)
            .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerBindingSource.MoveFirst();
            txtBx_Find_LastName.Clear();
        }
    }
}
