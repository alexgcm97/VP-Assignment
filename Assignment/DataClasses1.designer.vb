﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Assignment")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertMenu(instance As Menu)
    End Sub
  Partial Private Sub UpdateMenu(instance As Menu)
    End Sub
  Partial Private Sub DeleteMenu(instance As Menu)
    End Sub
  Partial Private Sub InsertOrder(instance As [Order])
    End Sub
  Partial Private Sub UpdateOrder(instance As [Order])
    End Sub
  Partial Private Sub DeleteOrder(instance As [Order])
    End Sub
  Partial Private Sub InsertOrderDetail(instance As OrderDetail)
    End Sub
  Partial Private Sub UpdateOrderDetail(instance As OrderDetail)
    End Sub
  Partial Private Sub DeleteOrderDetail(instance As OrderDetail)
    End Sub
  Partial Private Sub InsertStaff(instance As Staff)
    End Sub
  Partial Private Sub UpdateStaff(instance As Staff)
    End Sub
  Partial Private Sub DeleteStaff(instance As Staff)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Assignment.My.MySettings.Default.AssignmentConnectionString, mappingSource)
		OnCreated
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
	
	Public ReadOnly Property Menus() As System.Data.Linq.Table(Of Menu)
		Get
			Return Me.GetTable(Of Menu)
		End Get
	End Property
	
	Public ReadOnly Property Orders() As System.Data.Linq.Table(Of [Order])
		Get
			Return Me.GetTable(Of [Order])
		End Get
	End Property
	
	Public ReadOnly Property OrderDetails() As System.Data.Linq.Table(Of OrderDetail)
		Get
			Return Me.GetTable(Of OrderDetail)
		End Get
	End Property
	
	Public ReadOnly Property Staffs() As System.Data.Linq.Table(Of Staff)
		Get
			Return Me.GetTable(Of Staff)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Menu")>  _
Partial Public Class Menu
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _MenuID As Integer
	
	Private _MenuName As String
	
	Private _Price As System.Nullable(Of Decimal)
	
	Private _Category As System.Nullable(Of Integer)
	
	Private _OrderDetails As EntitySet(Of OrderDetail)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMenuIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnMenuIDChanged()
    End Sub
    Partial Private Sub OnMenuNameChanging(value As String)
    End Sub
    Partial Private Sub OnMenuNameChanged()
    End Sub
    Partial Private Sub OnPriceChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnPriceChanged()
    End Sub
    Partial Private Sub OnCategoryChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnCategoryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._OrderDetails = New EntitySet(Of OrderDetail)(AddressOf Me.attach_OrderDetails, AddressOf Me.detach_OrderDetails)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MenuID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property MenuID() As Integer
		Get
			Return Me._MenuID
		End Get
		Set
			If ((Me._MenuID = value)  _
						= false) Then
				Me.OnMenuIDChanging(value)
				Me.SendPropertyChanging
				Me._MenuID = value
				Me.SendPropertyChanged("MenuID")
				Me.OnMenuIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MenuName", DbType:="VarChar(40)")>  _
	Public Property MenuName() As String
		Get
			Return Me._MenuName
		End Get
		Set
			If (String.Equals(Me._MenuName, value) = false) Then
				Me.OnMenuNameChanging(value)
				Me.SendPropertyChanging
				Me._MenuName = value
				Me.SendPropertyChanged("MenuName")
				Me.OnMenuNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Price", DbType:="Decimal(18,2)")>  _
	Public Property Price() As System.Nullable(Of Decimal)
		Get
			Return Me._Price
		End Get
		Set
			If (Me._Price.Equals(value) = false) Then
				Me.OnPriceChanging(value)
				Me.SendPropertyChanging
				Me._Price = value
				Me.SendPropertyChanged("Price")
				Me.OnPriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Category", DbType:="Int")>  _
	Public Property Category() As System.Nullable(Of Integer)
		Get
			Return Me._Category
		End Get
		Set
			If (Me._Category.Equals(value) = false) Then
				Me.OnCategoryChanging(value)
				Me.SendPropertyChanging
				Me._Category = value
				Me.SendPropertyChanged("Category")
				Me.OnCategoryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Menu_OrderDetail", Storage:="_OrderDetails", ThisKey:="MenuID", OtherKey:="MenuID")>  _
	Public Property OrderDetails() As EntitySet(Of OrderDetail)
		Get
			Return Me._OrderDetails
		End Get
		Set
			Me._OrderDetails.Assign(value)
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
	
	Private Sub attach_OrderDetails(ByVal entity As OrderDetail)
		Me.SendPropertyChanging
		entity.Menu = Me
	End Sub
	
	Private Sub detach_OrderDetails(ByVal entity As OrderDetail)
		Me.SendPropertyChanging
		entity.Menu = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Orders")>  _
