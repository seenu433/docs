﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1378
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="NORTHWND")>  _
Partial Public Class northwindDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCustomer(instance As Customer)
    End Sub
  Partial Private Sub UpdateCustomer(instance As Customer)
    End Sub
  Partial Private Sub DeleteCustomer(instance As Customer)
    End Sub
  Partial Private Sub InsertOrder(instance As [Order])
    End Sub
  Partial Private Sub UpdateOrder(instance As [Order])
    End Sub
  Partial Private Sub DeleteOrder(instance As [Order])
    End Sub
  #End Region
	
	Shared Sub New()
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New()
		MyBase.New(Global.StoredProcedureHowTo.My.MySettings.Default.NORTHWNDConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
		Get
			Return Me.GetTable(Of Customer)
		End Get
	End Property
	
	Public ReadOnly Property Orders() As System.Data.Linq.Table(Of [Order])
		Get
			Return Me.GetTable(Of [Order])
		End Get
	End Property
	
	<FunctionAttribute(Name:="dbo.[Ten Most Expensive Products]")>  _
	Public Function Ten_Most_Expensive_Products() As ISingleResult(Of Ten_Most_Expensive_ProductsResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of Ten_Most_Expensive_ProductsResult))
	End Function
	
	<FunctionAttribute(Name:="dbo.[Sales by Year]")>  _
	Public Function Sales_by_Year(<Parameter(Name:="Beginning_Date", DbType:="DateTime")> ByVal beginning_Date As System.Nullable(Of Date), <Parameter(Name:="Ending_Date", DbType:="DateTime")> ByVal ending_Date As System.Nullable(Of Date)) As ISingleResult(Of Sales_by_YearResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), beginning_Date, ending_Date)
		Return CType(result.ReturnValue,ISingleResult(Of Sales_by_YearResult))
	End Function
End Class

