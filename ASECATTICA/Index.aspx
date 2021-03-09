<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ASECATTICA.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Index Asecattica</title>

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
          <li class="nav-item active">
            <a class="nav-link " href="#page-top">Inicio
              <span class="sr-only">(current)</span>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#servicios">Servicios</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#quienesSomos">Quiénes Somos</a>
          </li>
            <li class="nav-item">
            <a class="nav-link" href="#contacto">Contacto</a>
          </li>
            <%-- LOGIN --%>
              <li>
                  <asp:Button class=" text-uppercase font-weight-bold bg-dark text-white" style=" padding: 0.5rem; border:none;" ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
              <a href="Login.aspx">
                      <asp:Image ID="Imglogin" runat="server" ImageUrl="assets/img/login.png" Height="25px"/>
                  </a>
              </li>
            
        </ul>
      </div>
    </div>
  </nav>
              <%--  <main>--%>
          
                <!-- Header-->         
<header class="bg-primary py-5" style="background-image:url(assets/img/header-cafe-2-bg.jpg); background-color:dimgray;" >
    <div class="container h-100 ">
        <div class="row h-100 align-items-center">
        <div class="col-lg-12">
          <h1 class="display-4 text-white mt-5 mb-2" style="font-weight:600; text-shadow: -3px -3px 3px #343a40;">Business Name or Tagline</h1>
          <p class="lead mb-5 text-white" style="text-shadow: -3px -3px 3px #343a40;">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Non possimus ab labore provident mollitia. Id assumenda voluptate earum corporis facere quibusdam quisquam iste ipsa cumque unde nisi, totam quas ipsam.</p>
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
                            <img class="img-fluid" src="assets/img/portfolio/02-thumbnail.jpg" alt="" />
                        </span>

                        <h4 class="my-3">Ahorro</h4>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.</p>
                    </div>
                    <div class="col-md-4">
                        <span class="fa-stack fa-4x">
                            <img class="img-fluid" src="assets/img/portfolio/02-thumbnail.jpg" alt="" />
                        </span>
                        <h4 class="my-3">Crédito</h4>
                        <p class="text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Minima maxime quam architecto quo inventore harum ex magni, dicta impedit.</p>
                    </div>
                    <div class="col-md-4">
                        <span class="fa-stack fa-4x">
                             <img class="img-fluid" src="assets/img/portfolio/02-thumbnail.jpg" alt="" />
                        </span>
                        <h4 class="my-3">Equipo fútbol</h4>
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
            <div class="container page-section ">
                <div class="row">
                    <!-- Location-->
                    <div class="col-lg-4 mb-5 mb-lg-0">
                        <h2 class="text-uppercase mb-4">Dirección</h2>
                        <p class="lead mb-0">
                            Frailes Bustamente.
                            
                        </p>
                    </div>
                    <!-- Tel-->
                    <div class="col-lg-4">
                        <h2 class="text-uppercase mb-4">Teléfono</h2>
                        <p class="lead mb-0">
                             2222-2222
                        </p>
                    </div>

                    <!-- Email-->
                    <div class="col-lg-4">
                        <h2 class="text-uppercase mb-4">Correo</h2>
                        <p class="lead mb-0">
                             <a href="mailto:#">asecattica@cattica.com</a>
                        </p>
                    </div>

                </div>
            </div>
        </section>


     <!-- Copyright -->  
    <footer class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">Copyright &copy; Your Website 2021</p>
    </div>
  </footer>
    
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