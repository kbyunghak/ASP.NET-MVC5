enable-migrations -ContextTypeName NhlContext -MigrationsDirectory Migrations\NhlMigrations

add-migration -ConfigurationTypeName CodeFirstStuff.Migrations.NhlMigrations.Configuration "FirstCreate"

update-database -ConfigurationTypeName CodeFirstStuff.Migrations.NhlMigrations.Configuration

============================================================================================================

enable-migrations -ContextTypeName ApplicationDbContext -MigrationsDirectory Migrations\IdentityMigrations

add-migration -ConfigurationTypeName CodeFirstStuff.Migrations.IdentityMigrations.Configuration "StartIdentity"

update-database -ConfigurationTypeName CodeFirstStuff.Migrations.IdentityMigrations.Configuration
