<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="BlogWeb.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form" runat="server">
        <div class="form-group">
            <div style="margin-top: 10px">
                <asp:Label ID="Ad" runat="server" Text="ADINIZ"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Soyad" runat="server" Text="SOYADINIZ"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Adres" runat="server" Text="ADRES"></asp:Label>
                <asp:TextBox ID="TxtAdres" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Mail" runat="server" Text="MAIL"></asp:Label>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Telefon" runat="server" Text="TELEFON"></asp:Label>
                <asp:TextBox ID="TxtTelefon" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="KisaNot" runat="server" Text="KISA NOT"></asp:Label>
                <asp:TextBox ID="TxtKisaNot" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Label ID="Fotograf" runat="server" Text="FOTOĞRAF"></asp:Label>
                <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Button ID="BtnGuncelle" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="BtnGuncelle_Click" /></div>

        </div>
    </form>
</asp:Content>
