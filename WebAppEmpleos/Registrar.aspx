<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="WebAppEmpleos.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="form-group row justify-content-center">
            <p>Selecciona el tipo de usuario</p>
            
            <div class="col-md-6 offset-md-4">
                <asp:Button ID="btnPostulante" runat="server" Text="Postulante" OnClick="btnPostulante_Click1" CssClass="btn btn-primary"/>
            </div>
            
            <div class="col-md-6 offset-md-4">
                <asp:Button ID="btnEmpresa" runat="server" Text="Empresa" OnClick="btnEmpresa_Click1" CssClass="btn btn-primary" />
            </div>r
        
        </div>
    </div>

</asp:Content>
