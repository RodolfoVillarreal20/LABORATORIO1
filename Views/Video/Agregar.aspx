<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Agregar</title>
</head>
<body>       
<form action="/Video/Agregar" method="post">
    <fieldset>
        <legend>Datos contacto </legend>      
    <h1>    AGREGAR VIDEOS
        <br />  
    <label for= "idvideo">idvideo</label>
    <input type= "text" name= "idvideo"/>

    
    <label for= "titulo">titulo</label>
    <input type= "text" name= "titulo"/>


    <label for= "reproducciones">reproducciones</label>
    <input type= "text" name= "Reproducciones"/>

    <label for= "url">url</label>
    <input type= "text" name= "url"/>

        <br />
     <input type= "submit" Value= "registrar video"/> 
    
    </h1>

</body>
</html>