Partial Public Class [Order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderID As Integer
	
	Private _OrderDate As Date
	
	Private _OrderDetails As EntitySet(Of OrderDetail)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnOrderDateChanging(value As Date)
    End Sub
    Partial Private Sub OnOrderDateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._OrderDetails = New EntitySet(Of OrderDetail)(AddressOf Me.attach_OrderDetails, AddressOf Me.detach_OrderDetails)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
		Set
			If ((Me._OrderID = value)  _
						= false) Then
				Me.OnOrderIDChanging(value)
				Me.SendPropertyChanging
				Me._OrderID = value
				Me.SendPropertyChanged("OrderID")
				Me.OnOrderIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderDate", DbType:="DateTime NOT NULL")>  _
	Public Property OrderDate() As Date
		Get
			Return Me._OrderDate
		End Get
		Set
			If ((Me._OrderDate = value)  _
						= false) Then
				Me.OnOrderDateChanging(value)
				Me.SendPropertyChanging
				Me._OrderDate = value
				Me.SendPropertyChanged("OrderDate")
				Me.OnOrderDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_OrderDetail", Storage:="_OrderDetails", ThisKey:="OrderID", OtherKey:="OrderID")>  _
	Public Property OrderDetails() As EntitySet(Of OrderDetail)
		Get
			Return Me._OrderDetails
		End Get
		Set
			Me._OrderDetails.Assign(value)
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
	
	Private Sub attach_OrderDetails(ByVal entity As OrderDetail)
		Me.SendPropertyChanging
		entity.[Order] = Me
	End Sub
	
	Private Sub detach_OrderDetails(ByVal entity As OrderDetail)
		Me.SendPropertyChanging
		entity.[Order] = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.OrderDetails")>  _
Partial Public Class OrderDetail
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderID As Integer
	
	Private _MenuID As Integer
	
	Private _Quantity As System.Nullable(Of Integer)
	
	Private _SubTotal As System.Nullable(Of Decimal)
	
	Private _Menu As EntityRef(Of Menu)
	
	Private _Order As EntityRef(Of [Order])
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnMenuIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnMenuIDChanged()
    End Sub
    Partial Private Sub OnQuantityChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnQuantityChanged()
    End Sub
    Partial Private Sub OnSubTotalChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnSubTotalChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Menu = CType(Nothing, EntityRef(Of Menu))
		Me._Order = CType(Nothing, EntityRef(Of [Order]))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
		Set
			If ((Me._OrderID = value)  _
						= false) Then
				If Me._Order.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnOrderIDChanging(value)
				Me.SendPropertyChanging
				Me._OrderID = value
				Me.SendPropertyChanged("OrderID")
				Me.OnOrderIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MenuID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property MenuID() As Integer
		Get
			Return Me._MenuID
		End Get
		Set
			If ((Me._MenuID = value)  _
						= false) Then
				If Me._Menu.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnMenuIDChanging(value)
				Me.SendPropertyChanging
				Me._MenuID = value
				Me.SendPropertyChanged("MenuID")
				Me.OnMenuIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Quantity", DbType:="Int")>  _
	Public Property Quantity() As System.Nullable(Of Integer)
		Get
			Return Me._Quantity
		End Get
		Set
			If (Me._Quantity.Equals(value) = false) Then
				Me.OnQuantityChanging(value)
				Me.SendPropertyChanging
				Me._Quantity = value
				Me.SendPropertyChanged("Quantity")
				Me.OnQuantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SubTotal", DbType:="Decimal(18,2)")>  _
	Public Property SubTotal() As System.Nullable(Of Decimal)
		Get
			Return Me._SubTotal
		End Get
		Set
			If (Me._SubTotal.Equals(value) = false) Then
				Me.OnSubTotalChanging(value)
				Me.SendPropertyChanging
				Me._SubTotal = value
				Me.SendPropertyChanged("SubTotal")
				Me.OnSubTotalChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Menu_OrderDetail", Storage:="_Menu", ThisKey:="MenuID", OtherKey:="MenuID", IsForeignKey:=true)>  _
	Public Property Menu() As Menu
		Get
			Return Me._Menu.Entity
		End Get
		Set
			Dim previousValue As Menu = Me._Menu.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Menu.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Menu.Entity = Nothing
					previousValue.OrderDetails.Remove(Me)
				End If
				Me._Menu.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OrderDetails.Add(Me)
					Me._MenuID = value.MenuID
				Else
					Me._MenuID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Menu")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_OrderDetail", Storage:="_Order", ThisKey:="OrderID", OtherKey:="OrderID", IsForeignKey:=true)>  _
	Public Property [Order]() As [Order]
		Get
			Return Me._Order.Entity
		End Get
		Set
			Dim previousValue As [Order] = Me._Order.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Order.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Order.Entity = Nothing
					previousValue.OrderDetails.Remove(Me)
				End If
				Me._Order.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.OrderDetails.Add(Me)
					Me._OrderID = value.OrderID
				Else
					Me._OrderID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("[Order]")
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

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Staff")>  _
Partial Public Class Staff
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Password As String
	
	Private _Name As String
	
	Private _IcNo As String
	
	Private _Gender As String
	
	Private _ContactNo As String
	
	Private _Email As String
	
	Private _Address As String
	
	Private _State As String
	
	Private _Town As String
	
	Private _Postcode As String
	
	Private _Position As String
	
	Private _Status As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnIcNoChanging(value As String)
    End Sub
    Partial Private Sub OnIcNoChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnContactNoChanging(value As String)
    End Sub
    Partial Private Sub OnContactNoChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnStateChanging(value As String)
    End Sub
    Partial Private Sub OnStateChanged()
    End Sub
    Partial Private Sub OnTownChanging(value As String)
    End Sub
    Partial Private Sub OnTownChanged()
    End Sub
    Partial Private Sub OnPostcodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostcodeChanged()
    End Sub
    Partial Private Sub OnPositionChanging(value As String)
    End Sub
    Partial Private Sub OnPositionChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As String)
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IcNo", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property IcNo() As String
		Get
			Return Me._IcNo
		End Get
		Set
			If (String.Equals(Me._IcNo, value) = false) Then
				Me.OnIcNoChanging(value)
				Me.SendPropertyChanging
				Me._IcNo = value
				Me.SendPropertyChanged("IcNo")
				Me.OnIcNoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactNo", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ContactNo() As String
		Get
			Return Me._ContactNo
		End Get
		Set
			If (String.Equals(Me._ContactNo, value) = false) Then
				Me.OnContactNoChanging(value)
				Me.SendPropertyChanging
				Me._ContactNo = value
				Me.SendPropertyChanged("ContactNo")
				Me.OnContactNoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_State", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property State() As String
		Get
			Return Me._State
		End Get
		Set
			If (String.Equals(Me._State, value) = false) Then
				Me.OnStateChanging(value)
				Me.SendPropertyChanging
				Me._State = value
				Me.SendPropertyChanged("State")
				Me.OnStateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Town", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Town() As String
		Get
			Return Me._Town
		End Get
		Set
			If (String.Equals(Me._Town, value) = false) Then
				Me.OnTownChanging(value)
				Me.SendPropertyChanging
				Me._Town = value
				Me.SendPropertyChanged("Town")
				Me.OnTownChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Postcode", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Postcode() As String
		Get
			Return Me._Postcode
		End Get
		Set
			If (String.Equals(Me._Postcode, value) = false) Then
				Me.OnPostcodeChanging(value)
				Me.SendPropertyChanging
				Me._Postcode = value
				Me.SendPropertyChanged("Postcode")
				Me.OnPostcodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Position", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Position() As String
		Get
			Return Me._Position
		End Get
		Set
			If (String.Equals(Me._Position, value) = false) Then
				Me.OnPositionChanging(value)
				Me.SendPropertyChanging
				Me._Position = value
				Me.SendPropertyChanged("Position")
				Me.OnPositionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Status() As String
		Get
			Return Me._Status
		End Get
		Set
			If (String.Equals(Me._Status, value) = false) Then
				Me.OnStatusChanging(value)
				Me.SendPropertyChanging
				Me._Status = value
				Me.SendPropertyChanged("Status")
				Me.OnStatusChanged
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
