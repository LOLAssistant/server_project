﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.237
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LOLAssistantDataBase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertlol(lol instance);
    partial void Updatelol(lol instance);
    partial void Deletelol(lol instance);
    partial void Insertdistrict(district instance);
    partial void Updatedistrict(district instance);
    partial void Deletedistrict(district instance);
    #endregion
		
		public DataClasses1DataContext() :
        base(global::DAO.Properties.Settings.Default.LOLAssistantDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> user
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<lol> lol
		{
			get
			{
				return this.GetTable<lol>();
			}
		}
		
		public System.Data.Linq.Table<infodistrict> infodistrict
		{
			get
			{
				return this.GetTable<infodistrict>();
			}
		}
		
		public System.Data.Linq.Table<district> district
		{
			get
			{
				return this.GetTable<district>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _password;
		
		private string _nickname;
		
		private string _ID;
		
		private int _levelpoint;
		
		private string _phone;
		
		private string _e_mail;
		
		private EntitySet<lol> _lol;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnicknameChanging(string value);
    partial void OnnicknameChanged();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnlevelpointChanging(int value);
    partial void OnlevelpointChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void One_mailChanging(string value);
    partial void One_mailChanged();
    #endregion
		
		public user()
		{
			this._lol = new EntitySet<lol>(new Action<lol>(this.attach_lol), new Action<lol>(this.detach_lol));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nickname", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string nickname
		{
			get
			{
				return this._nickname;
			}
			set
			{
				if ((this._nickname != value))
				{
					this.OnnicknameChanging(value);
					this.SendPropertyChanging();
					this._nickname = value;
					this.SendPropertyChanged("nickname");
					this.OnnicknameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_levelpoint", DbType="Int NOT NULL")]
		public int levelpoint
		{
			get
			{
				return this._levelpoint;
			}
			set
			{
				if ((this._levelpoint != value))
				{
					this.OnlevelpointChanging(value);
					this.SendPropertyChanging();
					this._levelpoint = value;
					this.SendPropertyChanged("levelpoint");
					this.OnlevelpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[e-mail]", Storage="_e_mail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string e_mail
		{
			get
			{
				return this._e_mail;
			}
			set
			{
				if ((this._e_mail != value))
				{
					this.One_mailChanging(value);
					this.SendPropertyChanging();
					this._e_mail = value;
					this.SendPropertyChanged("e_mail");
					this.One_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_lol", Storage="_lol", ThisKey="username", OtherKey="username")]
		public EntitySet<lol> lol
		{
			get
			{
				return this._lol;
			}
			set
			{
				this._lol.Assign(value);
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
		
		private void attach_lol(lol entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_lol(lol entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lol")]
	public partial class lol : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _lolusername;
		
		private string _username;
		
		private string _lolpassword;
		
		private int _state;
		
		private EntityRef<user> _user;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnlolusernameChanging(string value);
    partial void OnlolusernameChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnlolpasswordChanging(string value);
    partial void OnlolpasswordChanged();
    partial void OnstateChanging(int value);
    partial void OnstateChanged();
    #endregion
		
		public lol()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lolusername", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string lolusername
		{
			get
			{
				return this._lolusername;
			}
			set
			{
				if ((this._lolusername != value))
				{
					this.OnlolusernameChanging(value);
					this.SendPropertyChanging();
					this._lolusername = value;
					this.SendPropertyChanged("lolusername");
					this.OnlolusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(100)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lolpassword", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string lolpassword
		{
			get
			{
				return this._lolpassword;
			}
			set
			{
				if ((this._lolpassword != value))
				{
					this.OnlolpasswordChanging(value);
					this.SendPropertyChanging();
					this._lolpassword = value;
					this.SendPropertyChanged("lolpassword");
					this.OnlolpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="Int NOT NULL")]
		public int state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_lol", Storage="_user", ThisKey="username", OtherKey="username", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.lol.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.lol.Add(this);
						this._username = value.username;
					}
					else
					{
						this._username = default(string);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.infodistrict")]
	public partial class infodistrict
	{
		
		private string _districtID;
		
		private string _lolusername;
		
		private int _level;
		
		public infodistrict()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_districtID", DbType="VarChar(100)")]
		public string districtID
		{
			get
			{
				return this._districtID;
			}
			set
			{
				if ((this._districtID != value))
				{
					this._districtID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lolusername", DbType="VarChar(100)")]
		public string lolusername
		{
			get
			{
				return this._lolusername;
			}
			set
			{
				if ((this._lolusername != value))
				{
					this._lolusername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Int NOT NULL")]
		public int level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this._level = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.district")]
	public partial class district : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _districtID;
		
		private string _name;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndistrictIDChanging(string value);
    partial void OndistrictIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public district()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_districtID", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string districtID
		{
			get
			{
				return this._districtID;
			}
			set
			{
				if ((this._districtID != value))
				{
					this.OndistrictIDChanging(value);
					this.SendPropertyChanging();
					this._districtID = value;
					this.SendPropertyChanged("districtID");
					this.OndistrictIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
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
