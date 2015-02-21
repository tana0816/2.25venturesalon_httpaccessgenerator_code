<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="venturesalonsample._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        HDInsight Demo用ページ<br />
        <br />
        HTTP リクエストを1000回送付<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送付" />
    
    </div>
    </form>
</body>
</html>
