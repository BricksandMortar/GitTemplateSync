﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.bricksandmortarstudio.GitEmailTemplateSync.Model;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Data
{
    public partial class GitEmailTemplateSyncContext : Rock.Data.DbContext
    {

        #region Models

        public DbSet<GitFile> GitFiles { get; set; }
        public DbSet<GitAttributeMatch> GitAttributeMatches { get; set; }
        public DbSet<GitCommunicationTemplateMatch> GitCommunicationTemplateMatches { get; set; }
        public DbSet<GitSystemEmailTemplateMatch> GitSystemEmailTemplateMatches { get; set; }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="VolunteerTrackingContext"/> class.
        /// </summary>
        public GitEmailTemplateSyncContext()
            : base( "RockContext" )
        {
            //intentionally left blank
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.
        /// </remarks>
        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            // we don't want this context to create a database or look for EF Migrations, do set the Initializer to null
            Database.SetInitializer<GitEmailTemplateSyncContext>( new NullDatabaseInitializer<GitEmailTemplateSyncContext>() );

            Rock.Data.ContextHelper.AddConfigurations( modelBuilder );
            modelBuilder.Configurations.AddFromAssembly( System.Reflection.Assembly.GetExecutingAssembly() );
        }

    }
}
