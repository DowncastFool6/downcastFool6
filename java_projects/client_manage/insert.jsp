<%-- 
    Document   : Insertion of Clients
    Created on : 16 Jan 2026, 18:20:05
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
            <h2>Insertion of Clients</h2>
            <article>  
            <%
                String name = request.getParameter("name");
                String address = request.getParameter("address");
                String zone = request.getParameter("zone");
                String nif = request.getParameter("nif");
                String vol_invoice = request.getParameter("vol_invoice");
                
            try {
                Class.forName("com.mysql.jdbc.Driver");
                    
                // connect to name of server, username and password
                Connection con = DriverManager.getConnection("jdbc:mysql://"
                            + "localhost:3306/bd_act1", "root", "");
                
                String sql = "INSERT INTO t_client (name, address, zone, nif, "
                        + "vol_invoice) VALUES (?, ?, ?, ? ,?)";
                        
                PreparedStatement pstm = con.prepareStatement(sql);
                
                pstm.setString(1, name);
                pstm.setString(2, address);
                pstm.setString(3, zone);
                pstm.setString(4, nif);
                pstm.setString(5, vol_invoice);
                
                int insert = pstm.executeUpdate();
                if (insert > 0)
                    out.print("<h3>Register inserted with success!</h3>");
                else
                    out.println("An error occurred durng insertion");
                
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

