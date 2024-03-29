﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaGames.Site.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>Usuario</div>
            <div>
                <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>
            </div>
            <div>Senha</div>
            <div>
                <asp:TextBox ID="TxtSenha" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server" ID="LblStatus"></asp:Label>
                <asp:Button ID="BtnLogin" Text="Entrar" runat="server" OnClick="BtnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
