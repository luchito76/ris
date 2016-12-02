using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace DalRis
{
    /// <summary>
    /// Controller class for RIS_CentrosDeInvestigacion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RisCentrosDeInvestigacionController
    {
        // Preload our schema..
        RisCentrosDeInvestigacion thisSchemaLoad = new RisCentrosDeInvestigacion();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public RisCentrosDeInvestigacionCollection FetchAll()
        {
            RisCentrosDeInvestigacionCollection coll = new RisCentrosDeInvestigacionCollection();
            Query qry = new Query(RisCentrosDeInvestigacion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RisCentrosDeInvestigacionCollection FetchByID(object IdCentroDeInvestigacion)
        {
            RisCentrosDeInvestigacionCollection coll = new RisCentrosDeInvestigacionCollection().Where("idCentroDeInvestigacion", IdCentroDeInvestigacion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RisCentrosDeInvestigacionCollection FetchByQuery(Query qry)
        {
            RisCentrosDeInvestigacionCollection coll = new RisCentrosDeInvestigacionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCentroDeInvestigacion)
        {
            return (RisCentrosDeInvestigacion.Delete(IdCentroDeInvestigacion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCentroDeInvestigacion)
        {
            return (RisCentrosDeInvestigacion.Destroy(IdCentroDeInvestigacion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Codigo,string Nombre,string Provincia,int? Estudios,DateTime? FechaDeRegistro)
	    {
		    RisCentrosDeInvestigacion item = new RisCentrosDeInvestigacion();
		    
            item.Codigo = Codigo;
            
            item.Nombre = Nombre;
            
            item.Provincia = Provincia;
            
            item.Estudios = Estudios;
            
            item.FechaDeRegistro = FechaDeRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdCentroDeInvestigacion,string Codigo,string Nombre,string Provincia,int? Estudios,DateTime? FechaDeRegistro)
	    {
		    RisCentrosDeInvestigacion item = new RisCentrosDeInvestigacion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCentroDeInvestigacion = IdCentroDeInvestigacion;
				
			item.Codigo = Codigo;
				
			item.Nombre = Nombre;
				
			item.Provincia = Provincia;
				
			item.Estudios = Estudios;
				
			item.FechaDeRegistro = FechaDeRegistro;
				
	        item.Save(UserName);
	    }
    }
}