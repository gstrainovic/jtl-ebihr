using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class Config 
{
    public ameise ameise { get; set; } = new ameise();
    public jtl jtl { get; set; } = new jtl();
    public sql sql { get; set; } = new sql();
    public jtl_bihr jtl_bihr { get; set; } = new jtl_bihr();
    public bihr bihr { get; set; } = new bihr();
    public string optionsBuilderString; 

    // public const string OptionsBuilderString = $"Data Source={SQLServerName};Initial Catalog={SQLDatabaseName};User ID={SQLUserName};Password={SQLPassword};TrustServerCertificate=True";


    public Config() {
        var deserializer = new DeserializerBuilder()
        .WithNamingConvention(UnderscoredNamingConvention.Instance)  
        .Build();
        var file = File.ReadAllText("_env.yaml");
        var env = deserializer.Deserialize<Env>(file);

        // check if all required values are set
        if (env.jtl.ameise.exe == "") {
            throw new System.Exception("ameise.exe not set in _env.yaml");
        }
        if (env.jtl.ameise?.hard_part_vorlage_id == "") {
            throw new System.Exception("hardPartVorlageId not set in _env.yaml");
        }
        if (env.jtl.ameise?.brand_vorlage_id == "") {
            throw new System.Exception("brandVorlageId not set in _env.yaml");
        }
        if (env.jtl.software_path == "") {
            throw new System.Exception("softwarePath not set in _env.yaml");
        }
        if (env.sql.server_name == "") {
            throw new System.Exception("serverName not set in _env.yaml");
        }
        if (env.sql.user_name == "") {
            throw new System.Exception("userName not set in _env.yaml");
        }
        if (env.sql.password == "") {
            throw new System.Exception("password not set in _env.yaml");
        }
        if (env.sql.databaseName == "") {
            throw new System.Exception("databaseName not set in _env.yaml");
        }
        if (env.jtl_bihr.temp_path == "") {
            throw new System.Exception("tempPath not set in _env.yaml");
        }
        if (env.bihr.url == "") {
            throw new System.Exception("url not set in _env.yaml");
        }
        if (env.bihr.user_name == "") {
            throw new System.Exception("username not set in _env.yaml");
        }
        if (env.bihr.password == "") {
            throw new System.Exception("password not set in _env.yaml");
        }


        this.jtl = env.jtl ?? throw new System.Exception("jtl not set in _env.yaml");
        this.ameise = this.jtl.ameise;
        this.sql = env.sql;
        this.jtl_bihr = env.jtl_bihr;
        this.bihr = env.bihr;
        optionsBuilderString = $"Data Source={sql.server_name};Initial Catalog={sql.databaseName};User ID={sql.user_name};Password={sql.password};TrustServerCertificate=True";

    }
}
public class ameise
{
    public string exe { get; set; } = "";
    public string hard_part_vorlage_id { get; set; } = "";
    public string brand_vorlage_id { get; set; } = "";
}

public class jtl 
{
    public string software_path { get; set; } = "";
    public ameise ameise { get; set; } = new ameise();
}

public class sql
{
    public string server_name { get; set; } = "";
    public string user_name { get; set; } = "";
    public string password { get; set; } = "";
    public string databaseName { get; set; } = "";
}

public class jtl_bihr
{
    public string temp_path { get; set; } = "";
    public int hersteller_importieren { get; set; } = 0;
    public int artikel_importieren { get; set; } = 0;
}

public class bihr
{
    public string url { get; set; } = "";
    public string user_name { get; set; } = "";
    public string password { get; set; } = "";
}

public class Env {
    public jtl jtl { get; set; } = new jtl();
    public sql sql { get; set; } = new sql();

    public jtl_bihr jtl_bihr { get; set; } = new jtl_bihr();
    public bihr bihr { get; set; } = new bihr();

}
