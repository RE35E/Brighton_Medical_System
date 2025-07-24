<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePagePatient.aspx.cs" Inherits="_46859675_EXAM_PROJECT.HomePagePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel ="stylesheet" type="text/css" href="MyStyleSheet.css" />
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 53px;
            width: 334px;
        }
        .auto-style4 {
            width: 308px;
            height: 53px;
        }
        .auto-style5 {
            height: 43px;
            width: 334px;
        }
        .auto-style6 {
            width: 308px;
            height: 43px;
        }
        .auto-style18 {
            width: 308px;
            height: 79px;
        }
        .auto-style19 {
            width: 334px;
            height: 79px;
        }
        .auto-style21 {
            width: 334px;
            height: 139px;
        }
        .auto-style23 {
            height: 53px;
            width: 503px;
        }
        .auto-style24 {
            height: 43px;
            width: 503px;
        }
        .auto-style25 {
            width: 284px;
            height: 139px;
        }
        .auto-style26 {
            width: 503px;
            height: 79px;
        }
        .auto-style27 {
            width: 250px;
        }
        .auto-style28 {
            width: 308px;
        }
        .auto-style29 {
            width: 334px;
        }
        .auto-style30 {
            width: 640px;
        }
        .auto-style31 {
            width: 640px;
            height: 139px;
        }
        .auto-style32 {
            width: 427px;
        }
        .auto-style33 {
            width: 503px;
        }
        .auto-style34 {
            width: 503px;
            height: 139px;
        }
        .auto-style35 {
            width: 284px;
        }
        .auto-style36 {
            width: 1001px;
        }
        .auto-style37 {
            height: 50px;
        }
        .auto-style38 {
            height: 79px;
        }
        .auto-style40 {
            height: 53px;
        }
        .auto-style41 {
            width: 503px;
            height: 50px;
        }
        .auto-style42 {
            width: 308px;
            height: 50px;
        }
        .auto-style43 {
            width: 334px;
            height: 50px;
        }
    </style>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <div>
            <table class="full-screen-table">
                <tr>
                    <td class="auto-style33">
                        <asp:Image ID="logoHPP" runat="server" Height="80px" ImageUrl="~/logoBrightonMedical.jpg" Width="300px" />
                    </td>
                    <td class="auto-style36">
                        &nbsp;</td>
                    <td class="auto-style30">
                        &nbsp;</td>
                    <td class="auto-style35">
                        <asp:Button ID="btnServicesHPP" runat="server" CssClass="buttonIcon" Text="Services" OnClick="btnServicesHPP_Click" ToolTip="Press to navigate to service page." />
                    </td>
                    <td class="auto-style27">
                        <asp:Button ID="btnAppointmentsHPP" runat="server" CssClass="buttonIconHiglight" OnClick="btnAppointmentsHPP_Click" Text="Appointments" TabIndex="1" ToolTip="Press to navigate to appointment page." />
                    </td>
                    <td class="auto-style32">
                        <asp:Button ID="btnAccountHPP" runat="server" CssClass="buttonIcon" Text="Account" OnClick="btnAccountHPP_Click" TabIndex="3" ToolTip="Press to navigate to account page." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td class="auto-style36">
                        &nbsp;</td>
                    <td class="auto-style30">
                        &nbsp;</td>
                    <td class="auto-style35">
                        &nbsp;</td>
                    <td class="auto-style27">
                        &nbsp;</td>
                    <td class="auto-style32">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40" colspan="4">
                        <asp:Label ID="lblPageNameHPP" runat="server" CssClass="textHeadingLeft" Text="Home Page"></asp:Label>
                    </td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style40" colspan="4">
                        <asp:Label ID="lblWelcomHPP" runat="server" CssClass="textSubHeadingLeft" Text="Hello Name Surname"></asp:Label>
                    </td>
                    <td class="auto-style3" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style4" colspan="3">
                        &nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        <asp:Label ID="lblSubHeadingHPP" runat="server" Text="Your Appointments" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                    <td class="auto-style28" colspan="3">
                        &nbsp;</td>
                    <td class="auto-style29" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:GridView ID="dgwDisplayAppoinmentsHPP" runat="server" CellPadding="4" CssClass="gridView" ForeColor="#333333" GridLines="None" Width="100%">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style24">
                        <asp:Label ID="lblServiceOfferedHPP" runat="server" Text="Services Offered" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                    <td class="auto-style6" colspan="3">
                        &nbsp;</td>
                    <td class="auto-style5" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style37" colspan="6">
                        <asp:TextBox ID="tbServiceOneHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceTwoHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceThreeHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbServiceFourHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        &nbsp;</td>
                    <td class="auto-style31" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style21" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        <asp:Label ID="lblNewsHPP" runat="server" Text="News at Brighton Medical" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                    <td class="auto-style18" colspan="3">
                    </td>
                    <td class="auto-style19" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style38" colspan="6">
                        <asp:TextBox ID="tbNewsOneHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsTwoHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsThreeHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                        <asp:TextBox ID="tbNewsFourHPP" runat="server" CssClass="textBoxInfographic" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style18" colspan="3">
                        &nbsp;</td>
                    <td class="auto-style19" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        <asp:Label ID="lblErrorHPP" runat="server" CssClass="textErrorBody"></asp:Label>
                    </td>
                    <td class="auto-style28" colspan="3">
                        &nbsp;</td>
                    <td class="auto-style29" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblContactUsHPP" runat="server" Text="Contact Us" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                    <td class="auto-style29" colspan="2">
                        <asp:Label ID="lblSoscialMediahpp" runat="server" Text="Social Media" CssClass="textSubHeadingLeft"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblAddressHPP" runat="server" CssClass="textBodyLeft" Text="Address: 123 Medical Street, Boksburg, 1459"></asp:Label>
                    </td>
                    <td class="auto-style29" colspan="2">
                        <asp:Label ID="lblFacbiikHPP" runat="server" CssClass="textBodyLeft" Text="Facebook: @BrightonMedicalClinic"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="blPhoneHPP" runat="server" CssClass="textBodyLeft" Text="Phone: +27 123 456 789"></asp:Label>
                    </td>
                    <td class="auto-style29" colspan="2">
                        <asp:Label ID="lblInstagramHPP" runat="server" CssClass="textBodyLeft" Text="Instagram: @BrightonMedical"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblEmailHPP" runat="server" CssClass="textBodyLeft" Text="Email: info@brightonmedical.com"></asp:Label>
                    </td>
                    <td class="auto-style29" colspan="2">
                        <asp:Label ID="lblTwitterHPP" runat="server" CssClass="textBodyLeft" Text="Twitter: @BrightonMed"></asp:Label>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
