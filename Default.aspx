<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- REFERENCIA: http://flexslider.woothemes.com/index.html -->
    <div class="flexslider">
        <ul class="slides">
            <li>
                <img src="Images/banner_tomates.jpg" />
            </li>
            <li>
                <img src="Images/banner_produtor.jpg" />
            </li>
            <li>
                <img src="Images/banner_alfaces.jpg" />
            </li>
            <li>
                <img src="Images/banner_planta.jpg" />
            </li>
        </ul>
    </div>
    <script>
        // Can also be used with $(document).ready()
        $(window).load(function () {
            $('.flexslider').flexslider({
                animation: "slide"
            });
        });
    </script>


    <div class="row min-height-300px margin-top-120 margin-bottom-120">
        <!-- COLUNA 1 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/alimentos.jpeg" />
                <br />
                <h2>Alimentos de Qualidade</h2>
                <br />
                <p>
                    Na nossa empresa, priorizamos a saúde e o bem-estar de nossos clientes, oferecendo alimentos orgânicos de alta qualidade. Todos os nossos produtos são cultivados sem o uso de pesticidas ou fertilizantes químicos, garantindo sabores mais autênticos e nutritivos. Acreditamos que uma alimentação saudável é a base para uma vida equilibrada e feliz. 
                </p>
            </div>
        </div>

        <!-- COLUNA 2 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/payment.jpeg" />
                <br />
                <h2>Pagamento facilitado</h2>
                <br />
                <p>
                    Queremos tornar sua experiência de compra o mais conveniente possível. Por isso, oferecemos diversas opções de pagamento, incluindo cartões de crédito, débito e pagamentos digitais. Nossa plataforma é segura e intuitiva, facilitando cada etapa da sua compra. Comprar alimentos orgânicos nunca foi tão fácil e acessível!
                </p>

            </div>
        </div>
        <!-- COLUNA 3 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/celular.jpeg" />
                <br />
                <h2>Compre pelo celular</h2>
                <br />
                <p>
                    Compre seus alimentos orgânicos favoritos diretamente pelo seu celular. Nosso site é totalmente otimizado para dispositivos móveis, permitindo que você navegue, selecione e finalize suas compras com apenas alguns toques. Com a praticidade da tecnologia, você pode cuidar da sua alimentação de qualquer lugar, a qualquer hora. 
                </p>

            </div>
        </div>
        <!-- COLUNA 4 -->
        <div class="col-3">
            <div class="box border margin-right-20">
                <img width="100%" src="Images/delivery.jpeg" />
                <br />
                <h2>Entregamos para você!</h2>
                <br />
                <p>
                    Para sua comodidade, oferecemos um serviço de entrega rápido e eficiente. Selecione seus produtos e receba-os fresquinhos diretamente na sua porta. Nossa equipe está comprometida em garantir que os alimentos cheguem até você em perfeitas condições, preservando sua qualidade e frescor. Aproveite a comodidade de ter alimentos orgânicos de qualidade entregues na sua casa. 
                </p>

            </div>
        </div>
    </div>
</asp:Content>
