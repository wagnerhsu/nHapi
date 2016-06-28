using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V27.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V27.Segment{

///<summary>
/// Represents an HL7 CNS message segment. 
/// This segment has the following fields:<ol>
///<li>CNS-1: Starting Notification Reference Number (NM)</li>
///<li>CNS-2: Ending Notification Reference Number (NM)</li>
///<li>CNS-3: Starting Notification Date/Time (DTM)</li>
///<li>CNS-4: Ending Notification Date/Time (DTM)</li>
///<li>CNS-5: Starting Notification Code (CWE)</li>
///<li>CNS-6: Ending Notification Code (CWE)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class CNS : AbstractSegment  {

  /**
   * Creates a CNS (Clear Notification) segment object that belongs to the given 
   * message.  
   */
	public CNS(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Starting Notification Reference Number");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Ending Notification Reference Number");
       this.add(typeof(DTM), false, 1, 0, new System.Object[]{message}, "Starting Notification Date/Time");
       this.add(typeof(DTM), false, 1, 0, new System.Object[]{message}, "Ending Notification Date/Time");
       this.add(typeof(CWE), false, 1, 0, new System.Object[]{message}, "Starting Notification Code");
       this.add(typeof(CWE), false, 1, 0, new System.Object[]{message}, "Ending Notification Code");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Starting Notification Reference Number(CNS-1).
	///</summary>
	public NM StartingNotificationReferenceNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Ending Notification Reference Number(CNS-2).
	///</summary>
	public NM EndingNotificationReferenceNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Starting Notification Date/Time(CNS-3).
	///</summary>
	public DTM StartingNotificationDateTime
	{
		get{
			DTM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (DTM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Ending Notification Date/Time(CNS-4).
	///</summary>
	public DTM EndingNotificationDateTime
	{
		get{
			DTM ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (DTM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Starting Notification Code(CNS-5).
	///</summary>
	public CWE StartingNotificationCode
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Ending Notification Code(CNS-6).
	///</summary>
	public CWE EndingNotificationCode
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}