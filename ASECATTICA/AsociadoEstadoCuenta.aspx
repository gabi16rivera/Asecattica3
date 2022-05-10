<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsociadoEstadoCuenta.aspx.cs" Inherits="ASECATTICA.AsociadoEstadoCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Administración</title>
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
                        <a class="nav-link" href="Administrador.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                            Inicio
                        </a>
                        <div class="sb-sidenav-menu-heading">ASOCIADO</div>

                        <%-- BLOQUE DE OPCIONES PARA EL ADMINISTRADOR --%>
                        <% 
                            //string rol = Request.QueryString["Rol"].ToString();
                            string rol = Session["rol"].ToString();

                            if (rol.Contains("Administrador"))
                            {
                        %>

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


                        <a class="nav-link collapsed" href="AsociadoEstadoCuenta.aspx">
                            <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                            Estado de cuenta
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
                    <div class="small">Logeado con rol:</div>
                    <%--Administrador--%>
                    <%LblLogueado.Text = rol;%>
                    <asp:Label ID="LblLogueado" runat="server" Text="Label"></asp:Label>
                </div>
            </nav>
        </div>

        <div id="layoutSidenav_content">
            <main>
                <div class="container-fluid">
                    <div class="float-right">
                        <button id="btnCertificadoEsp" type="button" class="btn btn-success image-btn" data-toggle="modal" data-target="#imgModal" title="Descargar certificado ">
                            <i class="fas fa-file-archive fa-1x"></i><span>Descargar Estado de Cuenta</span>

                        </button>

                    </div>
                    <h1 class="mt-4">Estado de cuenta</h1>
                    <ol class="breadcrumb mb-4">
                        <li class="breadcrumb-item active">En esta sección podrá observar datos estadísticos de la ASECATTICA</li>
                    </ol>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10">
                            <div id="EstadoDeCuenta" class="card mb-12">
                                <div class="card-header bg-dark text-white text-center">
                                    <h1>ASECATTICA</h1>
                                    <%--<i class="fas fa-chart-area mr-1"></i>--%>
                                        Estado de cuenta
                                </div>
                                <div class="card-body">
                                    <%--DATOS PERSONALES--%>
                                    <div class="row">
                                        <div class="col-3"><b>Socio N°</b></div>
                                        <div class="col-9">000</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-3"><b>Nombre</b></div>
                                        <div class="col-9">APELLIDO APELLIDO NOMBRE</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-3"><b>Cédula</b></div>
                                        <div class="col-9">0000000000</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-3"><b>Correo electrónico</b></div>
                                        <div class="col-9">correo@dominio.com</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-3"><b>Saldos al </b></div>
                                        <div class="col-9">31/05/2022</div>
                                    </div>
                                    <div class="row">
                                        <hr />
                                    </div>
                                    <%--CRÉDITOS--%>
                                    <div class="row bg-dark text-white text-center">
                                        <div class="mb-3"><b>CRÉDITOS</b></div>
                                        <div class="mb-9"></div>
                                    </div>
                                    <div class="row">
                                        <table class="table table-hover">
                                            <thead>
                                                <tr class="bg-dark text-white">
                                                    <th scope="col">Crédito</th>
                                                    <th scope="col">Monto</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <th scope="row">Aporte Patronal</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Aporte Personal</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Aporte en Custodia</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Ahorro Escolar</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Ahorro Navideño</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Excedentes</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <br />
                                    <%--DÉBITOS--%>
                                    <div class="row bg-dark text-white text-center">
                                        <div class="mb-3"><b>DÉBITOS</b></div>
                                        <div class="mb-9"></div>
                                    </div>
                                    <div class="row">
                                        <table class="table table-hover">
                                            <thead>
                                                <tr class="bg-dark text-white">
                                                    <th scope="col"><a href="AsociadoDetalleDebito.aspx">Préstamo personal</a></th>
                                                    <th scope="col">Monto</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <th scope="row">Saldo Anterior</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Abono</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Interés</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Préstamo del mes</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                                <tr>
                                                    <th scope="row">Total</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <br />                                    
                                    <%--DÉBITOS--%>
                                    <div class="row bg-dark text-white text-center">
                                        <div class="mb-3"><b>DISPONIBLES</b></div>
                                        <div class="mb-9"></div>
                                    </div>
                                    <div class="row">
                                        <table class="table table-hover">
                                            <thead>
                                                <tr class="bg-dark text-white">
                                                    <th scope="col">Tipo</th>
                                                    <th scope="col">Monto</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <th scope="row">Aumento de crédito</th>
                                                    <td>₡ 000.000,00</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <br />
                                </div>
                                <%--FOOTER--%>
                                <div class="card-header bg-dark text-white text-center">
                                    <div class="mb-12"><b>ASECATTICA | San José, Costa Rica</b></div>
                                    <div class="mb-12"><b>Tel.: 2544-0144 | consultas@asecattica.com</b></div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-1"></div>
                    </div>

                </div>
            </main>
            <footer class="py-4 bg-light mt-auto">
                <div class="container-fluid">
                    <div class="d-flex align-items-center justify-content-between small">
                        <div class="text-muted">Copyright &copy; Your Website 2022</div>
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
</body>
</html>



<%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>--%>

<script type="text/javascript">
    $("#btnCertificadoEsp").on("click", function () {
        var divContents = $("#EstadoDeCuenta").html();
        var printWindow = window.open('', '', 'height=400,width=800');
        printWindow.document.write('<html>')
        printWindow.document.write('<head><style type="text/css" media="print">@@page { margin: 0; size: landscape; }</style><link href="css/styles.css" rel="stylesheet" /><link href="Content/bootstrap.min.css" rel="stylesheet" /><title>Estado de Cuenta</title></head>')
        printWindow.document.write('<body>');
        printWindow.document.write(divContents);
        printWindow.document.write('</body></html>');
        printWindow.document.close();
        printWindow.print();
    });
</script>

