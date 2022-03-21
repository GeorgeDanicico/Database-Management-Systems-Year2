
namespace Assignment1
{
    partial class Form1
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
            this.dBDataSet = new Assignment1.DBDataSet();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Location = new System.Drawing.Point(24, 48);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.Size = new System.Drawing.Size(640, 220);
            this.playersDataGridView.TabIndex = 1;
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Location = new System.Drawing.Point(24, 323);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.teamsDataGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamsDataGridView);
            this.Controls.Add(this.playersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

