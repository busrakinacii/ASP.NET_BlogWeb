<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProjeListesi.aspx.cs" Inherits="BlogWeb.ProjeListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <form id="form" runat="server">
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>PROJELER</th>
                <th>İŞLEMLER</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <itemtemplate>
                        <tr>
                            <td><%#Eval("ID") %></td>
                            <td><%#Eval("PROJELER") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "ProjeSil.aspx?ID="+ Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "ProjeGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                            </td>
                        </tr>
                    </itemtemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <asp:HyperLink NavigateUrl="~/ProjeEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">PROJE EKLE</asp:HyperLink>
    </form>

</asp:Content>
