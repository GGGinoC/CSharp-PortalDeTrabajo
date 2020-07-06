<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PublicarTrabajo.aspx.cs" Inherits="WebAppEmpleos.PublicarTrabajo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <asp:ScriptManager runat="server"></asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-md-8">
                            <div class="card">
                                <div class="card-header">Publicar</div>

                                <div class="card-body">
                                    <div class="form-group">
                                        <div class="form-group row">
                                            <label for="name" class="col-md-4 col-form-label text-md-right">Puesto - Titulo</label>

                                            <div class="col-md-6">
                                                <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                        
                                        <div class="form-group row">
                                            <label for="name" class="col-md-4 col-form-label text-md-right">Descripcion</label>
                                            <div class="col-md-6">
                                               <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                            </div>
                                        </div>
                        
                        

                                        <div class="form-group row justify-content-center">
                                            <div class="col-md-6 offset-md-4">
                                                <asp:Button ID="Button1" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="Button1_Click"/>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
