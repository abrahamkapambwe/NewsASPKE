using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Models;
using Newsza.Models;
using System.Web.UI.HtmlControls;

namespace NewsSite.Views
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                LoadNewsHeadline();
            }
        }

        private void LoadNewsHeadline()
        {
            

            var news = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.POLITICS).OrderByDescending(s => s.NewsAdded).ToList();

            if (news != null && news.Any())
            {
                lstPoliticsHeadline.DataSource = news.Skip(9).Take(10);
                lstPoliticsHeadline.DataBind();
                lstPolitics.DataSource = news.Where(p => p.ContainsPictures).Skip(5).Take(4);
                lstPolitics.DataBind();


                var newsbusinessheadline = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.BUSINESS).OrderByDescending(s => s.NewsAdded).ToList();
                lstBusiness.DataSource = newsbusinessheadline.Take(4);
                lstBusiness.DataBind();
                lstBusinessHeadline.DataSource = newsbusinessheadline.Skip(4).Take(10);
                lstBusinessHeadline.DataBind();


                var newstechnology = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.TECHNOLOGY).OrderByDescending(s => s.NewsAdded).ToList();
                lstTechnology.DataSource = newstechnology.Where(p => p.ContainsPictures).Take(4);
                lstTechnology.DataBind();
                lstTechnologyHeadlines.DataSource = newstechnology.Skip(4).Take(10);
                lstTechnologyHeadlines.DataBind();

                var newsSport = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.SPORT).OrderByDescending(s => s.NewsAdded).ToList();
                lstSports.DataSource = newsSport.Where(p => p.ContainsPictures).Take(4);
                lstSports.DataBind();
                lstSportsHeadline.DataSource = newsSport.Skip(4).Take(10);
                lstSportsHeadline.DataBind();

                var newsentertainment = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.ENTERTAINMENT).OrderByDescending(s => s.NewsAdded).ToList();

                lstEntertainment.DataSource = newsentertainment.Where(p => p.ContainsPictures).Take(4);
                lstEntertainment.DataBind();
                lstEntertainmentHeadlines.DataSource = newsentertainment.Skip(4).Take(10);
                lstEntertainmentHeadlines.DataBind();
                var newsworld = GetNewsFromAmazon.GetNewsFromCache().Where(t => t.Category == Categories.WORLDNEWS).OrderByDescending(s => s.NewsAdded).ToList();

                lstWorldNews.DataSource = newsworld.Where(p => p.ContainsPictures).Take(4);
                lstWorldNews.DataBind();
                lstWorldNewsheadline.DataSource = newsworld.Skip(4).Take(10);
                lstWorldNewsheadline.DataBind();
            }

        }
        protected void lstPolitics_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                {
                    img.ImageUrl = newsComponents.Images[0].Url;
                    if (!string.IsNullOrWhiteSpace(newsComponents.ThumbNailUrl))
                        img.ImageUrl = newsComponents.ThumbNailUrl;
                }

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstPoliticsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstWorldNews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstWorldNewsheadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstBusiness_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstBusinessHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstTechnology_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstTechnologyHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstSports_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
            }
        }
        protected void lstSportsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

        protected void lstEntertainment_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HtmlAnchor anchor = (HtmlAnchor)e.Item.FindControl("photourl");
                anchor.HRef = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstEntertainmentHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }

    }
}