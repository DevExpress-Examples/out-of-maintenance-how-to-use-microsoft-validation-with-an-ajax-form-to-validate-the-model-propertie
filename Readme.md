# How to use Microsoft validation with an AJAX form to validate the Model properties on the client side


<p>The example demonstrates how to validate a Model using validation attributes applied to the Model properties.</p>


<h3>Description</h3>

<p>When an Ajax form returns a View, containing the DevExpress MVC extensions, their scripts and links should be processed using the private method: <strong>_aspxProcessScriptsAndLinks</strong></p><code lang='txt'>
... OnSuccess = "function() { _aspxProcessScriptsAndLinks('', true); }"
</code>

<br/>


