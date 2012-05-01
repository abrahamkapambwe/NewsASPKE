<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="ContactUs.aspx.cs" Inherits="NewsSite.Views.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding: 10px">
        <br />
        <br />
        <div runat="server" id="divMessage">
            <table>
                <tr>
                    <td valign="middle">
                        First name*<br />
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtName"></asp:TextBox><asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3" ControlToValidate="txtName" Text="Name is required"
                            runat="server" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Surname<br />
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtSurname"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone*<br />
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtPhone"></asp:TextBox><asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2" ControlToValidate="txtPhone" Text="Contact phone is required"
                            runat="server" ErrorMessage="Contact phone is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email*
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtEmail"></asp:TextBox><asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" Text="Email is required"
                            ErrorMessage="Email is required"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                                ID="RegularExpressionValidator1" ControlToValidate="txtEmail" Text="Invalid email address"
                                runat="server" ErrorMessage="Invalid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        Tell us the reason of getting in touch
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtTellUs"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Comment*
                    </td>
                    <td>
                        <asp:TextBox runat="server" CssClass="textbox" ID="txtComment" MaxLength="200" Height="200px"
                            TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtComment"
                            Text="Comment is required" ErrorMessage="Comment is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="bntSubmit" Text="Submit" OnClick="Submit_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div id="divStatus" runat="server" visible="false">
            <asp:Label runat="server" ID="labMessage"></asp:Label>
        </div>
    </div>
    <br />
</asp:Content>
