﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarContrasenia.aspx.cs" Inherits="ASECATTICA.RecuperarContrasenia" %>

<!DOCTYPE html>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>ASECATTICA</title>
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js"></script>
    </head>
    <body class="bg-primary sb-sidenav-toggled h-100">

         <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
     
      <a class="navbar-brand" href="Index.aspx">Asecattica</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item active">
            <a class="nav-link " href="Index.aspx">Inicio
              <span class="sr-only">(current)</span>
            </a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

        <div class="bg-light" id="layoutAuthentication">
            <div  class="bg-light" id="layoutAuthentication_content" style="margin-top:100px;>
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Recuperar contraseña</h3></div>
                                    <div class="card-body">
                                        <div class="small mb-3 text-muted">Ingrese su nueva contraseña. Debe tener al menos 8 caracteres.</div>
                                        <form runat="server">
<!--*****************************
    AL INICIAR EL FORM AGREGAR:-->
            <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
<ContentTemplate>

<!--*****************************
    CONTENIDO NORMAL DEL FORMULARIO-->
                                            <div class="form-group">
                                               <label class="small mb-1" for="inputNuevaContra">Nueva Contraseña</label>
                                                <asp:TextBox class="form-control py-4" ID="TxtNuevaContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                                                <label class="small mb-1" for="inputConfirmarContra">Confirmar Contraseña</label>
                                                <asp:TextBox class="form-control py-4" ID="TxtConfirmarContra" runat="server" TextMode="Password"></asp:TextBox>

                                            </div>
                                            <div class="form-group d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <a class="small" href="Login.aspx">Regresar a iniciar sesión</a>
                                                <asp:Button class="btn btn-primary" ID="BtnRestablecerContrasenia" runat="server" Text="Restablecer contraseña" OnClick="BtnRestablecerContrasenia_Click"/>
                                            </div>
 <!-- ----------------------------------- -->
  <!-- Bootstrap Modal Dialog: FINALIZAR -->

                                <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false">
                                    <div class="modal-dialog  modal-lg">
                                        <asp:UpdatePanel ID="UpModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <h4 class="modal-title">
                                                            <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                                                    </div>
                                                    <div class="modal-body">
                                                        <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                                                    </div>
                                                    <div class="modal-footer">
                                                        <%--<asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-info" Text="Cerrar" data-dismiss="modal" aria-hidden="true" onClick="location.reload()"/>--%>
                                                        <button class="btn btn-info" data-dismiss="modal" aria-hidden="true" onclick="location.reload();">Aceptar</button>
                                                        <%--<button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Cerrar</button>--%>
                                                    </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>

    <!-- Fin Bootstrap Modal Dialog: FINALIZAR -->
    <!--*****************************
    ANTES DEL CIERRE DEL FORM AGREGAR: -->
    <!--AGREGAR LOS BOTONES QUE HACEN ALGUN EVENTO: CLICK, TEXTCHANGE,SELECTEDINDEXCHANGE U OTROS -->

</ContentTemplate>
<Triggers>
    <asp:AsyncPostBackTrigger ControlID="BtnRestablecerContrasenia" EventName="Click" />
</Triggers>
</asp:UpdatePanel>
                                        </form>
                                    </div> <%--fin del card body--%>
                                    <%--<div class="card-footer text-center">
                                        <div class="small"><a href="register.html">Need an account? Sign up!</a></div>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                
                     <!-- Copyright -->  
    <div class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">Copyright &copy; Your Website 2021</p>
    </div>
  </div>
            </div>
        </div>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js" ></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
