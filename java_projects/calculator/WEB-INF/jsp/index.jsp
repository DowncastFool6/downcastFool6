<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Calculator - VC</title>
    </head>

    <body>
        <h1></h1>
        <form action="calc.jsp" method="post">
            What is the first number: <input type="text" name="n1"><br/><br/>
            What is the second number: <input type="text" name="n2"><br/>
            Choose an operator: <br/>
            <input type="radio" name="op" value="sum" checked>Addition<br/>
            <input type="radio" name="op" value="sub">Subtraction<br/>
            <input type="radio" name="op" value="mul">Multiplication<br/>
            <input type="radio" name="op" value="div">Division<br/><br/>
            <input type="submit" value="Calculate">
            <input type="reset" value="Clear">
        </form>
    </body>
</html>
