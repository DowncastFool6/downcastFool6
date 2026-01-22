<%-- 
    Document   : Removing Clients from Database
    Created on : 19 Jan 2026, 14:25:40
    Author     : Vissolela Cundi
--%>

<%@page language = "java" contentType="text/html" pageEncoding="UTF-8"%>
<%@page import = "java.sql.*" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="https://use.typekit.net/nqc1aaq.css">
        <link href="style.css" rel="stylesheet">
        <title>Client Management - VC</title>
    </head>
    <body>
        <h1>List of client database</h1>
        <section>
            <h2>Removal of Clients</h2>
            <article>  
            <%
                int id = Integer.parseInt(request.getParameter("id"));
                
            try {
                Class.forName("com.mysql.jdbc.Driver");
                    
                // connect to name of server, username and password
                Connection con = DriverManager.getConnection("jdbc:mysql://"
                            + "localhost:3306/bd_act1", "root", "");
                
                String sql = "DELETE FROM t_client WHERE id=?";
                        
                PreparedStatement pstm = con.prepareStatement(sql);
                
                pstm.setInt(1, id);
                
                int delete = pstm.executeUpdate();
                if (delete > 0)
                    out.print("<h3>Register removed with success!</h3>");
                else
                    out.println("An error occurred durng removal");
                
                pstm.close();
                con.close();
               
                } catch (Exception e) {
                            out.println("An error occurred: " + e.getMessage());        
                }
                %>
            <div class="btn-wrapper-left">
                <input type="button" value="Return to main page" onclick="history.go(-2)">
            </div>
            </article>
        </section> 
    </body>
</html>

