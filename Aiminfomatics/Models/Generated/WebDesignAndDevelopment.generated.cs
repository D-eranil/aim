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

[assembly: RegisterDocumentType(WebDesignAndDevelopment.CLASS_NAME, typeof(WebDesignAndDevelopment))]

namespace CMS.DocumentEngine.Types.Aiminfomatics
{
	/// <summary>
	/// Represents a content item of type WebDesignAndDevelopment.
	/// </summary>
	public partial class WebDesignAndDevelopment : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Aiminfomatics.WebDesignAndDevelopment";


		/// <summary>
		/// The instance of the class that provides extended API for working with WebDesignAndDevelopment fields.
		/// </summary>
		private readonly WebDesignAndDevelopmentFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// WebDesignAndDevelopmentID.
		/// </summary>
		[DatabaseIDField]
		public int WebDesignAndDevelopmentID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("WebDesignAndDevelopmentID"), 0);
			}
			set
			{
				SetValue("WebDesignAndDevelopmentID", value);
			}
		}


		/// <summary>
		/// Mobile Application.
		/// </summary>
		[DatabaseField]
		public string MobileApplication
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
		/// Web Design Deve.
		/// </summary>
		[DatabaseField]
		public string WebDesignDeve
		{
			get
			{
				return ValidationHelper.GetString(GetValue("WebDesignDeve"), @"");
			}
			set
			{
				SetValue("WebDesignDeve", value);
			}
		}


		/// <summary>
		/// Internet Marketing.
		/// </summary>
		[DatabaseField]
		public string InternetMarketing
		{
			get
			{
				return ValidationHelper.GetString(GetValue("InternetMarketing"), @"");
			}
			set
			{
				SetValue("InternetMarketing", value);
			}
		}


		/// <summary>
		/// E-Commerce Solutions.
		/// </summary>
		[DatabaseField]
		public string ECommerceSolutions
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ECommerceSolutions"), @"");
			}
			set
			{
				SetValue("ECommerceSolutions", value);
			}
		}


		/// <summary>
		/// Hire Ddeveloper.
		/// </summary>
		[DatabaseField]
		public string HireDeveloper
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HireDeveloper"), @"");
			}
			set
			{
				SetValue("HireDeveloper", value);
			}
		}


		/// <summary>
		/// Design Deve Txt.
		/// </summary>
		[DatabaseField]
		public string DesignDeveTxt
		{
			get
			{
				return ValidationHelper.GetString(GetValue("DesignDeveTxt"), @"");
			}
			set
			{
				SetValue("DesignDeveTxt", value);
			}
		}


		/// <summary>
		/// We Work.
		/// </summary>
		[DatabaseField]
		public string WeWork
		{
			get
			{
				return ValidationHelper.GetString(GetValue("WeWork"), @"");
			}
			set
			{
				SetValue("WeWork", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with WebDesignAndDevelopment fields.
		/// </summary>
		[RegisterProperty]
		public WebDesignAndDevelopmentFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with WebDesignAndDevelopment fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class WebDesignAndDevelopmentFields : AbstractHierarchicalObject<WebDesignAndDevelopmentFields>
		{
			/// <summary>
			/// The content item of type WebDesignAndDevelopment that is a target of the extended API.
			/// </summary>
			private readonly WebDesignAndDevelopment mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="WebDesignAndDevelopmentFields" /> class with the specified content item of type WebDesignAndDevelopment.
			/// </summary>
			/// <param name="instance">The content item of type WebDesignAndDevelopment that is a target of the extended API.</param>
			public WebDesignAndDevelopmentFields(WebDesignAndDevelopment instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// WebDesignAndDevelopmentID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.WebDesignAndDevelopmentID;
				}
				set
				{
					mInstance.WebDesignAndDevelopmentID = value;
				}
			}


			/// <summary>
			/// Mobile Application.
			/// </summary>
			public string MobileApplication
			{
				get
				{
					return mInstance.MobileApplication;
				}
				set
				{
					mInstance.MobileApplication = value;
				}
			}


			/// <summary>
			/// Web Design Deve.
			/// </summary>
			public string WebDesignDeve
			{
				get
				{
					return mInstance.WebDesignDeve;
				}
				set
				{
					mInstance.WebDesignDeve = value;
				}
			}


			/// <summary>
			/// Internet Marketing.
			/// </summary>
			public string InternetMarketing
			{
				get
				{
					return mInstance.InternetMarketing;
				}
				set
				{
					mInstance.InternetMarketing = value;
				}
			}


			/// <summary>
			/// E-Commerce Solutions.
			/// </summary>
			public string ECommerceSolutions
			{
				get
				{
					return mInstance.ECommerceSolutions;
				}
				set
				{
					mInstance.ECommerceSolutions = value;
				}
			}


			/// <summary>
			/// Hire Ddeveloper.
			/// </summary>
			public string HireDeveloper
			{
				get
				{
					return mInstance.HireDeveloper;
				}
				set
				{
					mInstance.HireDeveloper = value;
				}
			}


			/// <summary>
			/// Design Deve Txt.
			/// </summary>
			public string DesignDeveTxt
			{
				get
				{
					return mInstance.DesignDeveTxt;
				}
				set
				{
					mInstance.DesignDeveTxt = value;
				}
			}


			/// <summary>
			/// We Work.
			/// </summary>
			public string WeWork
			{
				get
				{
					return mInstance.WeWork;
				}
				set
				{
					mInstance.WeWork = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="WebDesignAndDevelopment" /> class.
		/// </summary>
		public WebDesignAndDevelopment() : base(CLASS_NAME)
		{
			mFields = new WebDesignAndDevelopmentFields(this);
		}

		#endregion
	}
}