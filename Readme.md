<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [MyModel.cs](./CS/Models/MyModel.cs) (VB: [MyModel.vb](./VB/Models/MyModel.vb))
* [_ViewStart.cshtml](./CS/Views/_ViewStart.cshtml)
* [Editors.cshtml](./CS/Views/Home/Editors.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to use Microsoft validation with an AJAX form to validate the Model properties on the client side


<p>The example demonstrates how to validate a Model using validation attributes applied to the Model properties.</p>


<h3>Description</h3>

<p>When an Ajax form returns a View, containing the DevExpress MVC extensions, their scripts and links should be processed using the private method: <strong>_aspxProcessScriptsAndLinks</strong></p><code lang='txt'>
... OnSuccess = "function() { _aspxProcessScriptsAndLinks('', true); }"
</code>

<br/>


