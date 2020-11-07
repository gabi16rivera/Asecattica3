<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASECATTICA.Login" %>

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
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js" crossorigin="anonymous"></script>
    </head>
    <body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Iniciar sesión</h3></div>
                                    <div class="card-body">



                                        <form runat="server">
<!--*****************************
    AL INICIAR EL FORM AGREGAR:-->
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>

<!--*****************************
    CONTENIDO NORMAL DEL FORMULARIO-->
                                            <div class="form-group">
                                                <label class="small mb-1" for="inputCedula">Cédula</label>
                                                <%--<input class="form-control py-4" id="inputIDAsecattica" type="email" placeholder="Ingrese el ID Asecattica" />--%>
                                                <asp:TextBox class="form-control py-4" ID="TxtCedula" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="form-group">
                                                <label class="small mb-1" for="inputContrasenia">Contraseña</label>
                                                <%--<input class="form-control py-4" id="inputContrasenia" type="password" placeholder="Ingrese la contraseña" />--%>
                                                <asp:TextBox class="form-control py-4" ID="TxtClave" runat="server" TextMode="Password"></asp:TextBox>
                                            </div>
                                            <div class="form-group">
                                                <div class="custom-control custom-checkbox">
                                                    <input class="custom-control-input" id="rememberPasswordCheck" type="checkbox" />
                                                    <label class="custom-control-label" for="rememberPasswordCheck">Recordar contraseña</label>
                                                </div>
                                            </div>
                                            <div class="form-group d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <a class="small" href="contrasenia.aspx">¿Olvidó su contraseña?</a>
                                                <%--<a class="btn btn-primary" href="Administrador.html">Ingresar</a>--%>
                                                <asp:Button class="btn btn-primary" ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
                                            </div>

                                            <!--*****************************
    ANTES LOS MODALES NECESARIOS AQUI -->
                                            <!-- Bootstrap Modal Dialog: NOTIFICACIONES -->
                                <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"> <!--data-backdrop="static" data-keyboard="false"-->
                                    <div class="modal-dialog  modal-lg">
                                        <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <h4 class="modal-title">
                                                            <asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>
                                                            
                                                    </div>
                                                    <div class="modal-body">
                                                        <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                                                    </div>
                                                    <%--<div class="modal-footer">--%>
                                                        <%--<asp:Button ID="btnCerrar" runat="server" CssClass="btn btn-info" Text="Cerrar" data-dismiss="modal" aria-hidden="true" onClick="location.reload()"/>--%>
                                                        <%--<button class="btn btn-info" data-dismiss="modal" aria-hidden="true" onclick="location.reload();">Cerrar</button>--%>
                                                       <%-- <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Cerrar</button>--%>
                                                   <%-- </div>--%>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div> <%--fin de modal--%>


<!--*****************************
    ANTES DEL CIERRE DEL FORM AGREGAR: -->
    <!--AGREGAR LOS BOTONES QUE HACEN ALGUN EVENTO: CLICK, TEXTCHANGE,SELECTEDINDEXCHANGE U OTROS -->

</ContentTemplate>
<Triggers>
    <asp:AsyncPostBackTrigger ControlID="BtnIngresar" EventName="Click" />
</Triggers>
</asp:UpdatePanel>

                                        </form>
                                    </div>
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
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>
