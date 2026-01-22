<%-- 
    Document   : Updating Clients
    Created on : 19 Jan 2026, 14:48:40
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
            <h2>Updating Clients</h2>
            <article>
                <form action="update2.jsp" method="post">
                    <label>Which client would you like to update: <select name="id">
                    
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
                <input type="submit" value="Update">
                <input type="button" value="Return to main page" onclick="history.go(-1)">
                </form>
            </article>
        </section> 
    </body>
</html>