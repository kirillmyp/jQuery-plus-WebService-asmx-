﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test_DB")]
	public partial class MyDC2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertContacts(Contacts instance);
    partial void UpdateContacts(Contacts instance);
    partial void DeleteContacts(Contacts instance);
    partial void InsertTelephones(Telephones instance);
    partial void UpdateTelephones(Telephones instance);
    partial void DeleteTelephones(Telephones instance);
    #endregion
		
		public MyDC2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Test_DBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDC2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDC2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDC2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDC2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Contacts> Contacts
		{
			get
			{
				return this.GetTable<Contacts>();
			}
		}
		
		public System.Data.Linq.Table<Telephones> Telephones
		{
			get
			{
				return this.GetTable<Telephones>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contacts")]
	public partial class Contacts : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _SecondName;
		
		private string _ThirdName;
		
		private int _IdTelephone;
		
		private string _Address;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnSecondNameChanging(string value);
    partial void OnSecondNameChanged();
    partial void OnThirdNameChanging(string value);
    partial void OnThirdNameChanged();
    partial void OnIdTelephoneChanging(int value);
    partial void OnIdTelephoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public Contacts()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecondName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SecondName
		{
			get
			{
				return this._SecondName;
			}
			set
			{
				if ((this._SecondName != value))
				{
					this.OnSecondNameChanging(value);
					this.SendPropertyChanging();
					this._SecondName = value;
					this.SendPropertyChanged("SecondName");
					this.OnSecondNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThirdName", DbType="VarChar(50)")]
		public string ThirdName
		{
			get
			{
				return this._ThirdName;
			}
			set
			{
				if ((this._ThirdName != value))
				{
					this.OnThirdNameChanging(value);
					this.SendPropertyChanging();
					this._ThirdName = value;
					this.SendPropertyChanged("ThirdName");
					this.OnThirdNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTelephone", DbType="Int NOT NULL")]
		public int IdTelephone
		{
			get
			{
				return this._IdTelephone;
			}
			set
			{
				if ((this._IdTelephone != value))
				{
					this.OnIdTelephoneChanging(value);
					this.SendPropertyChanging();
					this._IdTelephone = value;
					this.SendPropertyChanged("IdTelephone");
					this.OnIdTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Telephones")]
	public partial class Telephones : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Telephone_Number;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTelephone_NumberChanging(string value);
    partial void OnTelephone_NumberChanged();
    #endregion
		
		public Telephones()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone_Number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Telephone_Number
		{
			get
			{
				return this._Telephone_Number;
			}
			set
			{
				if ((this._Telephone_Number != value))
				{
					this.OnTelephone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Telephone_Number = value;
					this.SendPropertyChanged("Telephone_Number");
					this.OnTelephone_NumberChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
