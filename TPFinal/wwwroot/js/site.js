﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ValidarContraseña()
{
    //Id : Contraseña
    let Pass= document.getElementById("Contraseña")

    let reg = /^(?=.*[!@#$%^&*])(?=.*[A-Z]).{8,}$/
    
    if (reg.test(Pass)) 
      {
        alert("La contraseña es válida.")
        return true
      } 
      else 
      {
        alert("La contraseña no cumple con los requisitos.")
        return false
      }
}
function VerDetalle(IdP){

  $.ajax(
  {
    type: 'POST',
    dataType: 'JSON',
    url: '/Home/DetalleComponente',
    data: {id : IdP},
    success:
      function(response)
      {
        $("#Nombre").html(response.nombre);
        $("#img").attr("src", "/"+response.img);
        $("#Descripcion").html(response.descripcion);
        $("#Precio").html("$" + response.precio);
      }
  }
  
)

}