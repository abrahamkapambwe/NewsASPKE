using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using News.Models;
using NewsSite.Properties;
using Newsza.Models;

namespace NewsSite.Views
{
    public partial class multimedia : System.Web.UI.Page
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

            var news = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.POLITICS).ToList();
            if (news != null && news.Any())
            {
                lstPoliticsHeadline.DataSource = news.Skip(4).Take(10);
                lstPoliticsHeadline.DataBind();
                lstPolitics.DataSource = news.Take(4);
                lstPolitics.DataBind();


                var newsbusinessheadline = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.BUSINESS).ToList();
                lstBusiness.DataSource = newsbusinessheadline.Take(4);
                lstBusiness.DataBind();
                lstBusinessHeadline.DataSource = newsbusinessheadline.Skip(4).Take(10);
                lstBusinessHeadline.DataBind();


                var newstechnology = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.TECHNOLOGY).ToList();
                lstTechnology.DataSource = newstechnology.Take(4);
                lstTechnology.DataBind();
                lstTechnologyHeadlines.DataSource = newstechnology.Skip(4).Take(10);
                lstTechnologyHeadlines.DataBind();

                var newsSport = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.SPORT).ToList();
                lstSports.DataSource = newsSport.Take(4);
                lstSports.DataBind();
                lstSportsHeadline.DataSource = newsSport.Skip(4).Take(10);
                lstSportsHeadline.DataBind();

                var newsentertainment = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.ENTERTAINMENT).ToList();

                lstEntertainment.DataSource = newsentertainment.Take(4);
                lstEntertainment.DataBind();
                lstEntertainmentHeadlines.DataSource = newsentertainment.Skip(4).Take(10);
                lstEntertainmentHeadlines.DataBind();
                var comedy = GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(t => t.Category == Categories.COMEDY).ToList();
                lstComedy.DataSource = comedy;
                lstComedy.DataBind();
            }

        }
        protected void lstComedy_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }
        protected void lsttourism_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }
        protected void lstPolitics_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }
        protected void lstPoliticsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;


            }
        }
        protected void lsttourismHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;


            }
        }
        protected void lstBusiness_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }
        protected void lstBusinessHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;


            }
        }

        protected void lstTechnology_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }
        protected void lstTechnologyHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;


            }
        }

        protected void lstSports_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
            }
        }
        protected void lstSportsHeadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;


            }
        }

        protected void lstEntertainment_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                HtmlAnchor htmlAnchor = (HtmlAnchor)e.Item.FindControl("hyperThumbNail");
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                htmlAnchor.HRef = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
                HyperLink linksummary = (HyperLink)e.Item.FindControl("linksummary");
                linksummary.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;
            }
        }
        protected void lstEntertainmentHeadlines_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Multimedia newsComponents = (Multimedia)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/multimediaItem.aspx?VideoId=" + newsComponents.VideoId;

            }
        }

    }

}