<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChallengeConditionalRadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note Taking Preferences
    
    </div>
        <br />
        <asp:RadioButton ID="PencilRadioButton" runat="server" GroupName="NoteGroup" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" />
        <br />
        <asp:RadioButton ID="PenRadioButton" runat="server" GroupName="NoteGroup" Text="Pen" />
        <br />
        <asp:RadioButton ID="PhoneRadioButton" runat="server" GroupName="NoteGroup" Text="Phone" />
        <br />
        <asp:RadioButton ID="TabletRadioButton" runat="server" GroupName="NoteGroup" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
