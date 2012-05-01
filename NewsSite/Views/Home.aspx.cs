using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newsza.Models;
using News.Models;

namespace NewsSite.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var news = GetNewsFromAmazon.GetNewsFromCache();
                LoadNewsArticles(news);
            }

        }

        private void LoadNewsArticles(List<NewsComponents> news)
        {
            throw new NotImplementedException();
        }
    }
}