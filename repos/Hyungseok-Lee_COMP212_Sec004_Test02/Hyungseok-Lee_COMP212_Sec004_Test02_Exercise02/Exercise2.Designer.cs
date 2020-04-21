namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise02
{
    partial class Exercise2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label battingAverageLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label playerIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise2));
            System.Windows.Forms.Label lb_Find_LastName;
            this.playerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.battingAverageTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_BrowseAll = new System.Windows.Forms.Button();
            this.txtBx_Find_LastName = new System.Windows.Forms.TextBox();
            this.btn_Find_LastName = new System.Windows.Forms.Button();
            this.lb_ID = new System.Windows.Forms.Label();
            this.txtBx_ID = new System.Windows.Forms.TextBox();
            this.btn_BattingAvg = new System.Windows.Forms.Button();
            this.lb_BattingAvgOfAll = new System.Windows.Forms.Label();
            this.lb_BattingAvgOfAll_Value = new System.Windows.Forms.Label();
            this.lb_HighestScorePlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_HighestScorerName = new System.Windows.Forms.Label();
            this.btn_HighestScorer = new System.Windows.Forms.Button();
            battingAverageLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            playerIDLabel = new System.Windows.Forms.Label();
            lb_Find_LastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).BeginInit();
            this.playerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // battingAverageLabel
            // 
            battingAverageLabel.AutoSize = true;
            battingAverageLabel.Location = new System.Drawing.Point(15, 39);
            battingAverageLabel.Name = "battingAverageLabel";
            battingAverageLabel.Size = new System.Drawing.Size(115, 15);
            battingAverageLabel.TabIndex = 1;
            battingAverageLabel.Text = "Batting Average:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(15, 70);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(15, 101);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(81, 15);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // playerIDLabel
            // 
            playerIDLabel.AutoSize = true;
            playerIDLabel.Location = new System.Drawing.Point(15, 132);
            playerIDLabel.Name = "playerIDLabel";
            playerIDLabel.Size = new System.Drawing.Size(71, 15);
            playerIDLabel.TabIndex = 7;
            playerIDLabel.Text = "Player ID:";
            // 
            // playerBindingNavigator
            // 
            this.playerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playerBindingNavigator.BindingSource = this.playerBindingSource;
            this.playerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.playerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.playerBindingNavigatorSaveItem});
            this.playerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playerBindingNavigator.Name = "playerBindingNavigator";
            this.playerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playerBindingNavigator.Size = new System.Drawing.Size(1080, 27);
            this.playerBindingNavigator.TabIndex = 0;
            this.playerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(BaseballDb.Player);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // playerBindingNavigatorSaveItem
            // 
            this.playerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playerBindingNavigatorSaveItem.Enabled = false;
            this.playerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playerBindingNavigatorSaveItem.Image")));
            this.playerBindingNavigatorSaveItem.Name = "playerBindingNavigatorSaveItem";
            this.playerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.playerBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // battingAverageTextBox
            // 
            this.battingAverageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "BattingAverage", true));
            this.battingAverageTextBox.Location = new System.Drawing.Point(136, 36);
            this.battingAverageTextBox.Name = "battingAverageTextBox";
            this.battingAverageTextBox.Size = new System.Drawing.Size(100, 25);
            this.battingAverageTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(136, 67);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(136, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "PlayerID", true));
            this.playerIDTextBox.Location = new System.Drawing.Point(136, 129);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.playerIDTextBox.TabIndex = 8;
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(355, 36);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.RowHeadersWidth = 51;
            this.playerDataGridView.RowTemplate.Height = 27;
            this.playerDataGridView.Size = new System.Drawing.Size(553, 359);
            this.playerDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
            this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // btn_BrowseAll
            // 
            this.btn_BrowseAll.Location = new System.Drawing.Point(17, 247);
            this.btn_BrowseAll.Name = "btn_BrowseAll";
            this.btn_BrowseAll.Size = new System.Drawing.Size(88, 23);
            this.btn_BrowseAll.TabIndex = 19;
            this.btn_BrowseAll.Text = "Browse All";
            this.btn_BrowseAll.UseVisualStyleBackColor = true;
            this.btn_BrowseAll.Click += new System.EventHandler(this.btn_BrowseAll_Click);
            // 
            // txtBx_Find_LastName
            // 
            this.txtBx_Find_LastName.Location = new System.Drawing.Point(137, 212);
            this.txtBx_Find_LastName.Name = "txtBx_Find_LastName";
            this.txtBx_Find_LastName.Size = new System.Drawing.Size(75, 25);
            this.txtBx_Find_LastName.TabIndex = 18;
            // 
            // btn_Find_LastName
            // 
            this.btn_Find_LastName.Location = new System.Drawing.Point(137, 247);
            this.btn_Find_LastName.Name = "btn_Find_LastName";
            this.btn_Find_LastName.Size = new System.Drawing.Size(75, 23);
            this.btn_Find_LastName.TabIndex = 17;
            this.btn_Find_LastName.Text = "Find";
            this.btn_Find_LastName.UseVisualStyleBackColor = true;
            this.btn_Find_LastName.Click += new System.EventHandler(this.btn_Find_LastName_Click);
            // 
            // lb_Find_LastName
            // 
            lb_Find_LastName.AutoSize = true;
            lb_Find_LastName.Location = new System.Drawing.Point(15, 212);
            lb_Find_LastName.Name = "lb_Find_LastName";
            lb_Find_LastName.Size = new System.Drawing.Size(81, 15);
            lb_Find_LastName.TabIndex = 16;
            lb_Find_LastName.Text = "Last Name:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(14, 173);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(25, 15);
            this.lb_ID.TabIndex = 20;
            this.lb_ID.Text = "ID:";
            // 
            // txtBx_ID
            // 
            this.txtBx_ID.Location = new System.Drawing.Point(137, 173);
            this.txtBx_ID.Name = "txtBx_ID";
            this.txtBx_ID.Size = new System.Drawing.Size(75, 25);
            this.txtBx_ID.TabIndex = 21;
            // 
            // btn_BattingAvg
            // 
            this.btn_BattingAvg.Location = new System.Drawing.Point(17, 372);
            this.btn_BattingAvg.Name = "btn_BattingAvg";
            this.btn_BattingAvg.Size = new System.Drawing.Size(120, 23);
            this.btn_BattingAvg.TabIndex = 22;
            this.btn_BattingAvg.Text = "Batting Average";
            this.btn_BattingAvg.UseVisualStyleBackColor = true;
            this.btn_BattingAvg.Click += new System.EventHandler(this.btn_BattingAvg_Click);
            // 
            // lb_BattingAvgOfAll
            // 
            this.lb_BattingAvgOfAll.AutoSize = true;
            this.lb_BattingAvgOfAll.Location = new System.Drawing.Point(14, 294);
            this.lb_BattingAvgOfAll.Name = "lb_BattingAvgOfAll";
            this.lb_BattingAvgOfAll.Size = new System.Drawing.Size(204, 15);
            this.lb_BattingAvgOfAll.TabIndex = 23;
            this.lb_BattingAvgOfAll.Text = "Batting Average of all players:";
            // 
            // lb_BattingAvgOfAll_Value
            // 
            this.lb_BattingAvgOfAll_Value.AutoSize = true;
            this.lb_BattingAvgOfAll_Value.Location = new System.Drawing.Point(219, 294);
            this.lb_BattingAvgOfAll_Value.Name = "lb_BattingAvgOfAll_Value";
            this.lb_BattingAvgOfAll_Value.Size = new System.Drawing.Size(0, 15);
            this.lb_BattingAvgOfAll_Value.TabIndex = 24;
            // 
            // lb_HighestScorePlayer
            // 
            this.lb_HighestScorePlayer.AutoSize = true;
            this.lb_HighestScorePlayer.Location = new System.Drawing.Point(110, 320);
            this.lb_HighestScorePlayer.Name = "lb_HighestScorePlayer";
            this.lb_HighestScorePlayer.Size = new System.Drawing.Size(109, 15);
            this.lb_HighestScorePlayer.TabIndex = 25;
            this.lb_HighestScorePlayer.Text = "Highest Scorer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 26;
            // 
            // lb_HighestScorerName
            // 
            this.lb_HighestScorerName.AutoSize = true;
            this.lb_HighestScorerName.Location = new System.Drawing.Point(225, 320);
            this.lb_HighestScorerName.Name = "lb_HighestScorerName";
            this.lb_HighestScorerName.Size = new System.Drawing.Size(0, 15);
            this.lb_HighestScorerName.TabIndex = 27;
            // 
            // btn_HighestScorer
            // 
            this.btn_HighestScorer.Location = new System.Drawing.Point(167, 371);
            this.btn_HighestScorer.Name = "btn_HighestScorer";
            this.btn_HighestScorer.Size = new System.Drawing.Size(123, 23);
            this.btn_HighestScorer.TabIndex = 28;
            this.btn_HighestScorer.Text = "Highest Scorer";
            this.btn_HighestScorer.UseVisualStyleBackColor = true;
            this.btn_HighestScorer.Click += new System.EventHandler(this.btn_HighestScorer_Click);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.btn_HighestScorer);
            this.Controls.Add(this.lb_HighestScorerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_HighestScorePlayer);
            this.Controls.Add(this.lb_BattingAvgOfAll_Value);
            this.Controls.Add(this.lb_BattingAvgOfAll);
            this.Controls.Add(this.btn_BattingAvg);
            this.Controls.Add(this.txtBx_ID);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.btn_BrowseAll);
            this.Controls.Add(this.txtBx_Find_LastName);
            this.Controls.Add(this.btn_Find_LastName);
            this.Controls.Add(lb_Find_LastName);
            this.Controls.Add(this.playerDataGridView);
            this.Controls.Add(battingAverageLabel);
            this.Controls.Add(this.battingAverageTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(playerIDLabel);
            this.Controls.Add(this.playerIDTextBox);
            this.Controls.Add(this.playerBindingNavigator);
            this.Name = "Exercise2";
            this.Text = "Exercise2";
            this.Load += new System.EventHandler(this.Exercise2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).EndInit();
            this.playerBindingNavigator.ResumeLayout(false);
            this.playerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingNavigator playerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton playerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox battingAverageTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btn_BrowseAll;
        private System.Windows.Forms.TextBox txtBx_Find_LastName;
        private System.Windows.Forms.Button btn_Find_LastName;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox txtBx_ID;
        private System.Windows.Forms.Button btn_BattingAvg;
        private System.Windows.Forms.Label lb_BattingAvgOfAll;
        private System.Windows.Forms.Label lb_BattingAvgOfAll_Value;
        private System.Windows.Forms.Label lb_HighestScorePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_HighestScorerName;
        private System.Windows.Forms.Button btn_HighestScorer;
    }
}

