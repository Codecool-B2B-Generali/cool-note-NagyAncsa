# Cool Note

## Story

Do you know the feeling when something great comes to your mind,
but there is no paper and pencil nearby so you cannot take a note quickly?
How marvelous would it be to have a web page where you could quickly take a note!

## What are you going to learn?

- Create a new ASP.NET Core project with Razor pages.
- Create a web application in MVVM (Model-View-ViewModel) design pattern
- Work with HTTP requests:
  - Route with ASP.NET Razor pages.
  - Respond differently based on the HTTP request method value.
  - Use redirection.
- Use HTML and Razor template syntax:
  - Use HTML tags, attributes.
  - Work with a `<form>`.
  - Use Razor commands in an HTML file.


## Tasks

1. After you clone the repository of the project it only has a README.md file in it. Set up the project folder so that it meets the following requirements.
    - The folder contains the basic ASP.NET Razor Pages setup (one project-solution).
    - The folder contains a `Pages` folder for `.cshtml` Razor Page files and their respective `.cs` ViewModel files.
    - The folder contains a `Program` class with a `Main` method, which is an entry point to the application. The folder contains a `Startup` class with the generated code that runs the ASP.NET server application. The folder contains a `DataManager` static class, which contains two static properties: `string Note` and `int EditsAmount`.

2. Set up the application so that it has two Razor Pages, - `Index` and `Note`.
    - The application has an `Index` page, which serves as the main page (under route `/`).
    - The application has a `Note` page, which allows adding and editing notes.
    - The `Note` page can handle GET and POST requests.

3. Create the main page with the following features.
    - If there are no saved notes, a text indicates this in the first `<p>` tag on the page.
    - If there is a saved note, it is displayed in the first `<p>` element.
    - There is an edit counter in a `<small>` tag that updates every time a note is edited. The counter starts from 0.
    - There is a link to the `Note` page.

4. Create a note page with the following features.
    - Sending a request with the GET method to the `Note` page results in displaying a form.
    - The form has a `<textarea>` with a `<label>` and a submit `<button>`.
    - Clicking the submit button results in the browser sending an HTTP request to the `Note` page with POST method.
    - Submitting the form redirects to the main page. The saved note can be read on the main page.

## General requirements

None

## Hints



## Background materials

- <i class="far fa-exclamation"></i> [Introduction to HTML](project/curriculum/materials/tutorials/introduction-to-html.md)
- <i class="far fa-book-open"></i> [htmlreference.io](https://htmlreference.io/)
- <i class="far fa-book-open"></i> [HTML tutorials and references on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML)
- <i class="far fa-book-open"></i> [The official page of the HTML standard](https://html.spec.whatwg.org/multipage/)
- <i class="far fa-book-open"></i> [Ports](project/curriculum/materials/pages/networks/ports.md)
- <i class="far fa-book-open"></i> [What are environment variables?](https://medium.com/chingu/an-introduction-to-environment-variables-and-how-to-use-them-f602f66d15fa)
- <i class="far fa-exclamation"></i> [Razor syntax for ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor)
- <i class="far fa-exclamation"></i> [ASP.NET Razor Pages quickstart](https://docs.microsoft.com/en-us/visualstudio/ide/quickstart-aspnet-core)
- <i class="far fa-book-open"></i> [MVC vs MVVM](https://www.guru99.com/mvc-vs-mvvm.html)
- <i class="far fa-candy-cane"></i> [Cool Note step-by-step project guide](project/curriculum/materials/pages/web/cool-note-guide-csharp.md)
