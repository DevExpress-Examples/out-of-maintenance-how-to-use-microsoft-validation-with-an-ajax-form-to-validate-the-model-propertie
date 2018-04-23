Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Return View(New MyModel() With {.Id = 1, .Name = "Test", .Age = 17})
		End Function

		<HttpPost> _
		Public Function PostData(<ModelBinder(GetType(DevExpress.Web.Mvc.DevExpressEditorsBinder))> ByVal model As MyModel) As ActionResult
			If (Not ModelState.IsValid) Then
				Return PartialView("Editors", model)
			End If

			Return PartialView("Success")
		End Function
	End Class
End Namespace
