<%-- 
    Document   : Removing Clients from Database
    Created on : 16 Jan 2026, 18:55:09
    Author     : Vissolela Cundi
--%>

<%@page language = "java" contentType="text/html pageEncoding=UTF-8"%>
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
                <form action="delete2.jsp" method="post">
                    <label>Client: <select name="id">
                    
            <%
            try{
                Class.forName("com.mysql.jdbc.Driver");
                    
                // connect to name of server, username and password
                Connection con = DriverManager.getConnection("jdbc:mysql://"
                            + "localhost:3306/bd_act1", "root", "");
                Statement stmt = con.createStatement();
                
                ResultSet rs = stmt.executeQuery("SELECT * FROM t_client ORDER BY name ASC");
                    while (rs.next()) {
                       
                        out.print("<option value ='" + rs.getInt("id") +"'>" +  rs.getString("name") +" </option>");
                         
                    }
                    rs.close();
                    stmt.close();
                    con.close();
            }catch(Exception e) {
                    out.print("An error occurred: " + e.getMessage());        
            }
            %>
                </select></label>
                <input type="submit" value="Remove">
                <input type="button" value="Return to main page" onclick="history.go(-1)">
                </form>
            </article>
        </section> 
    </body>
</html>