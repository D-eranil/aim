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

[assembly: RegisterDocumentType(Seo.CLASS_NAME, typeof(Seo))]

namespace CMS.DocumentEngine.Types.Aiminfomatics
{
	/// <summary>
	/// Represents a content item of type Seo.
	/// </summary>
	public partial class Seo : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Aiminfomatics.Seo";


		/// <summary>
		/// The instance of the class that provides extended API for working with Seo fields.
		/// </summary>
		private readonly SeoFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// SeoID.
		/// </summary>
		[DatabaseIDField]
		public int SeoID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("SeoID"), 0);
			}
			set
			{
				SetValue("SeoID", value);
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
		/// Web Design Dev.
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
		/// Hire A Developer.
		/// </summary>
		[DatabaseField]
		public string HireADeveloper
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HireADeveloper"), @"");
			}
			set
			{
				SetValue("HireADeveloper", value);
			}
		}


		/// <summary>
		/// Internet Marketing Txt.
		/// </summary>
		[DatabaseField]
		public string InternetMarketingTxt
		{
			get
			{
				return ValidationHelper.GetString(GetValue("InternetMarketingTxt"), @"");
			}
			set
			{
				SetValue("InternetMarketingTxt", value);
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
		/// Gets an object that provides extended API for working with Seo fields.
		/// </summary>
		[RegisterProperty]
		public SeoFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Seo fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class SeoFields : AbstractHierarchicalObject<SeoFields>
		{
			/// <summary>
			/// The content item of type Seo that is a target of the extended API.
			/// </summary>
			private readonly Seo mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="SeoFields" /> class with the specified content item of type Seo.
			/// </summary>
			/// <param name="instance">The content item of type Seo that is a target of the extended API.</param>
			public SeoFields(Seo instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// SeoID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.SeoID;
				}
				set
				{
					mInstance.SeoID = value;
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
			/// Web Design Dev.
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
			/// E Commerce Solutions.
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
			/// Hire A Developer.
			/// </summary>
			public string HireADeveloper
			{
				get
				{
					return mInstance.HireADeveloper;
				}
				set
				{
					mInstance.HireADeveloper = value;
				}
			}


			/// <summary>
			/// Internet Marketing Txt.
			/// </summary>
			public string InternetMarketingTxt
			{
				get
				{
					return mInstance.InternetMarketingTxt;
				}
				set
				{
					mInstance.InternetMarketingTxt = value;
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
		/// Initializes a new instance of the <see cref="Seo" /> class.
		/// </summary>
		public Seo() : base(CLASS_NAME)
		{
			mFields = new SeoFields(this);
		}

		#endregion
	}
}