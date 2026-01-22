<%-- 
    Document   : List of Clients
    Created on : 16 Jan 2026, 16:34:41
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
            <article>  
            <table style="border: 1px solid black">
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Address</th>
                    <th>Zone</th>
                    <th>NIF</th>
                    <th>Volume of Invoice</th>
                </tr>
            <%
                int num = 0;
                float average = 0;
                
            try {
                Class.forName("com.mysql.jdbc.Driver");
                    
                // connect to name of server, username and password
                Connection con = DriverManager.getConnection("jdbc:mysql://"
                            + "localhost:3306/bd_act1", "root", "");
                Statement stm = con.createStatement();
                    
                // execute instruction to the database
                ResultSet rs = stm.executeQuery("SELECT * FROM t_client");
                    while (rs.next()) {
                        %>
                        <tr>
                            <td><%= rs.getInt("id")%></td>
                            <td><%= rs.getString("name")%></td>
                            <td><%= rs.getString("address")%></td>
                            <td><%= rs.getString("zone")%></td>
                            <td><%= rs.getString("nif")%></td>
                            <td><%= rs.getFloat("vol_invoice")%></td>
                            <% num ++;
                            average = average + rs.getFloat("vol_invoice"); %>
                            </tr>
                            <%
                    }
                            %>
                            <!-- spans over five column spaces and gives the total
                                 of registered data-->
                            <tr><th colspan="5">Number of registers in the database:</th>
                            <th><%= num %></th>
                            <!-- spans over five column spaces and gives the average
                                 volume of invoice-->
                            <tr><th colspan="5">Average volume of invoice:</th>
                            <th><%= average/num %></th>
                <%  
                    rs.close();
                    stm.close();
                    con.close();
                } catch (Exception e) {
                            out.println("An error occurred: " + e.getMessage());        
                }
                %>
            </table>
            <br>
            <div class="btn-wrapper-left">
                <input type="button" value="Return to main page" onclick="history.go(-1)">
            </div>
            </article>
        </section> 
    </body>
</html>
