 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_46859675_EXAM_PROJECT._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style8 {
            height: 49px;
            margin-left: 40px;
        }
        .auto-style10 {
            height: 49px;
            width: 180px;
        }
        .auto-style11 {
            height: 38px;
        }
        .auto-style12 {
            height: 50px;
            width: 850px;
        }
        .auto-style14 {
            width: 850px;
        }
        .auto-style15 {
            height: 26px;
            width: 850px;
        }
        .auto-style16 {
            height: 49px;
            width: 153px;
        }
        .auto-style17 {
            height: 49px;
        }
        .auto-style18 {
            width: 850px;
            height: 49px;
        }
        .auto-style19 {
            height: 59px;
        }
        .auto-style20 {
            height: 59px;
            width: 850px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="full-screen-table">
                <tr>
                    <td class="auto-style17">
                        <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                    </td>
                    <td class="auto-style18"></td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                    <td class="auto-style17">
                        <asp:Button ID="btnSignInLP" runat="server" CausesValidation="False" CssClass="buttonIconHiglight" OnClick="btnSignInLP_Click" Text="Sign In" ToolTip="Press to navigate to sign-in page." />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnSignUpLP" runat="server" CausesValidation="False" CssClass="buttonIcon" OnClick="btnSignUp_Click" Text="Sign Up" ToolTip="Press to navigate to sign-up page." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style12">&nbsp;</td>
                    <td colspan="4" class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="6">
                        <asp:Label ID="lblPageNameLP" runat="server" CssClass="textHeadingLeft" Text="Landing Page"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="6">
                        <asp:Label ID="lblAboutUsLP" runat="server" CssClass="textSubHeadingLeft" Text="About Us"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="6">
                        <asp:Label ID="lblInfographicLP" runat="server" CssClass="textBodyLeft"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style18"></td>
                    <td colspan="4" class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblServiceOffLP" runat="server" CssClass="textSubHeadingLeft" Text="Services Offered"></asp:Label>
                    </td>
                    <td class="auto-style12"></td>
                    <td colspan="4" class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="6">
                        <asp:TextBox ID="tbServiceOneLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceTwoLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceThreeLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceFourLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblNewsheadingLP" runat="server" CssClass="textSubHeadingLeft" Text="News At Brighton Medical"></asp:Label>
                    </td>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:TextBox ID="tbNewsOneLp" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsTwoLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsThreeLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsFourLP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style15"></td>
                    <td colspan="4" class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="lblContactUsLP" runat="server" CssClass="textSubHeadingLeft" Text="Contact Us"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                    <td colspan="4" class="auto-style19">
                        <asp:Label ID="lblSocialLP" runat="server" CssClass="textSubHeadingLeft" Text="Social Media"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="lblAddressLP" runat="server" CssClass="textBodyLeft" Text="Address: 123 Medical Street, Boksburg, 1459"></asp:Label>
                    </td>
                    <td colspan="4" class="auto-style3">
                        <asp:Label ID="lblFacbiikLP" runat="server" CssClass="textBodyLeft" Text="Facebook: @BrightonMedicalClinic"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="blPhoneLP" runat="server" CssClass="textBodyLeft" Text="Phone: +27 123 456 789"></asp:Label>
                    </td>
                    <td colspan="4" class="auto-style3">
                        <asp:Label ID="lblInstagramLP" runat="server" CssClass="textBodyLeft" Text="Instagram: @BrightonMedical"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="lblEmailLP" runat="server" CssClass="textBodyLeft" Text="Email: info@brightonmedical.com"></asp:Label>
                    </td>
                    <td colspan="4" class="auto-style3">
                        <asp:Label ID="lblTwitterLP" runat="server" CssClass="textBodyLeft" Text="Twitter: @BrightonMed"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td colspan="4" class="auto-style3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;</p>
    <p>
&nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
