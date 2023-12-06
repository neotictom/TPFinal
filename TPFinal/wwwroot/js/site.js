// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ValidarContraseña()
{
    //Id : Contraseña
    let Pass= document.getElementById("Contra")
    console.log(Pass.value)
    let reg = /^(?=.*[!@#$%^&*])(?=.*[A-Z]).{8,}$/
    
    if (reg.test(Pass.value)) 
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
  console.log(IdP)
  $.ajax(
  { 
    type: 'GET',
    dataType: 'JSON',
    url: '/Home/ModalComp',
    data: {id: IdP},
    success:
      function(response)
      {
        console.log(response);
        $("#Nombre").html(response.nombre);
        $("#img").attr("src", response.img);
        $("#Descripcion").html(response.descripcion);
        $("#Precio").html("$" + response.precio);
        $("#Consumo").html(response.consumo + "W De consumo")
      }
  }
  
)
}
