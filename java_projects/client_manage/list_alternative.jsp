<%-- 
    Document   : list_alternative (Exclusively JSP)
    Created on : 16 Jan 2026, 17:37:28
    Author     : Vissolela Cundi
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import = "java.sql.*" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
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
                            out.print("<tr>");
                            out.print("<td>" + rs.getInt("id") + "</td>");
                            out.print("<td>" + rs.getString("name") + "</td>");
                            out.print("<td>" + rs.getString("address") + "</td>");
                            out.print("<td>" + rs.getString("zone") + "</td>");
                            out.print("<td>" + rs.getString("nif") + "</td>");
                            out.print("<td>" + rs.getFloat("vol_invoice") + "</td>");
                            out.print("</tr>");
                            num ++;
                            average = average + rs.getFloat("vol_invoice");
                    }        
                            out.print("<tr>");
                            // spans over five column spaces and gives the total 
                            //of registered data
                            out.print("<th colspan='5'>Number of registers in the database:</th>");
                            out.print("<th>" + num + "</th>");
                            out.print("</tr>");
                            
                            out.print("<tr>");
                            // spans over five column spaces and gives the average
                            // volume of invoice
                            out.print("<th colspan='5'>The average volume of invoice:</th>");
                            out.print("<th>" + average/num + "</th>");
                            out.print("</tr>");
                            
                } catch (Exception e) {
                            out.println("An error occurred: " + e);        
                }
                %>
            </table>
            </article>
        </section> 
    </body>
</html>

