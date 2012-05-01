<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="search.aspx.cs" Inherits="NewsSite.Views.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:ListView runat="server" ID="lstSearch" OnItemDataBound="lstSearch_itemDatabound">
            <LayoutTemplate>
                <div id="itemPlaceholder" runat="server">
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                    <div class="viewport">
                        <a id="photourl" runat="server">
                            <asp:Image ID="imgPhoto" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                                Width="200px" Height="150px" title='<%#Eval("NewsHeadline") %>' runat="server" /></a>
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
</asp:Content>
