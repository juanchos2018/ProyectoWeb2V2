﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb2V2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bd_web")]
	public partial class ModeloSistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCATEGORIA(CATEGORIA instance);
    partial void UpdateCATEGORIA(CATEGORIA instance);
    partial void DeleteCATEGORIA(CATEGORIA instance);
    partial void InsertEMPRESA(EMPRESA instance);
    partial void UpdateEMPRESA(EMPRESA instance);
    partial void DeleteEMPRESA(EMPRESA instance);
    partial void InsertPRODUCTO(PRODUCTO instance);
    partial void UpdatePRODUCTO(PRODUCTO instance);
    partial void DeletePRODUCTO(PRODUCTO instance);
    partial void InsertCONDUCTOR(CONDUCTOR instance);
    partial void UpdateCONDUCTOR(CONDUCTOR instance);
    partial void DeleteCONDUCTOR(CONDUCTOR instance);
    partial void InsertUSUARIO(USUARIO instance);
    partial void UpdateUSUARIO(USUARIO instance);
    partial void DeleteUSUARIO(USUARIO instance);
    partial void InsertPEDIDO(PEDIDO instance);
    partial void UpdatePEDIDO(PEDIDO instance);
    partial void DeletePEDIDO(PEDIDO instance);
    #endregion
		
		public ModeloSistemaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bd_webConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloSistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloSistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloSistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModeloSistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CATEGORIA> CATEGORIA
		{
			get
			{
				return this.GetTable<CATEGORIA>();
			}
		}
		
		public System.Data.Linq.Table<EMPRESA> EMPRESA
		{
			get
			{
				return this.GetTable<EMPRESA>();
			}
		}
		
		public System.Data.Linq.Table<PRODUCTO> PRODUCTO
		{
			get
			{
				return this.GetTable<PRODUCTO>();
			}
		}
		
		public System.Data.Linq.Table<CONDUCTOR> CONDUCTOR
		{
			get
			{
				return this.GetTable<CONDUCTOR>();
			}
		}
		
		public System.Data.Linq.Table<USUARIO> USUARIO
		{
			get
			{
				return this.GetTable<USUARIO>();
			}
		}
		
		public System.Data.Linq.Table<PEDIDO> PEDIDO
		{
			get
			{
				return this.GetTable<PEDIDO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CATEGORIA")]
	public partial class CATEGORIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDCATEGORIA;
		
		private string _NOMBRE;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCATEGORIAChanging(int value);
    partial void OnIDCATEGORIAChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    #endregion
		
		public CATEGORIA()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCATEGORIA", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDCATEGORIA
		{
			get
			{
				return this._IDCATEGORIA;
			}
			set
			{
				if ((this._IDCATEGORIA != value))
				{
					this.OnIDCATEGORIAChanging(value);
					this.SendPropertyChanging();
					this._IDCATEGORIA = value;
					this.SendPropertyChanged("IDCATEGORIA");
					this.OnIDCATEGORIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMPRESA")]
	public partial class EMPRESA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDEMPRESA;
		
		private string _NOMBRE;
		
		private string _DESCRIPCION;
		
		private string _ESTADO;
		
		private EntitySet<PRODUCTO> _PRODUCTO;
		
		private EntitySet<CONDUCTOR> _CONDUCTOR;
		
		private EntitySet<PEDIDO> _PEDIDO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDEMPRESAChanging(int value);
    partial void OnIDEMPRESAChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnDESCRIPCIONChanging(string value);
    partial void OnDESCRIPCIONChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    #endregion
		
		public EMPRESA()
		{
			this._PRODUCTO = new EntitySet<PRODUCTO>(new Action<PRODUCTO>(this.attach_PRODUCTO), new Action<PRODUCTO>(this.detach_PRODUCTO));
			this._CONDUCTOR = new EntitySet<CONDUCTOR>(new Action<CONDUCTOR>(this.attach_CONDUCTOR), new Action<CONDUCTOR>(this.detach_CONDUCTOR));
			this._PEDIDO = new EntitySet<PEDIDO>(new Action<PEDIDO>(this.attach_PEDIDO), new Action<PEDIDO>(this.detach_PEDIDO));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDEMPRESA", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDEMPRESA
		{
			get
			{
				return this._IDEMPRESA;
			}
			set
			{
				if ((this._IDEMPRESA != value))
				{
					this.OnIDEMPRESAChanging(value);
					this.SendPropertyChanging();
					this._IDEMPRESA = value;
					this.SendPropertyChanged("IDEMPRESA");
					this.OnIDEMPRESAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string DESCRIPCION
		{
			get
			{
				return this._DESCRIPCION;
			}
			set
			{
				if ((this._DESCRIPCION != value))
				{
					this.OnDESCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION = value;
					this.SendPropertyChanged("DESCRIPCION");
					this.OnDESCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string ESTADO
		{
			get
			{
				return this._ESTADO;
			}
			set
			{
				if ((this._ESTADO != value))
				{
					this.OnESTADOChanging(value);
					this.SendPropertyChanging();
					this._ESTADO = value;
					this.SendPropertyChanged("ESTADO");
					this.OnESTADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_PRODUCTO", Storage="_PRODUCTO", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA")]
		public EntitySet<PRODUCTO> PRODUCTO
		{
			get
			{
				return this._PRODUCTO;
			}
			set
			{
				this._PRODUCTO.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_CONDUCTOR", Storage="_CONDUCTOR", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA")]
		public EntitySet<CONDUCTOR> CONDUCTOR
		{
			get
			{
				return this._CONDUCTOR;
			}
			set
			{
				this._CONDUCTOR.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_PEDIDO", Storage="_PEDIDO", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA")]
		public EntitySet<PEDIDO> PEDIDO
		{
			get
			{
				return this._PEDIDO;
			}
			set
			{
				this._PEDIDO.Assign(value);
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
		
		private void attach_PRODUCTO(PRODUCTO entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = this;
		}
		
		private void detach_PRODUCTO(PRODUCTO entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = null;
		}
		
		private void attach_CONDUCTOR(CONDUCTOR entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = this;
		}
		
		private void detach_CONDUCTOR(CONDUCTOR entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = null;
		}
		
		private void attach_PEDIDO(PEDIDO entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = this;
		}
		
		private void detach_PEDIDO(PEDIDO entity)
		{
			this.SendPropertyChanging();
			entity.EMPRESA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRODUCTO")]
	public partial class PRODUCTO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDPRODUCTO;
		
		private int _IDEMPRESA;
		
		private string _NOMBRE;
		
		private string _DESCRIPCION;
		
		private int _PRECIO;
		
		private System.Data.Linq.Binary _IMAGEN;
		
		private string _ESTADO;
		
		private EntityRef<EMPRESA> _EMPRESA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDPRODUCTOChanging(int value);
    partial void OnIDPRODUCTOChanged();
    partial void OnIDEMPRESAChanging(int value);
    partial void OnIDEMPRESAChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnDESCRIPCIONChanging(string value);
    partial void OnDESCRIPCIONChanged();
    partial void OnPRECIOChanging(int value);
    partial void OnPRECIOChanged();
    partial void OnIMAGENChanging(System.Data.Linq.Binary value);
    partial void OnIMAGENChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    #endregion
		
		public PRODUCTO()
		{
			this._EMPRESA = default(EntityRef<EMPRESA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPRODUCTO", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDPRODUCTO
		{
			get
			{
				return this._IDPRODUCTO;
			}
			set
			{
				if ((this._IDPRODUCTO != value))
				{
					this.OnIDPRODUCTOChanging(value);
					this.SendPropertyChanging();
					this._IDPRODUCTO = value;
					this.SendPropertyChanged("IDPRODUCTO");
					this.OnIDPRODUCTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDEMPRESA", DbType="Int NOT NULL")]
		public int IDEMPRESA
		{
			get
			{
				return this._IDEMPRESA;
			}
			set
			{
				if ((this._IDEMPRESA != value))
				{
					if (this._EMPRESA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDEMPRESAChanging(value);
					this.SendPropertyChanging();
					this._IDEMPRESA = value;
					this.SendPropertyChanged("IDEMPRESA");
					this.OnIDEMPRESAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string DESCRIPCION
		{
			get
			{
				return this._DESCRIPCION;
			}
			set
			{
				if ((this._DESCRIPCION != value))
				{
					this.OnDESCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION = value;
					this.SendPropertyChanged("DESCRIPCION");
					this.OnDESCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRECIO", DbType="Int NOT NULL")]
		public int PRECIO
		{
			get
			{
				return this._PRECIO;
			}
			set
			{
				if ((this._PRECIO != value))
				{
					this.OnPRECIOChanging(value);
					this.SendPropertyChanging();
					this._PRECIO = value;
					this.SendPropertyChanged("PRECIO");
					this.OnPRECIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGEN", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMAGEN
		{
			get
			{
				return this._IMAGEN;
			}
			set
			{
				if ((this._IMAGEN != value))
				{
					this.OnIMAGENChanging(value);
					this.SendPropertyChanging();
					this._IMAGEN = value;
					this.SendPropertyChanged("IMAGEN");
					this.OnIMAGENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(1)")]
		public string ESTADO
		{
			get
			{
				return this._ESTADO;
			}
			set
			{
				if ((this._ESTADO != value))
				{
					this.OnESTADOChanging(value);
					this.SendPropertyChanging();
					this._ESTADO = value;
					this.SendPropertyChanged("ESTADO");
					this.OnESTADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_PRODUCTO", Storage="_EMPRESA", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA", IsForeignKey=true)]
		public EMPRESA EMPRESA
		{
			get
			{
				return this._EMPRESA.Entity;
			}
			set
			{
				EMPRESA previousValue = this._EMPRESA.Entity;
				if (((previousValue != value) 
							|| (this._EMPRESA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EMPRESA.Entity = null;
						previousValue.PRODUCTO.Remove(this);
					}
					this._EMPRESA.Entity = value;
					if ((value != null))
					{
						value.PRODUCTO.Add(this);
						this._IDEMPRESA = value.IDEMPRESA;
					}
					else
					{
						this._IDEMPRESA = default(int);
					}
					this.SendPropertyChanged("EMPRESA");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CONDUCTOR")]
	public partial class CONDUCTOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDCONDUCTOR;
		
		private int _IDEMPRESA;
		
		private string _DNI;
		
		private string _NOMBRES;
		
		private string _APELLIDOS;
		
		private string _CORREO;
		
		private string _CLAVE;
		
		private System.Data.Linq.Binary _IMAGEN;
		
		private System.Nullable<System.DateTime> _FECHA;
		
		private EntityRef<EMPRESA> _EMPRESA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCONDUCTORChanging(int value);
    partial void OnIDCONDUCTORChanged();
    partial void OnIDEMPRESAChanging(int value);
    partial void OnIDEMPRESAChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnNOMBRESChanging(string value);
    partial void OnNOMBRESChanged();
    partial void OnAPELLIDOSChanging(string value);
    partial void OnAPELLIDOSChanged();
    partial void OnCORREOChanging(string value);
    partial void OnCORREOChanged();
    partial void OnCLAVEChanging(string value);
    partial void OnCLAVEChanged();
    partial void OnIMAGENChanging(System.Data.Linq.Binary value);
    partial void OnIMAGENChanged();
    partial void OnFECHAChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHAChanged();
    #endregion
		
		public CONDUCTOR()
		{
			this._EMPRESA = default(EntityRef<EMPRESA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCONDUCTOR", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDCONDUCTOR
		{
			get
			{
				return this._IDCONDUCTOR;
			}
			set
			{
				if ((this._IDCONDUCTOR != value))
				{
					this.OnIDCONDUCTORChanging(value);
					this.SendPropertyChanging();
					this._IDCONDUCTOR = value;
					this.SendPropertyChanged("IDCONDUCTOR");
					this.OnIDCONDUCTORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDEMPRESA", DbType="Int NOT NULL")]
		public int IDEMPRESA
		{
			get
			{
				return this._IDEMPRESA;
			}
			set
			{
				if ((this._IDEMPRESA != value))
				{
					if (this._EMPRESA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDEMPRESAChanging(value);
					this.SendPropertyChanging();
					this._IDEMPRESA = value;
					this.SendPropertyChanged("IDEMPRESA");
					this.OnIDEMPRESAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRES", DbType="VarChar(50)")]
		public string NOMBRES
		{
			get
			{
				return this._NOMBRES;
			}
			set
			{
				if ((this._NOMBRES != value))
				{
					this.OnNOMBRESChanging(value);
					this.SendPropertyChanging();
					this._NOMBRES = value;
					this.SendPropertyChanged("NOMBRES");
					this.OnNOMBRESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="VarChar(50)")]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this.OnAPELLIDOSChanging(value);
					this.SendPropertyChanging();
					this._APELLIDOS = value;
					this.SendPropertyChanged("APELLIDOS");
					this.OnAPELLIDOSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CORREO", DbType="VarChar(20)")]
		public string CORREO
		{
			get
			{
				return this._CORREO;
			}
			set
			{
				if ((this._CORREO != value))
				{
					this.OnCORREOChanging(value);
					this.SendPropertyChanging();
					this._CORREO = value;
					this.SendPropertyChanged("CORREO");
					this.OnCORREOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE", DbType="VarChar(100)")]
		public string CLAVE
		{
			get
			{
				return this._CLAVE;
			}
			set
			{
				if ((this._CLAVE != value))
				{
					this.OnCLAVEChanging(value);
					this.SendPropertyChanging();
					this._CLAVE = value;
					this.SendPropertyChanged("CLAVE");
					this.OnCLAVEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IMAGEN", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary IMAGEN
		{
			get
			{
				return this._IMAGEN;
			}
			set
			{
				if ((this._IMAGEN != value))
				{
					this.OnIMAGENChanging(value);
					this.SendPropertyChanging();
					this._IMAGEN = value;
					this.SendPropertyChanged("IMAGEN");
					this.OnIMAGENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA
		{
			get
			{
				return this._FECHA;
			}
			set
			{
				if ((this._FECHA != value))
				{
					this.OnFECHAChanging(value);
					this.SendPropertyChanging();
					this._FECHA = value;
					this.SendPropertyChanged("FECHA");
					this.OnFECHAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_CONDUCTOR", Storage="_EMPRESA", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA", IsForeignKey=true)]
		public EMPRESA EMPRESA
		{
			get
			{
				return this._EMPRESA.Entity;
			}
			set
			{
				EMPRESA previousValue = this._EMPRESA.Entity;
				if (((previousValue != value) 
							|| (this._EMPRESA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EMPRESA.Entity = null;
						previousValue.CONDUCTOR.Remove(this);
					}
					this._EMPRESA.Entity = value;
					if ((value != null))
					{
						value.CONDUCTOR.Add(this);
						this._IDEMPRESA = value.IDEMPRESA;
					}
					else
					{
						this._IDEMPRESA = default(int);
					}
					this.SendPropertyChanged("EMPRESA");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USUARIO")]
	public partial class USUARIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDUSUARIO;
		
		private string _CORREO;
		
		private string _NOMBRE;
		
		private string _CELULAR;
		
		private string _CLAVE;
		
		private EntitySet<PEDIDO> _PEDIDO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDUSUARIOChanging(int value);
    partial void OnIDUSUARIOChanged();
    partial void OnCORREOChanging(string value);
    partial void OnCORREOChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnCELULARChanging(string value);
    partial void OnCELULARChanged();
    partial void OnCLAVEChanging(string value);
    partial void OnCLAVEChanged();
    #endregion
		
		public USUARIO()
		{
			this._PEDIDO = new EntitySet<PEDIDO>(new Action<PEDIDO>(this.attach_PEDIDO), new Action<PEDIDO>(this.detach_PEDIDO));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUSUARIO", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDUSUARIO
		{
			get
			{
				return this._IDUSUARIO;
			}
			set
			{
				if ((this._IDUSUARIO != value))
				{
					this.OnIDUSUARIOChanging(value);
					this.SendPropertyChanging();
					this._IDUSUARIO = value;
					this.SendPropertyChanged("IDUSUARIO");
					this.OnIDUSUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CORREO", DbType="VarChar(20)")]
		public string CORREO
		{
			get
			{
				return this._CORREO;
			}
			set
			{
				if ((this._CORREO != value))
				{
					this.OnCORREOChanging(value);
					this.SendPropertyChanging();
					this._CORREO = value;
					this.SendPropertyChanged("CORREO");
					this.OnCORREOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(20)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CELULAR", DbType="VarChar(20)")]
		public string CELULAR
		{
			get
			{
				return this._CELULAR;
			}
			set
			{
				if ((this._CELULAR != value))
				{
					this.OnCELULARChanging(value);
					this.SendPropertyChanging();
					this._CELULAR = value;
					this.SendPropertyChanged("CELULAR");
					this.OnCELULARChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CLAVE", DbType="VarChar(100)")]
		public string CLAVE
		{
			get
			{
				return this._CLAVE;
			}
			set
			{
				if ((this._CLAVE != value))
				{
					this.OnCLAVEChanging(value);
					this.SendPropertyChanging();
					this._CLAVE = value;
					this.SendPropertyChanged("CLAVE");
					this.OnCLAVEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USUARIO_PEDIDO", Storage="_PEDIDO", ThisKey="IDUSUARIO", OtherKey="IDUSUARIO")]
		public EntitySet<PEDIDO> PEDIDO
		{
			get
			{
				return this._PEDIDO;
			}
			set
			{
				this._PEDIDO.Assign(value);
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
		
		private void attach_PEDIDO(PEDIDO entity)
		{
			this.SendPropertyChanging();
			entity.USUARIO = this;
		}
		
		private void detach_PEDIDO(PEDIDO entity)
		{
			this.SendPropertyChanging();
			entity.USUARIO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PEDIDO")]
	public partial class PEDIDO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDPEDIDO;
		
		private int _IDEMPRESA;
		
		private int _IDUSUARIO;
		
		private System.Nullable<System.DateTime> _FECHA;
		
		private System.Nullable<decimal> _TOTAL;
		
		private string _ESTADO;
		
		private EntityRef<EMPRESA> _EMPRESA;
		
		private EntityRef<USUARIO> _USUARIO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDPEDIDOChanging(int value);
    partial void OnIDPEDIDOChanged();
    partial void OnIDEMPRESAChanging(int value);
    partial void OnIDEMPRESAChanged();
    partial void OnIDUSUARIOChanging(int value);
    partial void OnIDUSUARIOChanged();
    partial void OnFECHAChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHAChanged();
    partial void OnTOTALChanging(System.Nullable<decimal> value);
    partial void OnTOTALChanged();
    partial void OnESTADOChanging(string value);
    partial void OnESTADOChanged();
    #endregion
		
		public PEDIDO()
		{
			this._EMPRESA = default(EntityRef<EMPRESA>);
			this._USUARIO = default(EntityRef<USUARIO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPEDIDO", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDPEDIDO
		{
			get
			{
				return this._IDPEDIDO;
			}
			set
			{
				if ((this._IDPEDIDO != value))
				{
					this.OnIDPEDIDOChanging(value);
					this.SendPropertyChanging();
					this._IDPEDIDO = value;
					this.SendPropertyChanged("IDPEDIDO");
					this.OnIDPEDIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDEMPRESA", DbType="Int NOT NULL")]
		public int IDEMPRESA
		{
			get
			{
				return this._IDEMPRESA;
			}
			set
			{
				if ((this._IDEMPRESA != value))
				{
					if (this._EMPRESA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDEMPRESAChanging(value);
					this.SendPropertyChanging();
					this._IDEMPRESA = value;
					this.SendPropertyChanged("IDEMPRESA");
					this.OnIDEMPRESAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUSUARIO", DbType="Int NOT NULL")]
		public int IDUSUARIO
		{
			get
			{
				return this._IDUSUARIO;
			}
			set
			{
				if ((this._IDUSUARIO != value))
				{
					if (this._USUARIO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDUSUARIOChanging(value);
					this.SendPropertyChanging();
					this._IDUSUARIO = value;
					this.SendPropertyChanged("IDUSUARIO");
					this.OnIDUSUARIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA
		{
			get
			{
				return this._FECHA;
			}
			set
			{
				if ((this._FECHA != value))
				{
					this.OnFECHAChanging(value);
					this.SendPropertyChanging();
					this._FECHA = value;
					this.SendPropertyChanged("FECHA");
					this.OnFECHAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL", DbType="Decimal(6,2)")]
		public System.Nullable<decimal> TOTAL
		{
			get
			{
				return this._TOTAL;
			}
			set
			{
				if ((this._TOTAL != value))
				{
					this.OnTOTALChanging(value);
					this.SendPropertyChanging();
					this._TOTAL = value;
					this.SendPropertyChanged("TOTAL");
					this.OnTOTALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESTADO", DbType="VarChar(100)")]
		public string ESTADO
		{
			get
			{
				return this._ESTADO;
			}
			set
			{
				if ((this._ESTADO != value))
				{
					this.OnESTADOChanging(value);
					this.SendPropertyChanging();
					this._ESTADO = value;
					this.SendPropertyChanged("ESTADO");
					this.OnESTADOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EMPRESA_PEDIDO", Storage="_EMPRESA", ThisKey="IDEMPRESA", OtherKey="IDEMPRESA", IsForeignKey=true)]
		public EMPRESA EMPRESA
		{
			get
			{
				return this._EMPRESA.Entity;
			}
			set
			{
				EMPRESA previousValue = this._EMPRESA.Entity;
				if (((previousValue != value) 
							|| (this._EMPRESA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EMPRESA.Entity = null;
						previousValue.PEDIDO.Remove(this);
					}
					this._EMPRESA.Entity = value;
					if ((value != null))
					{
						value.PEDIDO.Add(this);
						this._IDEMPRESA = value.IDEMPRESA;
					}
					else
					{
						this._IDEMPRESA = default(int);
					}
					this.SendPropertyChanged("EMPRESA");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USUARIO_PEDIDO", Storage="_USUARIO", ThisKey="IDUSUARIO", OtherKey="IDUSUARIO", IsForeignKey=true)]
		public USUARIO USUARIO
		{
			get
			{
				return this._USUARIO.Entity;
			}
			set
			{
				USUARIO previousValue = this._USUARIO.Entity;
				if (((previousValue != value) 
							|| (this._USUARIO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USUARIO.Entity = null;
						previousValue.PEDIDO.Remove(this);
					}
					this._USUARIO.Entity = value;
					if ((value != null))
					{
						value.PEDIDO.Add(this);
						this._IDUSUARIO = value.IDUSUARIO;
					}
					else
					{
						this._IDUSUARIO = default(int);
					}
					this.SendPropertyChanged("USUARIO");
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
