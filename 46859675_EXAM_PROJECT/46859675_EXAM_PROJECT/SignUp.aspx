<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="_46859675_EXAM_PROJECT.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 84px;
        }
        .auto-style4 {
            height: 84px;
            width: 302px;
        }
        .auto-style5 {
            width: 302px;
        }
        .auto-style6 {
            height: 26px;
            width: 302px;
        }
        .auto-style7 {
            height: 84px;
            width: 1003px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="full-screen-table">
                <tr>
                    <td class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                    </td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnHomeSUP" runat="server" CssClass="buttonIcon" OnClick="btnHomeSUP_Click" Text="Home" CausesValidation="False" ToolTip="Press to navigate to home page." />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btnSignInSUP" runat="server" CssClass="buttonIconHiglight" OnClick="btnSignInSUP_Click" Text="Sign In" CausesValidation="False" TabIndex="1" ToolTip="Press to navigate to sign-in page." />
                        </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblPageNameSUP" runat="server" CssClass="textHeadingLeft" Text="Sign Up Page"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblWelcomeSU" runat="server" CssClass="textSubHeadingLeft" Text="Welcome!"></asp:Label>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblSubHeadingSU" runat="server" CssClass="textSubHeadingLeft" Text="Please enter your details to sign up"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td aria-selected="undefined" colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblNameSU" runat="server" CssClass="textBodyLeft" Text="Name"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:TextBox ID="tbNameSU" runat="server" CssClass="textBoxRounded" TabIndex="2" ToolTip="Enter your name."></asp:TextBox>
                        </td>
                    <td class="auto-style2" colspan="3">
                        <asp:RequiredFieldValidator ID="rfvNameSU" runat="server" ControlToValidate="tbNameSU" CssClass="textErrorBody" ErrorMessage="Please enter your name."></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblSurnameSU" runat="server" CssClass="textBodyLeft" Text="Surname"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbSurnameSU" runat="server" CssClass="textBoxRounded" TabIndex="3" ToolTip="Enter your surname."></asp:TextBox>
                        </td>
                    <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvSurnameSu" runat="server" ControlToValidate="tbSurnameSU" CssClass="textErrorBody" ErrorMessage="Please enter  your surname."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblContactNumSU" runat="server" CssClass="textBodyLeft" Text="Contact Number"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbContactSU" runat="server" CssClass="textBoxRounded" TabIndex="4" ToolTip="Enter your contact number."></asp:TextBox>
                        </td>
                    <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvCContactNumberSU" runat="server" ControlToValidate="tbContactSU" CssClass="textErrorBody" ErrorMessage="Please enter  your contact number."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblEmailSU" runat="server" ClientIDMode="Static" CssClass="textBodyLeft" Text="E-Mail Address"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbEmailSU" runat="server" CssClass="textBoxRounded" TabIndex="5" ToolTip="Enter your e-mail address."></asp:TextBox>
                        </td>
                    <td colspan="3">
                        <asp:RegularExpressionValidator ID="revEmailSU" runat="server" ControlToValidate="tbEmailSU" CssClass="textErrorBody" ErrorMessage="Please enter your e-mail address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblPasswordSU" runat="server" CssClass="textBodyLeft" Text="Password"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbPasswordSU" runat="server" CssClass="textBoxRounded" EnableViewState="False" TabIndex="6" ToolTip="Enter your password."></asp:TextBox>
                        </td>
                    <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="tbPasswordSU" CssClass="textErrorBody" ErrorMessage="Please enter your password."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblAllergiesSU" runat="server" CssClass="textBodyLeft" Text="Allergies"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbAllergiesSU" runat="server" CssClass="textBoxRounded" TabIndex="7" ToolTip="Enter your allergies."></asp:TextBox>
                        </td>
                    <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvAllergiesSU" runat="server" ControlToValidate="tbAllergiesSU" CssClass="textErrorBody" ErrorMessage="Please enter your allergies."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblEmergencyContactSU" runat="server" CssClass="textBodyLeft" Text="Emergency Contact"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbEmergencyContactSU" runat="server" CssClass="textBoxRounded" TabIndex="8" ToolTip="Enter your emergency contact."></asp:TextBox>
                        </td>
                    <td aria-orientation="horizontal" colspan="3">
                        <asp:RequiredFieldValidator ID="rvfEmergencyContactSU" runat="server" ControlToValidate="tbEmergencyContactSU" CssClass="textErrorBody" ErrorMessage="Please enter your emergency contact."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblIDNumebrSUP" runat="server" CssClass="textBodyLeft" Text="ID Number"></asp:Label>
                    </td>
                    <td aria-orientation="horizontal" colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbIDNumSUP" runat="server" CssClass="textBoxRounded" TabIndex="9" ToolTip="Enter your ID number."></asp:TextBox>
                        </td>
                    <td aria-orientation="horizontal" colspan="3">
                        <asp:RequiredFieldValidator ID="rvfIDNumSUP" runat="server" ControlToValidate="tbIDNumSUP" CssClass="textErrorBody" ErrorMessage="Please enter your ID number."></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td aria-orientation="horizontal" colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="btnSignUpSU" runat="server" CssClass="buttonRounded" OnClick="btnSignUpSU_Click" Text="Sign Up" TabIndex="10" ToolTip="Press to sign-up." />
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblErrorSUP" runat="server" CssClass="textErrorBody"></asp:Label>
                    </td>
                    <td colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
