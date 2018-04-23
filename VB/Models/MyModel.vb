Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel.DataAnnotations

Public Class MyModel
	Private privateId? As Int32
	Public Property Id() As Int32?
		Get
			Return privateId
		End Get
		Set(ByVal value? As Int32)
			privateId = value
		End Set
	End Property

	Private privateName As String
	<Required> _
	Public Property Name() As String
		Get
			Return privateName
		End Get
		Set(ByVal value As String)
			privateName = value
		End Set
	End Property

	Private privateAge As Int32
	<Required, Range(18, 50, ErrorMessage := "Age: from 18 to 50")> _
	Public Property Age() As Int32
		Get
			Return privateAge
		End Get
		Set(ByVal value As Int32)
			privateAge = value
		End Set
	End Property

	Private privateOrderDate? As DateTime
	<Required> _
	Public Property OrderDate() As DateTime?
		Get
			Return privateOrderDate
		End Get
		Set(ByVal value? As DateTime)
			privateOrderDate = value
		End Set
	End Property
End Class