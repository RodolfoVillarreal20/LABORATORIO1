<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <h1>Mi lista:</h1>
    Hay <%: ((System.Data.DataTable)ViewData["video"]).Rows.Count %> Videos
    <br />
    <%
        //sirve para buscar en cada trenglon en la base de datos
        foreach (System.Data.DataRow ren in ((System.Data.DataTable)ViewData["video"]).Rows)
        {%>
    <br />
            <label for= "idVideo">idVideo</label>
            <%: ren["idvideo"].ToString() %>  </p>
            <label for= "titulo">titulo</label>
           <p> <%: ren["titulo"].ToString() %>  </p>
           <label for= "reproducciones">reproducciones</label>
           <p> <%: ren["reproducciones"].ToString() %>  </p>
           <label for= "url">url</label>
           <p> <%: ren["url"].ToString() %>  </p>
            
             <iframe width="560" height="315" src="<%: ren["url"].ToString() %>"frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            
    <%  }
    %>
</body>
</html>
