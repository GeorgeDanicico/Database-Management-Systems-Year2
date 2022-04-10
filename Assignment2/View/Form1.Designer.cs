
namespace Assignment1
{
    partial class GUI
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
            this.teamsGrid = new System.Windows.Forms.DataGridView();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet1 = new Assignment1.DBDataSet();
            this.dBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersGrid = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.teamsTableAdapter = new Assignment1.DBDataSetTableAdapters.TeamsTableAdapter();
            this.dBDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Assignment1.DBDataSetTableAdapters.PlayersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsGrid
            // 
            this.teamsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsGrid.Location = new System.Drawing.Point(32, 12);
            this.teamsGrid.Name = "teamsGrid";
            this.teamsGrid.Size = new System.Drawing.Size(520, 150);
            this.teamsGrid.TabIndex = 0;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.dBDataSet1;
            // 
            // dBDataSet1
            // 
            this.dBDataSet1.DataSetName = "DBDataSet";
            this.dBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBDataSet1BindingSource
            // 
            this.dBDataSet1BindingSource.DataSource = this.dBDataSet1;
            this.dBDataSet1BindingSource.Position = 0;
            // 
            // playersGrid
            // 
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Location = new System.Drawing.Point(32, 272);
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.Size = new System.Drawing.Size(625, 150);
            this.playersGrid.TabIndex = 1;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.dBDataSet1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(574, 104);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSet1BindingSource1
            // 
            this.dBDataSet1BindingSource1.DataSource = this.dBDataSet1;
            this.dBDataSet1BindingSource1.Position = 0;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // GUI
            // 
            this.ClientSize = new System.Drawing.Size(751, 455);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.playersGrid);
            this.Controls.Add(this.teamsGrid);
            this.Name = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView teamsGrid;
        private System.Windows.Forms.DataGridView playersGrid;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource;
        private DBDataSet dBDataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private DBDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DBDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
    }
}

