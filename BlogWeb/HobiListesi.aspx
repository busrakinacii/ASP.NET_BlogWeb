<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiListesi.aspx.cs" Inherits="BlogWeb.HobiListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>HOBİLER</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <td><%#Eval("ID") %></td>
                            <td><%#Eval("HOBI") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "HobiSil.aspx?ID="+ Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "HobiGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/HobiEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">HOBİ EKLE</asp:HyperLink>
    </form>

</asp:Content>
