<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebFormEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-top: 0px;
        }
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 93%;
        }
        .auto-style5 {
            width: 27%;
            height: 26px;
        }
        .auto-style6 {
            width: 684px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            width: 8%;
        }
        .auto-style8 {
            width: 27%;
        }
        .auto-style11 {
            width: 8%;
        }
        .auto-style12 {
            height: 26px;
            width: 38%;
        }
        .auto-style13 {
            width: 684px;
        }
        .auto-style14 {
            width: 38%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            EMPLOYEE MAINTENANCE</div>
        <p>
&nbsp;&nbsp;
            <table class="auto-style2">
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">Employee Number</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxEMployeeNumber" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" Width="74px" />
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" Width="77px" />
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxJobTitle" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:Button ID="ButtonListAll" runat="server" OnClick="ButtonListAll_Click" Text="List All" Width="79px" />
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="LabelEmployeeNumber" runat="server" Text="Enter Employee Number"></asp:Label>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Search By</td>
                    <td class="auto-style6">
                    <asp:DropDownList ID="DropDownListEmployee" runat="server" Width="193px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">
                        <input id="TextEmployeeNumber" type="text" /></td>
                    <td class="auto-style7">
                        <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridViewEmployee" runat="server" Height="187px" Width="1072px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
