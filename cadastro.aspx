<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="prj_series.cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="flex">
   <div class="conteudoHome">
      <table style=" padding-left:400px;">
         <tr>
            <td>
               Nome
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               E-mail
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               Senha
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtsenha" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               Confirmar Senha
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtsenha2" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <asp:Button ID="btnEntrar" runat="server" Text="Entrar"></asp:Button>
            </td>
         </tr>
         <tr>
            <td>
               <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
         </tr>
      </table>
   </div>
</div>

</asp:Content>
