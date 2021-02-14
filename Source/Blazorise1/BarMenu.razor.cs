﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise.Stores;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public partial class BarMenu : BaseComponent
    {
        #region Members

        private BarStore parentStore;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.BarMenu( ParentStore.Mode ));
            builder.Append( ClassProvider.BarMenuShow( ParentStore.Mode ), ParentStore.Visible );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        [CascadingParameter] 
        protected BarStore ParentStore
        {
            get => parentStore;
            set
            {
                if ( parentStore == value )
                    return;

                parentStore = value;

                DirtyClasses();
            }
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
