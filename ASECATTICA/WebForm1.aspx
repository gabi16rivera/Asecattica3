<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASECATTICA.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type = "text/javascript" src = "http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"> </script>
<link href = "http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css" rel = "hoja de estilo" type = "text/css"/>
<script type = "text/javascript" src = "http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js"> </script>
<link href = "http://cdn.rawgit.com/davidstutz/bootstrap-multiselect/master/dist/css/bootstrap-multiselect.css" rel = "stylesheet" type = "text/css" />
<script src = "http://cdn.rawgit.com/davidstutz/bootstrap-multiselect/master/dist/js/bootstrap-multiselect.js" type = "text/javascript"> </script>
<script type="text/javascript">
    $(function () {
        $('[id*=lstFruits]').multiselect({
            includeSelectAllOption: true
        });
    });
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID = "lstFruits" runat = "server" SelectionMode = "Multiple">
    <asp:ListItem Text = "Mango" Value = "1"/>
    <asp:ListItem Text = "Apple" Value = "2"/>
    <asp:ListItem Text = "Banana" Value = "3"/>
    <asp:ListItem Text = "Guava" Value = "4"/>
    <asp:ListItem Text = "Orange" Value = "5"/>
</asp:ListBox>
<asp:Button Text = "Enviar" runat="server"/>

        </div>
    </form>
</body>
</html>
