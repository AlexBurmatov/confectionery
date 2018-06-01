﻿<%--flexberryautogenerated="false"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="CHekE.aspx.cs" Inherits="IIS.АСУ_Кондитерская.ЧекE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Чек</h2>
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
  <asp:Label CssClass="descLbl" ID="ctrlСостояниеLabel" runat="server" Text="Состояние" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlСостояние" CssClass="descTxt" runat="server">
	<asp:ListItem>Открытый</asp:ListItem>
<asp:ListItem>Закрытый</asp:ListItem>
<asp:ListItem>Отмененный</asp:ListItem>

</asp:DropDownList>
<asp:RequiredFieldValidator ID="ctrlСостояниеRequiredFieldValidator" runat="server" ControlToValidate="ctrlСостояние"
                            ErrorMessage="Не указано: Состояние" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlНомерLabel" runat="server" Text="Номер" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlНомер" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

<asp:RequiredFieldValidator ID="ctrlНомерRequiredFieldValidator" runat="server" ControlToValidate="ctrlНомер"
                            ErrorMessage="Не указано: Номер" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаЗаполненияLabel" runat="server" Text="Дата заполнения" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаЗаполнения" runat="server"/>
</div>
<asp:RequiredFieldValidator ID="ctrlДатаЗаполненияRequiredFieldValidator" runat="server" ControlToValidate="ctrlДатаЗаполнения"
                            ErrorMessage="Не указано: ДатаЗаполнения" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />
<ac:DatePickerValidator ID="ctrlДатаЗаполненияDatePickerValidator" runat="server" ControlToValidate="ctrlДатаЗаполнения" 
                        ErrorMessage="Введена некорректная дата: Дата заполнения." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСуммаLabel" runat="server" Text="Сумма" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlСумма" runat="server" Enabled="false">
</ac:DecimalTextBox>

<asp:RequiredFieldValidator ID="ctrlСуммаRequiredFieldValidator" runat="server" ControlToValidate="ctrlСумма"
                            ErrorMessage="Не указано: Сумма" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlИндивидуальныйЗаказLabel" runat="server" Text="Индивидуальный заказ" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxDropDown ID="ctrlИндивидуальныйЗаказ" CssClass="descTxt" runat="server" EnablePostBack="false"/>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПродавецLabel" runat="server" Text="Продавец" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxDropDown ID="ctrlПродавец" CssClass="descTxt" runat="server" EnablePostBack="false"/>

<asp:RequiredFieldValidator ID="ctrlПродавецRequiredFieldValidator" runat="server" ControlToValidate="ctrlПродавец"
                            ErrorMessage="Не указано: Продавец" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlПримечаниеLabel" runat="server" Text="Примечание" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlПримечание" runat="server">
</asp:TextBox>


</div>
<asp:ScriptManager ID="ScriptManager1" runat="server" >
</asp:ScriptManager>

<div style="clear: left">
	<ac:AjaxGroupEdit ID="ctrlПозицияВЧеке" runat="server" ReadOnly="false" />
</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
