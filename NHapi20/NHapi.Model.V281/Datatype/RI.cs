using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V281.Datatype
{

///<summary>
/// <p>The HL7 RI (Repeat Interval) data type.  Consists of the following components: </p><ol>
/// <li>Repeat Pattern (CWE)</li>
/// <li>Explicit Time Interval (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class RI : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a RI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RI(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a RI.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public RI(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new CWE(message,"Repeat Pattern");
		data[1] = new ST(message,"Explicit Time Interval");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element RI composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Repeat Pattern (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE RepeatPattern {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Explicit Time Interval (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ExplicitTimeInterval {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}