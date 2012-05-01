using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using News.Models;
using Newsza.Models;
using System.Web.UI.HtmlControls;

namespace NewsSite.Views
{
    public partial class othernews : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["category"] != null)
                {
                    string category = Convert.ToString(Request.QueryString["category"]);
                    string value = Request.QueryString["value"] != null ? Request.QueryString["value"].ToString() : "";
                    switch (category)
                    {
                        case Categories.BUSINESS:

                            lblHeadline.Text = "Business";
                            var newsb =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.BUSINESS).Where(p => p.ContainsPictures).
                                    ToList();
                            if(!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newsb);
                            }
                            else
                            {
                                LoadNewsArticles(newsb);
                            }
                           
                            break;
                        case Categories.ENTERTAINMENT:
                            lblHeadline.Text = "Entertainment";
                            var newse =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.ENTERTAINMENT).Where(p => p.ContainsPictures).
                                    ToList();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newse);
                            }
                            else
                            {
                                LoadNewsArticles(newse);
                            }
                            break;
                        case Categories.TECHNOLOGY:
                            lblHeadline.Text = "Technology";
                            var newst =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.TECHNOLOGY).Where(p => p.ContainsPictures).
                                    ToList();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newst);
                            }
                            else
                            {
                                LoadNewsArticles(newst);
                            }
                            break;
                        case Categories.LIFESTYLE:
                            lblHeadline.Text = "Lifestyle";
                            var newsl =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.LIFESTYLE).Where(p => p.ContainsPictures).
                                    ToList();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newsl);
                            }
                            else
                            {
                                LoadNewsArticles(newsl);
                            }
                            break;
                        case Categories.GOSSIP:
                            lblHeadline.Text = "Business";
                            var newsg =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.GOSSIP).Where(p => p.ContainsPictures).ToList();
                                  
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newsg);
                            }
                            else
                            {
                                LoadNewsArticles(newsg);
                            }
                            break;
                        case Categories.POLITICS:
                            lblHeadline.Text = "News";
                            var newsp =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.POLITICS).Where(p => p.ContainsPictures).
                                    ToList();

                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newsp);
                            }
                            else
                            {
                                LoadNewsArticles(newsp);
                            }
                            break;
                        case Categories.SPORT:
                            lblHeadline.Text = "Sport";
                            var newss =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.SPORT).Where(p => p.ContainsPictures).ToList();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newss);
                            }
                            else
                            {
                                LoadNewsArticles(newss);
                            }
                            break;
                        case Categories.WORLDNEWS:
                            lblHeadline.Text = "World News";
                            var newswn =
                                GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.WORLDNEWS).Where(p => p.ContainsPictures).ToList();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                GetPopular(newswn);
                            }
                            else
                            {
                                LoadNewsArticles(newswn);
                            }
                            break;
                    }
                }
            }
        }

        private void GetPopular(List<NewsComponents> newsComponents)
        {
            var newsItems = newsComponents.OrderByDescending(p => p.CommentCount).ToList();
            LoadNewsArticles(newsItems);
        }
        private void LoadNewsArticles(List<NewsComponents> news)
        {
            lstothernews.DataSource = news;
            lstothernews.DataBind();
        }
        protected void lstothernews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
            }
        }
    }
}