<Table(Name:="dbo.Customers")>  _
Partial Public Class Customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CustomerID As String
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _ContactTitle As String
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _Phone As String
	
	Private _Fax As String
	
	Private _Orders As EntitySet(Of [Order])
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnCompanyNameChanging(value As String)
    End Sub
    Partial Private Sub OnCompanyNameChanged()
    End Sub
    Partial Private Sub OnContactNameChanging(value As String)
    End Sub
    Partial Private Sub OnContactNameChanged()
    End Sub
    Partial Private Sub OnContactTitleChanging(value As String)
    End Sub
    Partial Private Sub OnContactTitleChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnRegionChanging(value As String)
    End Sub
    Partial Private Sub OnRegionChanged()
    End Sub
    Partial Private Sub OnPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostalCodeChanged()
    End Sub
    Partial Private Sub OnCountryChanging(value As String)
    End Sub
    Partial Private Sub OnCountryChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnFaxChanging(value As String)
    End Sub
    Partial Private Sub OnFaxChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._Orders = New EntitySet(Of [Order])(AddressOf Me.attach_Orders, AddressOf Me.detach_Orders)
	End Sub
	
	<Column(Storage:="_CustomerID", DbType:="NChar(5) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If ((Me._CustomerID = value)  _
						= false) Then
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_CompanyName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If ((Me._CompanyName = value)  _
						= false) Then
				Me.OnCompanyNameChanging(value)
				Me.SendPropertyChanging
				Me._CompanyName = value
				Me.SendPropertyChanged("CompanyName")
				Me.OnCompanyNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ContactName", DbType:="NVarChar(30)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If ((Me._ContactName = value)  _
						= false) Then
				Me.OnContactNameChanging(value)
				Me.SendPropertyChanging
				Me._ContactName = value
				Me.SendPropertyChanged("ContactName")
				Me.OnContactNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ContactTitle", DbType:="NVarChar(30)")>  _
	Public Property ContactTitle() As String
		Get
			Return Me._ContactTitle
		End Get
		Set
			If ((Me._ContactTitle = value)  _
						= false) Then
				Me.OnContactTitleChanging(value)
				Me.SendPropertyChanging
				Me._ContactTitle = value
				Me.SendPropertyChanged("ContactTitle")
				Me.OnContactTitleChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If ((Me._Address = value)  _
						= false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If ((Me._City = value)  _
						= false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If ((Me._Region = value)  _
						= false) Then
				Me.OnRegionChanging(value)
				Me.SendPropertyChanging
				Me._Region = value
				Me.SendPropertyChanged("Region")
				Me.OnRegionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If ((Me._PostalCode = value)  _
						= false) Then
				Me.OnPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._PostalCode = value
				Me.SendPropertyChanged("PostalCode")
				Me.OnPostalCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If ((Me._Country = value)  _
						= false) Then
				Me.OnCountryChanging(value)
				Me.SendPropertyChanging
				Me._Country = value
				Me.SendPropertyChanged("Country")
				Me.OnCountryChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Phone", DbType:="NVarChar(24)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If ((Me._Phone = value)  _
						= false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Fax", DbType:="NVarChar(24)")>  _
	Public Property Fax() As String
		Get
			Return Me._Fax
		End Get
		Set
			If ((Me._Fax = value)  _
						= false) Then
				Me.OnFaxChanging(value)
				Me.SendPropertyChanging
				Me._Fax = value
				Me.SendPropertyChanged("Fax")
				Me.OnFaxChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Customer_Order", Storage:="_Orders", OtherKey:="CustomerID")>  _
	Public Property Orders() As EntitySet(Of [Order])
		Get
			Return Me._Orders
		End Get
		Set
			Me._Orders.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Me
		Me.SendPropertyChanged("Orders")
	End Sub
	
	Private Sub detach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Nothing
		Me.SendPropertyChanged("Orders")
	End Sub
End Class

<Table(Name:="dbo.Orders")>  _
Partial Public Class [Order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderID As Integer = CType(Nothing, Integer)
	
	Private _CustomerID As String
	
	Private _EmployeeID As System.Nullable(Of Integer)
	
	Private _OrderDate As System.Nullable(Of Date)
	
	Private _RequiredDate As System.Nullable(Of Date)
	
	Private _ShippedDate As System.Nullable(Of Date)
	
	Private _ShipVia As System.Nullable(Of Integer)
	
	Private _Freight As System.Nullable(Of Decimal)
	
	Private _ShipName As String
	
	Private _ShipAddress As String
	
	Private _ShipCity As String
	
	Private _ShipRegion As String
	
	Private _ShipPostalCode As String
	
	Private _ShipCountry As String
	
	Private _Customer As EntityRef(Of Customer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate()
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnEmployeeIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnEmployeeIDChanged()
    End Sub
    Partial Private Sub OnOrderDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnOrderDateChanged()
    End Sub
    Partial Private Sub OnRequiredDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnRequiredDateChanged()
    End Sub
    Partial Private Sub OnShippedDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnShippedDateChanged()
    End Sub
    Partial Private Sub OnShipViaChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnShipViaChanged()
    End Sub
    Partial Private Sub OnFreightChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnFreightChanged()
    End Sub
    Partial Private Sub OnShipNameChanging(value As String)
    End Sub
    Partial Private Sub OnShipNameChanged()
    End Sub
    Partial Private Sub OnShipAddressChanging(value As String)
    End Sub
    Partial Private Sub OnShipAddressChanged()
    End Sub
    Partial Private Sub OnShipCityChanging(value As String)
    End Sub
    Partial Private Sub OnShipCityChanged()
    End Sub
    Partial Private Sub OnShipRegionChanging(value As String)
    End Sub
    Partial Private Sub OnShipRegionChanged()
    End Sub
    Partial Private Sub OnShipPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnShipPostalCodeChanged()
    End Sub
    Partial Private Sub OnShipCountryChanging(value As String)
    End Sub
    Partial Private Sub OnShipCountryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
		Me._Customer = CType(Nothing, EntityRef(Of Customer))
	End Sub
	
	<Column(Storage:="_OrderID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true, UpdateCheck:=UpdateCheck.Never)>  _
	Public ReadOnly Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
	End Property
	
	<Column(Storage:="_CustomerID", DbType:="NChar(5)")>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If ((Me._CustomerID = value)  _
						= false) Then
				If Me._Customer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_EmployeeID", DbType:="Int")>  _
	Public Property EmployeeID() As System.Nullable(Of Integer)
		Get
			Return Me._EmployeeID
		End Get
		Set
			If (Me._EmployeeID.Equals(value) = false) Then
				Me.OnEmployeeIDChanging(value)
				Me.SendPropertyChanging
				Me._EmployeeID = value
				Me.SendPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_OrderDate", DbType:="DateTime")>  _
	Public Property OrderDate() As System.Nullable(Of Date)
		Get
			Return Me._OrderDate
		End Get
		Set
			If (Me._OrderDate.Equals(value) = false) Then
				Me.OnOrderDateChanging(value)
				Me.SendPropertyChanging
				Me._OrderDate = value
				Me.SendPropertyChanged("OrderDate")
				Me.OnOrderDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_RequiredDate", DbType:="DateTime")>  _
	Public Property RequiredDate() As System.Nullable(Of Date)
		Get
			Return Me._RequiredDate
		End Get
		Set
			If (Me._RequiredDate.Equals(value) = false) Then
				Me.OnRequiredDateChanging(value)
				Me.SendPropertyChanging
				Me._RequiredDate = value
				Me.SendPropertyChanged("RequiredDate")
				Me.OnRequiredDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShippedDate", DbType:="DateTime")>  _
	Public Property ShippedDate() As System.Nullable(Of Date)
		Get
			Return Me._ShippedDate
		End Get
		Set
			If (Me._ShippedDate.Equals(value) = false) Then
				Me.OnShippedDateChanging(value)
				Me.SendPropertyChanging
				Me._ShippedDate = value
				Me.SendPropertyChanged("ShippedDate")
				Me.OnShippedDateChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipVia", DbType:="Int")>  _
	Public Property ShipVia() As System.Nullable(Of Integer)
		Get
			Return Me._ShipVia
		End Get
		Set
			If (Me._ShipVia.Equals(value) = false) Then
				Me.OnShipViaChanging(value)
				Me.SendPropertyChanging
				Me._ShipVia = value
				Me.SendPropertyChanged("ShipVia")
				Me.OnShipViaChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Freight", DbType:="Money")>  _
	Public Property Freight() As System.Nullable(Of Decimal)
		Get
			Return Me._Freight
		End Get
		Set
			If (Me._Freight.Equals(value) = false) Then
				Me.OnFreightChanging(value)
				Me.SendPropertyChanging
				Me._Freight = value
				Me.SendPropertyChanged("Freight")
				Me.OnFreightChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipName", DbType:="NVarChar(40)")>  _
	Public Property ShipName() As String
		Get
			Return Me._ShipName
		End Get
		Set
			If ((Me._ShipName = value)  _
						= false) Then
				Me.OnShipNameChanging(value)
				Me.SendPropertyChanging
				Me._ShipName = value
				Me.SendPropertyChanged("ShipName")
				Me.OnShipNameChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipAddress", DbType:="NVarChar(60)")>  _
	Public Property ShipAddress() As String
		Get
			Return Me._ShipAddress
		End Get
		Set
			If ((Me._ShipAddress = value)  _
						= false) Then
				Me.OnShipAddressChanging(value)
				Me.SendPropertyChanging
				Me._ShipAddress = value
				Me.SendPropertyChanged("ShipAddress")
				Me.OnShipAddressChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipCity", DbType:="NVarChar(15)")>  _
	Public Property ShipCity() As String
		Get
			Return Me._ShipCity
		End Get
		Set
			If ((Me._ShipCity = value)  _
						= false) Then
				Me.OnShipCityChanging(value)
				Me.SendPropertyChanging
				Me._ShipCity = value
				Me.SendPropertyChanged("ShipCity")
				Me.OnShipCityChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipRegion", DbType:="NVarChar(15)")>  _
	Public Property ShipRegion() As String
		Get
			Return Me._ShipRegion
		End Get
		Set
			If ((Me._ShipRegion = value)  _
						= false) Then
				Me.OnShipRegionChanging(value)
				Me.SendPropertyChanging
				Me._ShipRegion = value
				Me.SendPropertyChanged("ShipRegion")
				Me.OnShipRegionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipPostalCode", DbType:="NVarChar(10)")>  _
	Public Property ShipPostalCode() As String
		Get
			Return Me._ShipPostalCode
		End Get
		Set
			If ((Me._ShipPostalCode = value)  _
						= false) Then
				Me.OnShipPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._ShipPostalCode = value
				Me.SendPropertyChanged("ShipPostalCode")
				Me.OnShipPostalCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_ShipCountry", DbType:="NVarChar(15)")>  _
	Public Property ShipCountry() As String
		Get
			Return Me._ShipCountry
		End Get
		Set
			If ((Me._ShipCountry = value)  _
						= false) Then
				Me.OnShipCountryChanging(value)
				Me.SendPropertyChanging
				Me._ShipCountry = value
				Me.SendPropertyChanged("ShipCountry")
				Me.OnShipCountryChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Customer_Order", Storage:="_Customer", ThisKey:="CustomerID", IsForeignKey:=true)>  _
	Public Property Customer() As Customer
		Get
			Return Me._Customer.Entity
		End Get
		Set
			Dim previousValue As Customer = Me._Customer.Entity
			If (((previousValue Is value)  _
						= false)  _
						OrElse (Me._Customer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Customer.Entity = Nothing
					previousValue.Orders.Remove(Me)
				End If
				Me._Customer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Orders.Add(Me)
					Me._CustomerID = value.CustomerID
				Else
					Me._CustomerID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Customer")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

Partial Public Class Ten_Most_Expensive_ProductsResult
	
	Private _TenMostExpensiveProducts As String
	
	Private _UnitPrice As System.Nullable(Of Decimal)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_TenMostExpensiveProducts", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property TenMostExpensiveProducts() As String
		Get
			Return Me._TenMostExpensiveProducts
		End Get
		Set
			If ((Me._TenMostExpensiveProducts = value)  _
						= false) Then
				Me._TenMostExpensiveProducts = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_UnitPrice", DbType:="Money")>  _
	Public Property UnitPrice() As System.Nullable(Of Decimal)
		Get
			Return Me._UnitPrice
		End Get
		Set
			If (Me._UnitPrice.Equals(value) = false) Then
				Me._UnitPrice = value
			End If
		End Set
	End Property
End Class

Partial Public Class Sales_by_YearResult
	
	Private _ShippedDate As System.Nullable(Of Date)
	
	Private _OrderID As Integer
	
	Private _Subtotal As System.Nullable(Of Decimal)
	
	Private _Year As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Column(Storage:="_ShippedDate", DbType:="DateTime")>  _
	Public Property ShippedDate() As System.Nullable(Of Date)
		Get
			Return Me._ShippedDate
		End Get
		Set
			If (Me._ShippedDate.Equals(value) = false) Then
				Me._ShippedDate = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_OrderID", DbType:="Int NOT NULL")>  _
	Public Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
		Set
			If ((Me._OrderID = value)  _
						= false) Then
				Me._OrderID = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_Subtotal", DbType:="Money")>  _
	Public Property Subtotal() As System.Nullable(Of Decimal)
		Get
			Return Me._Subtotal
		End Get
		Set
			If (Me._Subtotal.Equals(value) = false) Then
				Me._Subtotal = value
			End If
		End Set
	End Property
	
	<Column(Storage:="_Year", DbType:="NVarChar(30)")>  _
	Public Property Year() As String
		Get
			Return Me._Year
		End Get
		Set
			If ((Me._Year = value)  _
						= false) Then
				Me._Year = value
			End If
		End Set
	End Property
End Class
