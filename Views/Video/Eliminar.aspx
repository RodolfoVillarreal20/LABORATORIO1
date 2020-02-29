<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Eliminar videos</title>
</head>
<body>
<form action="/Video/Eliminar" method="post">
    <fieldset>
        <legend>Datos contacto </legend>
    <h1>    Eliminar videos 
     <br />  
    <label for= "idvideo">idvideo</label>
    <input type= "text" name= "idvideo"/>


    <input type= "submit" Value= "Eliminar video"/> 

    </h1>
</body>
</html>
