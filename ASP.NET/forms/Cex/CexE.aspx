﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="CexE.aspx.cs" Inherits="IIS.АСУ_Кондитерская.ЦехE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Цех</h2>
        <div class="<%= Constants.FormToolbarCssClass  + " " +  Constants.EditFormToolbarCssClass + " " + Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlАдресLabel" runat="server" Text="Адрес" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlАдрес" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlАдресRequiredFieldValidator" runat="server" ControlToValidate="ctrlАдрес"
                            ErrorMessage="Не указано: Адрес" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКоличествоLabel" runat="server" Text="Количество продукции на складе" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlКоличество" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>


</div>
<asp:ScriptManager ID="ScriptManager1" runat="server" >
</asp:ScriptManager>

<div style="clear: left">
	<ac:AjaxGroupEdit ID="ctrlГотовыйПродукт" runat="server" ReadOnly="false" />
</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
