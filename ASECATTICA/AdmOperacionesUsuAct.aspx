﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmOperacionesUsuAct.aspx.cs" Inherits="ASECATTICA.AdmOperacionesUsuAct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
<body class="sb-sidenav">
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
                    <a class="nav-link dropdown-toggle" id="userDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" ><i class="fas fa-user fa-fw"></i></a>
                    <div class="dropdown-menu dropdown-menu-right" aria-labelledby="userDropdown">
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
                                Inicio
                            </a>
                            <div class="sb-sidenav-menu-heading">Administración</div>
                            <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseLayouts" aria-expanded="false" aria-controls="collapseLayouts">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Usuarios
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                            </a>
                            <div class="collapse" id="collapseLayouts" aria-labelledby="headingOne" data-parent="#sidenavAccordion">
                                <nav class="sb-sidenav-menu-nested nav">
                                    <a class="nav-link" href="AdmUsu.aspx">Actualizar</a>
                                </nav>
                            </div>
                            
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
                        <h1 class="mt-4">Operaciones de Usuarios</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active">En esta sección cree la operación de usuario que considere necesario</li>
                        </ol>      
                    </div>
                
                     <%-- ----------------------------------------------------------- --%>
             <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-12">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Actualizar información</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="form-row" runat="server" >
                                               <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCodigoCuenta">Código de cuenta</label>
                                                    
                                                        <asp:TextBox ID="TxtCodigoCuenta"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputIDAsecattica">ID Asecattica</label>
                                                    
                                                        <asp:TextBox ID="TxtIDAsecattica"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputTipoAsiento">Tipo de asiento</label>
                                                     
                                                        <asp:TextBox ID="TxtTipoAsiento"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>

                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputTipoAjuste">Tipo de ajuste</label>
                                                     
                                                        <asp:TextBox ID="TxtTipoAjuste"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                
                                            </div> <%--Fin del form-row--%>

                                                <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputPorcentajeAjuste">Porcentaje de ajuste</label>
                                                     
                                                        <asp:TextBox ID="TxtPorcentajeAjuste"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>

                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputDescripcion">Descripción</label>
                                                     
                                                        <asp:TextBox ID="TxtDescripcion"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                
                                            </div> <%--Fin del form-row--%>

                                                    <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputFechaUltAct">Fecha última actualización</label>
                                                     
                                                        <asp:TextBox ID="TxtFechaUltAct"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                        <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputSaldoAnterior">Saldo Anterior</label>
                                                     
                                                        <asp:TextBox ID="TxtSaldoAnterior"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>

                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputSaldoActual">Saldo actual</label>
                                                     
                                                        <asp:TextBox ID="TxtSaldoActual"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                        <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputDebitosMes">Débitos del mes</label>
                                                     
                                                        <asp:TextBox ID="TxtDebitosMes"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            
                                      <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCreditoMes">Créditos del mes</label>
                                                     
                                                        <asp:TextBox ID="TxtCreditosMes"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                        
                                            </div> <%--Fin del form-row--%>

                            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
                                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />
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
