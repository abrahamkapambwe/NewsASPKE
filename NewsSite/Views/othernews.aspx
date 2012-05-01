<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="othernews.aspx.cs" Inherits="NewsSite.Views.othernews" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; padding-left: 9px; padding-top: 17px; width: 600px">
        <br />
        <br />
        <b>
            <asp:Label runat="server" ID="lblHeadline"></asp:Label></b><br />
        <br />
        <div>
            <asp:ListView ID="lstothernews" runat="server" OnItemDataBound="lstothernews_itemDatabound">
                <LayoutTemplate>
                    <div id="itemPlaceholder" runat="server">
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div style="clear: both; margin-right: 10px; margin-bottom: 5px; padding-bottom: 5px">
                        <div style="clear: both; padding: 10px">
                            <div style="float: left">
                                <div class="viewport">
                                    <a id="photourl" runat="server">
                                        <asp:Image ID="imgPhoto" runat="server" alt='<%#Eval("NewsHeadline") %>' Width="200px"
                                            Height="150px" title='<%#Eval("NewsHeadline") %>' /></a>
                                </div>
                            </div>
                            <div style="float: left; padding-left: 10px">
                                <div class="information-designonther">
                                    <div class="template-nameother">
                                        <span>
                                            <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                            <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div style="clear: both">
            <br />
            <br />
            <br />
        </div>
        <div style="font-size: 11px; margin-left: 20px; margin-right: 20px; margin-bottom: 10px;
            margin-top: 10px">
            <asp:DataPager runat="server" ID="BeforeListDataPager" PagedControlID="lstothernews"
                PageSize="20">
                <Fields>
                    <asp:TemplatePagerField>
                        <PagerTemplate>
                            <div style="width: 550px; float: left;">
                                Page
                                <asp:Label ID="CurrentPageLabel" runat="server" Text="<%# Container.TotalRowCount>0 ? (Container.StartRowIndex / Container.PageSize) + 1 : 0 %>" />
                                of
                                <asp:Label ID="TotalPagesLabel" runat="server" Text="<%# Math.Ceiling ((double)Container.TotalRowCount / Container.PageSize) %>" />
                                (
                                <asp:Label ID="TotalItemsLabel" runat="server" Text="<%# Container.TotalRowCount%>" />
                                records)</div>
                        </PagerTemplate>
                    </asp:TemplatePagerField>
                    <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowNextPageButton="false"
                        ShowPreviousPageButton="false" />
                    <asp:NumericPagerField ButtonCount="10" />
                    <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="true" ShowNextPageButton="false"
                        ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
</asp:Content>
