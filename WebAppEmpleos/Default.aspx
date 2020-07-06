<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppEmpleos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
    <link href="cover.css" rel="stylesheet">
    <div class="text-center">
    <div class="cover-container d-flex h-100 p-3 mx-auto flex-column">
      

      <main role="main" class="inner cover">
        <h1 class="cover-heading">Portal de Empleos</h1>
        <p class="lead">Esta es una aplicacion web creada con ASP.NET y un poco de bootstrap, el inicio de sesion y registros funcionan, sin embargo no esta con estandares de seguridad adecuados</p>
        <p class="lead">Se han creado usuarios empresa y postulantes al momento de iniciar la pagina, para probarlos, haz click en login e ingresa cualquiera de los siguientes datos:</p>
        <p>Postulantes</p>
        <ul>
          <li>Email:    Pepe@gmail.com  Pass:123</li>
          <li>Email:    Pablo@gmail.com Pass:123</li>
          <li>Email:    Juan@gmail.com  Pass:123</li>    
        </ul>
        
        <p>Empresas</p>
        <ul>
          <li>Email:    tottus@gmail.com    Pass:123</li>
          <li>Email:    lider@gmail.com     Pass:123</li>
          <li>Email:    jumbo@gmail.com     Pass:123</li>    
        </ul>
      </main>

      
    </div>
        </div>
</asp:Content>
