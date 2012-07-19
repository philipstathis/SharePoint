<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSolution.aspx.cs" Inherits="ApplicationPage.Layouts.ApplicationPage.AddSolution" DynamicMasterPageFile="~masterurl/default.master" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">

</asp:Content>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
<asp:Label runat="server" ID="status"></asp:Label>
<br />
<br />
<asp:FileUpload ID="RFPFile" runat="server" />
<asp:Button runat="server" id="Uploadrfpbtn" text="Upload" onclick="UploadRFP" />
<asp:Label ID="rfplabel" Visible="false"  Font-Bold="true" ForeColor="Red" runat="server" />
<asp:Button runat="server" id="uploadnewrfp" Visible="false" text="Re-Upload" onclick="ReUploadRFP" />
<br />
<br />
<asp:Button ID="add" runat="server" Text="Add Solution" onclick="AddingSolution"/>
<asp:Button ID="Button1" runat="server" Text="Solution Store" PostBackUrl="~/_admin/Solutions.aspx" />
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
AddSolution
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
Add Solution
</asp:Content>
