﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProjeEkle.aspx.cs" Inherits="BlogWeb.ProjeEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
    <form id="form" runat="server">
        <div class="form-group">
            <div style="margin-top: 10px">
                <asp:Label ID="Proje" runat="server" Text="PROJE"></asp:Label>
                <asp:TextBox ID="TxtProje" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div style="margin-top: 10px">
                <asp:Button ID="BtnKaydet" runat="server" Text="KAYDET" CssClass="btn btn-primary" OnClick="BtnKaydet_Click" />
            </div>

        </div>
    </form>


</asp:Content>
