using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsSite.Properties;
using Newsza.Models;
using News.Models;

namespace NewsSite.Views
{
    public partial class multimediaItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.QueryString["VideoId"] != null)
                {
                    string videoid = Convert.ToString(Request.QueryString["VideoId"]);
                    hdfNewsID.Value = videoid;
                    var multimedia =
                        GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(
                            t => t.VideoId == Guid.Parse(videoid));
                    var comments = GetNewsFromAmazon.GetCommentsFromCache(Settings.Default.DomainNameComment).Where(n => n.NewsID == Convert.ToString(videoid));
                    lstComments.DataSource = comments;
                    lstComments.DataBind();
                    var mult = multimedia.FirstOrDefault();

                    //GetYouTubeScript(mult.YoutubeUrl);
                    Literal2.Text = GetYouTubeScript(mult.YoutubeUrl);
                    lblTitle.Text = mult.Title;
                    lblContent.Text = mult.Content;
                }
            }
        }
        protected string GetYouTubeScript(string id)
        {
            string scr = @"<object width='420' height='340'> ";
            scr = scr + @"<param name='movie' value='http://www.youtube.com/v/" + id + "'></param> ";
            scr = scr + @"<param name='allowFullScreen' value='true'></param> ";
            scr = scr + @"<param name='allowscriptaccess' value='always'></param> ";
            scr = scr + @"<embed src='http://www.youtube.com/v/" + id + "' ";
            scr = scr + @"type='application/x-shockwave-flash' allowscriptaccess='always' ";
            scr = scr + @"allowfullscreen='true' width='420' height='340'> ";
            scr = scr + @"</embed></object>";
            return scr;
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

            GetNewsFromAmazon.SaveComments(Settings.Default.DomainNameComment, comment);
            lblResult.Text = "Saved";
        }
    }
}