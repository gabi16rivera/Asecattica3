﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmUsuAct.aspx.cs" Inherits="ASECATTICA.AdmUsuAct" %>

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

    <%-- Hace que aparezca el menú desplegable de la página --%>
      <link href="https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js" ></script>

    
 
    

      

</head>
<body class="sb-sidenav">
         
    <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
            <a class="navbar-brand" href="#">Asecattica</a>



            <button class="btn btn-link btn-sm order-1 order-lg-0" id="sidebarToggle"><i class="fas fa-bars"></i></button>
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
                        <h1 class="mt-4">Usuarios</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item active">En esta sección cree el usuario que considere necesario</li>
                        </ol>      
                    </div>
                
                     <%-- ----------------------------------------------------------- --%>
             <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-12">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">
                                        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label></h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                          
<!--*****************************
    AL INICIAR EL FORM AGREGAR:-->
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
<ContentTemplate>
<!--*****************************
    CONTENIDO NORMAL DEL FORMULARIO-->
                                            <div class="form-row" runat="server" >
                                               
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputIDAsecattica">IDAsecattica</label>
                                                    
                                                        <asp:TextBox ID="TextBoxIDAsecattica"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCedula">Cédula</label>
                                                     
                                                        <asp:TextBox ID="TextBoxCedula"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputUbicacion">Ubicación</label>
                                                   
                                                        <asp:DropDownList ID="DropDownListUbica" runat="server" class="custom-select" Width="100%" style="height: 50px">
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputNombre<">Nombre</label>
                                                   
                                                        <asp:TextBox ID="TextBoxNombre"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputApellido1">Apellido 1</label>
                                                  
                                                        <asp:TextBox ID="TextBoxApellido1"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputApellido2<">Apellido 2</label>
                                                        
                                                        <asp:TextBox ID="TextBoxApellido2"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputRol">Rol</label>  
                                                        
                                                        <%--<asp:DropDownList ID="DropDownListRol" runat="server" class="custom-select" style="height: 50px" Width="100%">
                                                            
                                                        </asp:DropDownList>--%>

                                                        <div>
                                                            <asp:ListBox ID="ListBoxRol" SelectionMode="Multiple" runat="server" >

                                                        </asp:ListBox>

                                                        </div>


                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputEstado<">Estado</label>
                                                        <asp:DropDownList ID="DropDownListEstado" runat="server" class="custom-select" style="height: 50px" Width="100%" OnSelectedIndexChanged="DropDownListEstado_SelectedIndexChanged" >
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCorreo">Correo</label>
                                                     
                                                        <asp:TextBox ID="TextBoxCorreo"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputClave<">Clave</label>
                                                 
                                                        <asp:TextBox ID="TextBoxClave"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCentroCosto<">Centro de costo</label>
                                                 
                                                        <asp:DropDownList ID="DropDownListCentroCosto" runat="server" class="custom-select" Width="100%" style="height: 50px">
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                                
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputTelefono<">Teléfono</label>
                                                 
                                                        <asp:TextBox ID="TextBoxTelefono"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputFechaNac">Fecha de Nacimiento</label>
                                                       
                                                        <asp:TextBox ID="TextBoxFechaNac"  runat="server" class="form-control py-4" TextMode="Date"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputEdad<">Edad</label>
                                                       
                                                        <asp:TextBox ID="TextBoxEdad"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputDireccion">Dirección</label>
                                                       
                                                        <asp:TextBox ID="TextBoxDireccion"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputSexo<">Sexo</label>
                                                        
                                                        <asp:TextBox ID="TextBoxSexo"  runat="server" class="form-control py-4"></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputFechaIngreso">Fecha de Ingreso</label>
                                                        <asp:TextBox ID="TextBoxFechaIngreso"  runat="server" class="form-control py-4" TextMode="Date"></asp:TextBox>
                                                      
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <asp:Label ID="lblFechaSalida" runat="server" Text="Fecha de Salida" style="font-size: 13px" ></asp:Label>
                                                        
                                                        <asp:TextBox ID="TextBoxFechaSalida"  runat="server" class="form-control py-4" TextMode="Date"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div> <%--Fin del form-row--%>                                            
                                         
                                            
                                            <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click"/>
                                             <asp:Button ID="BtnAtrás" runat="server" Text="Atrás" OnClick="BtnAtrás_Click" />
                                            <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click"/>
                                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click"/>
                               

    <!-- ANTES LOS MODALES NECESARIOS AQUI -->
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
                                                   <div class="modal-footer">
                                                       <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                                                   </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div> <%--fin de modal--%>

      <!-- Bootstrap Modal Dialog: VALIDAR RESPUESTA -->
                                <div class="modal fade" id="myModalValida" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"> <!--data-backdrop="static" data-keyboard="false"-->
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
                                                  <asp:Button ID="BtnSi" runat="server" CssClass="btn btn-info" Text="Si" data-dismiss="modal" aria-hidden="true" OnClick="BtnSi_Click" UseSubmitBehavior="false"/>
                                                    <asp:Button ID="BtnNo" runat="server" CssClass="btn btn-info" Text="No" data-dismiss="modal" aria-hidden="true"/>   
                                                   </div>
                                                </div>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div> <%--fin de modal--%>

    <!-- ANTES LOS MODALES NECESARIOS AQUI -->
                                            <!-- Bootstrap Modal Dialog: REGRESAR -->
                                <div class="modal fade" id="myModalRegresar" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"> <!--data-backdrop="static" data-keyboard="false"-->
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
                                                       <asp:Button ID="BtnRegresar" runat="server" CssClass="btn btn-info" Text="Regresar" data-dismiss="modal" aria-hidden="true" UseSubmitBehavior="false" OnClick="BtnRegresar_Click"/>
                                                   </div>
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
    <asp:AsyncPostBackTrigger ControlID="BtnActualizar" EventName="Click" />
    <asp:AsyncPostBackTrigger ControlID="BtnSi" EventName="Click" />
    <asp:AsyncPostBackTrigger ControlID="BtnEliminar" EventName="Click" />
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

    

    <%-- Script para que el menú se despliegue --%>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" ></script>
       <%--<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js" ></script>--%>
        <script src="js/scripts.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" ></script>
        <script src="assets/demo/chart-area-demo.js"></script>
        <script src="assets/demo/chart-bar-demo.js"></script>
        <script src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js" ></script>
        <script src="https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js" ></script>
        <script src="assets/demo/datatables-demo.js"></script>
           

      <%-- Script para seleccionar el rol del usuario nuevo --%>  
    <script type="text/javascript">
        $(function () {
            $('#ListBoxRol').multiselect({
                includeSelectAllOption: false,
                nonSelectedText: "Seleccione el rol"
            });
        });

    </script>  

    <%-- Enlaces para que el script de roles funcione --%>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.16/css/bootstrap-multiselect.css" type="text/css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-multiselect/0.9.16/js/bootstrap-multiselect.js"></script>
     

     <%--</form>--%>
    </body>
</html>
