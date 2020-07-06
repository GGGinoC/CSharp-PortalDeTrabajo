<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Trabajos.aspx.cs" Inherits="WebAppEmpleos.Trabajos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" runat="server">



<asp:ScriptManager runat="server"></asp:ScriptManager>
<asp:UpdatePanel runat="server">
    <ContentTemplate>
            <br />
            <div class="container ">
                <div class="">
                    <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control pull-left"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
                </div>
            </div>

            <% if (txtBuscar.Text == String.Empty)
                {
                    for (var i = 0; i < this.GetListaTrabajos().Count; i++)
                    {
                        ValoresCamposInicio(i);
                        Console.WriteLine(i);%>
              
                        <div class="card-body">
                            <div class="row justify-content-center">
                                <div class="col-md-8">
                                    <div class="card-header">
                                        <a href="#">
                                            <asp:Label ID="lblNombreEmpresa" runat="server"> </asp:Label>
                                        </a>
                                        publico:
                                    </div>
                                    <div class="card">
                                        <div class="card-body">
                                            <a href="#" class="font-weight-bold">
                                                <asp:Label ID="lblTrabajoTitulo" runat="server"/>
                                            </a>

                                            <p>
                                                <asp:Label ID="lblTrabajoDescripcion" runat="server"/>
                                            </p>
                                            <%if(WebAppEmpleos.Global.UsuarioActual != null){
                                                if (WebAppEmpleos.Global.UsuarioActual.getTipo().Equals("Postulante")){ %>
                                            
                                                    <asp:Button ID="btnPostular" runat="server" Text="Postular  " CssClass="btn btn-primary" OnClick="btnPostular_Click" />
                                            
                                            <% }} %>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

    
            <%      }
               }else if(lista.Count>0){
                    for (var i = 0; i < lista.Count; i++)
                    {
                        ValoresCamposBusqueda(i);
                        Console.WriteLine(i);%>
              
                        <div class="card-body">
                            <div class="row justify-content-center">
                                <div class="col-md-8">
                                    <div class="card-header">
                                        <a href="#">
                                            <a href="#">
                                            <asp:Label ID="lblBuscarNombre" runat="server"></asp:Label>
                                        </a>
                                        </a>
                                        publico:
                                    </div>
                                    <div class="card">
                                        <div class="card-body">
                                            <a href="#" class="font-weight-bold">
                                                <asp:Label ID="lblBuscarTitulo" runat="server"/>
                                            </a>

                                            <p>
                                                <asp:Label ID="lblBsucarDescripcion" runat="server"/>
                                            </p>
                                            <%if (WebAppEmpleos.Global.UsuarioActual != null) { if (WebAppEmpleos.Global.UsuarioActual.getTipo().Equals("Postulante")) { %>
                                            
                                            <asp:Button ID="btnBuscarPostular" runat="server" Text="Postular" CssClass="btn btn-primary" OnClick="btnBuscarPostular_Click" />
                                            
                                            
                                            <% } } %>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                


            <%}} %>



    </ContentTemplate>
</asp:UpdatePanel>





</asp:Content>
