<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Library.WebForms.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.css" />
    <link rel="stylesheet" href="../Content/Site.css" />
    <script src="../Scripts/modernizr-2.8.3.js"></script>
    <script>
        function onRemoveBook(bookId) {
            if (confirm("Удалить запись?")) {
                var client = new XMLHttpRequest();
                client.open("GET", "/Book/Remove?bookId=" + bookId, false);
                client.send();
                if (client.status != 200) {
                    alert(client.status + ': ' + client.statusText);
                } else {
                    var response = JSON.parse(client.responseText);
                    if (response) {
                        var books = document.getElementsByClassName(bookId);
                        for (var i = 0; i <= books.length; i++) {
                            while (books[0]) {
                                books[0].remove();
                            }
                        }
                        alert("Запись удалена");
                    } else {
                        alert("Произошла ошибка");
                    }
                }
            }
        }
    </script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a href="/Home/Index" class="navbar-brand">Главная</a>
            </div>
        </div>
    </div>
    <div class="container body-content">
        <div class="panel panel-default" style="margin-top: 20px;">
            <!-- Default panel contents -->
            <div class="panel-heading">Книги</div>

            <asp:Repeater ID="bookRepeater"
                runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <tr>
                            <th scope="col">Id</th>
                            <th scope="col">Название</th>
                            <th scope="col">Автор</th>
                            <th scope="col">Жанр</th>
                            <th scope="col">Дата публикации</th>
                            <th scope="col"></th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="<%# DataBinder.Eval(Container.DataItem, "Id") %>">
                        <td scope="row">
                            <%# DataBinder.Eval(Container.DataItem, "Id") %>
                        </td>
                        <td scope="row">
                            <%# DataBinder.Eval(Container.DataItem, "Name") %>
                        </td>
                        <td scope="row">
                            <%# DataBinder.Eval(Container.DataItem, "Author") %>
                        </td>
                        <td scope="row">
                            <%# DataBinder.Eval(Container.DataItem, "Genre") %>
                        </td>
                        <td scope="row">
                            <%# DataBinder.Eval(Container.DataItem, "ReleaseDate") %>
                        </td>
                    </tr>
                </ItemTemplate>

                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>

        <a href="/Book/Add">Добавить</a>

        <div class="panel panel-default" style="margin-top: 20px;">
            <!-- Default panel contents -->
            <div class="panel-heading">Книги</div>

            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Название</th>
                        <th scope="col">Автор</th>
                        <th scope="col">Жанр</th>
                        <th scope="col">Дата публикации</th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>

                    <% foreach (var book in Books)
                        { %>
                    <tr class="<%= book.Id %>">
                        <td scope="row"><%= book.Id %></td>
                        <td><a href="/Book/Update?bookId=<%= book.Id %>"><%= book.Name %></a></td>
                        <td><%= book.Author %></td>
                        <td><%= book.Genre %></td>
                        <td><%= book.ReleaseDate %></td>
                        <td><a onclick="onRemoveBook(<%= book.Id %>)">Удалить</a></td>
                    </tr>
                    <% } %>
                </tbody>
            </table>
        </div>

        <a href="/Book/Add">Добавить</a>

    </div>
</body>
</html>
