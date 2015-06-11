# Synopsis

This is a Visual Studio Code (VSCode) project to demonstrate an all-in-one application that uses a client-side 
javascript framework on the client and a rest service (WebAPI) and entity framework on the server. In particular,
this project uses ASP.Net 5, MVC 6, Entity Framework 7, Nuget, Node, Gulp, Ember 1.11, Ember-Data, Typescript and Yeoman.

Follow the instructions located [here](https://code.visualstudio.com/) to setup Visual Studio Code on your
machine.

# Creating Ember on the Client

### Based Upon the Following Articles

- [Creating a Ember.js app with Node.js, Express.js, Jade.js and Gulp.js](http://jb.demonte.fr/blog/nodejs-app-with-expressjs-emberjs-stylus-jade-handlebars-jquery-gulpjs/)
- [Visual Studio Code - Developing Node Applications](https://code.visualstudio.com/Docs/nodejs)

### Compiling Templates using Gulp

- [Ember Documentation](http://emberjs.com/blog/2015/02/05/compiling-templates-in-1-10-0.html)
- [gulp-htmlbars-compiler](https://www.npmjs.com/package/gulp-htmlbars-compiler)

### GitHub

- [.gitignore](https://help.github.com/articles/ignoring-files/)

# Creating WebAPI and Entity Framework on the Server

### Starting up the service

After starting the server using dnx:web (Microsoft.AspNet.Hosting) 

- [For example, call the values controller - all values](http://localhost:5000/api/values) 
- [For example, call the values controller - api/values/5](http://localhost:5000/api/values/1)

### Web API construction and camel casing
 
- [Create a Web API in MVC 6](http://www.asp.net/vnext/overview/aspnet-vnext/create-a-web-api-with-mvc-6)
- [Migrating from Web API 2](http://docs.asp.net/en/latest/mvc/migration/migratingfromwebapi2.html)

### Entity framework

- [ASP.NET 5 and EF 7](http://www.dotnetcurry.com/showarticle.aspx?ID=1128)
- [A look at ASP.NET 5 ](http://wildermuth.com/2015/03/17/A_Look_at_ASP_NET_5_Part_3_-_EF7)
- [Getting started with ASP.NET 5](http://bitoftech.net/2014/11/18/getting-started-asp-net-5-mvc-6-web-api-entity-framework-7/)
- [ASP.NET 5 Entity Framework 7](http://stephenwalther.com/archive/2015/01/17/asp-net-5-and-angularjs-part-4-using-entity-framework-7)
- [EF7 in Traditional .NET Applications](https://github.com/aspnet/EntityFramework/wiki/Using-EF7-in-Traditional-.NET-Applications)
- [EF7 Migrations: DNX Commands](http://www.bricelam.net/2014/09/14/migrations-on-k.html)
- Initial migration steps

<pre><code>	dnu restore	
	cd src\MyProject	
	dnx . ef		
	dnx . ef migration add initialMigration	
	dnx . ef migration apply
</code></pre>

# project.json

[Project.json file](https://github.com/aspnet/Home/wiki/Project.json-file)

# Things to Do

- Fix the app.UseWelcomePage splash page - <font color='green'>done</font>
- Hook in the Entity Framework - <font color='green'>done</font>
- Initiate migrations - <font color='green'>done</font>
- Figure out how to seed the database using code instead of using a SQL script
- Create a Sales database with Products and Codes tables - <font color='green'>done</font>
- Figure out how to use the config.json instead of hardcoding the connection string
- Build out a CodeController - <font color='green'>done</font>
- Rename the application - <font color='green'>done</font>
- Build out a visual studio code folder in documents - <font color='green'>done</font>
- Figure how to ignore and regenerate node modules - <font color='green'>done</font>
- Build local git repository
- Publish to git
- Figure out differences between both 'Web' and 'Kestrel' web servers
- Trim down the .gitignore file
- Figure out how to use the the launch.json file
- Figure out how the tasks.json file is used - <font color='green'>done</font>
- Use ember data to talk to the WebAPI - <font color='green'>done</font>
- Figure how to use a default route - <font color='green'>done</font>
- Refresh node_modules - <font color='green'>done</font>

>This is a block quote
