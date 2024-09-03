<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="BlogWeb.AdminEgitimGuncelle" %>

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
                <asp:Label ID="Ad" runat="server" Text="BAŞLIK"></asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Soyad" runat="server" Text="ALT BAŞLIK"></asp:Label>
                <asp:TextBox ID="TxtAltBaslik" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Aciklama" runat="server" Text="AÇIKLAMA"></asp:Label>
                <asp:TextBox ID="TxtAcıklama" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="GNot" runat="server" Text="GENEL NOT ORTALAMASI"></asp:Label>
                <asp:TextBox ID="TxtGNot" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Tarih" runat="server" Text="TARİH"></asp:Label>
                <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div style="margin-top: 10px">
                <asp:Button ID="BtnGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="BtnGuncelle_Click" />
            </div>

        </div>
    </form>

</asp:Content>
