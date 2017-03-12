<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pesquisar CEP</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-lg-12">
            <asp:Image ImageUrl="https://www.correios.com.br/++theme++correios.site.tema/images/logo_correios.png" runat="server" CssClass="col-lg-6 col-lg-offset-3" />
        </div>
        <div class="col-lg-offset-3 col-lg-6" style="margin-top: 50px;">
            <div class="col-lg-6">
                <asp:TextBox ID="TextCep" runat="server"></asp:TextBox>
                <asp:Button Text="Buscar" runat="server" OnClick="Unnamed1_Click" />
            </div>
            <div class="col-lg-6">
                <asp:Label Text="" ID="LabRetorno" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
