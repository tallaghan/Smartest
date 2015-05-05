

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Smartest\Web.config"
//     Connection String Name: "DefaultConnection"
//     Connection String:      "Data Source=.;Initial Catalog=Smartest;Integrated Security=True"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace Smartest.Data
{
    // ************************************************************************
    // Unit of work
    public interface ISmartestDbContext : IDisposable
    {
        IDbSet<Challenge> Challenges { get; set; } // Challenges
        IDbSet<Game> Games { get; set; } // Games

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class SmartestDbContext : DbContext, ISmartestDbContext
    {
        public IDbSet<Challenge> Challenges { get; set; } // Challenges
        public IDbSet<Game> Games { get; set; } // Games
        
        static SmartestDbContext()
        {
            Database.SetInitializer<SmartestDbContext>(null);
        }

        public SmartestDbContext()
            : base("Name=DefaultConnection")
        {
        }

        public SmartestDbContext(string connectionString) : base(connectionString)
        {
        }

        public SmartestDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ChallengeConfiguration());
            modelBuilder.Configurations.Add(new GameConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ChallengeConfiguration(schema));
            modelBuilder.Configurations.Add(new GameConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class FakeSmartestDbContext : ISmartestDbContext
    {
        public IDbSet<Challenge> Challenges { get; set; }
        public IDbSet<Game> Games { get; set; }

        public FakeSmartestDbContext()
        {
            Challenges = new FakeDbSet<Challenge>();
            Games = new FakeDbSet<Game>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.12.3.0")]
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // Challenges
    public class Challenge
    {
        public int Id { get; internal set; } // Id (Primary key)
        public string Challenger { get; set; } // Challenger
    }

    // Games
    public class Game
    {
        public int Id { get; internal set; } // Id (Primary key)
        public string Player1 { get; set; } // Player1
        public string Player2 { get; set; } // Player2
    }


    // ************************************************************************
    // POCO Configuration

    // Challenges
    internal class ChallengeConfiguration : EntityTypeConfiguration<Challenge>
    {
        public ChallengeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Challenges");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Challenger).HasColumnName("Challenger").IsRequired().HasMaxLength(255);
        }
    }

    // Games
    internal class GameConfiguration : EntityTypeConfiguration<Game>
    {
        public GameConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Games");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Player1).HasColumnName("Player1").IsRequired().HasMaxLength(255);
            Property(x => x.Player2).HasColumnName("Player2").IsRequired().HasMaxLength(255);
        }
    }


    // ************************************************************************
    // Stored procedure return models

}

