<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="_46859675_EXAM_PROJECT.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style11 {
            width: 29px;
        }
        .auto-style12 {
            width: 339px;
        }
        .auto-style13 {
            width: 1004px;
        }
        .auto-style17 {
            width: 32px;
        }
        .auto-style18 {
            width: 339px;
            height: 50px;
        }
        .auto-style19 {
            height: 50px;
        }
        .auto-style20 {
            width: 29px;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="full-screen-table">
            <tr>
                <td class="auto-style12">
                        <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                    </td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">
                        &nbsp;</td>
                <td>
                        <asp:Button ID="btnHomeSIP" runat="server" CssClass="buttonIcon" OnClick="btnHomeSIP_Click" Text="Home" CausesValidation="False" ToolTip="Press to navigate to home page." />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnSignUp" runat="server" CausesValidation="False" CssClass="buttonIcon" Text="Sign Up" TabIndex="2" ToolTip="Press to navigate to sign-up page." OnClick="btnSignUp_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                        &nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">
                        &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Label ID="lblPageNameSIP" runat="server" CssClass="textHeadingLeft" Text="Sign In Page"></asp:Label>
                </td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">
                        &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style11">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Label ID="lblWelcomeBackHeadingSingIn" runat="server" Text="Welcome Back!" CssClass="textSubHeadingLeft" TabIndex="3"></asp:Label>
                    </td>
                <td colspan="3">
                        &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                        <asp:Label ID="lblSubHeadingSignIn" runat="server" CssClass="textSubHeadingLeft" Text="Please enter your details to sign in" TabIndex="4"></asp:Label>
                    </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Label ID="lblEmailAddressSI" runat="server" CssClass="textBodyLeft" Text="E-Mail Address" TabIndex="5"></asp:Label>
                    </td>
                <td colspan="3">
                        &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:TextBox ID="tbEmailSI" runat="server" CssClass="textBoxRounded" TabIndex="5" ToolTip="Enter your e-mail address."></asp:TextBox>
                        </td>
                <td colspan="3">
                        <asp:RegularExpressionValidator ID="revEmailSIP" runat="server" ControlToValidate="tbEmailSI" CssClass="textErrorBody" ErrorMessage="Please enter your e-mail address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Label ID="lblPasswordSI" runat="server" CssClass="textBodyLeft" Text="Password"></asp:Label>
                    </td>
                <td colspan="3">
                        &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:TextBox ID="tbPasswordSI" runat="server" CssClass="textBoxRounded" ValidationGroup="Enter your password." ToolTip="Enter your password."></asp:TextBox>
                        </td>
                <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvPasswordSIP" runat="server" ControlToValidate="tbPasswordSI" CssClass="textErrorBody" ErrorMessage="Please enter your password."></asp:RequiredFieldValidator>
                    </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">
                        &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Button ID="btnSiginIn" runat="server" CssClass="buttonRounded" OnClick="btnSiginIn_Click" Text="Sign In" TabIndex="8" ToolTip="Press to sign in." />
                    </td>
                <td colspan="3">
                        <asp:Label ID="lblErrorInvalidSIP" runat="server" CssClass="textErrorBody"></asp:Label>
                    </td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                        <asp:Label ID="lblNoAccSi" runat="server" Text="Don't have an account yet? " CssClass="textBodyLeft"></asp:Label>
                    <asp:HyperLink ID="hlSignUpSIP" runat="server" CssClass="textBodyLeft" NavigateUrl="~/SignUp.aspx" TabIndex="9" ToolTip="Click to navigate to sign-up page.">Sign Up</asp:HyperLink>
                </td>
                <td colspan="3">
                        &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style19" colspan="3"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
