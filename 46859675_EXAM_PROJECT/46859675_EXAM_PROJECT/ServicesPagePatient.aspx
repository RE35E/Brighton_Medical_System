<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServicesPagePatient.aspx.cs" Inherits="_46859675_EXAM_PROJECT.ServicesPagePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" /> 
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 42px;
        }
        .auto-style3 {
            width: 908px;
        }
        .auto-style4 {
            height: 42px;
            width: 908px;
        }
        .auto-style5 {
            height: 24px;
        }
        .auto-style6 {
            width: 908px;
            height: 24px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 908px;
            height: 26px;
        }
        .auto-style9 {
            height: 36px;
        }
        .auto-style11 {
            width: 2500px;
            height: 50px;
        }
        .auto-style12 {
            height: 50px;
        }
        .auto-style13 {
            width: 908px;
            height: 50px;
        }
        .auto-style14 {
            width: 908px;
            height: 50px;
            font-family: Arial;
            font-size: 16pt;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="full-screen-table">
            <tr>
                <td class="auto-style12">
                    <asp:Image ID="imageLogoSPP" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                </td>
                <td class="auto-style11">
                </td>
                <td class="auto-style13">
                    &nbsp;</td>
                <td class="auto-style14">
                    <asp:Button ID="btnHomeSPP" runat="server" CssClass="buttonIcon" OnClick="btnHomeSPP_Click" Text="Home" ToolTip="Press to navigate to home page." />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="btnAppointmentSPP" runat="server" CssClass="buttonIconHiglight" OnClick="btnAppointmentSPP_Click" Text="Appointment" TabIndex="1" ToolTip="Press to navigate to appointment page." />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnAccountSPP" runat="server" CssClass="buttonIcon" OnClick="btnAccountSPP_Click" Text="Account" TabIndex="2" ToolTip="Press to navigate to account page." />
                </td>
            </tr>
            <tr>
                <td colspan="5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblPageNameSPP" runat="server" CssClass="textHeadingLeft" Text="Service Page"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblGenerateQuatationSPP" runat="server" Text="Generate Invoice" CssClass="textSubHeadingLeft"></asp:Label>
                </td>
                <td class="auto-style4" colspan="4">
                    &nbsp;</td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style4" colspan="4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="5">
                    <asp:Label ID="lblHowManySPP" runat="server" CssClass="textBodyLeft" Text="How many patients would you like to get a quote for?"></asp:Label>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rbOneSPP" runat="server" CssClass="checkBox" GroupName="NumPatients" Text="1" TabIndex="3" ToolTip="Click to add 1 person to quotation." />
                    <asp:RadioButton ID="rbTwoSPP" runat="server" CssClass="checkBox" GroupName="NumPatients" Text="2" TabIndex="4" ToolTip="Click to add 2 people to quotation." />
                    <asp:RadioButton ID="rbThreeSSP" runat="server" CssClass="checkBox" GroupName="NumPatients" Text="3" TabIndex="5" ToolTip="Click to add 3 people to quotation." />
                    <asp:RadioButton ID="rbFourSPP" runat="server" CssClass="checkBox" GroupName="NumPatients" Text="4" TabIndex="6" ToolTip="Click to add 4 people to quotation." />
                </td>
                <td class="auto-style3" colspan="4">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13" colspan="4">
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:Label ID="lblHowmanyServiceSPP" runat="server" CssClass="textBodyLeft" Text="Which services would you like to add to the quote?"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="lblProcedureSPP" class="auto-style5">
                    <asp:CheckBox ID="cbSugicalAppointmentSPP" runat="server" CssClass="checkBox" Text="Surgical Appointment" TabIndex="7" ToolTip="Click to add service to quotation." />
                </td>
                <td id="lblProcedureSPP" class="auto-style6" colspan="2">
                    &nbsp;</td>
                <td id="lblProcedureSPP" class="auto-style6" colspan="2"></td>
                <td id="lblProcedureSPP" class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="3">
                    <asp:CheckBox ID="cbLabSPP" runat="server" CssClass="checkBox" Text="Labratory / Medical Result  Analysis" TabIndex="8" ToolTip="Click to add service to quotation." />
                </td>
                <td class="auto-style8" colspan="2"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:CheckBox ID="cbRoutineCheckUpSSP" runat="server" CssClass="checkBox" Text="Routine Check-Up" TabIndex="9" ToolTip="Click to add service to quotation."/>
                </td>
                <td class="auto-style8" colspan="2">
                    &nbsp;</td>
                <td class="auto-style8" colspan="2">&nbsp;</td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="cbUrgentSSP" runat="server" CssClass="checkBox" Text="Urgent Medical Check-Up" TabIndex="10" ToolTip="Click to add service to quotation." />
                </td>
                <td class="auto-style3" colspan="2">
                    &nbsp;</td>
                <td class="auto-style3" colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                </td>
                <td class="auto-style13" colspan="2">
                    </td>
                <td class="auto-style13" colspan="2"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="btnGetQuotation" runat="server" CssClass="buttonRounded" OnClick="btnGetQuotation_Click" Text="Generate Invoice" TabIndex="11" ToolTip="Press to generate a invoice." />
                    </td>
                <td class="auto-style13" colspan="4">
                    <asp:Label ID="lblErrorSPP" runat="server" CssClass="textErrorBody"></asp:Label>
                </td>
                <td class="auto-style12">
                    </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style3" colspan="4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblQuotationTicketSPP" runat="server" CssClass="textSubHeadingLeft" Text="Invoice Ticket"></asp:Label>
                </td>
                <td class="auto-style3" colspan="4">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:ListBox ID="lbDisplayQuotationSPP" runat="server" Height="241px" Width="100%"></asp:ListBox>
                </td>
            </tr>
            </table>
    </form>
</body>
</html>
