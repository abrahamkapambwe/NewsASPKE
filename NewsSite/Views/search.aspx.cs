using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newsza.Models;
using News.Models;
using System.Web.UI.HtmlControls;

namespace NewsSite.Views
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["value"] != null)
                {
                    string term = Request.QueryString["value"];
                    var news = CheckContent(GetNewsFromAmazon.GetNewsFromCache(), term);
                    LoadSession(news);
                    lstSearch.DataSource = news;
                    lstSearch.DataBind();

                }
            }
        }
        private void LoadSession(List<NewsComponents> newswn)
        {
            Session["SessionNews"] = newswn;
        }
        protected void lstPropertyView_PagePropertiesChanged(object sender, EventArgs e)
        {
            if (Session["SessionNews"] != null)
            {
                var newswn = (List<NewsComponents>)Session["SessionNews"];
                lstSearch.DataSource = newswn;
                lstSearch.DataBind();

            }

        }
        private List<NewsComponents> CheckContent(List<NewsComponents> newsCache, string term)
        {

            List<NewsComponents> newsSearch = new List<NewsComponents>();
            foreach (var newsComponentse in newsCache)
            {
                string[] searchTerms = newsComponentse.NewsItem.Split(new char[] { ';', ' ', ',' });
                foreach (var searchTerm in searchTerms)
                {
                    if (searchTerm.StartsWith(term, StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (!newsSearch.Contains(newsComponentse))
                            newsSearch.Add(newsComponentse);
                    }
                }
            }

            return newsSearch;

        }
        protected void lstSearch_itemDatabound(object sender, ListViewItemEventArgs e)
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