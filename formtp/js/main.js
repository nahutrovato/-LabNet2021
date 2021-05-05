$(document).ready(function(){
    
    $('#botonSubmit').on('click', function(event){
         event.preventDefault();
      
          var nombre = $('#nombreFormulario').val();
          var apellido = $('#apellidoFormulario').val();
          var edad = $('#edadFormulario').val();
          var genero = $("input[type = 'radio']:checked");
          var empresa = $('#empresaFormulario').val();
          var mensajeError = $('.mensajeError')
          if(nombre == ""){
              mensajeError.css('display','flex').css('color','red');
              mensajeError.text('No ingreso el nombre');
          }else if( apellido == ""){
              mensajeError.css('display', 'flex').css('color','red');;
              mensajeError.text('No ingreso el apellido');
          }else if(genero.length == 0){
              mensajeError.css('display', 'flex').css('color','red');;
              mensajeError.text('No ingreso el genero');
          }else if( empresa == ""){
              mensajeError.css('display', 'flex').css('color','red');;
              mensajeError.text('No ingreso la empresa');
          }
         
    });
});