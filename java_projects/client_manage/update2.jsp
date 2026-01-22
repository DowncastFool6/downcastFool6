<%-- 
    Document   : Updating Client 
    Created on : 19 Jan 2026, 15:06:42
    Author     : Vissolela Cundi
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
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
            <%               
            try {
                int id = Integer.parseInt(request.getParameter("id"));
                Class.forName("com.mysql.jdbc.Driver");
                    
                // connect to name of server, username and password
                Connection con = DriverManager.getConnection("jdbc:mysql://"
                            + "localhost:3306/bd_act1", "root", "");
                PreparedStatement pstm = con.prepareStatement("SELECT * FROM t_client WHERE id=?");
                
                pstm.setInt(1, id);
                    
                // execute instruction to the database
                ResultSet rs = pstm.executeQuery();
                    if (rs.next()) {
            %>
                    <form action="update3.jsp" method="post">
                        <label>Id: <input type="text" name="id" size="10" maxlength="10"
                                value="<%= rs.getInt("id")%>" readyonly></label><br><br>
                        <label>Name: <input type="text" name="name" size="60" maxlength="100"
                                value="<%= rs.getString("name")%>" required></label><br><br>
                        <label>Address: <input type="text" name="address" size="60" maxlength="100"
                                value="<%= rs.getString("address")%>" required></label><br><br>
                        <label>Zone: <input type="text" name="zone" size="50" maxlength="50"
                                value="<%= rs.getString("zone")%>" required></label><br><br>
                        <label>NIF: <input type="text" name="nif" size="20" maxlength="9"
                                value="<%= rs.getInt("nif")%>" required></label><br><br>
                        <label>Volume of invoice: <input type="text" name="vol_invoice" size="10"
                                value="<%= rs.getFloat("vol_invoice")%>" required></label><br><br>
                        <input type="submit" value="Update">
                        <input type="reset" value="Clear">                             
                    </form>
            <%
                    }
            %>
            <%  
                    rs.close();
                    pstm.close();
                    con.close();
                } catch (Exception e) {
                  out.println("An error occurred: " + e.getMessage());        
                }
            %>
            <br>
            <div class="btn-wrapper-left">
                <input type="button" value="Return to main page" onclick="history.go(-1)">
            </div>
            <br>
            </article>
        </section> 
    </body>
</html>
