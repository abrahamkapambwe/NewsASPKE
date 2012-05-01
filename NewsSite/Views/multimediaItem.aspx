<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="multimediaItem.aspx.cs" Inherits="NewsSite.Views.multimediaItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; padding-top: 25px; padding-left: 9px; width: 600px;">
        <br />
        <br />
        <br />
        <asp:HiddenField runat="server" ID="hdfNewsID" />
        <div style="padding: 20px; border: 1px solid #E3E3E3; background: #F5F5F5; border-radius: 3px 3px 3px 3px;">
            <div>
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
            </div>
            <div>
                <asp:Label runat="server" ID="lblTitle"></asp:Label><br />
                <br />
                <asp:Label runat="server" ID="lblContent"></asp:Label>
            </div>
            <br />
        </div>
    </div>
    <div>
        <div style="float: left; padding-left: 9px; padding-top: 17px; width: 600px">
            <div>
                <asp:Label runat="server" ID="lblNumberComment"></asp:Label>
            </div>
            <br />
            <div class="comments" style="padding-top: 10px; padding-bottom: 10px; border: 1px solid #E3E3E3;
                background: #F5F5F5; border-radius: 3px 3px 3px 3px;">
                <asp:ListView runat="server" ID="lstComments">
                    <LayoutTemplate>
                        <ul id="itemPlaceholder" runat="server" style="list-style-type: none">
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li style="list-style-type: none">
                            <div class="commentItem" style="border-radius: 3px 3px 3px 3px; border: 1px solid #E3E3E3;
                                padding: 20px; margin: 15px 15px 0; background-color: #FFFFFF;">
                                <div class="comment" style="margin-bottom: 10px;">
                                    <%#Eval("CommentItem")%>
                                </div>
                                <div class="usename">
                                    Posted by <span style="color: Blue">
                                        <%#Eval("Name")%></span>
                                </div>
                                <div class="commentAdded">
                                    <%#Eval("CommentAdded","{0:M-dd-yyyy H:mm}")%>
                                </div>
                                </>
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:ListView>
               
            </div>
            <div style="padding-top: 20px; padding-bottom: 20px">
                <asp:UpdatePanel runat="server" ID="updateComments">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <div style="padding-left: 20px">
                                        <asp:UpdateProgress ID="UpdateProgress2" runat="server">
                                          
                                            <ProgressTemplate>
                                                <img src="../images/ajax-loader.gif" alt="" />An update is in progress...
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="padding-left: 5px">
                                    Name
                                </td>
                                <td>
                                    <asp:TextBox class="textbox" runat="server" ID="txtName"></asp:TextBox><asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" Text="*"
                                        ErrorMessage="Name is required"></asp:RequiredFieldValidator><br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="padding-left: 5px">
                                    Email:
                                </td>
                                <td>
                                    <asp:TextBox CssClass="textbox" runat="server" ID="txtEmail"></asp:TextBox>
                                    <br />
                                    <asp:RegularExpressionValidator ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ID="RegularExpressionValidator1" ControlToValidate="txtEmail" runat="server"
                                        ErrorMessage="invalid email address"></asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail"
                                        ErrorMessage="email is required"></asp:RequiredFieldValidator>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td valign="top" style="padding-left: 5px">
                                    Comment:
                                </td>
                                <td>
                                    <asp:TextBox CssClass="textbox" MaxLength="1000" Height="200px" TextMode="MultiLine"
                                        runat="server" ID="txtComment" /><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                            runat="server" Text="*" ControlToValidate="txtComment" ErrorMessage="Comments are required"></asp:RequiredFieldValidator><br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ForeColor="Red" ID="lblResult"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button runat="server" ID="btnSubmit" CausesValidation="True" OnClick="btnSubmit_Click"
                                        Text="Post Comment" />
                                </td>
                            </tr>
                        </table>
                        <div>
                            <span>1000 characters available</span>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
    <div>
        <asp:ListView runat="server">
            <LayoutTemplate>
                <ul id="itemPlaceholder" runat="server">
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>
                    <table>
                        <tr>
                            <td>
                                <a runat="server" id="hyperVideo">
                                    <asp:Image runat="server" ID="imgVideo" />
                                </a>
                            </td>
                            <td>
                                <div>
                                </div>
                            </td>
                        </tr>
                    </table>
                </li>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
