using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Models;
using NewsSite.Properties;
using Newsza.Models;
using System.Web.Security;

namespace NewsSite.Views
{
    public partial class details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["NewsID"] != null)
                {
                    string newsid = Convert.ToString(Request.QueryString["NewsID"]);
                    var news = GetNewsFromAmazon.GetNewsFromCache().Where(n => n.NewsID == Guid.Parse(newsid)).FirstOrDefault();
                    var comments = GetNewsFromAmazon.GetCommentsFromCache(Settings.Default.DomainNameComment).Where(n => n.NewsID == Convert.ToString(newsid));
                    lstComments.DataSource = comments;
                    lstComments.DataBind();
                    lstRelatedNews.DataSource = GetNewsFromAmazon.GetNewsFromCache().Where(p => p.Tag.Contains(news.Tag)).Take(5);
                    lstRelatedNews.DataBind();
                    divNewsItem.InnerHtml = Server.HtmlDecode(news.NewsItem);
                    lblHeadline.Text = news.NewsHeadline;
                    hdfNewsID.Value = Convert.ToString(news.NewsID);
                    lblNewsAdded.Text = String.Format("{0:dddd, MMMM d, yyyy H:mm:ss}", news.NewsAdded);
                    lblNumberComment.Text = Convert.ToString(news.CommentCount) + " Comments";
                    lblSource.Text = news.Source;
                    NumberViews number=new NumberViews();
                    number.NewsID = Convert.ToString(news.NewsID);
                    number.Views = news.Views +1;

                    GetNewsFromAmazon.SaveViews(Settings.Default.NumberView, number);

                }
            }
        }
        private void LoadUserName()
        {
            if(HttpContext.Current.User.Identity.IsAuthenticated)
            {
                 MembershipUser user = Membership.GetUser(HttpContext.Current.User.Identity.Name);
                txtName.Text = user.UserName;
                txtEmail.Text = user.Email;
            }
        }
        protected void lstRelatedNews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hypeRelated");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void btnSubmit_Click(Object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.NewsID = hdfNewsID.Value;
            comment.CommentID = Guid.NewGuid();
            comment.CommentItem = txtComment.Text;
            comment.Name = txtName.Text;
            comment.CommentAdded = DateTime.Now;
            comment.UserName = txtName.Text;
            comment.Email = txtEmail.Text;
            comment.Publish = true;

            GetNewsFromAmazon.SaveComments(Settings.Default.DomainNameComment,comment);
        }
        private string  checkForVague(string comments)
        {

            if(comments.Contains("Fuck You"))
            {
               //comments= comments.Replace("Fuck You", ****);

            }else if(comments.Contains("Mother fucker"))
            {
                
            }
            return comments;
        }
    }

}