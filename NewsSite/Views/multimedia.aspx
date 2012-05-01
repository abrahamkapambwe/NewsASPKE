<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="multimedia.aspx.cs" Inherits="NewsSite.Views.multimedia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main-para">
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Politics</span>
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
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
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
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
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
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
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
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
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
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
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
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
        <div class="space-big">
        </div>
        <!-- Divider -->
        <div class="story">
            <div class="inner-design-large">
                <div class="sub-title">
                    <span>Comedy</span>
                </div>
                <div style="float: left;">
                    <asp:ListView runat="server" ID="lstComedy" OnItemDataBound="lstComedy_itemDatabound">
                        <LayoutTemplate>
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                                <div class="viewport">
                                    <a id="hyperThumbNail" runat="server">
                                        <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                            height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                                </div>
                                <div class="information-design">
                                    <div class="template-name">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="information-design">
                    <div class="template-information">
                        <asp:ListView runat="server" ID="ListView2" OnItemDataBound="lstEntertainmentHeadlines_itemDatabound">
                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceholder">
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div>
                                    <span><span class="smaller"></span><span>
                                        <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                    </span>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
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
    <!-- Divider -->
    <div class="story">
        <div class="inner-design-large">
            <div class="sub-title">
                <span>Tourism</span>
            </div>
            <div style="float: left;">
                <asp:ListView runat="server" ID="lsttourism" OnItemDataBound="lsttourism_itemDatabound">
                    <LayoutTemplate>
                        <div id="itemPlaceholder" runat="server">
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                            <div class="viewport">
                                <a id="hyperThumbNail" runat="server">
                                    <img id="imgPhoto" style="margin-bottom: 20px" alt='<%#Eval("Title") %>' width="100%"
                                        height="100%" src='<%#Eval("ThumbNail") %>' title='<%#Eval("Title") %>' /></a>
                            </div>
                            <div class="information-design">
                                <div class="template-name">
                                    <span>
                                        <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("Title")%></asp:HyperLink><br />
                                        <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("Content")%></asp:HyperLink></span>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="information-design">
                <div class="template-information">
                    <asp:ListView runat="server" ID="lsttourismHeadlines" OnItemDataBound="lsttourismHeadlines_itemDatabound">
                        <LayoutTemplate>
                            <div runat="server" id="itemPlaceholder">
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div>
                                <span><span class="smaller"></span><span>
                                    <asp:HyperLink runat="server" ID="hyperNavi">
                                        <%#Eval("Title")%> </asp:HyperLink><br />
                                </span>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
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
</asp:Content>
