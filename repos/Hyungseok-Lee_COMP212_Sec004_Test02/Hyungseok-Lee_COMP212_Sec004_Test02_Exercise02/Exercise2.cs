using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise02
{
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }
        private BaseballDb.BaseballEntities dbcontext =
        new BaseballDb.BaseballEntities();
        private void Exercise2_Load(object sender, EventArgs e)
        {
            dbcontext.Players
            .OrderBy(player => player.PlayerID)
            .ThenBy(player => player.LastName)
            .ThenBy(player => player.FirstName)
            .Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void btn_BrowseAll_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            refresh();
        }

        private void btn_Find_LastName_Click(object sender, EventArgs e)
        {
            if(txtBx_ID.Text.Length == 0 && txtBx_Find_LastName.Text.Length == 0)
            {
                MessageBox.Show("You must enter the ID or the last name of the player.");
            }
            else
            {
                var lastNameQuery =
                    from player in dbcontext.Players
                    where player.LastName.ToUpper() == txtBx_Find_LastName.Text.ToUpper() ||
                    player.PlayerID.ToString() == txtBx_ID.Text
                    orderby player.LastName
                    select player;
                playerBindingSource.DataSource = lastNameQuery.ToList();
                playerBindingSource.MoveFirst();
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }
        private void refresh()
        {
            if (dbcontext != null)
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

        private void btn_BattingAvg_Click(object sender, EventArgs e)
        {
            var battingAvgQuery =
                from player in dbcontext.Players
                select player.BattingAverage;
            lb_BattingAvgOfAll_Value.Text = battingAvgQuery.Average().ToString();
        }

        private void btn_HighestScorer_Click(object sender, EventArgs e)
        {
            var highestBattingAvg = dbcontext.Players.Select(x => x.BattingAverage).Max();
            var highestScorer =
                from player in dbcontext.Players
                where player.BattingAverage == highestBattingAvg
                select player;
           foreach(var player in highestScorer)
            {
                lb_HighestScorerName.Text = $"{player.FirstName} {player.LastName}";
            }
        }
    }
}
