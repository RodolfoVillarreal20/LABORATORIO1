﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Modificar</title>
</head>
<body>
<form action="/Video/Modificar" method="post">
    <fieldset>
        <legend>Datos contacto </legend>
    <h1>    Modificar Videos
    <label for= "idVideo">idVideo</label>
    <input type= "text" name= "idVideo"/>

    
    <label for= "Titulo">Titulo</label>
    <input type= "text" name= "Titulo"/>


    <label for= "reproducciones">Reproducciones</label>
    <input type= "text" name= "Reproducciones"/>

    <label for= "Url">Url</label>
    <input type= "text" name= "Url"/>
        <br />
     <input type= "submit" Value= "MODIFICAR VIDEO"/> 

    </h1>

</body>
</html>
