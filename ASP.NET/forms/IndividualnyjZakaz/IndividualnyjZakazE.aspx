﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="IndividualnyjZakazE.aspx.cs" Inherits="IIS.АСУ_Кондитерская.ИндивидуальныйЗаказE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Индивидуальный заказ</h2>
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
	<asp:ListItem>Новый</asp:ListItem>
<asp:ListItem>Выполненный</asp:ListItem>
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
  <asp:Label CssClass="descLbl" ID="ctrlФИОЗаказчикаLabel" runat="server" Text="ФИО заказчика" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlФИОЗаказчика" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlФИОЗаказчикаRequiredFieldValidator" runat="server" ControlToValidate="ctrlФИОЗаказчика"
                            ErrorMessage="Не указано: ФИОЗаказчика" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСрокБрониLabel" runat="server" Text="Срок брони (дней)" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlСрокБрони" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

<asp:RequiredFieldValidator ID="ctrlСрокБрониRequiredFieldValidator" runat="server" ControlToValidate="ctrlСрокБрони"
                            ErrorMessage="Не указано: СрокБрони" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаПоступленияLabel" runat="server" Text="Дата поступления" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаПоступления" runat="server"/>
</div>
<ac:DatePickerValidator ID="ctrlДатаПоступленияDatePickerValidator" runat="server" ControlToValidate="ctrlДатаПоступления" 
                        ErrorMessage="Введена некорректная дата: Дата поступления." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlСтоимостьLabel" runat="server" Text="Стоимость" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlСтоимость" runat="server">
</ac:DecimalTextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlТорговаяТочкаLabel" runat="server" Text="Торговая точка" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlТорговаяТочка" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />


</div>
<asp:ScriptManager ID="ScriptManager1" runat="server" >
</asp:ScriptManager>

<div style="clear: left">
	<ac:AjaxGroupEdit ID="ctrlСтрокаЗаказа" runat="server" ReadOnly="false" />
</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
