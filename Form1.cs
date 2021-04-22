using logicLayer;
using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;




namespace RssProjct{
    public partial class Form1 : Form{
        private CategoryMethods categorymethod = new CategoryMethods();
       
        private Category cg = new Category();
        private operationsClass OP = new operationsClass();
        private UpdateMethods updating = new UpdateMethods();
        private string feedName;

        public Form1(){
            InitializeComponent();
            AddCategoryFrom();
            fillFeedListview();
            fillIntevallCb();
            OP = new operationsClass();
        }


        private void fillIntevallCb(){
            cbIntervall.Items.Add(500);
            cbIntervall.Items.Add(1000);
            cbIntervall.Items.Add(1500);
            cbIntervall.Items.Add(2000);
        }
            
        private void AddCategoryFrom(){
            try{
                cbCategory.Items.Clear();
                cbCategory.Items.Clear();
                var listOfCategories = OP.GetCategories();
                foreach (var categori in listOfCategories){
                    lvCategory.Items.Add(categori.categoryName);
                    cbCategory.Items.Add(categori.categoryName);
                }
            }
            catch (Exception){
                throw;
            }
        }

        public void fillFeedListview(){
            try
            {
                lvFeeds.Items.Clear();
                var CategoryList = OP.GetCategories();
                foreach (var category in CategoryList)
                {
                    var categoryTitle = category.categoryName;
                    foreach (var feedFile in category.FeedsList)
                    {

                        updating.update(feedFile.FeedTitle, categoryTitle, feedFile, feedFile.feedFolder);
                        var episodes = feedFile.EpisodeList.Count().ToString();
                        string[] anRow = { feedFile.FeedTitle, episodes, feedFile.FeedUpdateIntervall.ToString(), categoryTitle };
                        ListViewItem lvi = new ListViewItem(anRow);
                        lvFeeds.Items.Add(lvi);
                    }
           
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void DeletFeedsFromListView(){
            try {
                var selectedFeedsOfListView = lvFeeds.SelectedItems[0].SubItems[0].Text;
                var selectedCtegory = lvFeeds.SelectedItems[0].SubItems[3].Text;
                categorymethod.DeleteFeed(selectedFeedsOfListView, selectedCtegory);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e){
            
        }
      
        private void btnAdd_Click(object sender, EventArgs e){
            Validation validator = new Validation(txtCategory, "category"," is empty. try again");
            try
            {
                while (validator.TxtBoxIsEmpty() == false)
                {
                    string input = txtCategory.Text;
                    cg.AddCategory(input);
                    lvCategory.Items.Add(input);
                    cbCategory.Items.Add(input);
                    txtCategory.Clear();
                    break;
                }
            }
            catch (Exception)
            {
                throw;
            }
                
            
            
            
         
        }

        private void btnEditCategory_Click(object sender, EventArgs e){
            Validation validator = new Validation(txtCategory, "","you have to choose a category first then type the new name in the field.");
            try
            {
                while (validator.TxtBoxIsEmpty() == false)
                {
                    string editCategoryName = txtCategory.Text;
                    string edit = lvCategory.SelectedItem.ToString();
                    cg.EditCategory(editCategoryName, edit);
                    lvCategory.Items.Clear();
                    AddCategoryFrom();
                    fillFeedListview();
                    txtCategory.Clear();
                    txtCategory.Focus();
                    break;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        private void btnDeleteCategory_Click(object sender, EventArgs e){
            
            try
            {
                if (lvCategory.SelectedIndex != -1)
                {
                    cg.DeleteCategory(lvCategory.SelectedItem.ToString(), "");
                    lvCategory.Items.Clear();
                    AddCategoryFrom();
                    fillFeedListview();
                }
                else
                {
                    MessageBox.Show("you have to select an item first!");
                }

            }
            catch (Exception)
            {
                throw;
            }
           
           
        }

        private async void btnAddFeed_Click(object sender, EventArgs e){
            Validation checkIfURLIsEmpty = new Validation(txtLink, "","Type a valid URL");
            Validation checkIfBoxIsEmpty = new Validation(cbIntervall,"You have to choose how often should the podcats be uppdated.");
            Validation checkIfCategoryIsEmpty = new Validation(cbCategory, "Choose a category");
            Validation checkIffeedNameIsEmpty = new Validation(txtFeedName, "","You have to type a name for your feed.");
            try
            {
                if (!checkIfURLIsEmpty.TxtBoxIsEmpty() && !checkIfBoxIsEmpty.CmBoxIsEmpty() && !checkIfCategoryIsEmpty.CmBoxIsEmpty() && !checkIffeedNameIsEmpty.TxtBoxIsEmpty())
                {
                    int updateIntevall = Convert.ToInt32(cbIntervall.Text);
                    var folderDirection = Directory.GetCurrentDirectory() + @"\" + cbCategory.Text + @"\" + txtFeedName.Text + ".xml";
                    var FolderDirection = Directory.GetCurrentDirectory() + @"\" + cbCategory.Text + @"\" + txtFeedName.Text + ".xml";
                   await categorymethod.AddFeed(FolderDirection, txtLink.Text, updateIntevall, folderDirection, txtFeedName.Text, cbCategory.Text);
                   OP.GetPodcastsFromCategory();
                    fillFeedListview();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
            
        }
        

        private void lvFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var feedItems = lvFeeds.SelectedItems;
            lvEpisode.Clear();
            if (lvFeeds.SelectedItems.Count == 1)
            {
                var selectedItem = lvFeeds.SelectedItems[0].Text;
                feedName = selectedItem;
                var feedList = OP.GetPodcastsFromCategory();
                foreach (var feed in feedList){
                    if (feed.FeedTitle.Equals(selectedItem))
                    {
                        foreach (var episode in feed.EpisodeList)
                        {
                            lvEpisode.Items.Add(episode.EpisodeTitle);
                        }
                    }
                }
            }
        }

        private void lvEpisode_SelectedIndexChanged(object sender, EventArgs e){
           
            lvDescription.Items.Clear();
            if(lvEpisode.SelectedItems.Count == 1){
                var selectedEpisode = lvEpisode.SelectedItems[0].Text;
                var feedList = OP.GetPodcastsFromCategory();
                foreach (var item in feedList){
                    foreach (var episode in item.EpisodeList){
                        if(episode.EpisodeTitle.Equals(selectedEpisode) && item.FeedTitle.Equals(feedName))
                        lvDescription.Items.Add(episode.EpisodeDescription);
                    }
                }
            }
        }

        private void btnDeleteFeeds_Click(object sender, EventArgs e){
            
            try
            {
                
                if (lvFeeds.SelectedItems.Count == 1)
                {
                    var feedSelected = lvFeeds.SelectedItems[0];
                    DeletFeedsFromListView();
                    fillFeedListview();
                }
                else
                {
                    MessageBox.Show("you have to select an item first!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
           
        }

        private void btnEditFeeds_Click(object sender, EventArgs e){
            Validation validator = new Validation(txtFeedName, "", "");
            
            
                while (validator.TxtBoxIsEmpty() == false)
                {
                try
                {
                    var selectedItem = lvFeeds.SelectedItems[0].SubItems[0].Text;
                    var selectedCategory = lvFeeds.SelectedItems[0].SubItems[3].Text;
                    var feedsName = txtFeedName.Text;
                    var feedLink = txtLink.Text;
                    int feedUpdateIntervall = Convert.ToInt32(cbIntervall.Text);
                    var selectedCtegory = cbCategory.Text;
                    string folderDirection = Directory.GetCurrentDirectory() + @"\" + selectedCtegory + @"\" + selectedItem + ".xml";
                    Directory.CreateDirectory(selectedCtegory + feedsName);
                    string folderDirecti = Directory.GetCurrentDirectory() + @"\" + selectedCtegory + @"\" + feedsName + ".xml";
                    Directory.Move(folderDirection, folderDirecti);
                    categorymethod.EditFeed(selectedItem, feedsName, feedLink, folderDirection, feedUpdateIntervall, selectedCtegory);
                    categorymethod.DeleteFeed(selectedItem, selectedCategory);
                    var feedList = OP.GetPodcastsFromCategory();
                    feedList = OP.GetPodcastsFromCategory();
                    fillFeedListview();
                   break;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            




        }

       
    }
 }

