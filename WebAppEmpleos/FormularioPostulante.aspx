<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPostulante.aspx.cs" Inherits="WebAppEmpleos.FormularioPostulante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <br />

        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="card">
                        <div class="card-header">Registro</div>

                        <div class="card-body">
                                

                                <div class="form-group row">
                                    <label for="name" class="col-md-4 col-form-label text-md-right">Nombre</label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="email" class="col-md-4 col-form-label text-md-right">E-mail</label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <label for="password" class="col-md-4 col-form-label text-md-right">Password</label>
                                    <div class="col-md-6">
                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                            
                                </div>

                                <div class="form-group row">
                                    <label for="password-confirm" class="col-md-4 col-form-label text-md-right">Confirma Password</label>

                                    <div class="col-md-6">
                                        <asp:TextBox ID="txtPasswordConfirm" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>                                
                                    </div>
                                </div>

                                <div class="form-group row mb-0">
                                    <div class="col-md-6 offset-md-4">
                                        <asp:Button ID="Button1" runat="server" Text="Registrarse" class="btn btn-primary" OnClick="Button1_Click"/>
                                    </div>
                               </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
