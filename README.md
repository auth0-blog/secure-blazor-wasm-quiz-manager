This repository contains a Blazor WebAssembly application implementing a simple Quiz manager secured by [Auth0](https://auth0.com/).

The implementation details are described in the following article: [Securing Blazor WebAssembly Apps](https://auth0.com/blog/securing-blazor-webassembly-apps/)

---
### Technology

This project uses the following technologies:

- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Auth0](https://auth0.com/)

### Running the Application

To run this project, follow these steps:

1. Clone this repository (`git clone https://github.com/auth0-blog/secure-blazor-wasm-quiz-manager.git`)

2. [Register the Blazor WebAssembly client with Auth0](https://auth0.com/blog/securing-blazor-webassembly-apps/#Registering-the-Blazor-WASM-App-with-Auth0)

3. Move to the `secure-blazor-wasm-quiz-manager/Client/wwwroot`  folder in your machine and edit the `appsettings.json` configuration file by filling the Auth0 required parameters

4. [Register the API with Auth0](https://auth0.com/blog/securing-blazor-webassembly-apps/#Securing-the-API-with-Auth0)

5. Move to the `secure-blazor-wasm-quiz-manager/Server`  folder in your machine and edit the `appsettings.json` configuration file by filling the Auth0 required parameters

6. Move to the root folder of the project and run the following command in a terminal window:

   ```shell
   dotnet run --project Server
   ```

7. Now, point your browser to [https://localhost:5001](https://localhost:5001/). You should be able to authenticate and access the application

