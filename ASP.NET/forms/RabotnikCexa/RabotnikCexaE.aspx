﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="RabotnikCexaE.aspx.cs" Inherits="IIS.АСУ_Кондитерская.РаботникЦехаE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Работник цеха</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlТабельныйНомерLabel" runat="server" Text="Табельный номер" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlТабельныйНомер" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

<asp:RequiredFieldValidator ID="ctrlТабельныйНомерRequiredFieldValidator" runat="server" ControlToValidate="ctrlТабельныйНомер"
                            ErrorMessage="Не указано: ТабельныйНомер" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlФамилияLabel" runat="server" Text="Фамилия" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlФамилия" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlФамилияRequiredFieldValidator" runat="server" ControlToValidate="ctrlФамилия"
                            ErrorMessage="Не указано: Фамилия" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlИмяLabel" runat="server" Text="Имя" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlИмя" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlИмяRequiredFieldValidator" runat="server" ControlToValidate="ctrlИмя"
                            ErrorMessage="Не указано: Имя" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlОтчествоLabel" runat="server" Text="Отчество" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlОтчество" runat="server">
</asp:TextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЛогинLabel" runat="server" Text="Логин" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlЛогин" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlЛогинRequiredFieldValidator" runat="server" ControlToValidate="ctrlЛогин"
                            ErrorMessage="Не указано: Логин" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlТелефонLabel" runat="server" Text="Телефон" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlТелефон" runat="server">
</asp:TextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЦехLabel" runat="server" Text="Цех" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxDropDown ID="ctrlЦех" CssClass="descTxt" runat="server" EnablePostBack="false"/>

<asp:RequiredFieldValidator ID="ctrlЦехRequiredFieldValidator" runat="server" ControlToValidate="ctrlЦех"
                            ErrorMessage="Не указано: Цех" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
