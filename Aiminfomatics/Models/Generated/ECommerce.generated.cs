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

[assembly: RegisterDocumentType(ECommerce.CLASS_NAME, typeof(ECommerce))]

namespace CMS.DocumentEngine.Types.Aiminfomatics
{
	/// <summary>
	/// Represents a content item of type ECommerce.
	/// </summary>
	public partial class ECommerce : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Aiminfomatics.ECommerce";


		/// <summary>
		/// The instance of the class that provides extended API for working with ECommerce fields.
		/// </summary>
		private readonly ECommerceFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ECommerceID.
		/// </summary>
		[DatabaseIDField]
		public int ECommerceID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ECommerceID"), 0);
			}
			set
			{
				SetValue("ECommerceID", value);
			}
		}


		/// <summary>
		/// E Commerce.
		/// </summary>
		[DatabaseField]
		public string ECommerce1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ECommerce"), @"");
			}
			set
			{
				SetValue("ECommerce", value);
			}
		}


		/// <summary>
		/// Satisfaction.
		/// </summary>
		[DatabaseField]
		public string Satisfaction
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Satisfaction"), @"");
			}
			set
			{
				SetValue("Satisfaction", value);
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
		/// WebDesignDev.
		/// </summary>
		[DatabaseField]
		public string WebDesignDev
		{
			get
			{
				return ValidationHelper.GetString(GetValue("WebDesignDev"), @"");
			}
			set
			{
				SetValue("WebDesignDev", value);
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
		/// E Commerce Solutions.
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
		/// Hire Developer.
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
		/// E Commerce Text.
		/// </summary>
		[DatabaseField]
		public string ECommerceText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ECommerceText"), @"");
			}
			set
			{
				SetValue("ECommerceText", value);
			}
		}


		/// <summary>
		/// We Work In.
		/// </summary>
		[DatabaseField]
		public string WeWorkIn
		{
			get
			{
				return ValidationHelper.GetString(GetValue("WeWorkIn"), @"");
			}
			set
			{
				SetValue("WeWorkIn", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ECommerce fields.
		/// </summary>
		[RegisterProperty]
		public ECommerceFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ECommerce fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ECommerceFields : AbstractHierarchicalObject<ECommerceFields>
		{
			/// <summary>
			/// The content item of type ECommerce that is a target of the extended API.
			/// </summary>
			private readonly ECommerce mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ECommerceFields" /> class with the specified content item of type ECommerce.
			/// </summary>
			/// <param name="instance">The content item of type ECommerce that is a target of the extended API.</param>
			public ECommerceFields(ECommerce instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ECommerceID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ECommerceID;
				}
				set
				{
					mInstance.ECommerceID = value;
				}
			}


			/// <summary>
			/// E Commerce.
			/// </summary>
			public string ECommerce
			{
				get
				{
					return mInstance.ECommerce1;
				}
				set
				{
					mInstance.ECommerce1 = value;
				}
			}


			/// <summary>
			/// Satisfaction.
			/// </summary>
			public string Satisfaction
			{
				get
				{
					return mInstance.Satisfaction;
				}
				set
				{
					mInstance.Satisfaction = value;
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
			/// WebDesignDev.
			/// </summary>
			public string WebDesignDev
			{
				get
				{
					return mInstance.WebDesignDev;
				}
				set
				{
					mInstance.WebDesignDev = value;
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
			/// E Commerce Solutions.
			/// </summary>
			public string Solutions
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
			/// Hire Developer.
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
			/// E Commerce Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.ECommerceText;
				}
				set
				{
					mInstance.ECommerceText = value;
				}
			}


			/// <summary>
			/// We Work In.
			/// </summary>
			public string WeWorkIn
			{
				get
				{
					return mInstance.WeWorkIn;
				}
				set
				{
					mInstance.WeWorkIn = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ECommerce" /> class.
		/// </summary>
		public ECommerce() : base(CLASS_NAME)
		{
			mFields = new ECommerceFields(this);
		}

		#endregion
	}
}