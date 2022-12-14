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

[assembly: RegisterDocumentType(MobileApplicationSection.CLASS_NAME, typeof(MobileApplicationSection))]

namespace CMS.DocumentEngine.Types.Aiminfomatics
{
	/// <summary>
	/// Represents a content item of type MobileApplicationSection.
	/// </summary>
	public partial class MobileApplicationSection : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Aiminfomatics.MobileApplicationSection";


		/// <summary>
		/// The instance of the class that provides extended API for working with MobileApplicationSection fields.
		/// </summary>
		private readonly MobileApplicationSectionFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// Gets an object that provides extended API for working with MobileApplicationSection fields.
		/// </summary>
		[RegisterProperty]
		public MobileApplicationSectionFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MobileApplicationSection fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MobileApplicationSectionFields : AbstractHierarchicalObject<MobileApplicationSectionFields>
		{
			/// <summary>
			/// The content item of type MobileApplicationSection that is a target of the extended API.
			/// </summary>
			private readonly MobileApplicationSection mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MobileApplicationSectionFields" /> class with the specified content item of type MobileApplicationSection.
			/// </summary>
			/// <param name="instance">The content item of type MobileApplicationSection that is a target of the extended API.</param>
			public MobileApplicationSectionFields(MobileApplicationSection instance)
			{
				mInstance = instance;
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MobileApplicationSection" /> class.
		/// </summary>
		public MobileApplicationSection() : base(CLASS_NAME)
		{
			mFields = new MobileApplicationSectionFields(this);
		}

		#endregion
	}
}