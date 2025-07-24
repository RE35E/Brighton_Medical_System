<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppointmentsPatients.aspx.cs" Inherits="_46859675_EXAM_PROJECT.AppointmentsPatients" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 429px;
        }
        .auto-style4 {
            height: 156px;
        }
        .auto-style5 {
            width: 458px;
        }
        .auto-style7 {
            width: 429px;
            height: 67px;
            text-align: right;
        }
        .auto-style8 {
            width: 458px;
            height: 67px;
        }
        .auto-style12 {
            width: 429px;
            height: 68px;
            text-align: right;
        }
        .auto-style13 {
            width: 458px;
            height: 68px;
        }
        .auto-style15 {
            width: 429px;
            text-align: right;
        }
        .auto-style19 {
            width: 429px;
            height: 50px;
        }
        .auto-style20 {
            width: 458px;
            height: 50px;
        }
        .auto-style21 {
            height: 50px;
        }
        .auto-style22 {
            width: 429px;
            text-align: right;
            height: 242px;
        }
        .auto-style23 {
            width: 458px;
            height: 242px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<table class="full-screen-table">
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="imageLogoAPP" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnHomeAPP" runat="server" CssClass="buttonIcon" OnClick="btnHomeAPP_Click" Text="Home" CausesValidation="False" ToolTip="Press to navigate to home page." />
                    </td>
                    <td>
                        <asp:Button ID="btnServicesAPP" runat="server" CssClass="buttonIconHiglight" Text="Services" OnClick="btnServicesAPP_Click" TabIndex="1" ToolTip="Press to navigate to service page." />
                    </td>
                    <td>
                        <asp:Button ID="btnAccountAPP" runat="server" CssClass="buttonIcon" Text="Account" OnClick="btnAccountAPP_Click" TabIndex="2" ToolTip="Press to navigate to account page." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="lblDescriptionAPP" runat="server" CssClass="textHeadingLeft" Text="Appointment Page"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label ID="lblHeadingAPP" runat="server" CssClass="textSubHeadingLeft" Text="Hello Name and Surname"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblAppointmentsAPP" runat="server" CssClass="textSubHeadingLeft" Text="Appointments"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="5">
                        <asp:GridView ID="dgwDisplayAppoinmentsAPP" runat="server" CssClass="gridView" Width="100%">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21" colspan="5">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblMakeAppAPP" runat="server" CssClass="textSubHeadingLeft" Text="Make Appointments"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="lblSelectedDateAPP" runat="server" CssClass="textBodyLeft" Text="Selected Date:"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="lblDateSelectedAPP" runat="server" CssClass="textBodyLeft"></asp:Label>
                    </td>
                    <td rowspan="5" colspan="3">
                        <asp:Calendar ID="myCalMakeAppointmentsAPP" runat="server" OnSelectionChanged="myCalMakeAppointmentsAPP_SelectionChanged" CssClass="calendar" Width="100%" ToolTip="Choose date."></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblTimeAPP" runat="server" CssClass="textBodyLeft" Text="Time:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlTimeAPP" runat="server" CssClass="textBoxRounded" TabIndex="3" ToolTip="Choose a time.">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblServicerAPP" runat="server" CssClass="textBodyLeft" Text="Service:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlServicesAPP" runat="server" CssClass="textBoxRounded" Height="50px" TabIndex="4" ToolTip="Choose a service.">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:Label ID="lblDoctorAPP" runat="server" CssClass="textBodyLeft" Text="Doctor:"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:DropDownList ID="ddlDoctorApp" runat="server" CssClass="buttonRounded" TabIndex="5" ToolTip="Choose a doctor.">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnMakeAppointmentAPP" runat="server" CssClass="buttonRounded" OnClick="btnMakeAppointmentAPP_Click" Text="Make Appointment" TabIndex="6" ToolTip="Press to make a new appointment." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblMoveAppointmentAPP" runat="server" CssClass="textSubHeadingLeft" Text="Move Appointments"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblAppointmentIDAPP" runat="server" CssClass="textBodyLeft" Text="Appointment ID:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="tbAppointmentIDAPP" runat="server" CssClass="textBoxRounded" TabIndex="7" ToolTip="Insert appointment ID."></asp:TextBox>
                    </td>
                    <td rowspan="4" colspan="3">
                        <asp:Calendar ID="myCalMakeMoveAppointmentsAPP" runat="server" OnSelectionChanged="myCalMakeMoveAppointmentsAPP_SelectionChanged" CssClass="calendar" Width="100%" ToolTip="Choose date."></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblNewTimeAPP" runat="server" CssClass="textBodyLeft" Text="New Time:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlMoveTimeAPP" runat="server" CssClass="buttonRounded" TabIndex="8" ToolTip="Choose a time.">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblNewDateAPP" runat="server" CssClass="textBodyLeft" Text="New Date:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblNewMoveDateAPP" runat="server" CssClass="textBodyLeft"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style5">
                        <asp:Button ID="btnMoveAPP" runat="server" CssClass="buttonRounded" Text="Move" OnClick="btnMoveAPP_Click" TabIndex="9" ToolTip="Press to move appointment." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblErrorAPP" runat="server" CssClass="textErrorBody"></asp:Label>
                    </td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="lblCanxelAppointmentAPP" runat="server" CssClass="textSubHeadingLeft" Text="Remove Appointments"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                    <td colspan="3" class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="lblCancelIdAPP" runat="server" CssClass="textBodyLeft" Text="Appointment ID:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbCancelIdAPP" runat="server" CssClass="textBoxRounded" TabIndex="10" ToolTip="Enter appointment ID."></asp:TextBox>
                    </td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnRemovePP" runat="server" CssClass="buttonRounded" OnClick="btnCancelAPP_Click" Text="Remove" TabIndex="11" ToolTip="Press to remove appointment." />
                    </td>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        </td>
                    <td class="auto-style20">
                        </td>
                    <td colspan="3" class="auto-style21">
                        </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblContactUsHPP" runat="server" Text="Contact Us" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:Label ID="lblSoscialMediahpp" runat="server" Text="Social Media" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblAddressAPP" runat="server" CssClass="textBodyLeft" Text="Address: 123 Medical Street, Boksburg, 1459"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:Label ID="lblFacbiikAPP" runat="server" CssClass="textBodyLeft" Text="Facebook: @BrightonMedicalClinic"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="blPhoneAPP" runat="server" CssClass="textBodyLeft" Text="Phone: +27 123 456 789"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:Label ID="lblInstagramAPP" runat="server" CssClass="textBodyLeft" Text="Instagram: @BrightonMedical"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblEmailAPP" runat="server" CssClass="textBodyLeft" Text="Email: info@brightonmedical.com"></asp:Label>
                    </td>
                    <td colspan="3">
                        <asp:Label ID="lblTwitterAPP" runat="server" CssClass="textBodyLeft" Text="Twitter: @BrightonMed"></asp:Label>
                    </td>
                </tr>
                </table>
        </div>
    <p>
&nbsp;&nbsp;
    </p>
    </form>
    </body>
</html>
