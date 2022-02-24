<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="prj_series.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head id="Head1" runat="server">
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" type="text/css" href="estilo.css">
		<title>seriesfavoritas.com</title>
	</head>
	<body>
		<form id="form1" runat="server">
			<main class="principal ">

				<header class="cabeçalho" style=" line-height:15%;">

					<div class="black">  
						<a href="index.aspx"><img class="black1" src="imagens/1024px-San_Francisco_Shock_logo.svg.png" " alt="logo Séries Favoritas"></a>
					</div>

					<div  class="cha"  class="areaFacebook  fl">
						
						<div><input type="text" name="1nome" style=" display:block; margin-top:18%; width:180px;"></div>
						<div><asp:Button ID="btnpes" runat="server" Text="Pesquisar" Width="50%"></asp:Button></div>

					</div>

					<div class="pop">
						<ul>
                            <asp:Literal ID="ltr1" runat="server">
							    <div class="a fl"><a href="pagserie.aspx">Séries</a></div>
							    <div class="a fl"><a href="serie.aspx">Séries cadastradas</a></div>
							    <div class="cls"></div>
                            </asp:Literal>
                            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
						</ul>
					</div>
					

				</header>

					<div class="conteudoHome ">


						<div class="AreaimgHome2 fl">
							<img class="logo" src="imagens/1024px-San_Francisco_Shock_logo.svg.png" " alt="logo Séries Favoritas" height="500px">
						</div>

						<div class="cls"></div>


					</div>
			</main>
				<footer class="pezinho">
					<div class="conteudofooter2">
						
						Desenvolvido por: Matheus Barriento 

					</div>
				</footer>
		</form>
	</body>
</html>

