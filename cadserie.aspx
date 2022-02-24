<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="cadserie.aspx.cs" Inherits="prj_series.cadserie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="flex">
   <div class="conteudoHome2">
      <table>
         <tr>
            <td>
               <h2>Nome da série</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtnmserie" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Nome original</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtnmor" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Descrição</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Situação</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtsit" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Elenco</h2>
            </td>
         </tr>
         <tr>
            <td>Principal
               <asp:TextBox ID="txtaprinc" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Principal 2 
               <asp:TextBox ID="txtaprinc2" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Coadjuvante 1 
               <asp:TextBox ID="txtacod" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Coadjuvante 2
               <asp:TextBox ID="txtacod2" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Personagens</h2>
            </td>
         </tr>
         <tr>
            <td>Principal
               <asp:TextBox ID="txtprinc" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Principal 2 
               <asp:TextBox ID="txtprinc2" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Coadjuvante 1 
               <asp:TextBox ID="txtcod" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>Coadjuvante 2
               <asp:TextBox ID="txtcod2" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Data de lançamento</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtlan" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Data de finalização</h2>
            </td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtfim" runat="server"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td>
               <h2>Imagem</h2>
            </td>
         </tr>
         <tr>
            <td>
                <asp:FileUpload ID="txtFoto" runat="server" />
            </td>
         </tr>
         <tr>
            <td>
               <asp:Button ID="btnenviar" runat="server" Text="Enviar"></asp:Button>
            </td>
         </tr>
         <tr>
            <td>
               <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
         </tr>
      </table>
   </div>
</div>

</asp:Content>
