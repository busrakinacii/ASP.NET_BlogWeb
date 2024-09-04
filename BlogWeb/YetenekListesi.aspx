<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekListesi.aspx.cs" Inherits="BlogWeb.YetenekListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>YETENEKLER</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("ID") %></td>
                            <td><%#Eval("YETENEK") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "YetenekSil.aspx?ID="+ Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "YetenekGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/YetenekEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">YETENEK EKLE</asp:HyperLink>
    </form>

</asp:Content>
