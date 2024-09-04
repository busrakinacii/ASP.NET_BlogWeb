<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HobiGuncelle.aspx.cs" Inherits="BlogWeb.HobiGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="form" runat="server">
        <div class="form-group">
            <div style="margin-top: 10px">
                <asp:Label ID="ID" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Hobi" runat="server" Text="HOBİ"></asp:Label>
                <asp:TextBox ID="TxtHobi" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div style="margin-top: 10px">
                <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="BtnGuncelle_Click" />
            </div>

        </div>
    </form>

</asp:Content>
