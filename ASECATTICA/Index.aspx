<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASECATTICA.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>ASECATTICA</title>

    <!-- CAMBIAR FAVICON-->
    <link rel="icon" type="image/x-icon" href="assets/img/favicon.ico" />
    <!-- Core theme CSS (includes Bootstrap)-->
    <link href="css/stylesIndex.css" rel="stylesheet" />
    <style>
        html {
            scroll-behavior: smooth;
        }
    </style>
    

</head>
<body class="sb-sidenav-toggled" id="page-top">
    <form runat="server">



        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">

                <a class="navbar-brand" href="Index.aspx">Asecattica</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item">
                            <a class="nav-link " href="Index.aspx#page-top">Inicio<span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Index.aspx#servicios">Servicios</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Index.aspx#quienesSomos">Quiénes Somos</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Index.aspx#contacto">Contacto</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Login.aspx">Ingresar</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <%--  <main>--%>

        <!-- Header-->
        <header class="bg-primary py-5" style="background-image: url(assets/img/header-cafe-bg.jpg); background-color: dimgray;">
            <div class="container h-100 ">
                <div class="row h-100 align-items-center">
                    <div class="col-lg-12">
                        <h1 class="display-4 text-white mt-5 mb-2" style="font-weight: 600; text-shadow: -3px -3px 3px #343a40;">ASECATTICA</h1>
                        <p class="lead mb-5 text-white" style="text-shadow: -3px -3px 3px #343a40;">Asociación solidarista de empleados de CATTICA, enfocada en el apoyo y ayuda social en beneficio de todos.</p>
                    </div>
                </div>
            </div>
        </header>


        <!-- Services-->
        <section class="page-section py-5 " id="servicios">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Servicios</h2>
                    <h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                </div>
                <div class="row text-center">
                    <div class="col-md-4">
                        <span class="fa-stack fa-4x">
                            <img class="img-fluid" src="assets/img/portfolio/ahorro.jpg" alt="" />
                        </span>

                        <h4 class="my-3">Ahorro</h4>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.</p>
                    </div>
                    <div class="col-md-4">
                        <span class="fa-stack fa-4x">
                            <img class="img-fluid" src="assets/img/portfolio/credito.jpg" alt="" />
                        </span>
                        <h4 class="my-3">Crédito</h4>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.</p>
                    </div>
                    <div class="col-md-4">
                        <span class="fa-stack fa-4x">
                            <img class="img-fluid" src="assets/img/portfolio/ayuda.jpg" alt="" />
                        </span>
                        <h4 class="my-3">Apoyos</h4>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.</p>
                    </div>
                </div>
            </div>
        </section>

        <!-- QUINES SOMOS -->
        <section class="page-section bg-light py-5 " id="quienesSomos">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">¿Quiénes somos?</h2>
                </div>
                <div class="row">
                    <div class="col-md-12 mb-5">
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. A deserunt neque tempore recusandae animi soluta quasi? Asperiores rem dolore eaque vel, porro, soluta unde debitis aliquam laboriosam. Repellat explicabo, maiores!</p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis optio neque consectetur consequatur magni in nisi, natus beatae quidem quam odit commodi ducimus totam eum, alias, adipisci nesciunt voluptate. Voluptatum.</p>

                    </div>
                </div>
            </div>
        </section>

        <!-- Footer-->
        <section class="page-section py-5 text-center" id="contacto">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Contacto</h2>
                </div>
                <div class="row">
                    <div class="col-md-12 mb-5">
                        <form class="form-horizontal" method="post">
                            <fieldset>
                                <div class="form-group">
                                    <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-user bigicon"></i></span>
                                    <div class="col-md-12">
                                        <input id="fname" name="name" type="text" placeholder="Nombre completo" class="form-control">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-envelope-o bigicon"></i></span>
                                    <div class="col-md-12">
                                        <input id="email" name="email" type="text" placeholder="Correo electrónico" class="form-control">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-phone-square bigicon"></i></span>
                                    <div class="col-md-12">
                                        <input id="phone" name="phone" type="text" placeholder="Teléfono" class="form-control">
                                    </div>
                                </div>

                                <div class="form-group">
                                    <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-pencil-square-o bigicon"></i></span>
                                    <div class="col-md-12">
                                        <textarea class="form-control" id="message" name="message" placeholder="Por favor escriba su mensaje en este espacio." rows="7"></textarea>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-12 text-center">
                                        <!-- Button trigger modal -->
                                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalCenter">
                                            Enviar
                                        </button>
                                    </div>
                                </div>
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </section>


        <!-- Copyright -->
        <footer class="py-5 bg-dark">
            <div class="container">
                <p class="m-0 text-center text-white"><a href="mailto:#">consultas@asecattica.com</a> | <a href="Tel:25440144">2544-0144</a></p>
                <p class="m-0 text-center text-white">Derechos reservados © ASECATTICA 2022</p>
            </div>
        </footer>


        <!-- Modal -->
        <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLongTitle">Mensaje</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        Acción realizada con éxito
                    </div>
                    <div class="modal-footer">
                        <%--<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>--%>
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Aceptar</button>
                    </div>
                </div>
            </div>
        </div>

        <!-- Bootstrap core JS-->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"></script>
        <!-- Third party plugin JS-->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.min.js"></script>
        <!-- Core theme JS-->
        <script src="js/scriptsIndex.js"></script>
    </form>
</body>
</html>
