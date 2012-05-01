using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Models;
using Newsza.Models;
using NewsAppWebRole.Models;
using System.Net;
using System.IO;
using System.Xml.Linq;
using NewsSite.Properties;
using System.Web.UI.HtmlControls;

namespace NewsSite
{
    public partial class MainTemplate : System.Web.UI.MasterPage
    {
        private PropertyTableAzure PropertyTableAzure;
        //private List<PropertyTableAzure> listPropertyAzures;

        //public List<PropertyTableAzure> ListPropertyTableAzures
        //{
        //    get
        //    {
        //        //if (listPropertyAzures != null)
        //        //    listPropertyAzures = new List<PropertyTableAzure>();
        //        //return listPropertyAzures;
        //    }
        //    set{}
        //    //set { listPropertyAzures = value; }
        //}
        public List<PropertyTableAzure> ListPropertyTableAzures { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInTheCache();
                lstProperties.DataSource = ListPropertyTableAzures.OrderByDescending(s => s.Added).Take(5);
                lstProperties.DataBind();
                var multimedia =
                        GetNewsFromAmazon.GetVideosFromCache(Settings.Default.KenyaVideo).Where(p => p.Category == Categories.POLITICS).Take(1);
                if (multimedia != null)
                {
                    var mult = multimedia.FirstOrDefault();
                    if (mult != null)
                        Literal2.Text = GetYouTubeScript(mult.YoutubeUrl);
                }

                var news = GetNewsFromAmazon.GetNewsFromCache();
                if (news != null && news.Count > 0)
                {
                    var newsItem = news.OrderByDescending(p => p.NewsAdded).Where(p => p.Category == Categories.POLITICS).Take(1).FirstOrDefault();
                    hrheadline.Text = newsItem.NewsHeadline;
                    hrheadline.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsItem.NewsID;
                    var newsslideshow = news.Where(p => p.Category == Categories.POLITICS && p.ContainsPictures).OrderByDescending(s => s.NewsAdded).Skip(1).Take(1).FirstOrDefault();
                    imgHeadline.ImageUrl = newsslideshow.Images[0].Url;
                    imgHeadline.Width = 300;
                    imgHeadline.Height = 365;
                    lblHeadline.Text = newsslideshow.NewsHeadline;
                    lblheadlineAdded.Text = String.Format("{0:ddd, MMMM d, yyyy}", newsslideshow.NewsAdded);
                    lblSummaryContent.Text = newsslideshow.SummaryContent;
                    hyperHeadline.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsslideshow.NewsID;
                    hypTopNews.HRef = "~/Views/details.aspx?NewsID=" + newsslideshow.NewsID;


                    lstheadlinePictures.DataSource = news.Where(p => p.Category == Categories.POLITICS && p.ContainsPictures).OrderByDescending(s => s.NewsAdded).Skip(1).Take(4);
                    lstheadlinePictures.DataBind();
                    lstmainheadline.DataSource = news.Where(p => p.Category == Categories.POLITICS).OrderByDescending(s => s.NewsAdded).Skip(5).Take(10);
                    lstmainheadline.DataBind();
                    lstSingle.DataSource = news.Where(p => p.Category == Categories.POLITICS).OrderByDescending(s => s.NewsAdded).Skip(15).Take(1);
                    lstSingle.DataBind();
                    lstSidebarNews.DataSource = news.Where(p => p.Category == Categories.POLITICS).OrderByDescending(s => s.NewsAdded).Skip(16).Take(2);
                    lstSidebarNews.DataBind();
                    lstPopularNews.DataSource = news.OrderByDescending(s => s.CommentCount).Take(5);
                    lstPopularNews.DataBind();
                }
            }

        }
        public void Search_Click(object sender, EventArgs e)
        {
            string term = qsearch.Value;
            Response.Redirect("~/Views/search.aspx?value=" + term);
        }
        protected string GetYouTubeScript(string id)
        {
            string scr = @"<object width='220' height='140'> ";
            scr = scr + @"<param name='movie' value='http://www.youtube.com/v/" + id + "'></param> ";
            scr = scr + @"<param name='allowFullScreen' value='true'></param> ";
            scr = scr + @"<param name='allowscriptaccess' value='always'></param> ";
            scr = scr + @"<embed src='http://www.youtube.com/v/" + id + "' ";
            scr = scr + @"type='application/x-shockwave-flash' allowscriptaccess='always' ";
            scr = scr + @"allowfullscreen='true' width='220' height='140'> ";
            scr = scr + @"</embed></object>";
            return scr;
        }
        protected void lstheadlinePictures_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;
                if (newsComponents.Images.Any())
                    lnk.ImageUrl = newsComponents.Images[0].Url;


            }
        }
        protected void lstSidebarNews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;
                Image img = (Image)e.Item.FindControl("imgPhoto");
                if (newsComponents.Images.Any())
                    img.ImageUrl = newsComponents.Images[0].Url;
                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstmainheadline_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstSingle_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstPopularNews_itemDatabound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                NewsComponents newsComponents = (NewsComponents)e.Item.DataItem;

                HyperLink lnk = (HyperLink)e.Item.FindControl("hyperNavi");
                lnk.NavigateUrl = "~/Views/details.aspx?NewsID=" + newsComponents.NewsID;

            }
        }
        protected void lstProperty_itemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                PropertyTableAzure property = (PropertyTableAzure)e.Item.DataItem;
                //HyperLink link = (HyperLink)e.Item.FindControl("hypLink");
                HtmlAnchor html = (HtmlAnchor)e.Item.FindControl("hyparchor");
                Label price = (Label)e.Item.FindControl("lblPrice");
                Label street = (Label)e.Item.FindControl("lblStreet");
                Label suburb = (Label)e.Item.FindControl("lblSuburb");
                Label city = (Label)e.Item.FindControl("lblCity");
                if (property.ImageUrlAzures.Any())
                {
                    html.HRef = Settings.Default.PropertyUrlKE + "Public/PropertyDetails.aspx?PropertyID=" + property.PropertyID;
                    //link.ImageUrl = property.ImageUrlAzures[0].thumbnailblob;

                    //link.Target = "_blank";
                    //link.NavigateUrl = Settings.Default.PropertyUrlKA + "Public/PropertyDetails.aspx?PropertyID=" + property.PropertyID;
                }
                price.Text = "KSh " + property.Price;
                street.Text = property.StreetName;
                suburb.Text = property.Suburb;
                city.Text = property.City;


            }
        }
        private void LoadInTheCache()
        {
            if (HttpRuntime.Cache["PropertyEstate"] != null)
            {
                ListPropertyTableAzures = (List<PropertyTableAzure>)HttpRuntime.Cache["PropertyEstate"];
            }
            else
            {
                LoadProperties();

            }


        }
        private void LoadProperties()
        {
            ListPropertyTableAzures = new List<PropertyTableAzure>();
            HttpWebRequest webRequest =
                (HttpWebRequest)WebRequest.Create(Settings.Default.PropertySiteke);
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader streamRead = new StreamReader(stream);


            //string strResponse = streamRead.ReadToEnd();
            XElement document = XElement.Load(streamRead);


            var properties = from v in document.Descendants("PropertyTableAzure")
                             //from p in v.Element("PriceTableAzure")
                             select new
                             {
                                 PropertyID = v.Element("PropertyID").Value,
                                 WebReference = v.Element("WebReference").Value,
                                 StreetName = v.Element("StreetName").Value,
                                 Suburb = v.Element("Suburb").Value,
                                 City = v.Element("City").Value,
                                 ListingType = v.Element("PropertyType").Value,
                                 Province = v.Element("StreetName").Value,
                                 Images = from f in v.Element("ImageUrlAzures").Elements("ImageUrlAzure")
                                          where f.Element("PropertyID").Value == v.Element("PropertyID").Value
                                          select new
                                          {
                                              ImageUrl = f.Element("thumbnailblob").Value,
                                              Date = f.Element("DateUploaded").Value
                                          }
                                 ,
                                 Price = from p in v.Elements("PriceTableAzure")
                                         where p.Element("PropertyID").Value == v.Element("PropertyID").Value
                                         select new
                                         {
                                             MonthlyRental = p.Element("MonthlyRental").Value,
                                             Bedroom = GetTheAttribute(p.Element("Attributes").Value),
                                             PropertType =
                                  GetThePropertyType(p.Element("Attributes").Value)
                                         }
                             };

            foreach (var property in properties)
            {
                PropertyTableAzure = new PropertyTableAzure();
                PropertyTableAzure.City = property.City;
                PropertyTableAzure.ListingType = property.ListingType;
                PropertyTableAzure.Province = property.Province;
                PropertyTableAzure.WebReference = property.WebReference;
                PropertyTableAzure.StreetName = property.StreetName;
                PropertyTableAzure.PropertyID = property.PropertyID;
                foreach (var price in property.Price)
                {
                    PropertyTableAzure.Price = price.MonthlyRental;
                    PropertyTableAzure.PropertyType = price.PropertType;
                    PropertyTableAzure.Bedroom = price.Bedroom;
                }
                foreach (var images in property.Images)
                {
                    var img = new ImageUrlAzure();
                    img.thumbnailblob = images.ImageUrl;
                    PropertyTableAzure.ImageUrlAzures.Add(img);
                }
                ListPropertyTableAzures.Add(PropertyTableAzure);

            }
            HttpRuntime.Cache.Insert("PropertyEstate", ListPropertyTableAzures, null, DateTime.UtcNow.AddHours(2), System.Web.Caching.Cache.NoSlidingExpiration);
        }

        private string GetThePropertyType(string p)
        {
            string[] propertytypes = p.Split(new char[] { '|' });
            string result = "House";
            foreach (var propertytype in propertytypes)
            {
                if (propertytype.Contains("Duplex"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Apartment"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("House"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Cluster"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Simplex"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Garden Cottage"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Townhome"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Land"))
                {
                    return propertytype;
                }
                else if (propertytype.Contains("Farm"))
                {
                    return propertytype;
                }
            }
            return result;
        }

        private string GetTheAttribute(string p)
        {
            string[] attribute = p.Split(new char[] { '|' });
            string result = "";
            foreach (var s in attribute)
            {
                if (s.Contains("Bedroom"))
                    return s;
            }

            return result;
        }
    }
}