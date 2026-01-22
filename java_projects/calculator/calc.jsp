<%-- 
    Document   : calc
    Created on : 12 Jan 2026, 18:54:48
    Author     : Vissolela Cundi
--%>

<%@page contentType="text/html" import="java.util.*, java.text.*, java.lang.String" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Example of a Calculator - VC</title>
    </head>
    <body>
        <% 
            double n1 = Double.parseDouble(request.getParameter("n1"));
            double n2 = Double.parseDouble(request.getParameter("n2"));
            double result = 0;
            
            String op = request.getParameter("op");
            if (op.equals("sum"))
                result = n1 + n2;
            else if (op.equals("sub"))
                result = n1 - n2;
            else if (op.equals("mul"))
                result = n1 * n2;
            else if (op.equals("div")) 
                   if (n2 == 0)
                       out.println("Error: Division by zero is not allowed.");
                   else
                       result = n1 / n2;
            else
                result = n1 + n2;
                   
            out.print("<h1>Calculator</h1>");
            out.print("<h3>The result of " + n1 + " and " + n2 + " = " +result+ "</h3>");
        %>
    </body>
</html>
