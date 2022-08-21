<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsociadoInformes.aspx.cs" Inherits="ASECATTICA.AsociadoInformes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>ASECATTICA</title>
    <link href="css/styles.css" rel="stylesheet" />
    <link href="https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css" rel="stylesheet" crossorigin="anonymous" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js" crossorigin="anonymous"></script>
</head>
<%--<body class="sb-sidenav-toggled">--%>
<body class="sb-sidenav">


    <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Asecattica</a>
        <button class="btn btn-link btn-sm order-1 order-lg-0" id="sidebarToggle" href="#"><i class="fas fa-bars"></i></button>
        <!-- Navbar Search-->
        <form class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
            <%--<div class="input-group">
                    <input class="form-control" type="text" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2" />--%>
            <%--<div class="input-group-append">
                        <button class="btn btn-primary" type="button"><i class="fas fa-search"></i></button>
                    </div>
                </div>--%>
        </form>
        <!-- Navbar-->
        <ul class="navbar-nav ml-auto ml-md-0">
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" id="userDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                <div class="dropdown-menu dropdown-menu-right" aria-labelledby="userDropdown">
                    <a class="dropdown-item" href="AsociadoPerfil.aspx">Perfil</a>
                    <a class="dropdown-item" href="Index.aspx">Salir</a>
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
                        <a class="nav-link" href="Asociado.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Inicio
                        </a>


                        <%-- BLOQUE DE OPCIONES PARA EL ADMINISTRADOR --%>
                        <% 
                            //string rol = Request.QueryString["Rol"].ToString();
                            string rol = Session["rol"].ToString();

                            if (rol.Contains("Administrador"))
                            {
                        %>
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
                        <%--<a class="nav-link collapsed" href="AdmCreditosUsu.aspx">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Crédito de Usuarios
                            </a>
                            <a class="nav-link collapsed" href="AdmCuentas.aspx">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Cuentas
                            </a>--%>
                        <a class="nav-link collapsed" href="AdmEstados.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Estados
                        </a>
                        <%--<a class="nav-link collapsed" href="AdmOperacionesUsu.aspx">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Operaciones de Usuarios
                            </a>--%>
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

                        <%  }%>
                        <%-- FINALIZA EL BLOQUE PARA ADMINISTRADORES --%>
                        <%-- INICIA EL BLOQUE PARA ASOCIADO --%>
                        <% 
                            if (rol.Contains("Asociado"))
                            {%>
                        <div class="sb-sidenav-menu-heading">Estados</div>
                        <a class="nav-link collapsed" href="AsociadoEstadoCuenta.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Estado de cuenta
                        </a>
                        <a class="nav-link collapsed" href="AsociadoEstadosFinancieros.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-chart-area"></i></div>
                            Estados Financieros
                        </a>

                        <a class="nav-link collapsed" href="AsociadoInformes.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-chart-bar"></i></div>
                            Informes
                        </a>

                        <div class="sb-sidenav-menu-heading">Solicitudes</div>
                        <a class="nav-link collapsed" href="AsociadoSolicitudCredito.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Solicitud de crédito
                        </a>
                        <a class="nav-link collapsed" href="AsociadoCuotas.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-angle-right"></i></div>
                            Cambio de cuota
                        </a>
                        <a class="nav-link collapsed" href="AsociadoBeneficiarios.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-user"></i></div>
                            Beneficiarios
                        </a>
                        <a class="nav-link collapsed" href="AsociadoConsultas.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-user"></i></div>
                            Consultas
                        </a>

                        <%  }%>
                        <%-- FINALIZA EL BLOQUE PARA CONTABILIDAD --%>
                        <%-- INICIA EL BLOQUE PARA CONTABILIDAD --%>
                        <% 
                            if (rol.Contains("Contablidad"))
                            {%>


                        <a class="nav-link collapsed" href="AdmUsu.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Prueba Contabilidad
                        </a>

                        <%  }%>
                        <%-- FINALIZA EL BLOQUE PARA CONTABILIDAD --%>

                        <%-- INICIA EL BLOQUE PARA CONTABILIDAD --%>
                        <% 
                            if (rol.Contains("Administrador, Contabilidad"))
                            {%>

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

                        <a class="nav-link collapsed" href="AdmUsu.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Prueba Contabilidad
                        </a>

                        <%  }%>
                        <%-- FINALIZA EL BLOQUE PARA CONTABILIDAD --%>
                    </div>
                </div>
                <div class="sb-sidenav-footer">
                    <div class="small">
                        Rol: <%LblLogueado.Text = rol;%>
                        <asp:Label ID="LblLogueado" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </nav>
        </div>

        <div id="layoutSidenav_content">
            <main>
                <div class="container-fluid">
                    <h1 class="mt-4">Informes</h1>
                    <ol class="breadcrumb mb-4">
                        <li class="breadcrumb-item active">En esta sección podrá observar los informes de la ASECATTICA</li>
                    </ol>
                    <div class="row">
                        
                        <div class="col-md-1"></div>
                        <div class="col-md-10">
                                    <div class="row">
                                        <table class="table table-hover">
                                            <thead>
                                                <tr class="bg-dark text-white">
                                                    <th scope="col">Fecha</th>
                                                    <th scope="col">Título</th>
                                                    <th scope="col">Descripción</th>
                                                    <th scope="col">Descargar</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>mm/dd/aaaa</td>
                                                    <td>Título del informe</td>
                                                    <td>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</td>
                                                    <td><a href="docs/Informe.pdf" download="Informe.pdf" target="_blank">Descargar</a></td>
                                                </tr>
                                                <tr>
                                                    <td>mm/dd/aaaa</td>
                                                    <td>Título del informe</td>
                                                    <td>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</td>
                                                    <td><a href="docs/Informe.pdf" download="Informe.pdf" target="_blank">Descargar</a></td>
                                                </tr>
                                                <tr>
                                                    <td>mm/dd/aaaa</td>
                                                    <td>Título del informe</td>
                                                    <td>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</td>
                                                    <td><a href="docs/Informe.pdf" download="Informe.pdf" target="_blank">Descargar</a></td>
                                                </tr>
                                                <tr>
                                                    <td>mm/dd/aaaa</td>
                                                    <td>Título del informe</td>
                                                    <td>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</td>
                                                    <td><a href="docs/Informe.pdf" download="Informe.pdf" target="_blank">Descargar</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                        </div>
                        <div class="col-md-1"></div>
                    </div>

                </div>
            </main>
            <footer class="py-4 bg-light mt-auto">
                <div class="container-fluid">
                    <div class="d-flex align-items-center justify-content-between small">
                        <div class="text-muted">Derechos reservados &copy; ASECATTICA 2022</div>
                        <div>
                            <a href="#">Derechos reservados</a>
                            &middot;
                                <a href="#">Términos &amp; Condiciones</a>
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
</body>
</html>
