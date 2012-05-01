<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true"
    CodeBehind="homepage.aspx.cs" Inherits="NewsSite.Views.test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-para">
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>News</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstPolitics" OnItemDataBound="lstPolitics_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                    <a id="photourl" runat="server">
                                        <asp:Image ID="imgPhoto" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                            Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' runat="server" /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstPoliticsHeadline" OnItemDataBound="lstPoliticsHeadline_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink8" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=Politics"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="clear">
        </div>
        <!-- Divider -->
        <div class="space-big">
        </div>
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>World News</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstWorldNews" OnItemDataBound="lstWorldNews_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                    <a id="photourl" runat="server">
                                        <asp:Image ID="imgPhoto" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                            Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' runat="server" /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstWorldNewsheadline" OnItemDataBound="lstWorldNewsheadline_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink3" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=WorldNews"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="clear">
        </div>
        <!-- Divider -->
        <div class="space-big">
        </div>
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Business</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstBusiness" OnItemDataBound="lstBusiness_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                   <a id="photourl" runat="server"> <asp:Image ID="imgPhoto" runat="server" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                        Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstBusinessHeadline" OnItemDataBound="lstBusinessHeadline_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span><span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink1" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=Business"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <!-- Divider -->
        <div class="space-big">
        </div>
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Technology</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstTechnology" OnItemDataBound="lstTechnology_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                    <a id="photourl" runat="server"> <asp:Image ID="imgPhoto" runat="server" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                        Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstTechnologyHeadlines" OnItemDataBound="lstTechnologyHeadlines_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span></span>
                                    <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink2" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=Technology"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <!-- Divider -->
        <div class="space-big">
        </div>
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Sports</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstSports" OnItemDataBound="lstSports_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                   <a id="photourl" runat="server"> <asp:Image ID="imgPhoto" runat="server" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                        Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstSportsHeadline" OnItemDataBound="lstSportsHeadline_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span><span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink4" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=Sport"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <!-- Divider -->
        <div class="space-big">
        </div>
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Entertainment</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstEntertainment" OnItemDataBound="lstEntertainment_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                   <a id="photourl" runat="server">  <asp:Image ID="imgPhoto" runat="server" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                        Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="lstEntertainmentHeadlines" OnItemDataBound="lstEntertainmentHeadlines_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span><span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("NewsHeadline")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                        <span><span class="smaller"></span>
                            <asp:HyperLink ID="HyperLink5" class="highlighted" runat="server" NavigateUrl="~/Views/othernews.aspx?category=Entertainment"
                                Target="_parent">More from newske » </asp:HyperLink>
                        </span>
                    </div>
                    <div class="clear">
                    </div>
                    <div class="clear">
                    </div>
                    <div class="spacer">
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div class="clear">
            </div>
        </div>
        <!-- Divider
    -->
        <div class="clear">
        </div>
    </div>
</asp:Content>
