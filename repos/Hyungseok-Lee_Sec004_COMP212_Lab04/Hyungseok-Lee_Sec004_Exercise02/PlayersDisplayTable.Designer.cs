namespace Hyungseok_Lee_Sec004_Exercise02
{
    partial class PlayersDisplayTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersDisplayTable));
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Find_LastName = new System.Windows.Forms.Button();
            this.txtBx_Find_LastName = new System.Windows.Forms.TextBox();
            this.btn_BrowseAll = new System.Windows.Forms.Button();
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
            battingAverageLabel.Location = new System.Drawing.Point(12, 43);
            battingAverageLabel.Name = "battingAverageLabel";
            battingAverageLabel.Size = new System.Drawing.Size(115, 15);
            battingAverageLabel.TabIndex = 1;
            battingAverageLabel.Text = "Batting Average:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 74);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 105);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(81, 15);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // playerIDLabel
            // 
            playerIDLabel.AutoSize = true;
            playerIDLabel.Location = new System.Drawing.Point(12, 136);
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
            this.playerBindingNavigator.Size = new System.Drawing.Size(931, 27);
            this.playerBindingNavigator.TabIndex = 0;
            this.playerBindingNavigator.Text = "bindingNavigator1";
            this.playerBindingNavigator.RefreshItems += new System.EventHandler(this.playerBindingNavigator_RefreshItems);
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
            this.playerBindingNavigatorSaveItem.Click += new System.EventHandler(this.playerBindingNavigatorSaveItem_Click);
            // 
            // battingAverageTextBox
            // 
            this.battingAverageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "BattingAverage", true));
            this.battingAverageTextBox.Location = new System.Drawing.Point(133, 40);
            this.battingAverageTextBox.Name = "battingAverageTextBox";
            this.battingAverageTextBox.Size = new System.Drawing.Size(100, 25);
            this.battingAverageTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(133, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(133, 102);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playerBindingSource, "PlayerID", true));
            this.playerIDTextBox.Location = new System.Drawing.Point(133, 133);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.playerIDTextBox.TabIndex = 8;
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(239, 43);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.RowHeadersWidth = 51;
            this.playerDataGridView.RowTemplate.Height = 27;
            this.playerDataGridView.Size = new System.Drawing.Size(692, 403);
            this.playerDataGridView.TabIndex = 9;
            this.playerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playerDataGridView_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lb_Find_LastName
            // 
            lb_Find_LastName.AutoSize = true;
            lb_Find_LastName.Location = new System.Drawing.Point(32, 371);
            lb_Find_LastName.Name = "lb_Find_LastName";
            lb_Find_LastName.Size = new System.Drawing.Size(81, 15);
            lb_Find_LastName.TabIndex = 11;
            lb_Find_LastName.Text = "Last Name:";
            // 
            // btn_Find_LastName
            // 
            this.btn_Find_LastName.Location = new System.Drawing.Point(147, 406);
            this.btn_Find_LastName.Name = "btn_Find_LastName";
            this.btn_Find_LastName.Size = new System.Drawing.Size(75, 23);
            this.btn_Find_LastName.TabIndex = 13;
            this.btn_Find_LastName.Text = "Find";
            this.btn_Find_LastName.UseVisualStyleBackColor = true;
            this.btn_Find_LastName.Click += new System.EventHandler(this.btn_Find_LastName_Click);
            // 
            // txtBx_Find_LastName
            // 
            this.txtBx_Find_LastName.Location = new System.Drawing.Point(133, 361);
            this.txtBx_Find_LastName.Name = "txtBx_Find_LastName";
            this.txtBx_Find_LastName.Size = new System.Drawing.Size(100, 25);
            this.txtBx_Find_LastName.TabIndex = 14;
            // 
            // btn_BrowseAll
            // 
            this.btn_BrowseAll.Location = new System.Drawing.Point(8, 406);
            this.btn_BrowseAll.Name = "btn_BrowseAll";
            this.btn_BrowseAll.Size = new System.Drawing.Size(105, 23);
            this.btn_BrowseAll.TabIndex = 15;
            this.btn_BrowseAll.Text = "Browse All";
            this.btn_BrowseAll.UseVisualStyleBackColor = true;
            this.btn_BrowseAll.Click += new System.EventHandler(this.btn_BrowseAll_Click);
            // 
            // PlayersDisplayTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.btn_BrowseAll);
            this.Controls.Add(this.txtBx_Find_LastName);
            this.Controls.Add(this.btn_Find_LastName);
            this.Controls.Add(lb_Find_LastName);
            this.Controls.Add(this.label1);
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
            this.Name = "PlayersDisplayTable";
            this.Text = "PlayersDisplayTable";
            this.Load += new System.EventHandler(this.PlayersDisplayTable_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Find_LastName;
        private System.Windows.Forms.TextBox txtBx_Find_LastName;
        private System.Windows.Forms.Button btn_BrowseAll;
    }
}

