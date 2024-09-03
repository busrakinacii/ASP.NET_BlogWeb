<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimler.aspx.cs" Inherits="BlogWeb.AdminEgitimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

       <form id="form" runat="server">
       <table class="table table-bordered">
           <tr>
               <th>ID</th>
               <th>BAŞLIK</th>
               <th>ALT BAŞLIK</th>
               <th>AÇIKLAMA</th>
               <th>GENEL NOT</th>
               <th>TARİH</th>
               <th>İŞLEMLER</th>
           </tr>
           <tbody>
               <asp:Repeater ID="Repeater1" runat="server">
                   <ItemTemplate>
                       <tr>
                           <td><%#Eval("ID") %></td>
                           <td><%#Eval("BASLIK") %></td>
                           <td><%#Eval("ALTBASLIK") %></td>
                           <td><%#Eval("ACIKLAMA") %></td>
                           <td><%#Eval("GNOT") %></td>
                           <td><%#Eval("TARIH") %></td>
                           <td>
                               <asp:HyperLink NavigateUrl='<%# "AdminEgitimSil.aspx?ID="+ Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                               <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink>
                           </td>
                       </tr>
                   </ItemTemplate>
               </asp:Repeater>
           </tbody>
       </table>
       <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">EĞİTİM EKLE</asp:HyperLink>
   </form>

</asp:Content>
