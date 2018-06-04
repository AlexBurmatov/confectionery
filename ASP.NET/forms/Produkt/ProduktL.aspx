﻿<%--flexberryautogenerated="true"--%>

<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProduktL.aspx.cs" Inherits="IIS.АСУ_Кондитерская.ПродуктL" %>

<%@ Import Namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " + Constants.ListFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.ListFormHeaderCssClass %>">Продукт</h2>
        <div >
            <asp:Label CssClass="descLbl" ID="ctrlСреднняяСтоимостьLabel" runat="server" Text="Средняя стоимость 1 кг продукции: " EnableViewState="False">
            </asp:Label>
            <asp:TextBox CssClass="descTxt" Width="60" ID="descAverPrice" runat="server" Enabled="false">
            </asp:TextBox>
            <asp:Label CssClass="descLbl" ID="Label1" runat="server" Text="руб. " EnableViewState="False">
            </asp:Label>
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.ListFormControlsCssClass %>">
            <ac:WebObjectListView ID="WebObjectListView1" runat="server" Visible="true" />
        </div>
    </div>
</asp:Content>
