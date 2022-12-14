//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Aiminfomatics;

[assembly: RegisterDocumentType(MobileApplication.CLASS_NAME, typeof(MobileApplication))]

namespace CMS.DocumentEngine.Types.Aiminfomatics
{
	/// <summary>
	/// Represents a content item of type MobileApplication.
	/// </summary>
	public partial class MobileApplication : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Aiminfomatics.MobileApplication";


		/// <summary>
		/// The instance of the class that provides extended API for working with MobileApplication fields.
		/// </summary>
		private readonly MobileApplicationFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MobileApplicationID.
		/// </summary>
		[DatabaseIDField]
		public int MobileApplicationID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MobileApplicationID"), 0);
			}
			set
			{
				SetValue("MobileApplicationID", value);
			}
		}


		/// <summary>
		/// MobileApp.
		/// </summary>
		[DatabaseField]
		public string MobileApp
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MobileApp"), @"");
			}
			set
			{
				SetValue("MobileApp", value);
			}
		}


		/// <summary>
		/// Satification.
		/// </summary>
		[DatabaseField]
		public string Satification
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Satification"), @"");
			}
			set
			{
				SetValue("Satification", value);
			}
		}


		/// <summary>
		/// Mobile Application.
		/// </summary>
		[DatabaseField]
		public string MobileApplication1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MobileApplication"), @"");
			}
			set
			{
				SetValue("MobileApplication", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MobileApplication fields.
		/// </summary>
		[RegisterProperty]
		public MobileApplicationFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MobileApplication fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MobileApplicationFields : AbstractHierarchicalObject<MobileApplicationFields>
		{
			/// <summary>
			/// The content item of type MobileApplication that is a target of the extended API.
			/// </summary>
			private readonly MobileApplication mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MobileApplicationFields" /> class with the specified content item of type MobileApplication.
			/// </summary>
			/// <param name="instance">The content item of type MobileApplication that is a target of the extended API.</param>
			public MobileApplicationFields(MobileApplication instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MobileApplicationID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MobileApplicationID;
				}
				set
				{
					mInstance.MobileApplicationID = value;
				}
			}


			/// <summary>
			/// MobileApp.
			/// </summary>
			public string MobileApp
			{
				get
				{
					return mInstance.MobileApp;
				}
				set
				{
					mInstance.MobileApp = value;
				}
			}


			/// <summary>
			/// Satification.
			/// </summary>
			public string Satification
			{
				get
				{
					return mInstance.Satification;
				}
				set
				{
					mInstance.Satification = value;
				}
			}


			/// <summary>
			/// Mobile Application.
			/// </summary>
			public string MobileApplication
			{
				get
				{
					return mInstance.MobileApplication1;
				}
				set
				{
					mInstance.MobileApplication1 = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MobileApplication" /> class.
		/// </summary>
		public MobileApplication() : base(CLASS_NAME)
		{
			mFields = new MobileApplicationFields(this);
		}

		#endregion
	}
}