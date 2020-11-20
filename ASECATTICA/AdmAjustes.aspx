<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmAjustes.aspx.cs" Inherits="ASECATTICA.AdmAjustes" %>

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
            <a class="navbar-brand" href="#">Asecattica CAMBIO</a>



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
                    <a class="nav-link dropdown-toggle" id="userDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" ><i class="fas fa-user fa-fw"></i></a>
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
                            <form runat="server"> 
                            
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
                        <h1 class="mt-4">Ajustes</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active">En esta sección cree o seleccione el ajuste que considere necesario</li>
                        </ol>
                        <div class="row table table-responsive"> 
                        <asp:Button ID="BtnNuevo" class="breadcrumb-item" runat="server" Text="Nuevo" />
                            
                        <asp:GridView ID="GvAjustes" runat="server" AutoGenerateColumns="False" DataSourceID="DsAjustes" ViewStateMode="Enabled" ValidateRequestMode="Enabled" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnSelectedIndexChanged="GvAjustes_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EmptyDataTemplate>No hay información</EmptyDataTemplate>
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="CodigoAjuste" HeaderText="CodigoAjuste" SortExpression="CodigoAjuste" />
                            <asp:BoundField DataField="TipoAjuste" HeaderText="TipoAjuste" SortExpression="TipoAjuste" />
                            <asp:BoundField DataField="RangoInicial" HeaderText="RangoInicial" SortExpression="RangoInicial" />
                            <asp:BoundField DataField="RangoFinal" HeaderText="RangoFinal" SortExpression="RangoFinal" />
                            <asp:BoundField DataField="Peso" HeaderText="Peso" SortExpression="Peso" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                    
                               <asp:SqlDataSource ID="DsAjustes" runat="server" ConnectionString="<%$ ConnectionStrings:bdAsecatticaConnectionString %>" SelectCommand="sp_crud_TBAjustes" SelectCommandType="StoredProcedure">
                                   <SelectParameters>
                                       <asp:Parameter DefaultValue="0" Name="CodigoAjuste" Type="String" />
                                       <asp:Parameter DefaultValue="0" Name="TipoAjuste" Type="String" />
                                       <asp:Parameter DefaultValue="0" Name="RangoInicial" Type="Double" />
                                       <asp:Parameter DefaultValue="0" Name="RangoFinal" Type="Double" />
                                       <asp:Parameter DefaultValue="0" Name="Peso" Type="Double" />
                                       <asp:Parameter DefaultValue="0" Name="Descripcion" Type="String" />
                                       <asp:Parameter DefaultValue="Select" Name="choice" Type="String" />
                                   </SelectParameters>
                            </asp:SqlDataSource>
                    
                               </form>
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
    </body>

</html>
