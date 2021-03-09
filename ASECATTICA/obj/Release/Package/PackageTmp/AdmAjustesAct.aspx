<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmAjustesAct.aspx.cs" Inherits="ASECATTICA.AdmAjustesAct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Dashboard - SB Admin</title>
    <link href="css/styles.css" rel="stylesheet" />
    <link href="https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css" rel="stylesheet" crossorigin="anonymous" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js" crossorigin="anonymous"></script>
</head>
<body class="sb-sidenav-toggled">
    <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Asecattica</a>



        <button class="btn btn-link btn-sm order-1 order-lg-0" id="sidebarToggle" href="#"><i class="fas fa-bars"></i></button>
        <!-- Navbar Search-->
        <form class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
            <%--<div class="input-group">
                    <input class="form-control" type="text" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2" />--%>                    <%--<div class="input-group-append">
                        <button class="btn btn-primary" type="button"><i class="fas fa-search"></i></button>
                    </div>
                </div>--%>
        </form>
        <!-- Navbar-->
        <ul class="navbar-nav ml-auto ml-md-0">
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" id="userDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="userDropdown">
                    <a class="dropdown-item" href="#">Perfil</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="Login.aspx">Salir</a>
                </div>
            </li>
        </ul>
    </nav>
    <div id="layoutSidenav">
        <div id="layoutSidenav_nav">
            <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                <div class="sb-sidenav-menu">
                    <div class="nav">
                        <%--<div class="sb-sidenav-menu-heading">Core</div>--%>
                        <a class="nav-link" href="Administrador.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Dashboard
                        </a>
                        <div class="sb-sidenav-menu-heading">Administración</div>
                        <a class="nav-link collapsed" href="AdmAjustes.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Ajustes
                        </a>
                        <a class="nav-link collapsed" href="AdmAsientos.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Asientos
                        </a>
                        <a class="nav-link collapsed" href="AdmCentroCosto.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Centro de Costos
                        </a>
                        <a class="nav-link collapsed" href="AdmCreditosUsu.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Crédito de Usuarios
                        </a>
                        <a class="nav-link collapsed" href="AdmCuentas.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Cuentas
                        </a>
                        <a class="nav-link collapsed" href="AdmEstados.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Estados
                        </a>
                        <a class="nav-link collapsed" href="AdmOperacionesUsu.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Operaciones de Usuarios
                        </a>
                        <a class="nav-link collapsed" href="AdmRoles.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Roles
                        </a>

                        <a class="nav-link collapsed" href="AdmLineasCreditos.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Línea de Crédito
                        </a>
                        <a class="nav-link collapsed" href="AdmUbicacion.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Ubicación
                        </a>
                        <a class="nav-link collapsed" href="AdmUsu.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Usuarios
                        </a>

                    </div>
                </div>
                <div class="sb-sidenav-footer">
                    <div class="small">Logeado como:</div>
                    Administrador
                            
                        
                        
                </div>
            </nav>
        </div>
        <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid">
                        <h1 class="mt-4">Dashboard</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active">Dashboard</li>
                        </ol>
                    </div>

                    <%-- ----------------------------------------------------------- --%>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-12">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header">
                                        <h3 class="text-center font-weight-light my-4">
                                        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label></h3>
                                    </div>
                                <div class="card-body">
                                    
            <form runat="server">

                <!--*****************************-->
                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <!--*****************************
    CONTENIDO NORMAL DEL FORMULARIO-->

                                            <div class="form-row" runat="server">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCodigoAjuste">Código</label>
                                                        <asp:TextBox ID="txtCodigo" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                
                                            </div><%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                            <div class="form-group">
                                                <label class="small mb-1" for="inputTipoAjuste">Tipo</label>

                                                <asp:TextBox ID="txtTipoAjuste" runat="server" class="form-control py-4"></asp:TextBox>
                                            </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputNombreAjuste">Nombre</label>

                                                        <asp:TextBox ID="txtNombreAjuste" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>

                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputRangoInicial">Rango Inicial</label>

                                                        <asp:TextBox ID="txtRangoInicial" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputRangoFinal">Rango Final</label>

                                                        <asp:TextBox ID="txtRangoFinal" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputPeso" class="form-control py-4">Peso</label>

                                                        <asp:TextBox ID="txtPeso" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputDescripcion">Descripción</label>

                                                        <asp:TextBox ID="txtDescripcion" runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                            <%--Fin del form-row--%>

                                            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                                            <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" />
                                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />

                                            <!-- ANTES LOS MODALES NECESARIOS AQUI -->
                                            <!-- Bootstrap Modal Dialog: NOTIFICACIONES -->
                                            <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                                <!--data-backdrop="static" data-keyboard="false"-->
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
                                                                <div class="modal-footer">
                                                                    <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                                                </div>
                                                            </div>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </div>
                                            <%--fin de modal--%>

                                            <!-- Bootstrap Modal Dialog: VALIDAR RESPUESTA -->
                                            <div class="modal fade" id="myModalValida" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                                <!--data-backdrop="static" data-keyboard="false"-->
                                                <div class="modal-dialog  modal-lg">
                                                    <asp:UpdatePanel ID="upModalValida" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <div class="modal-content">
                                                                <div class="modal-header">
                                                                    <h4 class="modal-title">
                                                                        <asp:Label ID="lblModalTitleValida" runat="server" Text=""></asp:Label></h4>
                                                                    <%--<button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>--%>
                                                                </div>
                                                                <div class="modal-body">
                                                                    <asp:Label ID="lblModalBodyValida" runat="server" Text=""></asp:Label>
                                                                </div>
                                                                <div class="modal-footer">
                                                                    <asp:Button ID="BtnSi" runat="server" CssClass="btn btn-info" Text="Si" data-dismiss="modal" aria-hidden="true" OnClick="BtnSi_Click" UseSubmitBehavior="false" />
                                                                    <asp:Button ID="BtnNo" runat="server" CssClass="btn btn-info" Text="No" data-dismiss="modal" aria-hidden="true" />
                                                                </div>
                                                            </div>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </div>
                                            <%--fin de modal--%>

                                            <!-- ANTES LOS MODALES NECESARIOS AQUI -->
                                            <!-- Bootstrap Modal Dialog: REGRESAR -->
                                            <div class="modal fade" id="myModalRegresar" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                                <!--data-backdrop="static" data-keyboard="false"-->
                                                <div class="modal-dialog  modal-lg">
                                                    <asp:UpdatePanel ID="upModalRegresar" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                                                        <ContentTemplate>
                                                            <div class="modal-content">
                                                                <div class="modal-header">
                                                                    <h4 class="modal-title">
                                                                        <asp:Label ID="lblModalTitleRegresar" runat="server" Text=""></asp:Label></h4>
                                                                    <%--<button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>--%>
                                                                </div>
                                                                <div class="modal-body">
                                                                    <asp:Label ID="lblModalBodyRegresar" runat="server" Text=""></asp:Label>
                                                                </div>
                                                                <div class="modal-footer">
                                                                    <asp:Button ID="BtnRegresar" runat="server" CssClass="btn btn-info" Text="Regresar" data-dismiss="modal" aria-hidden="true" UseSubmitBehavior="false" OnClick="BtnRegresar_Click" />
                                                                </div>
                                                            </div>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </div>
                                            <%--fin de modal--%>

                                            <!--*****************************
    ANTES DEL CIERRE DEL FORM AGREGAR: -->
                                            <!--AGREGAR LOS BOTONES QUE HACEN ALGUN EVENTO: CLICK, TEXTCHANGE,SELECTEDINDEXCHANGE U OTROS -->

                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="BtnActualizar" EventName="Click" />
                                            <asp:AsyncPostBackTrigger ControlID="BtnEliminar" EventName="Click" />
                                            <asp:AsyncPostBackTrigger ControlID="BtnAgregar" EventName="Click" />
                                        </Triggers>
                                    </asp:UpdatePanel>
                </form> 
                                </div>

                            </div>

                        </div>
                                   
    
        </div>


                                </div>

        </main>
                

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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
    <script src="assets/demo/chart-area-demo.js"></script>
    <script src="assets/demo/chart-bar-demo.js"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js" crossorigin="anonymous"></script>
    <script src="https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js" crossorigin="anonymous"></script>
    <script src="assets/demo/datatables-demo.js"></script>

    <%--</form>--%>
</body>
</html>
