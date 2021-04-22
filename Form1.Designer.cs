namespace RssProjct
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
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.btnEditFeeds = new System.Windows.Forms.Button();
            this.btnDeleteFeeds = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lvEpisode = new System.Windows.Forms.ListView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.cbIntervall = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lvCategory = new System.Windows.Forms.ListBox();
            this.lvFeeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFeedName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvDescription = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(487, 435);
            this.btnAddFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(143, 35);
            this.btnAddFeed.TabIndex = 1;
            this.btnAddFeed.Text = "Add";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnEditFeeds
            // 
            this.btnEditFeeds.Location = new System.Drawing.Point(667, 435);
            this.btnEditFeeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditFeeds.Name = "btnEditFeeds";
            this.btnEditFeeds.Size = new System.Drawing.Size(145, 35);
            this.btnEditFeeds.TabIndex = 2;
            this.btnEditFeeds.Text = "Edit";
            this.btnEditFeeds.UseVisualStyleBackColor = true;
            this.btnEditFeeds.Click += new System.EventHandler(this.btnEditFeeds_Click);
            // 
            // btnDeleteFeeds
            // 
            this.btnDeleteFeeds.Location = new System.Drawing.Point(840, 435);
            this.btnDeleteFeeds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteFeeds.Name = "btnDeleteFeeds";
            this.btnDeleteFeeds.Size = new System.Drawing.Size(127, 35);
            this.btnDeleteFeeds.TabIndex = 3;
            this.btnDeleteFeeds.Text = "Delete";
            this.btnDeleteFeeds.UseVisualStyleBackColor = true;
            this.btnDeleteFeeds.Click += new System.EventHandler(this.btnDeleteFeeds_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(42, 384);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(403, 26);
            this.txtLink.TabIndex = 4;
            // 
            // lvEpisode
            // 
            this.lvEpisode.HideSelection = false;
            this.lvEpisode.Location = new System.Drawing.Point(42, 518);
            this.lvEpisode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvEpisode.Name = "lvEpisode";
            this.lvEpisode.Size = new System.Drawing.Size(1556, 150);
            this.lvEpisode.TabIndex = 6;
            this.lvEpisode.UseCompatibleStateImageBehavior = false;
            this.lvEpisode.View = System.Windows.Forms.View.Tile;
            this.lvEpisode.SelectedIndexChanged += new System.EventHandler(this.lvEpisode_SelectedIndexChanged);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(1419, 192);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(180, 35);
            this.btnDeleteCategory.TabIndex = 10;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(1419, 290);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(180, 35);
            this.btnEditCategory.TabIndex = 11;
            this.btnEditCategory.Text = "Edit";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(1174, 391);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(205, 26);
            this.txtCategory.TabIndex = 12;
            // 
            // cbIntervall
            // 
            this.cbIntervall.FormattingEnabled = true;
            this.cbIntervall.Location = new System.Drawing.Point(603, 384);
            this.cbIntervall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIntervall.Name = "cbIntervall";
            this.cbIntervall.Size = new System.Drawing.Size(180, 28);
            this.cbIntervall.TabIndex = 16;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(906, 389);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(180, 28);
            this.cbCategory.TabIndex = 17;
            // 
            // lvCategory
            // 
            this.lvCategory.FormattingEnabled = true;
            this.lvCategory.ItemHeight = 20;
            this.lvCategory.Location = new System.Drawing.Point(1174, 40);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(205, 284);
            this.lvCategory.TabIndex = 18;
            // 
            // lvFeeds
            // 
            this.lvFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFeeds.HideSelection = false;
            this.lvFeeds.Location = new System.Drawing.Point(1, 39);
            this.lvFeeds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvFeeds.Name = "lvFeeds";
            this.lvFeeds.Size = new System.Drawing.Size(1085, 299);
            this.lvFeeds.TabIndex = 19;
            this.lvFeeds.UseCompatibleStateImageBehavior = false;
            this.lvFeeds.View = System.Windows.Forms.View.Details;
            this.lvFeeds.SelectedIndexChanged += new System.EventHandler(this.lvFeeds_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sections";
            this.columnHeader2.Width = 248;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 259;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category";
            this.columnHeader4.Width = 305;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "update Intervall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "podcasts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "feeds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1171, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "categories";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1419, 389);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 29);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFeedName
            // 
            this.txtFeedName.Location = new System.Drawing.Point(42, 450);
            this.txtFeedName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFeedName.Name = "txtFeedName";
            this.txtFeedName.Size = new System.Drawing.Size(224, 26);
            this.txtFeedName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "feed name";
            // 
            // lvDescription
            // 
            this.lvDescription.FormattingEnabled = true;
            this.lvDescription.ItemHeight = 20;
            this.lvDescription.Location = new System.Drawing.Point(42, 699);
            this.lvDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDescription.Name = "lvDescription";
            this.lvDescription.Size = new System.Drawing.Size(1556, 104);
            this.lvDescription.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 835);
            this.Controls.Add(this.lvDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFeedName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFeeds);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbIntervall);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.lvEpisode);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnDeleteFeeds);
            this.Controls.Add(this.btnEditFeeds);
            this.Controls.Add(this.btnAddFeed);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.Button btnEditFeeds;
        private System.Windows.Forms.Button btnDeleteFeeds;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ListView lvEpisode;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ComboBox cbIntervall;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListBox lvCategory;
        private System.Windows.Forms.ListView lvFeeds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFeedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lvDescription;
    }
}

