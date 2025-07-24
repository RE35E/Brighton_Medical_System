<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountPagePatient.aspx.cs" Inherits="_46859675_EXAM_PROJECT.AccountPagePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" /> 
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 36px;
        }
        .auto-style3 {
            height: 68px;
        }
        .auto-style4 {
            height: 73px;
        }
        .auto-style5 {
            height: 54px;
        }
        .auto-style6 {
            height: 50px;
        }
        .auto-style7 {
            height: 54px;
            width: 26px;
        }
        .auto-style8 {
            height: 50px;
            width: 26px;
        }
        .auto-style9 {
            height: 36px;
            width: 26px;
        }
        .auto-style10 {
            width: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="full-screen-table">
            <tr>
                <td class="auto-style5">
                    <asp:Image ID="imageLogoACPP" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnHomeACPP" runat="server" CssClass="buttonIcon" OnClick="btnHomeACPP_Click" Text="Home" ToolTip="Press to navigate to home page." />
                    </td>
                <td class="auto-style5">
                    <asp:Button ID="btnServicesACPP" runat="server" CssClass="buttonIcon" OnClick="btnServicesACPP_Click" Text="Services" TabIndex="1" ToolTip="Press to navigate to service page." />
                    </td>
                <td class="auto-style5">
                    <asp:Button ID="btnAppointments" runat="server" CssClass="buttonIcon" OnClick="btnAppointments_Click" Text="Appointment" TabIndex="2" ToolTip="Press to navigate to appointment page." />
                    </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style8">
                    </td>
                <td class="auto-style6">
                    </td>
                <td class="auto-style6">
                    </td>
                <td class="auto-style6">
                    </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblPageName" runat="server" CssClass="textHeadingLeft" Text="Account Page"></asp:Label>
                </td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblHeadingACPP" runat="server" CssClass="textSubHeadingLeft"></asp:Label>
                </td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblDescriptionACPP" runat="server" CssClass="textSubHeadingLeft" Text="Please view your details and update if necessary"></asp:Label>
                </td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblNameACPP" runat="server" CssClass="textBodyLeft" Text="Name"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="tbNameACPP" runat="server" CssClass="textBoxRounded" TabIndex="3" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNameACPP" runat="server" ControlToValidate="tbNameACPP" CssClass="textErrorBody" ErrorMessage="Please enter your name."></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSurnameACPP" runat="server" CssClass="textBodyLeft" Text="Surname"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="tbSurnameACPP" runat="server" CssClass="textBoxRounded" TabIndex="4" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSurnameACPP" runat="server" ControlToValidate="tbSurnameACPP" CssClass="textErrorBody" ErrorMessage="Please enter your surname."></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmailACPP" runat="server" CssClass="textBodyLeft" Text="Email"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="tbEmailACPP" runat="server" CssClass="textBoxRounded" TabIndex="5" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmailACPP" runat="server" ControlToValidate="tbEmailACPP" CssClass="textErrorBody" ErrorMessage="Please enter your e-mail address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style2" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPasswordACPP" runat="server" CssClass="textBodyLeft" Text="Password"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbPasswordACPP" runat="server" CssClass="textBoxRounded" TabIndex="6" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPasswordACPP" runat="server" ControlToValidate="tbPasswordACPP" CssClass="textErrorBody" ErrorMessage="Please enter your password."></asp:RequiredFieldValidator>
                </td>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContactNumACPP" runat="server" CssClass="textBodyLeft" Text="Contact Number"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="tbCOntactNumACPP" runat="server" CssClass="textBoxRounded" TabIndex="7" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContactNumACPP" runat="server" ControlToValidate="tbCOntactNumACPP" CssClass="textErrorBody" ErrorMessage="Please enter your contact number."></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAllergiesACPP" runat="server" CssClass="textBodyLeft" Text="Allergies"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbAllergiesACPP" runat="server" CssClass="textBoxRounded" TabIndex="8" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfAllergiesACPP" runat="server" ControlToValidate="tbAllergiesACPP" CssClass="textErrorBody" ErrorMessage="Please enter your allergies."></asp:RequiredFieldValidator>
                </td>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmergencyContACPP" runat="server" CssClass="textBodyLeft" Text="Emergency Contact"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="tbEmergencyContactACPP" runat="server" CssClass="textBoxRounded" TabIndex="9" ToolTip="Type in new information if necessary."></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmergencyContactACPP" runat="server" ControlToValidate="tbAllergiesACPP" CssClass="textErrorBody" ErrorMessage="Please enter your emergency contact."></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblIDnumACPP" runat="server" CssClass="textBodyLeft" Text="ID Number"></asp:Label>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="tbIdNumACPP" runat="server" CssClass="textBoxRounded" ReadOnly="True" TabIndex="10" ToolTip="Type in new information if necessary."></asp:TextBox>
                </td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style2" colspan="3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpdateACPP" runat="server" CssClass="buttonRounded" OnClick="btnUpdateACPP_Click" Text="Update" TabIndex="11" ToolTip="Press to update information." />
                    <asp:Label ID="lblErrorACP" runat="server" CssClass="textErrorBody"></asp:Label>
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSignOuttACPP" runat="server" CssClass="buttonRounded" OnClick="btnLogoutACPP_Click" Text="Sign Out" TabIndex="12" ToolTip="Press to sign our." />
                </td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
