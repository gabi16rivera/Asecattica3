﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contrasenia.aspx.cs" Inherits="ASECATTICA.Contrasenia" %>

<!DOCTYPE html>

<html lang="en">
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Page Title - SB Admin</title>
        <link href="css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js"></script>
    </head>
    <body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Recuperar contraseña</h3></div>
                                    <div class="card-body">
                                        <div class="small mb-3 text-muted">Ingrese su cédula y le enviaremos un enlace a su correo electrónico registrado para restablecer su contraseña.</div>
                                        <form runat="server">
<!--*****************************
    AL INICIAR EL FORM AGREGAR:-->
            <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
<ContentTemplate>

<!--*****************************
    CONTENIDO NORMAL DEL FORMULARIO-->
                                            <div class="form-group">
                                               <label class="small mb-1" for="inputCedula">Cédula</label>
                                                <asp:TextBox class="form-control py-4" ID="TxtCedula" runat="server"></asp:TextBox>
                                                <%--<input class="form-control py-4" id="inputEmailAddress" type="email" aria-describedby="emailHelp" placeholder="Ingrese la dirección de correo electrónico" />--%>
                                                
                                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                                            </div>
                                            <div class="form-group d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <a class="small" href="Login.aspx">Regresar a iniciar sesión</a>
                                               <%-- <a class="btn btn-primary" href="login.html">Restablecer la contraseña</a>--%>
                                                <asp:Button class="btn btn-primary" ID="BtnRestablecerContrasenia" runat="server" Text="Restablecer contraseña" OnClick="BtnRestablecerContrasenia_Click"/>
                                            </div>
 <!-- ----------------------------------- -->
  <!-- Bootstrap Modal Dialog: FINALIZAR -->

                                <div class="modal fade" id="myModalFinalizar" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false">
                                    <div class="modal-dialog  modal-lg">
                                        <asp:UpdatePanel ID="UpModal2" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <h4 class="modal-title">
                                                            <asp:Label ID="lblModalTitleFinalizar" runat="server" Text=""></asp:Label></h4>
                                                    </div>
                                                    <div class="modal-body">
                                                        <asp:Label ID="lblModalBodyFinalizar" runat="server" Text=""></asp:Label>
                                                    </div>
                                                    <div class="modal-footer">
                                                        <%--<asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-info" Text="Cerrar" data-dismiss="modal" aria-hidden="true" onClick="location.reload()"/>--%>
                                                        <button class="btn btn-info" data-dismiss="modal" aria-hidden="true" onclick="location.reload();">Finalizar</button>
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
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2020</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js" ></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
