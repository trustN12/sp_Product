dotnet ef dbcontext scaffold Name=ProjectConfig Microsoft.EntityFrameworkCore.SqlServer -o Models

dotnet ef dbcontext scaffold Name=ProjectConfig Microsoft.EntityFrameworkCore.SqlServer --context ProductContext --output-dir Models --context-dir Models --no-onconfiguring --force